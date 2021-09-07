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

namespace Skin_Swapper__Sorry_.Music
{
    public partial class SwapAllMusic : MetroForm
    {
        public SwapAllMusic()
        {
            InitializeComponent();
        }

        private static byte[] name1 = new byte[78]
        {
            047, 071, 097, 109, 101, 047, 083, 111, 117, 110, 100, 115, 047, 070, 111, 114, 116, 095, 077, 117, 115, 105, 099, 047, 077, 101, 110, 117, 047, 102, 111, 114, 116, 110, 105, 116, 101, 095, 108, 111, 103, 105, 110, 095, 115, 099, 114, 101, 101, 110, 046, 102, 111, 114, 116, 110, 105, 116, 101, 095, 108, 111, 103, 105, 110, 095, 115, 099, 114, 101, 101, 110, 000, 000, 000, 000, 000, 000
        };

        private static byte[] name2 = new byte[78]
        {
            047, 071, 097, 109, 101, 047, 065, 116, 104, 101, 110, 097, 047, 083, 111, 117, 110, 100, 115, 047, 077, 117, 115, 105, 099, 080, 097, 099, 107, 115, 047, 065, 116, 104, 101, 110, 097, 095, 077, 117, 115, 105, 099, 080, 097, 099, 107, 095, 083, 112, 111, 111, 107, 121, 046, 065, 116, 104, 101, 110, 097, 095, 077, 117, 115, 105, 099, 080, 097, 099, 107, 095, 083, 112, 111, 111, 107, 121
        };

        //

        private static byte[] name3 = new byte[76]
        {
            047, 071, 097, 109, 101, 047, 083, 111, 117, 110, 100, 115, 047, 070, 111, 114, 116, 095, 077, 117, 115, 105, 099, 047, 077, 101, 110, 117, 047, 102, 111, 114, 116, 110, 105, 116, 101, 095, 108, 111, 103, 105, 110, 095, 115, 099, 114, 101, 101, 110, 046, 102, 111, 114, 116, 110, 105, 116, 101, 095, 108, 111, 103, 105, 110, 095, 115, 099, 114, 101, 101, 110, 000, 000, 000, 000
        };

        private static byte[] name4 = new byte[76]
        {
            047, 071, 097, 109, 101, 047, 065, 116, 104, 101, 110, 097, 047, 083, 111, 117, 110, 100, 115, 047, 077, 117, 115, 105, 099, 080, 097, 099, 107, 115, 047, 065, 116, 104, 101, 110, 097, 095, 077, 117, 115, 105, 099, 080, 097, 099, 107, 095, 070, 108, 111, 115, 115, 046, 065, 116, 104, 101, 110, 097, 095, 077, 117, 115, 105, 099, 080, 097, 099, 107, 095, 070, 108, 111, 115, 115
        };

        //

        private static byte[] name5 = new byte[76]
        {
            047, 071, 097, 109, 101, 047, 083, 111, 117, 110, 100, 115, 047, 070, 111, 114, 116, 095, 077, 117, 115, 105, 099, 047, 077, 101, 110, 117, 047, 102, 111, 114, 116, 110, 105, 116, 101, 095, 108, 111, 103, 105, 110, 095, 115, 099, 114, 101, 101, 110, 046, 102, 111, 114, 116, 110, 105, 116, 101, 095, 108, 111, 103, 105, 110, 095, 115, 099, 114, 101, 101, 110, 000, 000, 000, 000
        };

        private static byte[] name6 = new byte[76]
        {
            047, 071, 097, 109, 101, 047, 065, 116, 104, 101, 110, 097, 047, 083, 111, 117, 110, 100, 115, 047, 077, 117, 115, 105, 099, 080, 097, 099, 107, 115, 047, 065, 116, 104, 101, 110, 097, 095, 077, 117, 115, 105, 099, 080, 097, 099, 107, 095, 084, 119, 105, 115, 116, 046, 065, 116, 104, 101, 110, 097, 095, 077, 117, 115, 105, 099, 080, 097, 099, 107, 095, 084, 119, 105, 115, 116
        };

        //

        private static byte[] name7 = new byte[100]
        {
            047, 071, 097, 109, 101, 047, 083, 111, 117, 110, 100, 115, 047, 070, 111, 114, 116, 095, 077, 117, 115, 105, 099, 047, 077, 101, 110, 117, 047, 102, 111, 114, 116, 110, 105, 116, 101, 095, 108, 111, 103, 105, 110, 095, 115, 099, 114, 101, 101, 110, 046, 102, 111, 114, 116, 110, 105, 116, 101, 095, 108, 111, 103, 105, 110, 095, 115, 099, 114, 101, 101, 110, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        private static byte[] name8 = new byte[100]
        {
            047, 071, 097, 109, 101, 047, 065, 116, 104, 101, 110, 097, 047, 083, 111, 117, 110, 100, 115, 047, 077, 117, 115, 105, 099, 080, 097, 099, 107, 115, 047, 077, 117, 115, 105, 099, 080, 097, 099, 107, 095, 067, 111, 114, 097, 108, 067 ,114 ,117 ,105 ,115 ,101 ,114, 095, 066, 080, 077, 095, 056 ,052 ,095, 076, 079, 079, 080, 046, 077, 117, 115, 105, 099, 080, 097, 099, 107, 095, 067, 111, 114, 097, 108, 067, 114, 117, 105, 115, 101, 114, 095, 066, 080, 077, 095, 056, 052, 095, 076, 079, 079, 080
        };

        //

        private static void RevertByte2()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1258295609L, name1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1258242360L, name3);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1258303800L, name5);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1258225988L, name7);
        }

        private static void ReplaceByte3()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1258295609L, name2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1258242360L, name4);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1258303800L, name6);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1258225988L, name8);
        }

        public static void ReplaceBytes(string pak, long offset, byte[] bytes)
        {
            BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(pak, FileMode.Open, FileAccess.ReadWrite));
            binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
            binaryWriter.Write(bytes);
            binaryWriter.Close();
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

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (checkPak())
            {
                txtbunny.Text = "[LOG] " + "Music Packs Added Successfully";
               
                string path = Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak";
                if (File.Exists(path))
                {
                    RevertByte2();
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
                txtbunny.Text = "[LOG] " + "Music Packs Reverted Successfully";

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
