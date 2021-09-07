using MetroFramework.Forms;
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

namespace Skin_Swapper__Sorry_
{
    public partial class GalaxyGirl : MetroForm
    {
        public GalaxyGirl()
        {
            InitializeComponent();
        }

        private void GalaxyGirl_Load(object sender, EventArgs e)
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

        private static byte[] bodymat1 = new byte[151]
        {
           047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 070, 095, 077, 069, 068, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 068, 097, 114, 107, 095, 066, 111, 109, 098, 101, 114, 047, 077, 097, 116, 101, 114, 105, 097, 108, 115, 047, 070, 095, 077, 069, 068, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 068, 097, 114, 107, 095, 066, 111, 109, 098, 101, 114, 095, 072, 097, 105, 114, 095, 048, 049, 046, 070, 095, 077, 069, 068, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 068, 097, 114, 107, 095, 066, 111, 109, 098, 101, 114, 095, 072, 097, 105, 114, 095, 048, 049
        };

        private static byte[] bodymat2 = new byte[151]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 077, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 077, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 048, 052, 047, 083, 107, 105, 110, 115, 047, 071, 097, 108, 097, 120, 121, 047, 077, 097, 116, 101, 114, 105, 097, 108, 115, 047, 077, 095, 077, 069, 068, 095, 072, 073, 083, 095, 083, 112, 097, 114, 107, 115, 095, 072, 097, 105, 114, 095, 067, 101, 108, 101, 115, 116, 105, 097, 108, 046, 077, 095, 077, 069, 068, 095, 072, 073, 083, 095, 083, 112, 097, 114, 107, 115, 095, 072, 097, 105, 114, 095, 067, 101, 108, 101, 115, 116, 105, 097, 108, 000, 000, 000, 000, 000
        };

        private static byte[] headmat1 = new byte[151]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 070, 095, 077, 069, 068, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 068, 097, 114, 107, 095, 066, 111, 109, 098, 101, 114, 047, 077, 097, 116, 101, 114, 105, 097, 108, 115, 047, 070, 095, 077, 069, 068, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 068, 097, 114, 107, 095, 066, 111, 109, 098, 101, 114, 095, 072, 101, 097, 100, 095, 048, 049, 046, 070, 095, 077, 069, 068, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 068, 097, 114, 107, 095, 066, 111, 109, 098, 101, 114, 095, 072, 101, 097, 100, 095, 048, 049
        };

        private static byte[] headmat2 = new byte[151]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 077, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 077, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 048, 052, 047, 083, 107, 105, 110, 115, 047, 071, 097, 108, 097, 120, 121, 047, 077, 097, 116, 101, 114, 105, 097, 108, 115, 047, 077, 095, 077, 069, 068, 095, 072, 073, 083, 095, 083, 112, 097, 114, 107, 115, 095, 072, 101, 097, 100, 095, 067, 101, 108, 101, 115, 116, 105, 097, 108, 046, 077, 095, 077, 069 ,068 ,095 ,072 ,073 ,083 ,095 ,083 ,112 ,097 ,114 ,107 ,115 ,095 ,072 ,101 ,097 ,100 ,095 ,067 ,101 ,108 ,101 ,115 ,116 ,105 ,097 ,108, 000, 000, 000, 000, 000
        };

        private static byte[] head1 = new byte[141]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 070, 095, 077, 069, 068, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 068, 097, 114, 107, 095, 066, 111, 109, 098, 101, 114, 047, 077, 097, 116, 101, 114, 105, 097, 108, 115, 047, 077, 073, 095, 070, 095, 077, 069, 068, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 068, 097, 114, 107, 095, 066, 111, 109, 098, 101, 114, 046, 077, 073, 095, 070, 095, 077, 069, 068, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 068, 097, 114, 107, 095, 066, 111, 109, 098, 101, 114
        };

        private static byte[] head2 = new byte[141]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 077, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 077, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 048, 052, 047, 083, 107, 105, 110, 115, 047, 071, 097, 108, 097, 120, 121, 047, 077, 097, 116, 101, 114, 105, 097, 108, 115, 047, 077, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 048, 052, 095, 067, 101, 108, 101, 115, 116, 105, 097, 108, 046, 077, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 048, 052, 095, 067, 101, 108, 101, 115, 116, 105, 097, 108, 000, 000, 000, 000, 000
        };

        private static void ReplaceByte3()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1271462351L, bodymat1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1271462636L, headmat1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1221886574L, head1);
        }

        private static void RevertByte4()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1271462351L, bodymat2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1271462636L, headmat2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1221886574L, head2);
        }


        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (checkPak())
            {
                txtbunny.Text = "[LOG] " + "Skin Added Successfully";

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
                txtbunny.Text = "[LOG] " + "Skin Reverted Successfully";

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

        private void Txtbunny_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
