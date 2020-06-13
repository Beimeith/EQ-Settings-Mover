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
        string EQSourceDir = "No directory selected";
        string EQDestinationDir = "No directory selected";

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

            B_Copy_Settings.Enabled = false;

            DD_Current_Server.Sorted = true;
            DD_Current_Server.Sorted = false;
            DD_Current_Server.Items.Insert(0, "Select server");
            DD_Current_Server.SelectedIndex = 0;
            DD_New_Server.Text = "Select server";



            // Set short server names
            ShortServer.Add("Aradune", "aradune");
            ShortServer.Add("Mangler", "mangler");
            ShortServer.Add("Selo", "selo");
            ShortServer.Add("Miragul", "miragul");
            ShortServer.Add("Rizlona", "rizlona");
            ShortServer.Add("Vox", "vox");
            ShortServer.Add("Agnarr", "agnarr");
            ShortServer.Add("Coirnav", "coirnav");
            ShortServer.Add("Lockjaw", "lockjaw");
            ShortServer.Add("Phinigel", "phinigel");
            ShortServer.Add("Quarm", "quarm");
            ShortServer.Add("Ragefire", "ragefire");

            ShortServer.Add("Antonius Bayle", "antonius");
            ShortServer.Add("Bertoxxulous", "bertox");
            ShortServer.Add("Brekt", "brekt");
            ShortServer.Add("Bristlebane", "bristle");
            ShortServer.Add("Cazic Thule", "cazic");
            ShortServer.Add("Drinal", "drinal");
            ShortServer.Add("Druzzil Ro", "druzzil");
            ShortServer.Add("Erollisi Marr", "erollisi");
            ShortServer.Add("Fennin Ro", "fenninro");
            ShortServer.Add("Fippy Darkpaw", "fippy");
            ShortServer.Add("Firona Vie", "firiona");
            ShortServer.Add("Luclin", "luclin");
            ShortServer.Add("Maelin Starpyre", "maelin");
            ShortServer.Add("Mayong", "mayong");
            ShortServer.Add("Povar", "povar");
            ShortServer.Add("Prexus", "prexus");
            ShortServer.Add("Quellious", "quellious");
            ShortServer.Add("Saryrn", "saryrn");
            ShortServer.Add("Stromm", "stromm");
            ShortServer.Add("The Nameless", "nameless");
            ShortServer.Add("The Rathe", "rathe");
            ShortServer.Add("The Seventh Hammer", "seventh");
            ShortServer.Add("The Tribunal", "tribunal");
            ShortServer.Add("Tunare", "tunare");
            ShortServer.Add("Vulek'Aerr", "vulek");
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



        private void DD_Current_Server_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CharName = "";
            string ServerName = "";

            if (DD_Current_Server.SelectedItem.ToString() != "Select server")
                if (EQSourceDir != "No directory selected")
                {
                    DD_Current_Name.Items.Clear();
                    DD_Current_Name.Items.Add("Select a character");

                    string[] FileNames = Directory.GetFiles(EQSourceDir);

                    ShortServer.TryGetValue(DD_Current_Server.SelectedItem.ToString(), out ServerName);

                    foreach (string FileName in FileNames)
                        if (FileName.ToUpper().Contains(@"\UI_") && FileName.EndsWith("_" + ServerName + ".ini"))
                        {
                            CharName = FileName.Substring(FileName.ToUpper().IndexOf(@"\UI_") + 4);
                            CharName = CharName.Substring(0, CharName.IndexOf("_"));
                            DD_Current_Name.Items.Add(CharName);
                        }

                    DD_Current_Name.Text = "Select a character";
                }
                else
                    MessageBox.Show("Please select your EverQuest directory and try again", "Select EverQuest directory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (DD_Current_Server.SelectedItem.ToString() != "Select server" && DD_New_Server.SelectedItem.ToString() != "Select server" && DD_Current_Name.SelectedItem.ToString() != "Select a character")
                ShowChanges();
            else
                HideChanges();
        }

        private void DD_New_Server_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DD_Current_Server.SelectedItem.ToString() == "Select server" && DD_New_Server.SelectedItem.ToString() != "Select server")
                MessageBox.Show("Please select your server first and try again", "Select current server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (EQSourceDir == "No directory selected" && DD_New_Server.SelectedItem.ToString() != "Select server")
                MessageBox.Show("Please select your EverQuest directory and try again", "Select EverQuest directory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (DD_Current_Server.SelectedItem.ToString() != "Select server" && DD_New_Server.SelectedItem.ToString() != "Select server" && DD_Current_Name.SelectedItem.ToString() != "Select a character")
                ShowChanges();
            else
                HideChanges();
        }

        private void DD_Current_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DD_Current_Name.SelectedItem.ToString() != "Select a character")
                TB_New_Name.Text = DD_Current_Name.SelectedItem.ToString();

            if (DD_Current_Server.SelectedItem.ToString() != "Select server" && DD_New_Server.SelectedItem.ToString() != "Select server" && DD_Current_Name.SelectedItem.ToString() != "Select a character")
                ShowChanges();
            else
                HideChanges();
        }

        private void TB_New_Name_TextChanged(object sender, EventArgs e)
        {
            if (DD_Current_Server.SelectedItem.ToString() != "Select server" && DD_New_Server.SelectedItem.ToString() != "Select server" && DD_Current_Name.SelectedItem.ToString() != "Select a character")
                ShowChanges();
            else
                HideChanges();
        }

        void ShowChanges()
        {
            string FromServer = "";
            string ToServer = "";
            string FromCharacter = DD_Current_Name.Text;
            string ToCharacter = TB_New_Name.Text;

            L_Warning.Text = "";
            B_Copy_Settings.Enabled = true;

            ShortServer.TryGetValue(DD_Current_Server.SelectedItem.ToString(), out FromServer);
            ShortServer.TryGetValue(DD_New_Server.SelectedItem.ToString(), out ToServer);

            if (DD_New_Server.SelectedItem.ToString() == "Staying on same server")
                ToServer = FromServer;

            if ((FromServer == ToServer || ToServer == "Staying on same server") && FromCharacter == ToCharacter)
            {
                L_Warning.Text = "You have chosen the same server and same character name. Please check your server and character selections.";
                B_Copy_Settings.Enabled = false;
            }

            FromUI = "UI_" + FromCharacter + "_" + FromServer + ".ini";
            ToUI = "UI_" + ToCharacter + "_" + ToServer + ".ini";

            if (File.Exists(EQSourceDir + FromUI))
                UILabel.Text = FromUI + "   to   " + ToUI;
            else
            {
                FromUI = "";
                ToUI = "";
                UILabel.Text = "There is no UI file to copy";
            }

            FromSocial = FromCharacter + "_" + FromServer + ".ini";
            ToSocial = ToCharacter + "_" + ToServer + ".ini";

            if (File.Exists(EQSourceDir + FromSocial))
                SocialsLabel.Text = FromSocial + "   to   " + ToSocial;
            else
            {
                FromSocial = "";
                ToSocial = "";
                SocialsLabel.Text = "There is no socials file to copy";
            }

            FromAudio = "AT_default_" + FromCharacter + "_" + FromServer + ".ini";
            ToAudio = "AT_default_" + ToCharacter + "_" + ToServer + ".ini";

            if (File.Exists(EQSourceDir + "userdata\\" + FromAudio))
                AudioLabel.Text = FromAudio + "   to   " + ToAudio;
            else
            {
                FromAudio = "";
                ToAudio = "";
                AudioLabel.Text = "There is no audio triggers file to copy";
            }

            FromAbilities = "Abilities_" + FromCharacter + "_" + FromServer + ".ini";
            ToAbilities = "Abilities_" + ToCharacter + "_" + ToServer + ".ini";

            if (File.Exists(EQSourceDir + "userdata\\" + FromAbilities))
                CombatLabel.Text = FromAbilities + "   to   " + ToAbilities;
            else
            {
                FromAbilities = "";
                ToAbilities = "";
                CombatLabel.Text = "There is no combat abilities file to copy";
            }

            FromBazaar = "BZR_" + FromCharacter + "_" + FromServer + ".ini";
            ToBazaar = "BZR_" + ToCharacter + "_" + ToServer + ".ini";

            if (File.Exists(EQSourceDir + FromBazaar))
                BazaarLabel.Text = FromBazaar + "   to   " + ToBazaar;
            else
            {
                FromBazaar = "";
                ToBazaar = "";
                BazaarLabel.Text = "There is no bazaar file to copy";
            }

            FromBarter = "BART_" + FromCharacter + "_" + FromServer + ".ini";
            ToBarter = "BART_" + ToCharacter + "_" + ToServer + ".ini";

            if (File.Exists(EQSourceDir + "userdata\\" + FromBarter))
                BarterLabel.Text = FromBarter + "   to   " + ToBarter;
            else
            {
                FromBarter = "";
                ToBarter = "";
                BarterLabel.Text = "There is no barter file to copy";
            }

            FromGN = "GN_" + FromCharacter + "_" + FromServer + ".txt";
            ToGN = "GN_" + ToCharacter + "_" + ToServer + ".txt";

            if (File.Exists(EQSourceDir + "userdata\\" + FromGN))
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
            L_Warning.Text = "";
            B_Copy_Settings.Enabled = false;

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

        bool ConfirmCopy(string Source, string Destination, string FromFile, string ToFile, string FileType)
        {
            bool Confirmed = true;
            string message = "";
            string caption = "";
            long FromSize = 0;
            long ToSize = 0;
            FileStream Stream;

            //Check if the Source File we're trying to copy exists
            if (File.Exists(Source + FromFile))
            {
                //Check if the Destination File already exists
                if (File.Exists(Destination + ToFile))
                {
                    //If they both exist, get the filesizes for both and
                    Stream = new FileStream(Source + FromFile, FileMode.Open);
                    FromSize = Stream.Length;
                    Stream.Close();

                    Stream = new FileStream(Destination + ToFile, FileMode.Open);
                    ToSize = Stream.Length;
                    Stream.Close();

                    //Inform the user they need to overwrite the current file in that location with the new copy
                    caption = "The destination " + FileType + " file already exists";
                    message = "Do you wish to copy \"" + FromFile + "\" over the existing file \"" + ToFile + "\"?\n\n";
                    message += "Source file: \n   " + FromSize + " bytes,  " + File.GetLastWriteTime(Source + FromFile) + "\n\n";
                    message += "Destination file: \n  " + ToSize + " bytes,  " + File.GetLastWriteTime(Destination + ToFile) + "\n\n";
                    message += "The overwritten file will be backed up to: \n   " + Destination + "BackupSettings\\";

                    //Promt the user for confirmation
                    var Result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    //If they agree
                    if (Result == DialogResult.OK)
                    {
                        //Check if there is a BackupSettings directory in place and if not, create one.
                        if (!Directory.Exists(EQDestinationDir + "BackupSettings"))
                            Directory.CreateDirectory(EQDestinationDir + "BackupSettings");

                        //Copy the existing file at the Destination location into the BackupSettings directory
                        File.Copy(Destination + ToFile, Destination + "BackupSettings\\" + ToFile, true);
                        //Copy the new file from the Source to the Destination.
                        File.Copy(Source + FromFile, Destination + ToFile, true);
                    }
                    else //if they don't agree, don't copy.
                        Confirmed = false;
                }
                else //if the Destination file doesn't already exist, just copy the file.
                    File.Copy(Source + FromFile, Destination + ToFile, true);
            }
            return Confirmed;
        }

        private void B_Copy_Settings_Click(object sender, EventArgs e)
        {
            string message = "";
            string caption = "";

            //If the user doesn't specify a separate Destination directory, default back to the Source directory
            if (EQDestinationDir == null || EQDestinationDir == "" || EQDestinationDir == "No directory selected")
                EQDestinationDir = EQSourceDir;

            try
            {
                if (ConfirmCopy(EQSourceDir, EQDestinationDir, FromUI, ToUI, "UI"))
                    message += "\n   UI:  " + ToUI;

                if (ConfirmCopy(EQSourceDir, EQDestinationDir, FromSocial, ToSocial, "socials"))
                    message += "\n   Socials:  " + ToSocial;

                if (ConfirmCopy(EQSourceDir + "userdata\\", EQDestinationDir + "userdata\\", FromAudio, ToAudio, "audio triggers"))
                    message += "\n   Audio triggers:  " + ToAudio;

                if (ConfirmCopy(EQSourceDir + "userdata\\", EQDestinationDir + "userdata\\", FromAbilities, ToAbilities, "combat abilities"))
                    message += "\n   Combat abilities:  " + ToAbilities;

                if (ConfirmCopy(EQSourceDir, EQDestinationDir, FromBazaar, ToBazaar, "bazaar"))
                    message += "\n   Bazaar prices:  " + ToBazaar;

                if (ConfirmCopy(EQSourceDir + "userdata\\", EQDestinationDir + "userdata\\", FromBarter, ToBarter, "barter"))
                    message += "\n   Barter prices:  " + ToBarter;

                if (ConfirmCopy(EQSourceDir + "userdata\\", EQDestinationDir + "userdata\\", FromGN, ToGN, "guild notes"))
                    message += "\n   Guild notes:  " + ToGN;

                if (message != "")
                {
                    caption = "Copy completed!";
                    message = TB_New_Name.Text + " is now ready to use on them " + DD_New_Server.SelectedItem.ToString() + " server!\n\nThe following files were copied:" + message;
                    B_Copy_Settings.Enabled = false;
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    caption = "Nothing Copied!";
                    message = "You have declined all copies. No changes have been made!";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception )
            {
                MessageBox.Show("GamSettingsMover cannot copy the files. This is likely due to insufficient access. To resolve this issue, you will need to run the program in administrator mode.\n\nClose the program and then start it again by right clicking on the program and selecting \"Run as administrator\"", "Cannot copy files", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        void SelectEQFolder(int directory)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (Directory.Exists(@"C:\Users\Public\Daybreak Game Company\Installed Games\EverQuest"))
                openFileDialog1.InitialDirectory = @"c:\Users\Public\Daybreak Game Company\Installed Games\EverQuest";
            else if (Directory.Exists(@"C:\Program files (x86)\Sony\EverQuest"))
                openFileDialog1.InitialDirectory = @"c:\Program files (x86)\Sony\EverQuest";
            else if (Directory.Exists(@"C:\Program Files (x86)\Steam\SteamApps\common\Everquest F2P"))
                openFileDialog1.InitialDirectory = @"C:\Program Files(x86)\Steam\SteamApps\common\Everquest F2P";
            else if (Directory.Exists(@"C:\Program Files\Steam\SteamApps\common\Everquest F2P"))
                openFileDialog1.InitialDirectory = @"C:\Program Files\Steam\SteamApps\common\Everquest F2P";
            else if (Directory.Exists(@"C:\Program files\Sony\EverQuest"))
                openFileDialog1.InitialDirectory = @"c:\Program files\Sony\EverQuest";
            else if (Directory.Exists(@"C:\Program files (x86)\Sony\EverQuest Titanium"))
                openFileDialog1.InitialDirectory = @"c:\Program files (x86)\Sony\EverQuest Titanium";
            else if (Directory.Exists(@"C:\Program files\Sony\EverQuest Titanium"))
                openFileDialog1.InitialDirectory = @"c:\Program files\Sony\EverQuest Titanium";
            else if (Directory.Exists(@"C:\Program files (x86)\Sony\EverQuest Trilogy"))
                openFileDialog1.InitialDirectory = @"c:\Program files (x86)\Sony\EverQuest Trilogy";
            else if (Directory.Exists(@"C:\Program files\Sony\EverQuest Trilogy"))
                openFileDialog1.InitialDirectory = @"c:\Program files\Sony\EverQuest Trilogy";
            else if (Directory.Exists(@"C:\Program files (x86)\EverQuest"))
                openFileDialog1.InitialDirectory = @"c:\Program files (x86)\EverQuest";
            else if (Directory.Exists(@"C:\Program files\EverQuest"))
                openFileDialog1.InitialDirectory = @"c:\Program files\EverQuest";
            else if (Directory.Exists(@"C:\EverQuest"))
                openFileDialog1.InitialDirectory = @"c:\EverQuest";
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
                    {
                        if (directory == 1)
                            EQSourceDir = EQFile.Substring(0, Counter);
                        else if (directory == 2)
                            EQDestinationDir = EQFile.Substring(0, Counter);
                    }
                }

                if (directory == 1)
                    L_EQ_Directory_Path.Text = EQSourceDir;
                else if (directory == 2)
                    L_EQ_Destination_Directory_Path.Text = EQDestinationDir;
            }
        }

        private void selectEQFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectEQFolder(1);
        }

        private void gettingStartedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://gambosoft.eqresource.com/gamsettingsmovergettingstarted.php");
        }

        private void supportForumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://eqresource.com/board/index.php#c7");
        }

        private void aboutGamSettingsMoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About AboutBox = new About("GamSettingsMover v1.5.0.1");
            AboutBox.Show();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            SelectEQFolder(1);
        }

        private void selectNewEQFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectEQFolder(2);
        }
    }
}
