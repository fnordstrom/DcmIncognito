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
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Settings.Default.ShowToolTips = checkBoxShowToolTips.Checked;
            Settings.Default.AlwaysAskForNameAndId = checkBoxAlwaysAskForNameAndId.Checked;
            Settings.Default.AlwaysAskForOutputDirectory = checkBoxAlwaysAskForOutputFolder.Checked;
        }
    }
}
