using System;
using System.Windows.Forms;
using DcmIncognito.Properties;

namespace DcmIncognito
{
    public partial class AdvancedSettings : Form
    {
        public AdvancedSettings()
        {
            InitializeComponent();

            checkBoxShowToolTips.Checked = Settings.Default.ShowToolTips;
            checkBoxAlwaysAskForNameAndId.Checked = Settings.Default.AlwaysAskForNameAndId;
            checkBoxAlwaysAskForOutputFolder.Checked = Settings.Default.AlwaysAskForOutputDirectory;
            checkBoxOverwriteFiles.Checked  = !Settings.Default.AlwaysAskForOutputDirectory && Settings.Default.OverwriteFiles;
            checkBoxIgnoreFilesWithoutDCMExtension.Checked = Settings.Default.IgnoreFilesWithoutDCMExtension;
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Settings.Default.ShowToolTips = checkBoxShowToolTips.Checked;
            Settings.Default.AlwaysAskForNameAndId = checkBoxAlwaysAskForNameAndId.Checked;
            Settings.Default.AlwaysAskForOutputDirectory = checkBoxAlwaysAskForOutputFolder.Checked;
            Settings.Default.OverwriteFiles = !checkBoxAlwaysAskForOutputFolder.Checked && checkBoxOverwriteFiles.Checked;
            Settings.Default.IgnoreFilesWithoutDCMExtension = checkBoxIgnoreFilesWithoutDCMExtension.Checked;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == checkBoxAlwaysAskForOutputFolder && checkBoxAlwaysAskForOutputFolder.Checked)
                checkBoxOverwriteFiles.Checked = false;
            else if (sender == checkBoxOverwriteFiles && checkBoxOverwriteFiles.Checked)
                checkBoxAlwaysAskForOutputFolder.Checked = false;
        }
    }
}
