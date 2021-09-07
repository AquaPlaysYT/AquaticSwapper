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
    public partial class Scenario : MetroForm
    {
        public Scenario()
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
            077, 097, 105, 110, 080, 108, 097, 121, 101, 114, 047, 069, 109, 111, 116, 101, 115, 047, 066, 111, 111, 103, 105, 101, 095, 068, 111, 119, 110, 047, 069, 109, 111, 116, 101, 095, 066, 111, 111, 103, 105, 101, 095, 068, 111, 119, 110, 095, 067, 077, 077, 046, 069, 109, 111, 116, 101, 095, 066, 111, 111, 103, 105, 101, 095, 068, 111, 119, 110, 095, 067, 077, 077,
        };

        private static byte[] cmf2 = new byte[]
        {
            077, 097, 105, 110, 080, 108, 097, 121, 101, 114, 047, 069, 109, 111, 116, 101, 115, 047, 075, 080, 111, 112, 095, 068, 097, 110, 099, 101, 048, 051, 047, 069, 109, 111, 116, 101, 095, 075, 080, 079, 080, 095, 068, 097, 110, 099, 101, 048, 051, 095, 077, 046, 069, 109, 111, 116, 101, 095, 075, 080, 079, 080, 095, 068, 097, 110, 099, 101, 048, 051, 095, 077, 000,
        };

        private static byte[] cmm1 = new byte[]
        {
            077, 097, 105, 110, 080, 108, 097, 121, 101, 114, 047, 069, 109, 111, 116, 101, 115, 047, 066, 111, 111, 103, 105, 101, 095, 068, 111, 119, 110, 047, 069, 109, 111, 116, 101, 095, 066, 111, 111, 103, 105, 101, 095, 068, 111, 119, 110, 095, 067, 077, 070, 046, 069, 109, 111, 116, 101, 095, 066, 111, 111, 103, 105, 101, 095, 068, 111, 119, 110, 095, 067, 077, 070,
        };

        private static byte[] cmm2 = new byte[]
        {
            077, 097, 105, 110, 080, 108, 097, 121, 101, 114, 047, 069, 109, 111, 116, 101, 115, 047, 075, 080, 111, 112, 095, 068, 097, 110, 099, 101, 048, 051, 047, 069, 109, 111, 116, 101, 095, 075, 080, 079, 080, 095, 068, 097, 110, 099, 101, 048, 051, 095, 077, 046, 069, 109, 111, 116, 101, 095, 075, 080, 079, 080, 095, 068, 097, 110, 099, 101, 048, 051, 095, 077, 000,
        };

        private static void ReplaceByte3()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 98660888L, cmf1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 98660704L, cmm1);
        }

        private static void RevertByte4()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 98660888L, cmf2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 98660704L, cmm2);
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

