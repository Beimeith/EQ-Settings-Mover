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
            this.L_EQ_Directory_Path = new System.Windows.Forms.Label();
            this.DD_Current_Server = new System.Windows.Forms.ComboBox();
            this.L_Current_Server = new System.Windows.Forms.Label();
            this.DD_New_Server = new System.Windows.Forms.ComboBox();
            this.L_New_Server = new System.Windows.Forms.Label();
            this.L_New_Name = new System.Windows.Forms.Label();
            this.DD_Current_Name = new System.Windows.Forms.ComboBox();
            this.L_Current_Name = new System.Windows.Forms.Label();
            this.TB_New_Name = new System.Windows.Forms.TextBox();
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
            this.B_Copy_Settings = new System.Windows.Forms.Button();
            this.GNLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.L_Warning = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectEQFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectNewEQFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gettingStartedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportForumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutGamSettingsMoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.L_EQ_Source_Directory = new System.Windows.Forms.Label();
            this.L_EQ_Destination_Directory = new System.Windows.Forms.Label();
            this.L_EQ_Destination_Directory_Path = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_EQ_Directory_Path
            // 
            this.L_EQ_Directory_Path.AutoSize = true;
            this.L_EQ_Directory_Path.Location = new System.Drawing.Point(15, 83);
            this.L_EQ_Directory_Path.Margin = new System.Windows.Forms.Padding(3);
            this.L_EQ_Directory_Path.Name = "L_EQ_Directory_Path";
            this.L_EQ_Directory_Path.Size = new System.Drawing.Size(107, 13);
            this.L_EQ_Directory_Path.TabIndex = 1;
            this.L_EQ_Directory_Path.Text = "No directory selected";
            // 
            // DD_Current_Server
            // 
            this.DD_Current_Server.DropDownHeight = 380;
            this.DD_Current_Server.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DD_Current_Server.FormattingEnabled = true;
            this.DD_Current_Server.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DD_Current_Server.IntegralHeight = false;
            this.DD_Current_Server.Items.AddRange(new object[] {
            "Aradune",
            "Mangler",
            "Selo",
            "Miragul",
            "Rizlona",
            "Vox",
            "Agnarr",
            "Antonius Bayle",
            "Bertoxxulous",
            "Brekt",
            "Bristlebane",
            "Cazic Thule",
            "Coirnav",
            "Drinal",
            "Druzzil Ro",
            "Erollisi Marr",
            "Fennin Ro",
            "Fippy Darkpaw",
            "Firona Vie",
            "Lockjaw",
            "Luclin",
            "Maelin Starpyre",
            "Mayong",
            "Phinigel",
            "Povar",
            "Prexus",
            "Quarm",
            "Quellious",
            "Ragefire",
            "Saryrn",
            "Stromm",
            "The Nameless",
            "The Rathe",
            "The Seventh Hammer",
            "The Tribunal",
            "Tunare",
            "Vulek\'Aerr",
            "Xegony",
            "Zek",
            "Test",
            "Beta"});
            this.DD_Current_Server.Location = new System.Drawing.Point(134, 107);
            this.DD_Current_Server.Name = "DD_Current_Server";
            this.DD_Current_Server.Size = new System.Drawing.Size(191, 21);
            this.DD_Current_Server.TabIndex = 78;
            this.DD_Current_Server.SelectedIndexChanged += new System.EventHandler(this.DD_Current_Server_SelectedIndexChanged);
            // 
            // L_Current_Server
            // 
            this.L_Current_Server.AutoSize = true;
            this.L_Current_Server.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Current_Server.Location = new System.Drawing.Point(70, 110);
            this.L_Current_Server.Name = "L_Current_Server";
            this.L_Current_Server.Size = new System.Drawing.Size(58, 13);
            this.L_Current_Server.TabIndex = 77;
            this.L_Current_Server.Text = "Old server:";
            // 
            // DD_New_Server
            // 
            this.DD_New_Server.DropDownHeight = 380;
            this.DD_New_Server.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DD_New_Server.FormattingEnabled = true;
            this.DD_New_Server.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DD_New_Server.IntegralHeight = false;
            this.DD_New_Server.Items.AddRange(new object[] {
            "Select server",
            "Staying on same server",
            "Aradune",
            "Mangler",
            "Selo",
            "Miragul",
            "Rizlona",
            "Vox",
            "Agnarr",
            "Antonius Bayle",
            "Bertoxxulous - Saryrn",
            "Bristlebane - The Tribunal",
            "Cazic Thule - Fennin Ro",
            "Coirnav",
            "Drinal - Maelin Starpyre",
            "Erollisi Marr - The Nameless",
            "Fippy Darkpaw",
            "Firona Vie",
            "Luclin - Stromm",
            "Phinigel",
            "Povar - Quellious",
            "Ragefire",
            "The Rathe - Prexus",
            "Tunare - The Seventh Hammer",
            "Vulek\'Aerr",
            "Xegony - Druzzil Ro",
            "Zek",
            "Test",
            "Beta"});
            this.DD_New_Server.Location = new System.Drawing.Point(134, 140);
            this.DD_New_Server.Name = "DD_New_Server";
            this.DD_New_Server.Size = new System.Drawing.Size(191, 21);
            this.DD_New_Server.TabIndex = 80;
            this.DD_New_Server.SelectedIndexChanged += new System.EventHandler(this.DD_New_Server_SelectedIndexChanged);
            // 
            // L_New_Server
            // 
            this.L_New_Server.AutoSize = true;
            this.L_New_Server.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_New_Server.Location = new System.Drawing.Point(38, 143);
            this.L_New_Server.Name = "L_New_Server";
            this.L_New_Server.Size = new System.Drawing.Size(90, 13);
            this.L_New_Server.TabIndex = 79;
            this.L_New_Server.Text = "Server moving to:";
            // 
            // L_New_Name
            // 
            this.L_New_Name.AutoSize = true;
            this.L_New_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_New_Name.Location = new System.Drawing.Point(383, 143);
            this.L_New_Name.Name = "L_New_Name";
            this.L_New_Name.Size = new System.Drawing.Size(144, 13);
            this.L_New_Name.TabIndex = 83;
            this.L_New_Name.Text = "Character name changing to:";
            // 
            // DD_Current_Name
            // 
            this.DD_Current_Name.DropDownHeight = 212;
            this.DD_Current_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DD_Current_Name.FormattingEnabled = true;
            this.DD_Current_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DD_Current_Name.IntegralHeight = false;
            this.DD_Current_Name.Items.AddRange(new object[] {
            "Select server first"});
            this.DD_Current_Name.Location = new System.Drawing.Point(533, 107);
            this.DD_Current_Name.MaxDropDownItems = 100;
            this.DD_Current_Name.Name = "DD_Current_Name";
            this.DD_Current_Name.Size = new System.Drawing.Size(160, 21);
            this.DD_Current_Name.TabIndex = 82;
            this.DD_Current_Name.SelectedIndexChanged += new System.EventHandler(this.DD_Current_Name_SelectedIndexChanged);
            // 
            // L_Current_Name
            // 
            this.L_Current_Name.AutoSize = true;
            this.L_Current_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Current_Name.Location = new System.Drawing.Point(406, 110);
            this.L_Current_Name.Name = "L_Current_Name";
            this.L_Current_Name.Size = new System.Drawing.Size(121, 13);
            this.L_Current_Name.TabIndex = 81;
            this.L_Current_Name.Text = "Current character name:";
            // 
            // TB_New_Name
            // 
            this.TB_New_Name.Location = new System.Drawing.Point(533, 141);
            this.TB_New_Name.Name = "TB_New_Name";
            this.TB_New_Name.Size = new System.Drawing.Size(160, 20);
            this.TB_New_Name.TabIndex = 84;
            this.TB_New_Name.TextChanged += new System.EventHandler(this.TB_New_Name_TextChanged);
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteLabel.ForeColor = System.Drawing.Color.Red;
            this.NoteLabel.Location = new System.Drawing.Point(151, 32);
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
            this.NoteLabel2.Location = new System.Drawing.Point(94, 45);
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
            this.label4.Location = new System.Drawing.Point(115, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "UI, screen and window layouts:";
            // 
            // UILabel
            // 
            this.UILabel.AutoSize = true;
            this.UILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UILabel.Location = new System.Drawing.Point(286, 172);
            this.UILabel.Name = "UILabel";
            this.UILabel.Size = new System.Drawing.Size(0, 13);
            this.UILabel.TabIndex = 88;
            // 
            // SocialsLabel
            // 
            this.SocialsLabel.AutoSize = true;
            this.SocialsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SocialsLabel.Location = new System.Drawing.Point(286, 198);
            this.SocialsLabel.Name = "SocialsLabel";
            this.SocialsLabel.Size = new System.Drawing.Size(0, 13);
            this.SocialsLabel.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(170, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "Friends and socials:";
            // 
            // CombatLabel
            // 
            this.CombatLabel.AutoSize = true;
            this.CombatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombatLabel.Location = new System.Drawing.Point(286, 250);
            this.CombatLabel.Name = "CombatLabel";
            this.CombatLabel.Size = new System.Drawing.Size(0, 13);
            this.CombatLabel.TabIndex = 98;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(187, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 97;
            this.label13.Text = "Combat abilities:";
            // 
            // AudioLabel
            // 
            this.AudioLabel.AutoSize = true;
            this.AudioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AudioLabel.Location = new System.Drawing.Point(286, 224);
            this.AudioLabel.Name = "AudioLabel";
            this.AudioLabel.Size = new System.Drawing.Size(0, 13);
            this.AudioLabel.TabIndex = 96;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(196, 224);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 95;
            this.label15.Text = "Audio triggers:";
            // 
            // BazaarLabel
            // 
            this.BazaarLabel.AutoSize = true;
            this.BazaarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BazaarLabel.Location = new System.Drawing.Point(286, 276);
            this.BazaarLabel.Name = "BazaarLabel";
            this.BazaarLabel.Size = new System.Drawing.Size(0, 13);
            this.BazaarLabel.TabIndex = 100;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(196, 276);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 13);
            this.label19.TabIndex = 99;
            this.label19.Text = "Bazaar prices:";
            // 
            // BarterLabel
            // 
            this.BarterLabel.AutoSize = true;
            this.BarterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarterLabel.Location = new System.Drawing.Point(286, 302);
            this.BarterLabel.Name = "BarterLabel";
            this.BarterLabel.Size = new System.Drawing.Size(0, 13);
            this.BarterLabel.TabIndex = 106;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(188, 302);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 13);
            this.label21.TabIndex = 105;
            this.label21.Text = "Barter buy lines:";
            // 
            // B_Copy_Settings
            // 
            this.B_Copy_Settings.Location = new System.Drawing.Point(12, 372);
            this.B_Copy_Settings.Name = "B_Copy_Settings";
            this.B_Copy_Settings.Size = new System.Drawing.Size(134, 28);
            this.B_Copy_Settings.TabIndex = 107;
            this.B_Copy_Settings.Text = "Copy settings files";
            this.B_Copy_Settings.UseVisualStyleBackColor = true;
            this.B_Copy_Settings.Click += new System.EventHandler(this.B_Copy_Settings_Click);
            // 
            // GNLabel
            // 
            this.GNLabel.AutoSize = true;
            this.GNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GNLabel.Location = new System.Drawing.Point(286, 328);
            this.GNLabel.Name = "GNLabel";
            this.GNLabel.Size = new System.Drawing.Size(0, 13);
            this.GNLabel.TabIndex = 111;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(187, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 110;
            this.label9.Text = "Guild notes file:";
            // 
            // L_Warning
            // 
            this.L_Warning.AutoSize = true;
            this.L_Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Warning.ForeColor = System.Drawing.Color.Red;
            this.L_Warning.Location = new System.Drawing.Point(113, 350);
            this.L_Warning.Name = "L_Warning";
            this.L_Warning.Size = new System.Drawing.Size(0, 13);
            this.L_Warning.TabIndex = 112;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 113;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectEQFolderToolStripMenuItem,
            this.selectNewEQFolderToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectEQFolderToolStripMenuItem
            // 
            this.selectEQFolderToolStripMenuItem.Name = "selectEQFolderToolStripMenuItem";
            this.selectEQFolderToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.selectEQFolderToolStripMenuItem.Text = "Select Source EQ Folder";
            this.selectEQFolderToolStripMenuItem.Click += new System.EventHandler(this.selectEQFolderToolStripMenuItem_Click);
            // 
            // selectNewEQFolderToolStripMenuItem
            // 
            this.selectNewEQFolderToolStripMenuItem.Name = "selectNewEQFolderToolStripMenuItem";
            this.selectNewEQFolderToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.selectNewEQFolderToolStripMenuItem.Text = "Select Destination EQ Folder";
            this.selectNewEQFolderToolStripMenuItem.Click += new System.EventHandler(this.selectNewEQFolderToolStripMenuItem_Click);
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
            // L_EQ_Source_Directory
            // 
            this.L_EQ_Source_Directory.AutoSize = true;
            this.L_EQ_Source_Directory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_EQ_Source_Directory.Location = new System.Drawing.Point(15, 67);
            this.L_EQ_Source_Directory.Name = "L_EQ_Source_Directory";
            this.L_EQ_Source_Directory.Size = new System.Drawing.Size(169, 13);
            this.L_EQ_Source_Directory.TabIndex = 114;
            this.L_EQ_Source_Directory.Text = "EverQuest Source Directory:";
            // 
            // L_EQ_Destination_Directory
            // 
            this.L_EQ_Destination_Directory.AutoSize = true;
            this.L_EQ_Destination_Directory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_EQ_Destination_Directory.Location = new System.Drawing.Point(384, 67);
            this.L_EQ_Destination_Directory.Name = "L_EQ_Destination_Directory";
            this.L_EQ_Destination_Directory.Size = new System.Drawing.Size(193, 13);
            this.L_EQ_Destination_Directory.TabIndex = 116;
            this.L_EQ_Destination_Directory.Text = "EverQuest Destination Directory:";
            // 
            // L_EQ_Destination_Directory_Path
            // 
            this.L_EQ_Destination_Directory_Path.AutoSize = true;
            this.L_EQ_Destination_Directory_Path.Location = new System.Drawing.Point(384, 83);
            this.L_EQ_Destination_Directory_Path.Margin = new System.Windows.Forms.Padding(3);
            this.L_EQ_Destination_Directory_Path.Name = "L_EQ_Destination_Directory_Path";
            this.L_EQ_Destination_Directory_Path.Size = new System.Drawing.Size(107, 13);
            this.L_EQ_Destination_Directory_Path.TabIndex = 115;
            this.L_EQ_Destination_Directory_Path.Text = "No directory selected";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 412);
            this.Controls.Add(this.L_EQ_Destination_Directory);
            this.Controls.Add(this.L_EQ_Destination_Directory_Path);
            this.Controls.Add(this.L_EQ_Source_Directory);
            this.Controls.Add(this.L_Warning);
            this.Controls.Add(this.GNLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.B_Copy_Settings);
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
            this.Controls.Add(this.TB_New_Name);
            this.Controls.Add(this.L_New_Name);
            this.Controls.Add(this.DD_Current_Name);
            this.Controls.Add(this.L_Current_Name);
            this.Controls.Add(this.DD_New_Server);
            this.Controls.Add(this.L_New_Server);
            this.Controls.Add(this.DD_Current_Server);
            this.Controls.Add(this.L_Current_Server);
            this.Controls.Add(this.L_EQ_Directory_Path);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GamSettingsMover v1.5.0.3";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_EQ_Directory_Path;
        private System.Windows.Forms.ComboBox DD_Current_Server;
        private System.Windows.Forms.Label L_Current_Server;
        private System.Windows.Forms.ComboBox DD_New_Server;
        private System.Windows.Forms.Label L_New_Server;
        private System.Windows.Forms.Label L_New_Name;
        private System.Windows.Forms.ComboBox DD_Current_Name;
        private System.Windows.Forms.Label L_Current_Name;
        private System.Windows.Forms.TextBox TB_New_Name;
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
        private System.Windows.Forms.Button B_Copy_Settings;
        private System.Windows.Forms.Label GNLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label L_Warning;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectEQFolderToolStripMenuItem;
        private System.Windows.Forms.Label L_EQ_Source_Directory;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gettingStartedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportForumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutGamSettingsMoverToolStripMenuItem;
        private System.Windows.Forms.Label L_EQ_Destination_Directory;
        private System.Windows.Forms.Label L_EQ_Destination_Directory_Path;
        private System.Windows.Forms.ToolStripMenuItem selectNewEQFolderToolStripMenuItem;
    }
}

