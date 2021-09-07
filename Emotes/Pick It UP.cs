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

namespace Skin_Swapper__Sorry_.Emotes
{
    public partial class Pick_It_UP : MetroForm
    {
        public Pick_It_UP()
        {
            InitializeComponent();
        }

        private void Pick_It_UP_Load(object sender, EventArgs e)
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

        private static byte[] cmf1 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 065, 110, 105, 109, 097, 116, 105, 111, 110, 047, 071, 097, 109, 101, 047, 077, 097, 105, 110, 080, 108, 097, 121, 101, 114, 047, 069, 109, 111, 116, 101, 115, 047, 067, 104, 105, 099, 107, 101, 110, 095, 077, 111, 118, 101, 115, 047, 069, 109, 111, 116, 101, 095, 067, 104, 105, 099, 107, 101, 110, 095, 077, 111, 118, 101, 115, 095, 067, 077, 070, 095, 077, 046, 069, 109, 111, 116, 101, 095, 067, 104, 105, 099, 107, 101, 110, 095, 077, 111, 118, 101, 115, 095, 067, 077, 070, 095, 077
        };

        private static byte[] cmf2 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 065, 110, 105, 109, 097, 116, 105, 111, 110, 047, 071, 097, 109, 101, 047, 077, 097, 105, 110, 080, 108, 097, 121, 101, 114, 047, 069, 109, 111, 116, 101, 115, 047, 082, 117, 110, 110, 105, 110, 103, 109, 097, 110, 086, 051, 047, 069, 109, 111, 116, 101, 095, 082, 117, 110, 110, 105, 110, 103, 077, 097, 110, 118, 051, 095, 067, 077, 070, 095, 077, 046, 069, 109, 111, 116, 101, 095, 082, 117, 110, 110, 105, 110, 103, 077, 097, 110, 118, 051, 095, 067, 077, 070, 095, 077, 000, 000, 000
        };

        private static byte[] cmm1 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 065, 110, 105, 109, 097, 116, 105, 111, 110, 047, 071, 097, 109, 101, 047, 077, 097, 105, 110, 080, 108, 097, 121, 101, 114, 047, 069, 109, 111, 116, 101, 115, 047, 067, 104, 105, 099, 107, 101, 110, 095, 077, 111, 118, 101, 115, 047, 069, 109, 111, 116, 101, 095, 067, 104, 105, 099, 107, 101, 110, 095, 077, 111, 118, 101, 115, 095, 067, 077, 077, 095, 077, 046, 069, 109, 111, 116, 101, 095, 067, 104, 105, 099, 107, 101, 110, 095, 077, 111, 118, 101, 115, 095, 067, 077, 077, 095, 077
        };

        private static byte[] cmm2 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 065, 110, 105, 109, 097, 116, 105, 111, 110, 047, 071, 097, 109, 101, 047, 077, 097, 105, 110, 080, 108, 097, 121, 101, 114, 047, 069, 109, 111, 116, 101, 115, 047, 082, 117, 110, 110, 105, 110, 103, 109, 097, 110, 086, 051, 047, 069, 109, 111, 116, 101, 095, 082, 117, 110, 110, 105, 110, 103, 077, 097, 110, 118, 051, 095, 067, 077, 070, 095, 077, 046, 069, 109, 111, 116, 101, 095, 082, 117, 110, 110, 105, 110, 103, 077, 097, 110, 118, 051, 095, 067, 077, 070, 095, 077, 000, 000, 000
        };

        private static void ReplaceByte3()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 127215953L, cmf1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 127216153L, cmm1);
        }

        private static void RevertByte4()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 127215953L, cmf2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 127216153L, cmm2);
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            if (checkPak())
            {
                txtbunny.Text = "[LOG] " + "Emote Added Successfully";

                string path = Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak";
                if (File.Exists(path))
                {
                    RevertByte4();
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
                txtbunny.Text = "[LOG] " + "Emote Reverted Successfully";

                string path = Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak";
                if (File.Exists(path))
                {
                    ReplaceByte3();
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
