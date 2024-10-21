namespace DcmIncognito
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.labelProgressStatus = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelEvilDICOM = new System.Windows.Forms.Label();
            this.pictureBoxAnonymize = new System.Windows.Forms.PictureBox();
            this.pictureBoxClearFiles = new System.Windows.Forms.PictureBox();
            this.pictureBoxAddFiles = new System.Windows.Forms.PictureBox();
            this.pictureBoxAddFolder = new System.Windows.Forms.PictureBox();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.contextMenuStripSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemOutputDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemId = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemGenerateNewUIDs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemAnynomizeNames = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAnonymizeStudyIDs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAnonymizeDates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPreserveAge = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemClearAge = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRandomize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRemovePrivateTags = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRemoveSetupTechniqueDescription = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemClearStandardIdentificationProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemAdvancedSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new DcmIncognito.ColorProgressBar();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelNumberOfModalities = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDropFiles = new System.Windows.Forms.Panel();
            this.labelDropFilesHere = new System.Windows.Forms.Label();
            this.labelDevelopedBy = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnonymize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClearFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            this.contextMenuStripSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panelDropFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(70, 5, 0, 0);
            this.labelTitle.Size = new System.Drawing.Size(344, 28);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "DcmIncognito";
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseDown);
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseMove);
            this.labelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseUp);
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.Black;
            this.panelBackground.Controls.Add(this.labelProgressStatus);
            this.panelBackground.Controls.Add(this.pictureBoxIcon);
            this.panelBackground.Controls.Add(this.labelEvilDICOM);
            this.panelBackground.Controls.Add(this.pictureBoxAnonymize);
            this.panelBackground.Controls.Add(this.pictureBoxClearFiles);
            this.panelBackground.Controls.Add(this.pictureBoxAddFiles);
            this.panelBackground.Controls.Add(this.pictureBoxAddFolder);
            this.panelBackground.Controls.Add(this.pictureBoxSettings);
            this.panelBackground.Controls.Add(this.progressBar);
            this.panelBackground.Controls.Add(this.pictureBoxMinimize);
            this.panelBackground.Controls.Add(this.pictureBoxClose);
            this.panelBackground.Controls.Add(this.flowLayoutPanelNumberOfModalities);
            this.panelBackground.Controls.Add(this.panelDropFiles);
            this.panelBackground.Controls.Add(this.labelDevelopedBy);
            this.panelBackground.Controls.Add(this.labelVersion);
            this.panelBackground.Controls.Add(this.labelTitle);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(1, 1);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(344, 570);
            this.panelBackground.TabIndex = 8;
            // 
            // labelProgressStatus
            // 
            this.labelProgressStatus.ForeColor = System.Drawing.Color.White;
            this.labelProgressStatus.Location = new System.Drawing.Point(16, 384);
            this.labelProgressStatus.Name = "labelProgressStatus";
            this.labelProgressStatus.Size = new System.Drawing.Size(310, 23);
            this.labelProgressStatus.TabIndex = 23;
            this.labelProgressStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBoxIcon.Image = global::DcmIncognito.Properties.Resources.DcmIncognito;
            this.pictureBoxIcon.Location = new System.Drawing.Point(3, 5);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 8;
            this.pictureBoxIcon.TabStop = false;
            this.pictureBoxIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseDown);
            this.pictureBoxIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseMove);
            this.pictureBoxIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseUp);
            // 
            // labelEvilDICOM
            // 
            this.labelEvilDICOM.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.labelEvilDICOM.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEvilDICOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvilDICOM.ForeColor = System.Drawing.Color.White;
            this.labelEvilDICOM.Location = new System.Drawing.Point(0, 54);
            this.labelEvilDICOM.Name = "labelEvilDICOM";
            this.labelEvilDICOM.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.labelEvilDICOM.Size = new System.Drawing.Size(344, 13);
            this.labelEvilDICOM.TabIndex = 22;
            this.labelEvilDICOM.Text = "Based on EvilDICOM version x.x.x.x";
            // 
            // pictureBoxAnonymize
            // 
            this.pictureBoxAnonymize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxAnonymize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAnonymize.Image = global::DcmIncognito.Properties.Resources.Anonymize;
            this.pictureBoxAnonymize.Location = new System.Drawing.Point(205, 521);
            this.pictureBoxAnonymize.Name = "pictureBoxAnonymize";
            this.pictureBoxAnonymize.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxAnonymize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAnonymize.TabIndex = 21;
            this.pictureBoxAnonymize.TabStop = false;
            this.pictureBoxAnonymize.Click += new System.EventHandler(this.PictureBoxAnonymize_Click);
            this.pictureBoxAnonymize.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.pictureBoxAnonymize.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // pictureBoxClearFiles
            // 
            this.pictureBoxClearFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxClearFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClearFiles.Image = global::DcmIncognito.Properties.Resources.ClearFiles;
            this.pictureBoxClearFiles.Location = new System.Drawing.Point(108, 520);
            this.pictureBoxClearFiles.Name = "pictureBoxClearFiles";
            this.pictureBoxClearFiles.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxClearFiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClearFiles.TabIndex = 20;
            this.pictureBoxClearFiles.TabStop = false;
            this.pictureBoxClearFiles.Click += new System.EventHandler(this.PictureBoxClearFiles_Click);
            this.pictureBoxClearFiles.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.pictureBoxClearFiles.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // pictureBoxAddFiles
            // 
            this.pictureBoxAddFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxAddFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAddFiles.Image = global::DcmIncognito.Properties.Resources.AddFiles;
            this.pictureBoxAddFiles.Location = new System.Drawing.Point(58, 520);
            this.pictureBoxAddFiles.Name = "pictureBoxAddFiles";
            this.pictureBoxAddFiles.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxAddFiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAddFiles.TabIndex = 19;
            this.pictureBoxAddFiles.TabStop = false;
            this.pictureBoxAddFiles.Click += new System.EventHandler(this.PictureBoxAddFiles_Click);
            this.pictureBoxAddFiles.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.pictureBoxAddFiles.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // pictureBoxAddFolder
            // 
            this.pictureBoxAddFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxAddFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAddFolder.Image = global::DcmIncognito.Properties.Resources.AddFolder;
            this.pictureBoxAddFolder.Location = new System.Drawing.Point(8, 521);
            this.pictureBoxAddFolder.Name = "pictureBoxAddFolder";
            this.pictureBoxAddFolder.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxAddFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAddFolder.TabIndex = 18;
            this.pictureBoxAddFolder.TabStop = false;
            this.pictureBoxAddFolder.Click += new System.EventHandler(this.PictureBoxAddFolder_Click);
            this.pictureBoxAddFolder.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.pictureBoxAddFolder.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxSettings.ContextMenuStrip = this.contextMenuStripSettings;
            this.pictureBoxSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSettings.Image = global::DcmIncognito.Properties.Resources.Settings;
            this.pictureBoxSettings.Location = new System.Drawing.Point(298, 521);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSettings.TabIndex = 17;
            this.pictureBoxSettings.TabStop = false;
            this.pictureBoxSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxSettings_MouseDown);
            this.pictureBoxSettings.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.pictureBoxSettings.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // contextMenuStripSettings
            // 
            this.contextMenuStripSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOutputDirectory,
            this.toolStripMenuItem4,
            this.toolStripMenuItemId,
            this.toolStripMenuItemName,
            this.toolStripMenuItem2,
            this.toolStripMenuItemGenerateNewUIDs,
            this.toolStripMenuItem3,
            this.toolStripMenuItemAnynomizeNames,
            this.toolStripMenuItemAnonymizeStudyIDs,
            this.toolStripMenuItemAnonymizeDates,
            this.toolStripMenuItemRemovePrivateTags,
            this.toolStripMenuItemRemoveSetupTechniqueDescription,
            this.toolStripMenuItemClearStandardIdentificationProfile,
            this.toolStripMenuItem1,
            this.toolStripMenuItemAdvancedSettings,
            this.toolStripMenuItemSaveSettings});
            this.contextMenuStripSettings.Name = "contextMenuStripSettings";
            this.contextMenuStripSettings.Size = new System.Drawing.Size(268, 314);
            this.contextMenuStripSettings.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.ContextMenuStripSettings_Closing);
            this.contextMenuStripSettings.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripSettings_Opening);
            // 
            // toolStripMenuItemOutputDirectory
            // 
            this.toolStripMenuItemOutputDirectory.Name = "toolStripMenuItemOutputDirectory";
            this.toolStripMenuItemOutputDirectory.Size = new System.Drawing.Size(267, 22);
            this.toolStripMenuItemOutputDirectory.Text = "Output folder:";
            this.toolStripMenuItemOutputDirectory.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(264, 6);
            // 
            // toolStripMenuItemId
            // 
            this.toolStripMenuItemId.Name = "toolStripMenuItemId";
            this.toolStripMenuItemId.Size = new System.Drawing.Size(267, 22);
            this.toolStripMenuItemId.Text = "ID:";
            this.toolStripMenuItemId.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItemName
            // 
            this.toolStripMenuItemName.Name = "toolStripMenuItemName";
            this.toolStripMenuItemName.Size = new System.Drawing.Size(267, 22);
            this.toolStripMenuItemName.Text = "Name:";
            this.toolStripMenuItemName.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(264, 6);
            // 
            // toolStripMenuItemGenerateNewUIDs
            // 
            this.toolStripMenuItemGenerateNewUIDs.Checked = true;
            this.toolStripMenuItemGenerateNewUIDs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemGenerateNewUIDs.Name = "toolStripMenuItemGenerateNewUIDs";
            this.toolStripMenuItemGenerateNewUIDs.Size = new System.Drawing.Size(267, 22);
            this.toolStripMenuItemGenerateNewUIDs.Text = "Generate new UID:s";
            this.toolStripMenuItemGenerateNewUIDs.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(264, 6);
            // 
            // toolStripMenuItemAnynomizeNames
            // 
            this.toolStripMenuItemAnynomizeNames.Checked = true;
            this.toolStripMenuItemAnynomizeNames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemAnynomizeNames.Name = "toolStripMenuItemAnynomizeNames";
            this.toolStripMenuItemAnynomizeNames.Size = new System.Drawing.Size(267, 22);
            this.toolStripMenuItemAnynomizeNames.Text = "Anonymize names";
            this.toolStripMenuItemAnynomizeNames.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItemAnonymizeStudyIDs
            // 
            this.toolStripMenuItemAnonymizeStudyIDs.Checked = true;
            this.toolStripMenuItemAnonymizeStudyIDs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemAnonymizeStudyIDs.Name = "toolStripMenuItemAnonymizeStudyIDs";
            this.toolStripMenuItemAnonymizeStudyIDs.Size = new System.Drawing.Size(267, 22);
            this.toolStripMenuItemAnonymizeStudyIDs.Text = "Anonymize study ids";
            this.toolStripMenuItemAnonymizeStudyIDs.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItemAnonymizeDates
            // 
            this.toolStripMenuItemAnonymizeDates.Checked = true;
            this.toolStripMenuItemAnonymizeDates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemAnonymizeDates.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPreserveAge,
            this.toolStripMenuItemClearAge,
            this.toolStripMenuItemRandomize});
            this.toolStripMenuItemAnonymizeDates.Name = "toolStripMenuItemAnonymizeDates";
            this.toolStripMenuItemAnonymizeDates.Size = new System.Drawing.Size(267, 22);
            this.toolStripMenuItemAnonymizeDates.Text = "Anonymize dates";
            this.toolStripMenuItemAnonymizeDates.DropDownClosed += new System.EventHandler(this.ToolStripMenuItemAnonymizeDates_DropDownClosed);
            this.toolStripMenuItemAnonymizeDates.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItemPreserveAge
            // 
            this.toolStripMenuItemPreserveAge.Checked = true;
            this.toolStripMenuItemPreserveAge.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemPreserveAge.Name = "toolStripMenuItemPreserveAge";
            this.toolStripMenuItemPreserveAge.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemPreserveAge.Text = "Preserve age";
            this.toolStripMenuItemPreserveAge.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItemClearAge
            // 
            this.toolStripMenuItemClearAge.Name = "toolStripMenuItemClearAge";
            this.toolStripMenuItemClearAge.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemClearAge.Text = "Clear age";
            this.toolStripMenuItemClearAge.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItemRandomize
            // 
            this.toolStripMenuItemRandomize.Name = "toolStripMenuItemRandomize";
            this.toolStripMenuItemRandomize.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemRandomize.Text = "Randomize";
            this.toolStripMenuItemRandomize.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItemRemovePrivateTags
            // 
            this.toolStripMenuItemRemovePrivateTags.Checked = true;
            this.toolStripMenuItemRemovePrivateTags.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemRemovePrivateTags.Name = "toolStripMenuItemRemovePrivateTags";
            this.toolStripMenuItemRemovePrivateTags.Size = new System.Drawing.Size(267, 22);
            this.toolStripMenuItemRemovePrivateTags.Text = "Remove private tags";
            this.toolStripMenuItemRemovePrivateTags.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItemRemoveSetupTechniqueDescription
            // 
            this.toolStripMenuItemRemoveSetupTechniqueDescription.Name = "toolStripMenuItemRemoveSetupTechniqueDescription";
            this.toolStripMenuItemRemoveSetupTechniqueDescription.Size = new System.Drawing.Size(267, 22);
            this.toolStripMenuItemRemoveSetupTechniqueDescription.Text = "Remove setup technique description";
            this.toolStripMenuItemRemoveSetupTechniqueDescription.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItemClearStandardIdentificationProfile
            // 
            this.toolStripMenuItemClearStandardIdentificationProfile.Checked = true;
            this.toolStripMenuItemClearStandardIdentificationProfile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemClearStandardIdentificationProfile.Name = "toolStripMenuItemClearStandardIdentificationProfile";
            this.toolStripMenuItemClearStandardIdentificationProfile.Size = new System.Drawing.Size(267, 22);
            this.toolStripMenuItemClearStandardIdentificationProfile.Text = "Clear standard identification profile";
            this.toolStripMenuItemClearStandardIdentificationProfile.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(264, 6);
            // 
            // toolStripMenuItemAdvancedSettings
            // 
            this.toolStripMenuItemAdvancedSettings.Name = "toolStripMenuItemAdvancedSettings";
            this.toolStripMenuItemAdvancedSettings.Size = new System.Drawing.Size(267, 22);
            this.toolStripMenuItemAdvancedSettings.Text = "Advanced settings...";
            this.toolStripMenuItemAdvancedSettings.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItemSaveSettings
            // 
            this.toolStripMenuItemSaveSettings.Name = "toolStripMenuItemSaveSettings";
            this.toolStripMenuItemSaveSettings.Size = new System.Drawing.Size(267, 22);
            this.toolStripMenuItemSaveSettings.Text = "Save settings";
            this.toolStripMenuItemSaveSettings.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.BarColor = System.Drawing.Color.White;
            this.progressBar.BorderColor = System.Drawing.Color.Black;
            this.progressBar.FillStyle = DcmIncognito.ColorProgressBar.FillStyles.Dashed;
            this.progressBar.Location = new System.Drawing.Point(16, 364);
            this.progressBar.Maximum = 100;
            this.progressBar.Minimum = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(310, 17);
            this.progressBar.Step = 10;
            this.progressBar.TabIndex = 16;
            this.progressBar.Value = 0;
            this.progressBar.Visible = false;
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimize.Image = global::DcmIncognito.Properties.Resources.Minimize;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(288, 3);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimize.TabIndex = 15;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.PictureBoxMinimize_Click);
            this.pictureBoxMinimize.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.pictureBoxMinimize.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = global::DcmIncognito.Properties.Resources.Close;
            this.pictureBoxClose.Location = new System.Drawing.Point(315, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 14;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.PictureBoxClose_Click);
            this.pictureBoxClose.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.pictureBoxClose.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // flowLayoutPanelNumberOfModalities
            // 
            this.flowLayoutPanelNumberOfModalities.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanelNumberOfModalities.Location = new System.Drawing.Point(16, 420);
            this.flowLayoutPanelNumberOfModalities.Name = "flowLayoutPanelNumberOfModalities";
            this.flowLayoutPanelNumberOfModalities.Size = new System.Drawing.Size(310, 87);
            this.flowLayoutPanelNumberOfModalities.TabIndex = 12;
            // 
            // panelDropFiles
            // 
            this.panelDropFiles.AllowDrop = true;
            this.panelDropFiles.AutoSize = true;
            this.panelDropFiles.BackgroundImage = global::DcmIncognito.Properties.Resources.FileDrop;
            this.panelDropFiles.Controls.Add(this.labelDropFilesHere);
            this.panelDropFiles.Location = new System.Drawing.Point(44, 89);
            this.panelDropFiles.Name = "panelDropFiles";
            this.panelDropFiles.Size = new System.Drawing.Size(256, 256);
            this.panelDropFiles.TabIndex = 11;
            this.panelDropFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelDropFiles_DragDrop);
            this.panelDropFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelDropFiles_DragEnter);
            // 
            // labelDropFilesHere
            // 
            this.labelDropFilesHere.ForeColor = System.Drawing.Color.White;
            this.labelDropFilesHere.Location = new System.Drawing.Point(3, 116);
            this.labelDropFilesHere.Name = "labelDropFilesHere";
            this.labelDropFilesHere.Size = new System.Drawing.Size(250, 23);
            this.labelDropFilesHere.TabIndex = 7;
            this.labelDropFilesHere.Text = "Drop files or directories here";
            this.labelDropFilesHere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDevelopedBy
            // 
            this.labelDevelopedBy.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.labelDevelopedBy.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDevelopedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDevelopedBy.ForeColor = System.Drawing.Color.White;
            this.labelDevelopedBy.Location = new System.Drawing.Point(0, 41);
            this.labelDevelopedBy.Name = "labelDevelopedBy";
            this.labelDevelopedBy.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.labelDevelopedBy.Size = new System.Drawing.Size(344, 13);
            this.labelDevelopedBy.TabIndex = 10;
            this.labelDevelopedBy.Text = "Developed by Fredrik Nordström";
            this.labelDevelopedBy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseDown);
            this.labelDevelopedBy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseMove);
            this.labelDevelopedBy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseUp);
            // 
            // labelVersion
            // 
            this.labelVersion.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(0, 28);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.labelVersion.Size = new System.Drawing.Size(344, 13);
            this.labelVersion.TabIndex = 9;
            this.labelVersion.Text = "Version x.x.x.x";
            this.labelVersion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseDown);
            this.labelVersion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseMove);
            this.labelVersion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseUp);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(346, 572);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "DcmIncognito";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnonymize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClearFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
            this.contextMenuStripSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panelDropFiles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDropFilesHere;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelDevelopedBy;
        private System.Windows.Forms.Panel panelDropFiles;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNumberOfModalities;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private ColorProgressBar progressBar;
        private System.Windows.Forms.PictureBox pictureBoxSettings;
        private System.Windows.Forms.PictureBox pictureBoxAddFolder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGenerateNewUIDs;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemId;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemName;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdvancedSettings;
        private System.Windows.Forms.PictureBox pictureBoxAddFiles;
        private System.Windows.Forms.PictureBox pictureBoxClearFiles;
        private System.Windows.Forms.PictureBox pictureBoxAnonymize;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemovePrivateTags;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOutputDirectory;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveSettings;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAnynomizeNames;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAnonymizeStudyIDs;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAnonymizeDates;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClearStandardIdentificationProfile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPreserveAge;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClearAge;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRandomize;
        private System.Windows.Forms.Label labelEvilDICOM;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemoveSetupTechniqueDescription;
        private System.Windows.Forms.Label labelProgressStatus;
    }
}

