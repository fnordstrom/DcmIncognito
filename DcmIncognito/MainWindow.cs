using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using DcmIncognito.Properties;

namespace DcmIncognito
{
    public partial class MainWindow : Form
    {
        private readonly AnonymizationSettings anonymizationSettings = new AnonymizationSettings();
        private readonly DICOMManager dicomManager = new DICOMManager();
                
        private readonly Dictionary<ToolStripMenuItem, string> menuItemSettingsMap;
        private readonly Dictionary<ToolStripMenuItem, string> menuItemDateSettingsMap;

        private bool moveWindow = false;
        private Point moveStart = Point.Empty;
        private Point menuLocation = Point.Empty;

        public MainWindow()
        {
            InitializeComponent();

            menuItemSettingsMap = new Dictionary<ToolStripMenuItem, string>()
            {
                { toolStripMenuItemGenerateNewUIDs, "GenerateNewUIDs"},
                { toolStripMenuItemAnynomizeNames, "AnynomizeNames"},
                { toolStripMenuItemAnonymizeStudyIDs, "AnonymizeStudyIDs"},
                { toolStripMenuItemAnonymizeDates, "AnonymizeDates"},
                { toolStripMenuItemRemovePrivateTags, "RemovePrivateTags"},
                { toolStripMenuItemRemoveSetupTechniqueDescription, "RemoveSetupTechniqueDescription"},
                { toolStripMenuItemClearStandardIdentificationProfile, "ClearStandardIdentificationProfile"}
            };
            menuItemDateSettingsMap = new Dictionary<ToolStripMenuItem, string>()
            {
                { toolStripMenuItemPreserveAge, "PRESERVE_AGE" },
                { toolStripMenuItemClearAge, "NULL_AGE" },
                { toolStripMenuItemRandomize, "RANDOMIZE" }
            };

            UpdateToolTips();

            labelVersion.Text = $"Version {Assembly.GetExecutingAssembly().GetName().Version}";
            labelEvilDICOM.Text = $"Based on EvilDICOM version {Assembly.GetAssembly(typeof(EvilDICOM.Core.DICOMObject)).GetName().Version}";
            
            dicomManager.TaskStarted += DicomManager_TaskStarted;
            dicomManager.ProgressChanged += DicomManager_ProgressChanged;
            dicomManager.TaskCompleted += DicomManager_TaskCompleted;
        }        

