using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.ComponentModel;
using EvilDICOM.Core;
using EvilDICOM.Core.Helpers;
using EvilDICOM.Core.Element;
using EvilDICOM.Core.Interfaces;
using EvilDICOM.Anonymization;
using EvilDICOM.Anonymization.Settings;
using DcmIncognito.Properties;

namespace DcmIncognito
{
    /// <summary>
    /// Manage DICOM operations
    /// </summary>
    internal class DICOMManager
    {
        private readonly BackgroundWorker backgroundWorkerReadFiles = new BackgroundWorker() { WorkerReportsProgress = true, WorkerSupportsCancellation = true };
        private readonly BackgroundWorker backgroundAnonymize = new BackgroundWorker() { WorkerReportsProgress = true, WorkerSupportsCancellation = true };
        private readonly List<DICOMFile> dicomFiles = new List<DICOMFile>();        
        private readonly Dictionary<string, int> numberOfModalities = new Dictionary<string, int>();

        public event ProgressChangedEventHandler ProgressChanged;
        public event EventHandler TaskStarted;
        public event EventHandler<Exception> TaskCompleted;

        /// <summary>
        /// Constructor for the DICOM Manager
        /// </summary>
        public DICOMManager()
        {            
            backgroundWorkerReadFiles.DoWork += BackgroundWorkerReadFiles_DoWork;
            backgroundWorkerReadFiles.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorkerReadFiles.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;

            backgroundAnonymize.DoWork += BackgroundAnonymize_DoWork;
            backgroundAnonymize.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundAnonymize.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }
                
        /// <summary>
        /// Current directory
        /// </summary>
        public string CurrentDirectory { get; private set; }

        /// <summary>
        /// Add files to the DICOM manager
        /// </summary>
        /// <param name="paths">Path of file</param>
        public void AddFile(string[] paths)
        {
            foreach (string path in paths)
                AddFile(path);
        }

        /// <summary>
        /// Add files to the DICOM manager
        /// </summary>
        /// <param name="path">Path of file</param>
        public void AddFile(string path)
        {
            string fullPath = Path.GetFullPath(path);

            if (dicomFiles.FirstOrDefault(dcm => fullPath.Equals(dcm.FullPath)) is null) // Check if the file has not yet been added
            {                
                CurrentDirectory = Path.GetDirectoryName(path);
                dicomFiles.Add(new DICOMFile(fullPath));                
            }            
        }

        /// <summary>
        /// Remove all files from the DICOM manager
        /// </summary>
        public void Clear()
        {
            dicomFiles.Clear();
            numberOfModalities.Clear();
            ProgressChanged?.Invoke(this, new ProgressChangedEventArgs(0, numberOfModalities.ToArray()));
        }

        /// <summary>
        /// Asynchronously read DICOM files added
        /// </summary>
        public void Read()
        {
            ProgressChanged?.Invoke(this, new ProgressChangedEventArgs(0, null));
            TaskStarted?.Invoke(this, EventArgs.Empty);
            backgroundWorkerReadFiles.RunWorkerAsync();
        }

        /// <summary>
        /// Asynchronously anonymize files 
        /// </summary>
        /// <param name="settings"></param>
        public void Anonymize(AnonymizationSettings settings)
        {
            ProgressChanged?.Invoke(this, new ProgressChangedEventArgs(0, null));
            TaskStarted?.Invoke(this, EventArgs.Empty);
            backgroundAnonymize.RunWorkerAsync(settings);
        }

        /// <summary>
        /// Cancel all asynchronous tasks
        /// </summary>
        public void Cancel()
        {
            backgroundWorkerReadFiles.CancelAsync();
            backgroundAnonymize.CancelAsync();
        }

        /// <summary>
        /// Handles progress changed events from background workers
        /// </summary>
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressChanged?.Invoke(this, e);
        }

        /// <summary>
        /// Handles run worker completed events from background workers
        /// </summary>
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (sender == backgroundAnonymize)            
                Clear();

