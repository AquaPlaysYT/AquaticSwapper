using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;

namespace Skin_Swapper__Sorry_.Weapons
{
    public partial class Neon_Rifle : MetroForm
    {
        public Neon_Rifle()
        {
            InitializeComponent();
        }

        bool checkPak()
        {
            if (Properties.Settings.Default.pakFiles == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void ReplaceBytes(string pak, long offset, byte[] bytes)
        {
            BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(pak, FileMode.Open, FileAccess.ReadWrite));
            binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
            binaryWriter.Write(bytes);
            binaryWriter.Close();
        }

        private static byte[] shred1 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 087, 101, 097, 112, 111, 110, 115, 047, 070, 079, 082, 084, 095, 083, 104, 111, 116, 103, 117, 110, 115, 047, 077, 101, 115, 104, 047, 083, 075, 095, 084, 097, 099, 116, 105, 099, 097, 108, 095, 083, 104, 111, 116, 103, 117, 110, 095, 048, 050, 046, 083, 075, 095, 084, 097, 099, 116, 105, 099, 097, 108, 095, 083, 104, 111, 116, 103, 117, 110, 095, 048, 050
        };

        private static byte[] shred2 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 087, 101, 097, 112, 111, 110, 115, 047, 070, 079, 082, 084, 095, 082, 105, 102, 108, 101, 115, 047, 077, 101, 115, 104, 047, 083, 075, 095, 078, 101, 111, 110, 095, 071, 108, 111, 119, 095, 065, 115, 115, 097, 117, 108, 116, 046, 083, 075, 095, 078, 101, 111, 110, 095, 071, 108, 111, 119, 095, 065, 115, 115, 097, 117, 108, 116, 000, 000, 000, 000, 000, 000
        };

        private static void ReplaceByteshred()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 133175799L, shred1);
        }

        private static void RevertByteshred()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 133175799L, shred2);
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (checkPak())
            {
                metroTextBox1.Text = "[LOG] " + "Gun Added Successfully";

                string path = Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak";
                if (File.Exists(path))
                {
                    RevertByteshred();
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Please Select your pak folder in settings!");
            }
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            if (checkPak())
            {
                metroTextBox1.Text = "[LOG] " + "Gun Reverted Successfully";

                string path = Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak";
                if (File.Exists(path))
                {
                    ReplaceByteshred();
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Please Select your pak folder in settings!");
            }
        }
    }
}
