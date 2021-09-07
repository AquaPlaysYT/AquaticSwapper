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

namespace Skin_Swapper__Sorry_.BackBlings
{
    public partial class Gaze : MetroForm
    {
        public Gaze()
        {
            InitializeComponent();
        }

        private void Gaze_Load(object sender, EventArgs e)
        {

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

        private static byte[] gazemesh1 = new byte[123]
        {
            047, 071, 097, 109, 101, 047, 065, 099, 099, 101, 115, 115, 111, 114, 105, 101, 115, 047, 070, 079, 082, 084, 095, 066, 097, 099, 107, 112, 097, 099, 107, 115, 047, 077, 095, 077, 069, 068, 095, 086, 105, 103, 105, 108, 097, 110, 116, 101, 066, 111, 097, 114, 100, 095, 066, 097, 099, 107, 112, 097, 099, 107, 047, 077, 101, 115, 104, 101, 115, 047, 077, 095, 077, 069, 068, 095, 086, 105, 103, 105, 108, 097, 110, 116, 101, 095, 066, 111, 097, 114, 100, 095, 080, 097, 099, 107, 046, 077, 095, 077, 069, 068, 095, 086, 105, 103, 105, 108, 097, 110, 116, 101, 095, 066, 111, 097, 114, 100, 095, 080, 097, 099, 107
        };

        private static byte[] gazemesh2 = new byte[123]
        {
            047, 071, 097, 109, 101, 047, 065, 099, 099, 101, 115, 115, 111, 114, 105, 101, 115, 047, 070, 079, 082, 084, 095, 066, 097, 099, 107, 112, 097, 099, 107, 115, 047, 066, 097, 099, 107, 112, 097, 099, 107, 095, 077, 095, 077, 069, 068, 095, 071, 101, 105, 115, 104, 097, 047, 077, 101, 115, 104, 101, 115, 047, 070, 095, 077, 069, 068, 095, 071, 101, 105, 115, 104, 097, 095, 080, 097, 099, 107, 046, 070, 095, 077, 069, 068, 095, 071, 101, 105, 115, 104, 097, 095, 080, 097, 099, 107, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        private static void ReplaceBytegaze()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1552968035L, gazemesh1);
        }

        private static void RevertBytegaze()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1552968035L, gazemesh2);
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (checkPak())
            {
                txtbunny.Text = "[LOG] " + "BackBling Added Successfully";

                string path = Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak";
                if (File.Exists(path))
                {
                    RevertBytegaze();
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

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            if (checkPak())
            {
                txtbunny.Text = "[LOG] " + "BackBling Reverted Successfully";

                string path = Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak";
                if (File.Exists(path))
                {
                    ReplaceBytegaze();
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