        #region UI

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox && Resources.ResourceManager.GetObject(pictureBox.Name.Replace("pictureBox", string.Empty) + "_white") is Bitmap bitmap)
                pictureBox.Image = bitmap;
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox && Resources.ResourceManager.GetObject(pictureBox.Name.Replace("pictureBox", string.Empty)) is Bitmap bitmap)
                pictureBox.Image = bitmap;
        }

        private static void ShowError(Exception exception)
        {
            MessageBox.Show(exception.Message + "\n\n" + exception.StackTrace, exception.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PictureBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateToolTips()
        {
            if (Settings.Default.ShowToolTips)
            {
                toolTip.SetToolTip(pictureBoxAddFolder, "Add folder");
                toolTip.SetToolTip(pictureBoxAddFiles, "Add files");
                toolTip.SetToolTip(pictureBoxClearFiles, "Clear files");
                toolTip.SetToolTip(pictureBoxSettings, "Settings");
                toolTip.SetToolTip(pictureBoxAnonymize, "Anonymize files");
            }
            else
                toolTip.RemoveAll();
        }

        #endregion

        #region UI:MoveWindow

        private void LabelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (!moveWindow)
            {
                moveWindow = true;
                moveStart = e.Location;
            }
        }

        private void LabelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            moveWindow = false;
        }

        private void LabelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveWindow)
                Location = new Point(Location.X + e.X - moveStart.X, Location.Y + e.Y - moveStart.Y);
        }

        #endregion

        #region Drag/drop

        private void PanelDropFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }        

        private void PanelDropFiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedData = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string path in droppedData)
            {
                try
                {
                    FileAttributes attr = File.GetAttributes(path);
                    if (attr.HasFlag(FileAttributes.Directory))
                    {
                        try
                        {
                            string[] subFiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                            dicomManager.AddFile(subFiles);
                        }
                        catch
                        {
                        }
                    }
                    else
                        dicomManager.AddFile(path);
                }
                catch
                {
                }
            }

            dicomManager.Read();
        }

        #endregion

        #region Menu

        private void PictureBoxSettings_MouseDown(object sender, MouseEventArgs e)
        {
            menuLocation = e.Location;
            pictureBoxSettings.ContextMenuStrip.Show(pictureBoxSettings, e.Location);
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem toolStripMenuItem)
            {
                if (sender == toolStripMenuItemOutputDirectory)
                {
                    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                    if (string.IsNullOrEmpty(anonymizationSettings.OutputDirectory))
                        folderBrowserDialog.SelectedPath = dicomManager.CurrentDirectory;
                    else
                        folderBrowserDialog.SelectedPath = anonymizationSettings.OutputDirectory;
                    folderBrowserDialog.Description = "Select output folder...";
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        anonymizationSettings.OutputDirectory = folderBrowserDialog.SelectedPath;
                        toolStripMenuItemOutputDirectory.Text = $"Output folder: {anonymizationSettings.GetShortOutputDirectory()}";
                    }
                }
                else if (sender == toolStripMenuItemId || sender == toolStripMenuItemName)
                {
                    TopMost = false;
                    AnonymizationWindow patientDataWindow = new AnonymizationWindow(anonymizationSettings) { Owner = this };
                    if (patientDataWindow.ShowDialog() == DialogResult.OK)
                    {
                        toolStripMenuItemId.Text = $"ID: {anonymizationSettings.Id}";
                        toolStripMenuItemName.Text = $"Name: {anonymizationSettings.LastName}{(anonymizationSettings.LastName.Length != 0 && anonymizationSettings.FirstName.Length != 0 ? ", " : string.Empty)}{anonymizationSettings.FirstName}";
                    }
                    TopMost = true;
                    pictureBoxSettings.ContextMenuStrip.Show(pictureBoxSettings, menuLocation);
                }
                else if (menuItemDateSettingsMap.ContainsKey(toolStripMenuItem))
                {
                    foreach (KeyValuePair<ToolStripMenuItem, string> map in menuItemDateSettingsMap)
                        map.Key.Checked = map.Key == toolStripMenuItem;
                    Settings.Default.DateSettings = menuItemDateSettingsMap[toolStripMenuItem];
                }
                else if (sender == toolStripMenuItemAdvancedSettings)
                {
                    TopMost = false;
                    AdvancedSettings advancedSettingsWindow = new AdvancedSettings() { Owner = this };
                    if (advancedSettingsWindow.ShowDialog() == DialogResult.OK)
                        UpdateToolTips();
                    TopMost = true;
                    pictureBoxSettings.ContextMenuStrip.Show(pictureBoxSettings, menuLocation);
                }
                else if (sender == toolStripMenuItemSaveSettings)
                {
                    TopMost = false;
                    try
                    {
                        Settings.Default.Save();
                        MessageBox.Show("The settings were saved!", "DcmIncognito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exception)
                    {
                        ShowError(exception);
                    }
                    TopMost = true;
                }
                else
                {
                    ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
                    if (menuItemSettingsMap.ContainsKey(toolStripMenuItem))
                        typeof(Settings).GetProperty(menuItemSettingsMap[toolStripMenuItem]).SetValue(Settings.Default, toolStripMenuItem.Checked);
                }
            }
        }        

        private void ContextMenuStripSettings_Opening(object sender, CancelEventArgs e)
        {
            toolStripMenuItemOutputDirectory.Text = toolStripMenuItemOutputDirectory.Text = $"Output folder: {anonymizationSettings.GetShortOutputDirectory()}";

            toolStripMenuItemId.Text = $"ID: {anonymizationSettings.Id}";
            toolStripMenuItemName.Text = $"Name: {anonymizationSettings.LastName}{(anonymizationSettings.LastName.Length != 0 && anonymizationSettings.FirstName.Length != 0 ? ", " : string.Empty)}{anonymizationSettings.FirstName}";

            foreach (KeyValuePair<ToolStripMenuItem, string> map in menuItemSettingsMap)
                map.Key.Checked = (bool)typeof(Settings).GetProperty(map.Value).GetValue(Settings.Default);
            foreach (KeyValuePair<ToolStripMenuItem, string> map in menuItemDateSettingsMap)
                map.Key.Checked = map.Value == Settings.Default.DateSettings;
        }

        private void ContextMenuStripSettings_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            if (e.CloseReason == ToolStripDropDownCloseReason.ItemClicked)
                e.Cancel = true;
        }

        private void ToolStripMenuItemAnonymizeDates_DropDownClosed(object sender, EventArgs e)
        {
            pictureBoxSettings.ContextMenuStrip.Show(pictureBoxSettings, menuLocation);
        }

        #endregion

        #region DicomManager events

        private void DicomManager_TaskStarted(object sender, EventArgs e)
        {
            pictureBoxAddFolder.Enabled = false;
            pictureBoxAddFiles.Enabled = false;
            pictureBoxClearFiles.Enabled = false;
            pictureBoxAnonymize.Enabled = false;
            pictureBoxSettings.Enabled = false;
            panelDropFiles.Enabled = false;

            progressBar.Visible = true;
        }

        private void DicomManager_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;

            if (e.UserState is KeyValuePair<string, int>[] numberOfModalities)
            {
                if (flowLayoutPanelNumberOfModalities.Controls.Count < numberOfModalities.Length)
                {
                    int currentModalityIndex = flowLayoutPanelNumberOfModalities.Controls.Count;
                    flowLayoutPanelNumberOfModalities.Controls.Add(new Label { ForeColor = Color.White, Text = numberOfModalities[currentModalityIndex].Key + ": " + numberOfModalities[currentModalityIndex].Value });
                }
                else if (flowLayoutPanelNumberOfModalities.Controls.Count > numberOfModalities.Length)
                {
                    while (flowLayoutPanelNumberOfModalities.Controls.Count > numberOfModalities.Length)
                        flowLayoutPanelNumberOfModalities.Controls.RemoveAt(flowLayoutPanelNumberOfModalities.Controls.Count - 1);
                }
                for (int modalityIndex = 0; modalityIndex < numberOfModalities.Length; modalityIndex++)
                    flowLayoutPanelNumberOfModalities.Controls[modalityIndex].Text = $"{numberOfModalities[modalityIndex].Key}: {numberOfModalities[modalityIndex].Value}";
            }
            else if(e.UserState is string status)
            {
                if (status.Length > 40)
                    status = $"{status.Substring(0, 37)}...";
                labelProgressStatus.Text = status;
            }
        }

        private void DicomManager_TaskCompleted(object sender, Exception e)
        {
            pictureBoxAddFolder.Enabled = true;
            pictureBoxAddFiles.Enabled = true;
            pictureBoxClearFiles.Enabled = true;
            pictureBoxAnonymize.Enabled = true;
            pictureBoxSettings.Enabled = true;
            panelDropFiles.Enabled = true;

            progressBar.Visible = false;
            labelProgressStatus.Text = string.Empty;

            if (e != null)
                ShowError(e);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            dicomManager.Cancel();
        }

        #endregion

        #region User inputs
        private void PictureBoxAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog() { SelectedPath = dicomManager.CurrentDirectory };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] files = Directory.GetFiles(dicomManager.CurrentDirectory, "*.*", SearchOption.AllDirectories);
                    dicomManager.AddFile(files);
                }
                catch (Exception exception)
                {
                    ShowError(exception);
                }
            }

            dicomManager.Read();
        }

        private void PictureBoxAddFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { InitialDirectory = dicomManager.CurrentDirectory, Multiselect = true, Filter = "DICOM-files (*.dcm)|*.dcm|All files (*.*)|*.*" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                dicomManager.AddFile(openFileDialog.FileNames);

            dicomManager.Read();
        }

        private void PictureBoxClearFiles_Click(object sender, EventArgs e)
        {
            dicomManager.Clear();            
        }

        private void PictureBoxAnonymize_Click(object sender, EventArgs e)
        {
            if (Settings.Default.AlwaysAskForNameAndId || string.IsNullOrEmpty(anonymizationSettings.Id) || string.IsNullOrEmpty(anonymizationSettings.FirstName) || string.IsNullOrEmpty(anonymizationSettings.LastName))
            {
                TopMost = false;

                AnonymizationWindow anonymizationWindow = new AnonymizationWindow(anonymizationSettings) { Owner = this };
                if (anonymizationWindow.ShowDialog() != DialogResult.OK)
                {
                    TopMost = true;
                    return;
                }
            }

            if(Settings.Default.AlwaysAskForOutputDirectory || string.IsNullOrEmpty(anonymizationSettings.OutputDirectory))
            {
                TopMost = false;

                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (string.IsNullOrEmpty(anonymizationSettings.OutputDirectory))
                    folderBrowserDialog.SelectedPath = dicomManager.CurrentDirectory;
                else
                    folderBrowserDialog.SelectedPath = anonymizationSettings.OutputDirectory;
                folderBrowserDialog.Description = "Select output folder...";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    anonymizationSettings.OutputDirectory = folderBrowserDialog.SelectedPath;
                else
                {
                    TopMost = true;
                    return;
                }
            }

            TopMost = true;

            dicomManager.Anonymize(anonymizationSettings);                
        }

        #endregion
    }
}