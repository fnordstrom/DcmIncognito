using System;
using System.Windows.Forms;

namespace DcmIncognito
{
    internal partial class AnonymizationWindow : Form
    {
        private readonly AnonymizationSettings anonymizationSettings;
        public AnonymizationWindow(AnonymizationSettings anonymizationSettings)
        {
            this.anonymizationSettings = anonymizationSettings;

            InitializeComponent();
            
            textBoxId.Text = anonymizationSettings.Id;
            textBoxFirstName.Text = anonymizationSettings.FirstName;
            textBoxLastName.Text = anonymizationSettings.LastName;
            checkBoxRandom.Checked = anonymizationSettings.Random;

            TextBox_TextChanged(null, null);
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            anonymizationSettings.Id = textBoxId.Text;
            anonymizationSettings.FirstName = textBoxFirstName.Text;
            anonymizationSettings.LastName = textBoxLastName.Text;
            anonymizationSettings.Random = checkBoxRandom.Checked;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            textBoxId.Enabled = !checkBoxRandom.Checked;
            textBoxFirstName.Enabled = !checkBoxRandom.Checked;
            textBoxLastName.Enabled = !checkBoxRandom.Checked;

            buttonOk.Enabled = (textBoxId.Text.Length > 0 && textBoxFirstName.Text.Length > 0 && textBoxLastName.Text.Length > 0) || checkBoxRandom.Checked;
        }
    }
}
