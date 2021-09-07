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
    public partial class DreamFeet : MetroForm
    {
        public DreamFeet()
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

        private static byte[] cmf1 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 065, 110, 105, 109, 097, 116, 105, 111, 110, 047, 071, 097, 109, 101, 047, 077, 097, 105, 110, 080, 108, 097, 121, 101, 114, 047, 069, 109, 111, 116, 101, 115, 047, 082, 101, 103, 097, 108, 095, 087, 097, 118, 101, 047, 069, 109, 111, 116, 101, 095, 082, 101, 103, 097, 108, 095, 087, 097, 118, 101, 095, 067, 077, 070, 095, 077, 046, 069, 109, 111, 116, 101, 095, 082, 101, 103, 097, 108, 095, 087, 097, 118, 101, 095, 067, 077, 070, 095, 077
        };

        private static byte[] cmf2 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 065, 110, 105, 109, 097, 116, 105, 111, 110, 047, 071, 097, 109, 101, 047, 077, 097, 105, 110, 080, 108, 097, 121, 101, 114, 047, 069, 109, 111, 116, 101, 115, 047, 068, 114, 101, 097, 109, 070, 101, 101, 116, 047, 069, 109, 111, 116, 101, 095, 068, 114, 101, 097, 109, 070, 101, 101, 116, 095, 067, 077, 070, 095, 077, 046, 069, 109, 111, 116, 101, 095, 068, 114, 101, 097, 109, 070, 101, 101, 116, 095, 067, 077, 070, 095, 077, 000, 000, 000
        };

        private static byte[] cmm1 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 065, 110, 105, 109, 097, 116, 105, 111, 110, 047, 071, 097, 109, 101, 047, 077, 097, 105, 110, 080, 108, 097, 121, 101, 114, 047, 069, 109, 111, 116, 101, 115, 047, 082, 101, 103, 097, 108, 095, 087, 097, 118, 101, 047, 069, 109, 111, 116, 101, 095, 082, 101, 103, 097, 108, 095, 087, 097, 118, 101, 095, 067, 077, 077, 095, 077, 046, 069, 109, 111, 116, 101, 095, 082, 101, 103, 097, 108, 095, 087, 097, 118, 101, 095, 067, 077, 077, 095, 077,
        };

        private static byte[] cmm2 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 065, 110, 105, 109, 097, 116, 105, 111, 110, 047, 071, 097, 109, 101, 047, 077, 097, 105, 110, 080, 108, 097, 121, 101, 114, 047, 069, 109, 111, 116, 101, 115, 047, 068, 114, 101, 097, 109, 070, 101, 101, 116, 047, 069, 109, 111, 116, 101, 095, 068, 114, 101, 097, 109, 070, 101, 101, 116, 095, 067, 077, 077, 095, 077, 046, 069, 109, 111, 116, 101, 095, 068, 114, 101, 097, 109, 070, 101, 101, 116, 095, 067, 077, 077, 095, 077, 000, 000, 000, 
        };

        private static void ReplaceByte3()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 98371918L, cmf1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 98372103L, cmm1);
        }

        private static void RevertByte4()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 98371918L, cmf2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 98372103L, cmm2);
        }

        private void MetroButton1_Click(object sender, EventArgs e)
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

        private void MetroButton2_Click(object sender, EventArgs e)
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
