using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;
using System.Diagnostics;
using AutoUpdaterDotNET;

namespace Skin_Swapper__Sorry_
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC2pXSfyN3aBHxljs7K5MqLw");
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/Vfwsft7");
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            bool shown = false;

            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC2pXSfyN3aBHxljs7K5MqLw");

            this.TopMost = true;
            chkPassword.Visible = true;
            metroTextBox1.Text = Properties.Settings.Default.username;
            
            if (!shown)
            {
                MessageBox.Show("Thank you for using Aquatic Swapper this takes time to update, so dropping a sub on youtube would be appreciated, for any help join the discord!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                shown = true;
            }

            AutoUpdater.Mandatory = true;
            AutoUpdater.UpdateMode = Mode.Forced;
            AutoUpdater.ShowRemindLaterButton = false;
            AutoUpdater.ShowSkipButton = false;
            AutoUpdater.Start("http://home.xexstudios.xyz/update.xml");
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {           
            Swapper frm = new Swapper();
            frm.Show();
            this.Hide();
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            Program.Username = metroTextBox1.Text;
            Properties.Settings.Default.username = metroTextBox1.Text;
            Properties.Settings.Default.Save();
        

            Swapper frm = new Swapper();
            frm.Show();
            this.Hide();
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
           // new WebClient().DownloadFile("https://aquaplays.000webhostapp.com/SkinSwapper.exe", "SkinSwapper.exe");
          //  System.Diagnostics.Process.Start("SkinSwapper.exe");       
          //  Environment.Exit(0);
        }

        private void MetroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
           
        }
      

        private void Timer2_Tick(object sender, EventArgs e)
        {         
            
        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton3_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
