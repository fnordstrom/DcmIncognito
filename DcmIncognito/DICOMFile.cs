using System.Collections.Generic;
using System.Linq;
using System;
using EvilDICOM.Core.Element;
using EvilDICOM.Core.Helpers;
using EvilDICOM.Core.IO.Reading;
using EvilDICOM.Core;
using EvilDICOM.Core.Enums;
using EvilDICOM.Core.Interfaces;
using EvilDICOM.Core.IO.Writing;

namespace DcmIncognito
{
    /// <summary>
    /// Handels DIOCM objects
    /// </summary>
    internal class  DICOMFile
    {
        private readonly string fullpath;
        private DICOMObject dicomObject;
        private string modality;
        private bool invalid = false;

        /// <summary>
        /// Constructor for DICOMFile
        /// </summary>
        /// <param name="fullpath">Path to the DICOM file</param>
        public DICOMFile(string fullpath)
        {
            this.fullpath = fullpath;
        }

        /// <summary>
        /// Read the file using EvilDICOM (encoding is determined from specific character set)
        /// </summary>
        /// <returns>Modality of the DICOM file</returns>
        public string Read()
        {
            if (dicomObject == null && invalid == false)
            {
                try
                {
                    // dicomObject = DICOMFileReader.Read(fullpath); // Always defaults to ISO_IR_192

                    TransferSyntax trySyntax = TransferSyntax.IMPLICIT_VR_LITTLE_ENDIAN;
                    var enc = StringEncoding.ISO_IR_192;
                    var syntax = trySyntax;
                    List<IDICOMElement> elements;
                    using (var dr = new DICOMBinaryReader(fullpath))
                    {
                        DICOMPreambleReader.Read(dr);
                        var metaElements = DICOMFileReader.ReadFileMetadata(dr, ref syntax, ref enc);
                        enc = GetEncodingFromSpecificCharacterSet(dr, syntax);
                        elements = metaElements.Concat(DICOMElementReader.ReadAllElements(dr, syntax, enc)).ToList();
                    }
                    dicomObject = new DICOMObject(elements);

                    modality = (dicomObject.FindFirst(TagHelper.Modality) as CodeString)?.Data;
                }
                catch
                {
                }
            }
            if (dicomObject == null || string.IsNullOrEmpty(modality))
            {
                invalid = true;
                return null;
            }
            else
                return modality;
        }

        /// <summary>
        /// Write the DICOMObject using EvilDICOM (encoding is determined from specific character set)
        /// </summary>
        /// <param name="fullpath">Path to the new DICOM file</param>
        public void Write(string fullpath)
        {
            string specificCharacterSet = (dicomObject.FindFirst(TagHelper.SpecificCharacterSet) as CodeString)?.Data;

            DICOMIOSettings settings = DICOMIOSettings.Default();
            settings.StringEncoding = !string.IsNullOrEmpty(specificCharacterSet) && Enum.TryParse(specificCharacterSet.Replace(" ", "_").ToUpper(), out StringEncoding stringEncoding) ? stringEncoding : StringEncoding.ISO_IR_192;

            dicomObject.Write(fullpath, settings);
        }

        /// <summary>
        /// Determine the encoding from the specific character set tag
        /// </summary>
        /// <param name="dr">DICOM binary reader</param>
        /// <param name="syntax">Transfer syntax</param>
        /// <returns>String encoding</returns>
        private StringEncoding GetEncodingFromSpecificCharacterSet(DICOMBinaryReader dr, TransferSyntax syntax)
        {
            StringEncoding enc = StringEncoding.ISO_IR_192;
            long startPosition = dr.StreamPosition;
            while (dr.StreamPosition < dr.StreamLength)
            {
                IDICOMElement element;
                switch (syntax)
                {
                    case TransferSyntax.IMPLICIT_VR_LITTLE_ENDIAN:
                        element = DICOMElementReader.ReadElementImplicitLittleEndian(dr, enc);
                        break;
                    case TransferSyntax.EXPLICIT_VR_BIG_ENDIAN:
                        element = DICOMElementReader.ReadElementExplicitBigEndian(dr, enc);
                        break;
                    default:
                        element = DICOMElementReader.ReadElementExplicitLittleEndian(dr, enc);
                        break;
                }
                if (element != null && element.Tag == TagHelper.SpecificCharacterSet)
                {
                    Enum.TryParse(element.DData?.ToString().Replace(" ", "_").ToUpper(), out enc);
                    break;
                }
            }
            dr.StreamPosition = startPosition;
            return enc;
        }

        /// <summary>
        /// Full path to the DICOM file
        /// </summary>
        public string FullPath { get { return fullpath; } }
        /// <summary>
        /// Modality of the DICOM file
        /// </summary>
        public string Modality { get { return modality; } }
        /// <summary>
        /// The associated EvilDICOM object
        /// </summary>
        public DICOMObject DICOMObject { get { return dicomObject; } }
        /// <summary>
        /// File is invalid if true
        /// </summary>
        public bool Invalid { get { return invalid; } }
        /// <summary>
        /// The series instance UID
        /// </summary>
        public string SeriesInstanceUID { get { return (dicomObject.FindFirst(TagHelper.SeriesInstanceUID) as UniqueIdentifier).Data; } }
        /// <summary>
        /// The study instance UID
        /// </summary>
        public string StudyInstanceUID { get { return (dicomObject.FindFirst(TagHelper.StudyInstanceUID) as UniqueIdentifier).Data; } }
        /// <summary>
        /// The SOP instance UID
        /// </summary>
        public string SOPInstanceUID { get { return (dicomObject.FindFirst(TagHelper.SOPInstanceUID) as UniqueIdentifier).Data; } }
        public string PatientId { get { return (dicomObject.FindFirst(TagHelper.PatientID) as LongString).Data; } }
    }
}