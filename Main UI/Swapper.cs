using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using Skin_Swapper__Sorry_.Skin_Forms;
using Skin_Swapper__Sorry_.Music;
using Skin_Swapper__Sorry_.BackBlings;
using Skin_Swapper__Sorry_.Emotes;
using Skin_Swapper__Sorry_.Wraps;

namespace Skin_Swapper__Sorry_
{
    public partial class Swapper : Form
    {
        public Swapper()
        {
            InitializeComponent();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            
            PakFilestxt.Text = "Please put right Pak File before Swap";
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Ghoul_trooper Skin1 = new Ghoul_trooper();
            Skin1.Show();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC2pXSfyN3aBHxljs7K5MqLw");
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discordapp.com/invite/Vfwsft7");
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void MetroButton4_Click(object sender, EventArgs e)
        {
         
        }

        private void MetroLabel18_Click(object sender, EventArgs e)
        {

        }

        private void MetroTabPage7_Click(object sender, EventArgs e)
        {

        }

        private void MetroTabPage4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Ren Skin2 = new Ren();
            Skin2.Show();
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            Recon Skin3 = new Recon();
            Skin3.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Elf Skin4 = new Elf();
            Skin4.Show();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
             SGT Skin5 = new SGT();
            Skin5.Show();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            Bunny Skin6 = new Bunny();
            Skin6.Show();
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            Ikonik Skin7 = new Ikonik();
            Skin7.Show();
        }

        private void PictureBox32_Click(object sender, EventArgs e)
        {
            Ghoul_trooper Skin1 = new Ghoul_trooper();
            Skin1.Show();
        }

        private void PictureBox33_Click(object sender, EventArgs e)
        {
            Ren Skin2 = new Ren();
            Skin2.Show();
        }

        private void PictureBox34_Click(object sender, EventArgs e)
        {
            Recon Skin3 = new Recon();
            Skin3.Show();
        }

        private void PictureBox32_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Error", "Aquatic Swapper", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Swapper_Load(object sender, EventArgs e)
        {
            Opacity = 100;
            txtUser.Text = "Welcome: " + Program.Username;
            this.metroLabel10.Text = new WebClient().DownloadString("https://pastebin.com/raw/v4Kx6pNL");
            PakFilestxt.Text = Properties.Settings.Default.pakFiles;
            this.txtversion.Text = "Version: " + new WebClient().DownloadString("https://pastebin.com/raw/RwMKGR8R");
        }

        private void MetroTabPage6_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton11_Click_1(object sender, EventArgs e)
        {

        }

        private void MetroCheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void MetroToggle1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void MetroButton12_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void MetroTrackBar1_Scroll_1(object sender, ScrollEventArgs e)
        {

        }

        private void MetroButton12_Click_1(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("EpicGamesLauncher").Length == 0)
            {
                MessageBox.Show("Your Epic Games client is already closed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else//Process is found so run the code in the block body
            {
                try
                {
                    Process[] proc = Process.GetProcessesByName("EpicGamesLauncher");
                    proc[0].Kill();
                    MessageBox.Show("You Closed Epic Games!", "Epic Closed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void MetroButton11_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            txtComputerName.Visible = true;
            string computer = System.Windows.Forms.SystemInformation.ComputerName;
            String user = System.Windows.Forms.SystemInformation.UserName.ToString();

            txtComputerName.Text = computer;
            label3.Text = user;
        }

        public static string Username { get; set; }
        public static string UsernameSkip { get; internal set; }
        public int OpacityValue { get; internal set; }

        private void TopCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (TopCheck.Checked)
            {
                TopMost = true;//Enable TopMost
                Properties.Settings.Default.TopMostSetting = true;//Set TopMostSetting to true
                Properties.Settings.Default.Save();//Save Settings
            }
            else
            {
                TopMost = false;//Disable TopMost
                Properties.Settings.Default.TopMostSetting = false;//Set TopMostSetting to false
                Properties.Settings.Default.Save();//Save Settings
            }
        }

        private void OpacityBar_Scroll(object sender, ScrollEventArgs e)
        {
            Opacity = OpacityBar.Value / (double)50;
            Properties.Settings.Default.OpacityValue = OpacityBar.Value;
            Properties.Settings.Default.Save();
        }

        private void MetroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MetroTabPage4_Click_1(object sender, EventArgs e)
        {

        }

        private void PictureBox26_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discordapp.com/invite/Vfwsft7");
        }

        private void PictureBox27_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC2pXSfyN3aBHxljs7K5MqLw");
        }

        private void MetroButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select your defaul pak files location \n \n The normal location is \n \n C:/Program Files/Epic Games/Fortnite/Fortnite Game/Content/Paks", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FolderBrowserDialog browser = new FolderBrowserDialog();
            string tempPath = "";

            if (browser.ShowDialog() == DialogResult.OK)
            {
                tempPath = browser.SelectedPath;
                PakFilestxt.Text = tempPath;


                Properties.Settings.Default.pakFiles = tempPath;


                Properties.Settings.Default.Save();

            }
        }

