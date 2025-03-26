using System.IO;

namespace DcmIncognito
{
    internal class AnonymizationSettings
    {
        public AnonymizationSettings() 
        {
            Id = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            OutputDirectory = string.Empty;
        }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Random { get; set; }
        public string OutputDirectory { get; set; }

        public string GetShortOutputDirectory()
        {
            if (string.IsNullOrEmpty(OutputDirectory))
                return string.Empty;
            else if (Path.GetFileName(OutputDirectory) is string directory && !string.IsNullOrEmpty(directory))
                return directory;
            else 
                return OutputDirectory;
        }
    }
}