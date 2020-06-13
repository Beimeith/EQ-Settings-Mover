using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GamSettingsMover
{
    public partial class MainScreen : Form
    {
        string EQDir = "No directory selected";
        Dictionary<string, string> ShortServer = new Dictionary<string, string>();

        string FromUI = "";
        string ToUI = "";

        string FromSocial = "";
        string ToSocial = "";

        string FromAbilities = "";
        string ToAbilities = "";

        string FromAudio = "";
        string ToAudio = "";

        string FromBazaar = "";
        string ToBazaar = "";

        string FromBarter = "";
        string ToBarter = "";

        string FromGN = "";
        string ToGN = "";

        public MainScreen()
        {
            InitializeComponent();

            ConfirmationButton.Enabled = false;

            // Set drop downs
            CurrentServerDropDown.Text = "Select server";
            NewServerDropDown.Text = "Select server";

            // Set short server names
            ShortServer.Add("Maelin Starpyre", "maelin");
            ShortServer.Add("The Tribunal", "tribunal");
            ShortServer.Add("The Rathe", "rathe");
            ShortServer.Add("Luclin", "luclin");
            ShortServer.Add("Antonius Bayle", "antonius");
            ShortServer.Add("Bertoxxulous", "bertox");
            ShortServer.Add("Bristlebane", "bristle");
            ShortServer.Add("Cazic Thule", "cazic");
            ShortServer.Add("Drinal", "drinal");
            ShortServer.Add("Druzzil Ro", "druzzil");
            ShortServer.Add("Erollisi Marr", "erollisi");
            ShortServer.Add("Fennin Ro", "fenninro");
            ShortServer.Add("Firona Vie", "firiona");
            ShortServer.Add("Mayong", "mayong");
            ShortServer.Add("Povar", "povar");
            ShortServer.Add("Prexus", "prexus");
            ShortServer.Add("Quellious", "quellious");
            ShortServer.Add("Saryrn", "saryrn");
            ShortServer.Add("Stromm", "stromm");
            ShortServer.Add("The Nameless", "nameless");
            ShortServer.Add("The Seventh Hammer", "seventh");
            ShortServer.Add("Tunare", "tunare");
            ShortServer.Add("Xegony", "xegony");
            ShortServer.Add("Zek", "zek");
            ShortServer.Add("Test", "test");
            ShortServer.Add("Beta", "beta");

            ShortServer.Add("Bertoxxulous - Saryrn", "bertox");
            ShortServer.Add("Bristlebane - The Tribunal", "bristle");
            ShortServer.Add("Cazic Thule - Fennin Ro", "cazic");
            ShortServer.Add("Drinal - Maelin Starpyre", "drinal");
            ShortServer.Add("Erollisi Marr - The Nameless", "erollisi");
            ShortServer.Add("Luclin - Stromm", "luclin");
            ShortServer.Add("Povar - Quellious", "povar");
            ShortServer.Add("The Rathe - Prexus", "rathe");
            ShortServer.Add("Tunare - The Seventh Hammer", "tunare");
            ShortServer.Add("Xegony - Druzzil Ro", "xegony");
        }

        private void CurrentServerDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CharName = "";
            string ServerName = "";

            if (CurrentServerDropDown.SelectedItem.ToString() != "Select server")
                if (EQDir != "No directory selected")
                {
                    CurrentCharDropDown.Items.Clear();
                    CurrentCharDropDown.Items.Add("Select a character");

                    string[] FileNames = Directory.GetFiles(EQDir);

                    ShortServer.TryGetValue(CurrentServerDropDown.SelectedItem.ToString(), out ServerName);
                    
                    foreach (string FileName in FileNames)
                        if (FileName.ToUpper().Contains(@"\UI_") && FileName.EndsWith("_" + ServerName + ".ini"))
                        {
                            CharName = FileName.Substring(FileName.ToUpper().IndexOf(@"\UI_") + 4);
                            CharName = CharName.Substring(0, CharName.IndexOf("_"));
                            CurrentCharDropDown.Items.Add(CharName);
                        }

                    CurrentCharDropDown.Text = "Select a character";
                }
                else
                    MessageBox.Show("Please select your EverQuest directory and try again", "Select EverQuest directory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (CurrentServerDropDown.SelectedItem.ToString() != "Select server" && NewServerDropDown.SelectedItem.ToString() != "Select server" && CurrentCharDropDown.SelectedItem.ToString() != "Select a character")
                ShowChanges();
            else
                HideChanges();
        }

        private void NewServerDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentServerDropDown.SelectedItem.ToString() == "Select server" && NewServerDropDown.SelectedItem.ToString() != "Select server")
                MessageBox.Show("Please select your server first and try again", "Select current server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (EQDir == "No directory selected" && NewServerDropDown.SelectedItem.ToString() != "Select server")
                MessageBox.Show("Please select your EverQuest directory and try again", "Select EverQuest directory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (CurrentServerDropDown.SelectedItem.ToString() != "Select server" && NewServerDropDown.SelectedItem.ToString() != "Select server" && CurrentCharDropDown.SelectedItem.ToString() != "Select a character")
                ShowChanges();
            else
                HideChanges();
        }

        private void CurrentCharDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentCharDropDown.SelectedItem.ToString() != "Select a character")
                NewCharTextBox.Text = CurrentCharDropDown.SelectedItem.ToString();

            if (CurrentServerDropDown.SelectedItem.ToString() != "Select server" && NewServerDropDown.SelectedItem.ToString() != "Select server" && CurrentCharDropDown.SelectedItem.ToString() != "Select a character")
                ShowChanges();
            else
                HideChanges();
        }

        private void NewCharTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CurrentServerDropDown.SelectedItem.ToString() != "Select server" && NewServerDropDown.SelectedItem.ToString() != "Select server" && CurrentCharDropDown.SelectedItem.ToString() != "Select a character")
                ShowChanges();
            else
                HideChanges();
        }

        void ShowChanges()
        {
            string FromServer = "";
            string ToServer = "";
            string FromCharacter = CurrentCharDropDown.Text;
            string ToCharacter = NewCharTextBox.Text;

            WarningLabel.Text = "";
            ConfirmationButton.Enabled = true;

            ShortServer.TryGetValue(CurrentServerDropDown.SelectedItem.ToString(), out FromServer);
            ShortServer.TryGetValue(NewServerDropDown.SelectedItem.ToString(), out ToServer);

            if (NewServerDropDown.SelectedItem.ToString() == "Staying on same server")
                ToServer = FromServer;

            if ((FromServer == ToServer || ToServer == "Staying on same server") && FromCharacter == ToCharacter)
            {
                WarningLabel.Text = "You have chosen the same server and same character name. Please check your server and character selections.";
                ConfirmationButton.Enabled = false;
            }

            FromUI = "UI_" + FromCharacter + "_" + FromServer + ".ini";
            ToUI = "UI_" + ToCharacter + "_" + ToServer + ".ini";

            if (File.Exists(EQDir + FromUI))
                UILabel.Text = FromUI + "   to   " + ToUI;
            else
            {
                FromUI = "";
                ToUI = "";
                UILabel.Text = "There is no UI file to copy";
            }

            FromSocial = FromCharacter + "_" + FromServer + ".ini";
            ToSocial = ToCharacter + "_" + ToServer + ".ini";

            if (File.Exists(EQDir + FromSocial))
                SocialsLabel.Text = FromSocial + "   to   " + ToSocial;
            else
            {
                FromSocial = "";
                ToSocial = "";
                SocialsLabel.Text = "There is no socials file to copy";
            }

            FromAudio = "AT_default_" + FromCharacter + "_" + FromServer + ".ini";
            ToAudio = "AT_default_" + ToCharacter + "_" + ToServer + ".ini";

            if (File.Exists(EQDir + "userdata\\" + FromAudio))
                AudioLabel.Text = FromAudio + "   to   " + ToAudio;
            else
            {
                FromAudio = "";
                ToAudio = "";
                AudioLabel.Text = "There is no audio triggers file to copy";
            }

            FromAbilities = "Abilities_" + FromCharacter + "_" + FromServer + ".ini";
            ToAbilities = "Abilities_" + ToCharacter + "_" + ToServer + ".ini";

            if (File.Exists(EQDir + "userdata\\" + FromAbilities))
                CombatLabel.Text = FromAbilities + "   to   " + ToAbilities;
            else
            {
                FromAbilities = "";
                ToAbilities = "";
                CombatLabel.Text = "There is no combat abilities file to copy";
            }

            FromBazaar = "BZR_" + FromCharacter + "_" + FromServer + ".ini";
            ToBazaar = "BZR_" + ToCharacter + "_" + ToServer + ".ini";

            if (File.Exists(EQDir + FromBazaar))
                BazaarLabel.Text = FromBazaar + "   to   " + ToBazaar;
            else
            {
                FromBazaar = "";
                ToBazaar = "";
                BazaarLabel.Text = "There is no bazaar file to copy";
            }

            FromBarter = "BART_" + FromCharacter + "_" + FromServer + ".ini";
            ToBarter = "BART_" + ToCharacter + "_" + ToServer + ".ini";

            if (File.Exists(EQDir + "userdata\\" + FromBarter))
                BarterLabel.Text = FromBarter + "   to   " + ToBarter;
            else
            {
                FromBarter = "";
                ToBarter = "";
                BarterLabel.Text = "There is no barter file to copy";
            }

            FromGN = "GN_" + FromCharacter + "_" + FromServer + ".txt";
            ToGN = "GN_" + ToCharacter + "_" + ToServer + ".txt";

            if (File.Exists(EQDir + "userdata\\" + FromGN))
                GNLabel.Text = FromGN + "   to   " + ToGN;
            else
            {
                FromGN = "";
                ToGN = "";
                GNLabel.Text = "There is no guild notes file to copy";
            }
        }

        void HideChanges()
        {
            WarningLabel.Text = "";
            ConfirmationButton.Enabled = false;

            FromUI = "";
            ToUI = "";
            UILabel.Text = "";

            FromSocial = "";
            ToSocial = "";
            SocialsLabel.Text = "";

            FromAudio = "";
            ToAudio = "";
            AudioLabel.Text = "";

            FromAbilities = "";
            ToAbilities = "";
            CombatLabel.Text = "";

            FromBazaar = "";
            ToBazaar = "";
            BazaarLabel.Text = "";

            FromBarter = "";
            ToBarter = "";
            BarterLabel.Text = "";

            FromGN = "";
            ToGN = "";
            GNLabel.Text = "";
        }

        bool ConfirmCopy(string Path, string FromFile, string ToFile, string FileType, string BackupPath)
        {
            bool Confirmed = true;
            string message = "";
            string caption = "";
            long FromSize = 0;
            long ToSize = 0;
            FileStream Stream;

            if (File.Exists(Path + FromFile))
            {
                if (File.Exists(Path + ToFile))
                {
                    Stream = new FileStream(Path + FromFile, FileMode.Open);
                    FromSize = Stream.Length;
                    Stream.Close();

                    Stream = new FileStream(Path + ToFile, FileMode.Open);
                    ToSize = Stream.Length;
                    Stream.Close();

                    caption = "The destination " + FileType + " file already exists";
                    message = "Do you wish to copy \"" + FromFile + "\" over the existing file \"" + ToFile + "\"?\n\n";
                    message += "Source file: \n   " + FromSize + " bytes,  " + File.GetLastWriteTime(Path + FromFile) + "\n\n";
                    message += "Destination file: \n  " + ToSize + " bytes,  " + File.GetLastWriteTime(Path + ToFile) + "\n\n";
                    message += "The overwritten file will be backed up to: \n   " + BackupPath;

                    var Result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Result == DialogResult.OK)
                    {
                        File.Copy(Path + ToFile, BackupPath + ToFile, true);
                        File.Copy(Path + FromFile, Path + ToFile, true);
                    }
                    else
                        Confirmed = false;
                }
                else
                    File.Copy(Path + FromFile, Path + ToFile, true);
            }

            return Confirmed;
        }

        private void ConfirmationButton_Click(object sender, EventArgs e)
        {
            string message = "";
            string caption = "";

            try
            {
                if (!Directory.Exists(EQDir + "BackupSettings"))
                    Directory.CreateDirectory(EQDir + "BackupSettings");

                if (ConfirmCopy(EQDir, FromUI, ToUI, "UI", EQDir + "BackupSettings\\"))
                    message += "\n   UI:  " + ToUI;

                if (ConfirmCopy(EQDir, FromSocial, ToSocial, "socials", EQDir + "BackupSettings\\"))
                    message += "\n   Socials:  " + ToSocial;

                if (ConfirmCopy(EQDir + "userdata\\", FromAudio, ToAudio, "audio triggers", EQDir + "BackupSettings\\"))
                    message += "\n   Audio triggers:  " + ToAudio;

                if (ConfirmCopy(EQDir + "userdata\\", FromAbilities, ToAbilities, "combat abilities", EQDir + "BackupSettings\\"))
                    message += "\n   Combat abilities:  " + ToAbilities;

                if (ConfirmCopy(EQDir, FromBazaar, ToBazaar, "bazaar", EQDir + "BackupSettings\\"))
                    message += "\n   Bazaar prices:  " + ToBazaar;

                if (ConfirmCopy(EQDir + "userdata\\", FromBarter, ToBarter, "barter", EQDir + "BackupSettings\\"))
                    message += "\n   Barter prices:  " + ToBarter;

                if (ConfirmCopy(EQDir + "userdata\\", FromGN, ToGN, "guild notes", EQDir + "BackupSettings\\"))
                    message += "\n   Guild notes:  " + ToGN;

                if (message != "")
                {
                    caption = "Copy completed!";
                    message = NewCharTextBox.Text + " is now ready to use on them " + NewServerDropDown.SelectedItem.ToString() + " server!\n\nThe following files were copied:" + message;
                    ConfirmationButton.Enabled = false;
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    caption = "Nothing Copied!";
                    message = "You have declined all copies. No changes have been made!";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("GamSettingsMover cannot copy the files. This is likely due to insufficient access. To resolve this issue, you will need to run the program in administrator mode.\n\nClose the program and then start it again by right clicking on the program and selecting \"Run as administrator\"", "Cannot copy files", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        void SelectEQFolder()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (Directory.Exists(@"C:\Program files (x86)\Sony\EverQuest"))
                openFileDialog1.InitialDirectory = @"c:\Program files (x86)\Sony\EverQuest";
            else if (Directory.Exists(@"C:\Program files\Sony\EverQuest"))
                openFileDialog1.InitialDirectory = @"c:\Program files\Sony\EverQuest";
            if (Directory.Exists(@"C:\Program files (x86)\Sony\EverQuest Trilogy"))
                openFileDialog1.InitialDirectory = @"c:\Program files (x86)\Sony\EverQuest Trilogy";
            else if (Directory.Exists(@"C:\Program files\Sony\EverQuest Trilogy"))
                openFileDialog1.InitialDirectory = @"c:\Program files\Sony\EverQuest Trilogy";
            else if (Directory.Exists(@"C:\Program files (x86)\EverQuest"))
                openFileDialog1.InitialDirectory = @"c:\Program files (x86)\EverQuest";
            else if (Directory.Exists(@"C:\Program files\EverQuest"))
                openFileDialog1.InitialDirectory = @"c:\Program files\EverQuest";
            else if (Directory.Exists(@"C:\EQ\EverQuest C"))
                openFileDialog1.InitialDirectory = @"C:\EQ\EverQuest C";
            else if (Directory.Exists(@"C:\Program files (x86)\Sony"))
                openFileDialog1.InitialDirectory = @"c:\Program files (x86)\Sony";
            else if (Directory.Exists(@"C:\Program files\Sony"))
                openFileDialog1.InitialDirectory = @"c:\Program files\Sony";
            else if (Directory.Exists(@"C:\Program files (x86)"))
                openFileDialog1.InitialDirectory = @"c:\Program files (x86)";
            else if (Directory.Exists(@"C:\Program files"))
                openFileDialog1.InitialDirectory = @"c:\Program files";

            openFileDialog1.Filter = "EverQuest|EQGame.exe";
            openFileDialog1.Title = "Select EQGame.exe";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string EQFile = openFileDialog1.FileName;
                int Counter = 0;

                foreach (char c in EQFile)
                {
                    Counter++;
                    if (c == '\\')
                        EQDir = EQFile.Substring(0, Counter);
                }

                EQDirLabel.Text = EQDir;
            }
        }

        private void selectEQFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectEQFolder();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            SelectEQFolder();
        }

        private void gettingStartedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://GamboSoft.com/Pages/GamSettingsMover_GettingStarted.htm");
        }

        private void supportForumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://GamboSoft.com/forum/");
        }

        private void aboutGamSettingsMoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About AboutBox = new About("GamSettingsMover");
            AboutBox.Show();
        }

    }
}