        private void PictureBox29_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discordapp.com/invite/Vfwsft7");
        }

        private void PictureBox37_Click(object sender, EventArgs e)
        {
            BreakPoint Skin1 = new BreakPoint();
            Skin1.Show();
        }

        private void FlatClose1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox35_Click(object sender, EventArgs e)
        {
            Dark_Vertex Skin1 = new Dark_Vertex();
            Skin1.Show();
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            Chinese_Def skin1 = new Chinese_Def();
            skin1.Show();
        }

        private void MetroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            GalaxyGirl skin1 = new GalaxyGirl();
            skin1.Show();
        }

        private void PictureBox34_Click_1(object sender, EventArgs e)
        {
            wonder skin1 = new wonder();
            skin1.Show();
        }

        private void PictureBox23_Click(object sender, EventArgs e)
        {
            Ranger skin1 = new Ranger();
            skin1.Show();
        }

        private void PictureBox24_Click(object sender, EventArgs e)
        {
            Trooper skin1 = new Trooper();
            skin1.Show();
        }

        private void PictureBox33_Click_1(object sender, EventArgs e)
        {
            Sarah_Stw skin1 = new Sarah_Stw();
            skin1.Show();
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            SwapAllMusic skin1 = new SwapAllMusic();
            skin1.Show();
        }

        private void PictureBox15_Click(object sender, EventArgs e)
        {
            Captian skin1 = new Captian();
            skin1.Show();
        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {

            Rift skin1 = new Rift();
            skin1.Show();
        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            Black_Knight skin1 = new Black_Knight();
            skin1.Show();
        }

        private void PictureBox34_Click_2(object sender, EventArgs e)
        {
            wonder skin1 = new wonder();
            skin1.Show();
        }

        private void PictureBox14_Click(object sender, EventArgs e)
        {
            Purple_Wings skin1 = new Purple_Wings();
            skin1.Show();
        }

        private void PictureBox16_Click(object sender, EventArgs e)
        {
            Gaze skin1 = new Gaze();
            skin1.Show();
        }

        private void PictureBox17_Click(object sender, EventArgs e)
        {
            Scarlet_BB skin1 = new Scarlet_BB();
            skin1.Show();
        }

        private void PictureBox18_Click(object sender, EventArgs e)
        {
            Galaxy skin1 = new Galaxy();
            skin1.Show();
        }

        private void PictureBox53_Click(object sender, EventArgs e)
        {
            DreamFeet skin1 = new DreamFeet();
            skin1.Show();
        }

        private void PictureBox54_Click(object sender, EventArgs e)
        {
            DiscoFever skin1 = new DiscoFever();
            skin1.Show();
        }

        private void PictureBox55_Click(object sender, EventArgs e)
        {
            Scenario skin1 = new Scenario();
            skin1.Show();
        }

        private void PictureBox25_Click(object sender, EventArgs e)
        {
            Pick_It_UP skin1 = new Pick_It_UP();
            skin1.Show();
        }

        private void PictureBox30_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://paypal.me/AquaPlaysYT");
        }

        private void PictureBox74_Click(object sender, EventArgs e)
        {
            GemStone skin1 = new GemStone();
            skin1.Show();

        }

        private void PictureBox72_Click(object sender, EventArgs e)
        {
            Chrome skin1 = new Chrome();
            skin1.Show();
        }

        private void PictureBox75_Click(object sender, EventArgs e)
        {
            Lava skin1 = new Lava();
            skin1.Show();
        }

        private void PictureBox68_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox31_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disabled", "Aquatic Swapper", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PictureBox35_Click_1(object sender, EventArgs e)
        {
            Archetype skin1 = new Archetype();
            skin1.Show();
        }
    }
}
//Skin (Number) = How many skins it is

