using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Skin_Swapper__Sorry_.BackBlings
{
    public partial class Purple_Wings : MetroForm
    {
        public Purple_Wings()
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

        private static byte[] cupid1 = new byte[135]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 077, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 077, 095, 077, 101, 100, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 067, 117, 112, 105, 100, 047, 083, 107, 105, 110, 115, 047, 073, 099, 101, 047, 077, 097, 116, 101, 114, 105, 097, 108, 115, 047, 077, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 067, 117, 112, 105, 100, 095, 087, 105, 110, 103, 115, 046, 077, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 067, 117, 112, 105, 100, 095, 087, 105, 110, 103, 115
        };

        private static byte[] cupid2 = new byte[135]
        {
            047, 071, 097, 109, 101, 047, 071, 097, 100, 103, 101, 116, 115, 047, 065, 115, 115, 101, 116, 115, 047, 086, 105, 110, 100, 101, 114, 084, 101, 099, 104, 095, 071, 108, 105, 100, 101, 114, 067, 104, 117, 116, 101, 047, 077, 097, 116, 101, 114, 105, 097, 108, 115, 047, 077, 073, 095, 086, 105, 110, 100, 101, 114, 084, 101, 099, 104, 095, 071, 108, 105, 100, 101, 114, 067, 104, 117, 116, 101, 095, 067, 101, 108, 101, 115, 116, 105, 097, 108, 046, 077, 073, 095, 086, 105, 110, 100, 101, 114, 084, 101, 099, 104, 095, 071, 108, 105, 100, 101, 114, 067, 104, 117, 116, 101, 095, 067, 101, 108, 101, 115, 116, 105, 097, 108, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        private static void ReplaceByte5()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 115235868L, cupid1);
        }

        private static void RevertByte6()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 115235868L, cupid2);
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            if (checkPak())
            {
                metroTextBox1.Text = "[LOG] " + "BackBling Added Successfully";

                string path = Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak";
                if (File.Exists(path))
                {
                    RevertByte6();
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

        private void MetroButton4_Click(object sender, EventArgs e)
        {
            if (checkPak())
            {
                metroTextBox1.Text = "[LOG] " + "BackBling Reverted Successfully";

                string path = Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak";
                if (File.Exists(path))
                {
                    ReplaceByte5();
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
