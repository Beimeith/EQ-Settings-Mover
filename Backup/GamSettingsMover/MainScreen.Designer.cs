namespace GamSettingsMover
{
    partial class MainScreen
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
            this.EQDirLabel = new System.Windows.Forms.Label();
            this.CurrentServerDropDown = new System.Windows.Forms.ComboBox();
            this.CurrentServerLabel = new System.Windows.Forms.Label();
            this.NewServerDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentCharDropDown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewCharTextBox = new System.Windows.Forms.TextBox();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.NoteLabel2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UILabel = new System.Windows.Forms.Label();
            this.SocialsLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CombatLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.AudioLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.BazaarLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.BarterLabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.ConfirmationButton = new System.Windows.Forms.Button();
            this.GNLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectEQFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gettingStartedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportForumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutGamSettingsMoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EQDirLabel
            // 
            this.EQDirLabel.AutoSize = true;
            this.EQDirLabel.Location = new System.Drawing.Point(146, 67);
            this.EQDirLabel.Name = "EQDirLabel";
            this.EQDirLabel.Size = new System.Drawing.Size(107, 13);
            this.EQDirLabel.TabIndex = 1;
            this.EQDirLabel.Text = "No directory selected";
            // 
            // CurrentServerDropDown
            // 
            this.CurrentServerDropDown.DropDownHeight = 380;
            this.CurrentServerDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrentServerDropDown.FormattingEnabled = true;
            this.CurrentServerDropDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CurrentServerDropDown.IntegralHeight = false;
            this.CurrentServerDropDown.Items.AddRange(new object[] {
            "Select server",
            "Antonius Bayle",
            "Bertoxxulous",
            "Bristlebane",
            "Cazic Thule",
            "Drinal",
            "Druzzil Ro",
            "Erollisi Marr",
            "Fennin Ro",
            "Firona Vie",
            "Luclin",
            "Maelin Starpyre",
            "Mayong",
            "Povar",
            "Prexus",
            "Quellious",
            "Saryrn",
            "Stromm",
            "The Nameless",
            "The Rathe",
            "The Seventh Hammer",
            "The Tribunal",
            "Tunare",
            "Xegony",
            "Zek",
            "Test",
            "Beta"});
            this.CurrentServerDropDown.Location = new System.Drawing.Point(111, 92);
            this.CurrentServerDropDown.Name = "CurrentServerDropDown";
            this.CurrentServerDropDown.Size = new System.Drawing.Size(191, 21);
            this.CurrentServerDropDown.TabIndex = 78;
            this.CurrentServerDropDown.SelectedIndexChanged += new System.EventHandler(this.CurrentServerDropDown_SelectedIndexChanged);
            // 
            // CurrentServerLabel
            // 
            this.CurrentServerLabel.AutoSize = true;
            this.CurrentServerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentServerLabel.Location = new System.Drawing.Point(47, 95);
            this.CurrentServerLabel.Name = "CurrentServerLabel";
            this.CurrentServerLabel.Size = new System.Drawing.Size(58, 13);
            this.CurrentServerLabel.TabIndex = 77;
            this.CurrentServerLabel.Text = "Old server:";
            // 
            // NewServerDropDown
            // 
            this.NewServerDropDown.DropDownHeight = 380;
            this.NewServerDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NewServerDropDown.FormattingEnabled = true;
            this.NewServerDropDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NewServerDropDown.IntegralHeight = false;
            this.NewServerDropDown.Items.AddRange(new object[] {
            "Select server",
            "Staying on same server",
            "Antonius Bayle",
            "Bertoxxulous - Saryrn",
            "Bristlebane - The Tribunal",
            "Cazic Thule - Fennin Ro",
            "Drinal - Maelin Starpyre",
            "Erollisi Marr - The Nameless",
            "Firona Vie",
            "Luclin - Stromm",
            "Mayong",
            "Povar - Quellious",
            "The Rathe - Prexus",
            "Tunare - The Seventh Hammer",
            "Xegony - Druzzil Ro",
            "Zek",
            "Test",
            "Beta"});
            this.NewServerDropDown.Location = new System.Drawing.Point(111, 131);
            this.NewServerDropDown.Name = "NewServerDropDown";
            this.NewServerDropDown.Size = new System.Drawing.Size(191, 21);
            this.NewServerDropDown.TabIndex = 80;
            this.NewServerDropDown.SelectedIndexChanged += new System.EventHandler(this.NewServerDropDown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Server moving to:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Character name changing to:";
            // 
            // CurrentCharDropDown
            // 
            this.CurrentCharDropDown.DropDownHeight = 212;
            this.CurrentCharDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrentCharDropDown.FormattingEnabled = true;
            this.CurrentCharDropDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CurrentCharDropDown.IntegralHeight = false;
            this.CurrentCharDropDown.Items.AddRange(new object[] {
            "Select server first"});
            this.CurrentCharDropDown.Location = new System.Drawing.Point(475, 92);
            this.CurrentCharDropDown.MaxDropDownItems = 100;
            this.CurrentCharDropDown.Name = "CurrentCharDropDown";
            this.CurrentCharDropDown.Size = new System.Drawing.Size(160, 21);
            this.CurrentCharDropDown.TabIndex = 82;
            this.CurrentCharDropDown.SelectedIndexChanged += new System.EventHandler(this.CurrentCharDropDown_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Current character name:";
            // 
            // NewCharTextBox
            // 
            this.NewCharTextBox.Location = new System.Drawing.Point(475, 132);
            this.NewCharTextBox.Name = "NewCharTextBox";
            this.NewCharTextBox.Size = new System.Drawing.Size(160, 20);
            this.NewCharTextBox.TabIndex = 84;
            this.NewCharTextBox.TextChanged += new System.EventHandler(this.NewCharTextBox_TextChanged);
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteLabel.ForeColor = System.Drawing.Color.Red;
            this.NoteLabel.Location = new System.Drawing.Point(15, 32);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(459, 13);
            this.NoteLabel.TabIndex = 85;
            this.NoteLabel.Text = "Note: This only copies your UI settings files to work with server transfers and c" +
                "haracter renames.";
            // 
            // NoteLabel2
            // 
            this.NoteLabel2.AutoSize = true;
            this.NoteLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteLabel2.ForeColor = System.Drawing.Color.Red;
            this.NoteLabel2.Location = new System.Drawing.Point(15, 45);
            this.NoteLabel2.Name = "NoteLabel2";
            this.NoteLabel2.Size = new System.Drawing.Size(582, 13);
            this.NoteLabel2.TabIndex = 86;
            this.NoteLabel2.Text = "Use this program after server merges, paid character transfers or paid character " +
                "renames so you can retain your UI settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "UI, screen and window layouts:";
            // 
            // UILabel
            // 
            this.UILabel.AutoSize = true;
            this.UILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UILabel.Location = new System.Drawing.Point(228, 166);
            this.UILabel.Name = "UILabel";
            this.UILabel.Size = new System.Drawing.Size(0, 13);
            this.UILabel.TabIndex = 88;
            // 
            // SocialsLabel
            // 
            this.SocialsLabel.AutoSize = true;
            this.SocialsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SocialsLabel.Location = new System.Drawing.Point(228, 192);
            this.SocialsLabel.Name = "SocialsLabel";
            this.SocialsLabel.Size = new System.Drawing.Size(0, 13);
            this.SocialsLabel.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(112, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "Friends and socials:";
            // 
            // CombatLabel
            // 
            this.CombatLabel.AutoSize = true;
            this.CombatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombatLabel.Location = new System.Drawing.Point(228, 244);
            this.CombatLabel.Name = "CombatLabel";
            this.CombatLabel.Size = new System.Drawing.Size(0, 13);
            this.CombatLabel.TabIndex = 98;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(129, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 97;
            this.label13.Text = "Combat abilities:";
            // 
            // AudioLabel
            // 
            this.AudioLabel.AutoSize = true;
            this.AudioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AudioLabel.Location = new System.Drawing.Point(228, 218);
            this.AudioLabel.Name = "AudioLabel";
            this.AudioLabel.Size = new System.Drawing.Size(0, 13);
            this.AudioLabel.TabIndex = 96;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(138, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 95;
            this.label15.Text = "Audio triggers:";
            // 
            // BazaarLabel
            // 
            this.BazaarLabel.AutoSize = true;
            this.BazaarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BazaarLabel.Location = new System.Drawing.Point(228, 270);
            this.BazaarLabel.Name = "BazaarLabel";
            this.BazaarLabel.Size = new System.Drawing.Size(0, 13);
            this.BazaarLabel.TabIndex = 100;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(138, 270);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 13);
            this.label19.TabIndex = 99;
            this.label19.Text = "Bazaar prices:";
            // 
            // BarterLabel
            // 
            this.BarterLabel.AutoSize = true;
            this.BarterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarterLabel.Location = new System.Drawing.Point(228, 296);
            this.BarterLabel.Name = "BarterLabel";
            this.BarterLabel.Size = new System.Drawing.Size(0, 13);
            this.BarterLabel.TabIndex = 106;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(130, 296);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 13);
            this.label21.TabIndex = 105;
            this.label21.Text = "Barter buy lines:";
            // 
            // ConfirmationButton
            // 
            this.ConfirmationButton.Location = new System.Drawing.Point(12, 372);
            this.ConfirmationButton.Name = "ConfirmationButton";
            this.ConfirmationButton.Size = new System.Drawing.Size(134, 28);
            this.ConfirmationButton.TabIndex = 107;
            this.ConfirmationButton.Text = "Copy settings files";
            this.ConfirmationButton.UseVisualStyleBackColor = true;
            this.ConfirmationButton.Click += new System.EventHandler(this.ConfirmationButton_Click);
            // 
            // GNLabel
            // 
            this.GNLabel.AutoSize = true;
            this.GNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GNLabel.Location = new System.Drawing.Point(228, 322);
            this.GNLabel.Name = "GNLabel";
            this.GNLabel.Size = new System.Drawing.Size(0, 13);
            this.GNLabel.TabIndex = 111;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(129, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 110;
            this.label9.Text = "Guild notes file:";
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(15, 346);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(0, 13);
            this.WarningLabel.TabIndex = 112;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 113;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectEQFolderToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectEQFolderToolStripMenuItem
            // 
            this.selectEQFolderToolStripMenuItem.Name = "selectEQFolderToolStripMenuItem";
            this.selectEQFolderToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.selectEQFolderToolStripMenuItem.Text = "Select EQ Folder";
            this.selectEQFolderToolStripMenuItem.Click += new System.EventHandler(this.selectEQFolderToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gettingStartedToolStripMenuItem,
            this.supportForumToolStripMenuItem,
            this.aboutGamSettingsMoverToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // gettingStartedToolStripMenuItem
            // 
            this.gettingStartedToolStripMenuItem.Name = "gettingStartedToolStripMenuItem";
            this.gettingStartedToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.gettingStartedToolStripMenuItem.Text = "Getting Started";
            this.gettingStartedToolStripMenuItem.Click += new System.EventHandler(this.gettingStartedToolStripMenuItem_Click);
            // 
            // supportForumToolStripMenuItem
            // 
            this.supportForumToolStripMenuItem.Name = "supportForumToolStripMenuItem";
            this.supportForumToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.supportForumToolStripMenuItem.Text = "Support Forum";
            this.supportForumToolStripMenuItem.Click += new System.EventHandler(this.supportForumToolStripMenuItem_Click);
            // 
            // aboutGamSettingsMoverToolStripMenuItem
            // 
            this.aboutGamSettingsMoverToolStripMenuItem.Name = "aboutGamSettingsMoverToolStripMenuItem";
            this.aboutGamSettingsMoverToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.aboutGamSettingsMoverToolStripMenuItem.Text = "About GamSettingsMover";
            this.aboutGamSettingsMoverToolStripMenuItem.Click += new System.EventHandler(this.aboutGamSettingsMoverToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 114;
            this.label5.Text = "EverQuest Directory:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.GNLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ConfirmationButton);
            this.Controls.Add(this.BarterLabel);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.BazaarLabel);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.CombatLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.AudioLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.SocialsLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UILabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NoteLabel2);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.NewCharTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentCharDropDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewServerDropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentServerDropDown);
            this.Controls.Add(this.CurrentServerLabel);
            this.Controls.Add(this.EQDirLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainScreen";
            this.Text = "GamSettingsMover";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EQDirLabel;
        private System.Windows.Forms.ComboBox CurrentServerDropDown;
        private System.Windows.Forms.Label CurrentServerLabel;
        private System.Windows.Forms.ComboBox NewServerDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CurrentCharDropDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewCharTextBox;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.Label NoteLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UILabel;
        private System.Windows.Forms.Label SocialsLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CombatLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label AudioLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label BazaarLabel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label BarterLabel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button ConfirmationButton;
        private System.Windows.Forms.Label GNLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectEQFolderToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gettingStartedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportForumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutGamSettingsMoverToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