            TaskCompleted?.Invoke(this, e.Result as Exception);
        }

        /// <summary>
        /// Background worker for asynchronously read of the DICOM files added
        /// </summary>
        private void BackgroundWorkerReadFiles_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                DICOMFile[] filesToRead = dicomFiles.Where(dcm => !dcm.Invalid && dcm.DICOMObject is null).ToArray();
                for (int fileNr = 0; fileNr < filesToRead.Length; fileNr++)
                {
                    if (backgroundWorkerReadFiles.CancellationPending)
                        break;

                    backgroundWorkerReadFiles.ReportProgress((int)Math.Round(100 * (double)fileNr / filesToRead.Length), $"Reading {Path.GetFileName(filesToRead[fileNr].FullPath)}");

                    DICOMFile dicomFile = filesToRead[fileNr];

                    string modality = dicomFile.Read();
                    if (dicomFile.Invalid)
                        modality = "INVALID";

                    if (!string.IsNullOrEmpty(modality))
                    {
                        if (!numberOfModalities.ContainsKey(modality))
                            numberOfModalities.Add(modality, 1);
                        else
                            numberOfModalities[modality]++;
                    }

                    backgroundWorkerReadFiles.ReportProgress((int)Math.Round(100 * (double)fileNr / filesToRead.Length), numberOfModalities.ToArray());
                }
            }
            catch(Exception exception)
            {
                e.Result = exception;
            }
        }

        /// <summary>
        /// Background worker for asynchronously anonymize the read DICOM files
        /// </summary>
        private void BackgroundAnonymize_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                AnonymizationSettings settings = e.Argument as AnonymizationSettings;

                EvilDICOM.Anonymization.Settings.AnonymizationSettings evilDICOMAnonymizationConfiguration = new EvilDICOM.Anonymization.Settings.AnonymizationSettings()
                {
                    FirstName = settings.FirstName,
                    LastName = settings.LastName,
                    Id = settings.Id,

                    DoAnonymizeUIDs = Settings.Default.GenerateNewUIDs,

                    DoAnonymizeNames = Settings.Default.AnynomizeNames,
                    DoAnonymizeStudyIDs = Settings.Default.AnonymizeStudyIDs,
                    DateSettings = Settings.Default.AnonymizeDates && Enum.TryParse(Settings.Default.DateSettings, out DateSettings dateSettings) ? dateSettings : DateSettings.KEEP_ALL_DATES,
                    DoRemovePrivateTags = false, // Doesn't work. Implemented it in another way.
                    DoDICOMProfile = Settings.Default.ClearStandardIdentificationProfile
                };

                bool removePrivateTags = Settings.Default.RemovePrivateTags;
                bool removeSetupNote = true;

                backgroundAnonymize.ReportProgress(0, $"Building queue...");
                IEnumerable<DICOMFile> filesForExport = dicomFiles.Where(x => !x.Invalid);
                AnonymizationQueue anonymizationQueue = AnonymizationQueue.BuildQueue(evilDICOMAnonymizationConfiguration, filesForExport.Select(x => x.FullPath));


                for (int fileNr = 0; fileNr < filesForExport.Count(); fileNr++)
                {
                    if (backgroundAnonymize.CancellationPending)
                        break;

                    backgroundAnonymize.ReportProgress((int)Math.Round(100 * (double)fileNr / filesForExport.Count()), $"Anonymizing {Path.GetFileName(filesForExport.ElementAt(fileNr).FullPath)}");

                    string modality = filesForExport.ElementAt(fileNr).Modality;
                    DICOMObject dicomObject = filesForExport.ElementAt(fileNr).DICOMObject;

                    anonymizationQueue.Anonymize(dicomObject);

                    string prefix;
                    switch (modality)
                    {
                        case "RTPLAN":
                            prefix = "RP.";
                            break;
                        case "RTDOSE":
                            prefix = "RD.";
                            break;
                        case "RTSTRUCT":
                            prefix = "RS.";
                            break;
                        case "RTIMAGE":
                            prefix = "RI.";
                            break;
                        default:
                            prefix = $"{modality}.";
                            break;
                    }

                    if (removePrivateTags)
                    {
                        IDICOMElement[] privateElements = dicomObject.AllElements.Where(x => x.Tag.IsPrivate()).ToArray();
                        for (int i = privateElements.Length - 1; i >= 0; i--)
                            dicomObject.Remove(privateElements[i].Tag);
                    }

                    if (removeSetupNote)
                    {
                        IDICOMElement[] setupTechniqueDescriptionElements = dicomObject.FindAll(TagHelper.SetupTechniqueDescription).ToArray();
                        for (int i = setupTechniqueDescriptionElements.Length - 1; i >= 0; i--)
                            dicomObject.Remove(setupTechniqueDescriptionElements[i].Tag);
                    }

                    string sopInstanceUID = (dicomObject.FindFirst(TagHelper.SOPInstanceUID) as UniqueIdentifier)?.Data;

                    string outputPath = Path.Combine(settings.OutputDirectory, $"{prefix}{sopInstanceUID}.dcm");                    
                    dicomFiles.ElementAt(fileNr).Write(outputPath);

                    if (numberOfModalities.ContainsKey(modality))
                    {
                        numberOfModalities[modality]--;
                        if (numberOfModalities[modality] ==0)
                            numberOfModalities.Remove(modality);
                    }

                    backgroundAnonymize.ReportProgress((int)Math.Round(100 * (double)fileNr / filesForExport.Count()), numberOfModalities.ToArray());
                }
            }
            catch(Exception exception)
            {
                e.Result = exception;
            }
        }
    } 
}
