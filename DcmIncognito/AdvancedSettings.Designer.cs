﻿namespace DcmIncognito
{
    partial class AdvancedSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxShowToolTips = new System.Windows.Forms.CheckBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.checkBoxAlwaysAskForNameAndId = new System.Windows.Forms.CheckBox();
            this.checkBoxAlwaysAskForOutputFolder = new System.Windows.Forms.CheckBox();
            this.checkBoxOverwriteFiles = new System.Windows.Forms.CheckBox();
            this.checkBoxIgnoreFilesWithoutDCMExtension = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxShowToolTips
            // 
            this.checkBoxShowToolTips.AutoSize = true;
            this.checkBoxShowToolTips.Location = new System.Drawing.Point(12, 12);
            this.checkBoxShowToolTips.Name = "checkBoxShowToolTips";
            this.checkBoxShowToolTips.Size = new System.Drawing.Size(92, 17);
            this.checkBoxShowToolTips.TabIndex = 0;
            this.checkBoxShowToolTips.Text = "Show tool tips";
            this.checkBoxShowToolTips.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(86, 147);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(167, 147);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // checkBoxAlwaysAskForNameAndId
            // 
            this.checkBoxAlwaysAskForNameAndId.AutoSize = true;
            this.checkBoxAlwaysAskForNameAndId.Location = new System.Drawing.Point(12, 35);
            this.checkBoxAlwaysAskForNameAndId.Name = "checkBoxAlwaysAskForNameAndId";
            this.checkBoxAlwaysAskForNameAndId.Size = new System.Drawing.Size(153, 17);
            this.checkBoxAlwaysAskForNameAndId.TabIndex = 8;
            this.checkBoxAlwaysAskForNameAndId.Text = "Always ask for patient data";
            this.checkBoxAlwaysAskForNameAndId.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlwaysAskForOutputFolder
            // 
            this.checkBoxAlwaysAskForOutputFolder.AutoSize = true;
            this.checkBoxAlwaysAskForOutputFolder.Location = new System.Drawing.Point(12, 58);
            this.checkBoxAlwaysAskForOutputFolder.Name = "checkBoxAlwaysAskForOutputFolder";
            this.checkBoxAlwaysAskForOutputFolder.Size = new System.Drawing.Size(156, 17);
            this.checkBoxAlwaysAskForOutputFolder.TabIndex = 9;
            this.checkBoxAlwaysAskForOutputFolder.Text = "Always ask for output folder";
            this.checkBoxAlwaysAskForOutputFolder.UseVisualStyleBackColor = true;
            this.checkBoxAlwaysAskForOutputFolder.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxOverwriteFiles
            // 
            this.checkBoxOverwriteFiles.AutoSize = true;
            this.checkBoxOverwriteFiles.Location = new System.Drawing.Point(12, 81);
            this.checkBoxOverwriteFiles.Name = "checkBoxOverwriteFiles";
            this.checkBoxOverwriteFiles.Size = new System.Drawing.Size(92, 17);
            this.checkBoxOverwriteFiles.TabIndex = 10;
            this.checkBoxOverwriteFiles.Text = "Overwrite files";
            this.checkBoxOverwriteFiles.UseVisualStyleBackColor = true;
            this.checkBoxOverwriteFiles.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxIgnoreNoneDCMFiles
            // 
            this.checkBoxIgnoreFilesWithoutDCMExtension.AutoSize = true;
            this.checkBoxIgnoreFilesWithoutDCMExtension.Location = new System.Drawing.Point(12, 104);
            this.checkBoxIgnoreFilesWithoutDCMExtension.Name = "checkBoxIgnoreNoneDCMFiles";
            this.checkBoxIgnoreFilesWithoutDCMExtension.Size = new System.Drawing.Size(188, 17);
            this.checkBoxIgnoreFilesWithoutDCMExtension.TabIndex = 11;
            this.checkBoxIgnoreFilesWithoutDCMExtension.Text = "Ignore files without .dcm extension";
            this.checkBoxIgnoreFilesWithoutDCMExtension.UseVisualStyleBackColor = true;
            // 
            // AdvancedSettings
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(254, 182);
            this.Controls.Add(this.checkBoxIgnoreFilesWithoutDCMExtension);
            this.Controls.Add(this.checkBoxOverwriteFiles);
            this.Controls.Add(this.checkBoxAlwaysAskForOutputFolder);
            this.Controls.Add(this.checkBoxAlwaysAskForNameAndId);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.checkBoxShowToolTips);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdvancedSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Advanced settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxShowToolTips;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.CheckBox checkBoxAlwaysAskForNameAndId;
        private System.Windows.Forms.CheckBox checkBoxAlwaysAskForOutputFolder;
        private System.Windows.Forms.CheckBox checkBoxOverwriteFiles;
        private System.Windows.Forms.CheckBox checkBoxIgnoreFilesWithoutDCMExtension;
    }
}