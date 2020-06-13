using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GamSettingsMover
{
    public partial class About : Form
    {
        public About(string Version)
        {
            InitializeComponent();
            TitleLabel.Text = Version;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://gambosoft.eqresource.com/gamsettingsmover.php");
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
