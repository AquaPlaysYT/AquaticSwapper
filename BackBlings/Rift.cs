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
    public partial class Rift : MetroForm
    {
        public Rift()
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

        private static byte[] cake1 = new byte[116]
        {
            047, 071, 097, 109, 101, 047, 065, 099, 099, 101, 115, 115, 111, 114, 105, 101, 115, 047, 070, 079, 082, 084, 095, 066, 097, 099, 107, 112, 097, 099, 107, 115, 047, 070, 095, 077, 069, 068, 095, 083, 110, 111, 119, 098, 111, 097, 114, 100, 095, 066, 097, 099, 107, 112, 097, 099, 107, 047, 077, 101, 115, 104, 101, 115, 047, 070, 095, 077, 069, 068, 095, 083, 110, 111, 119, 095, 066, 111, 097, 114, 100, 095, 066, 097, 099, 107, 112, 097, 099, 107, 046, 070, 095, 077, 069, 068, 095, 083, 110, 111, 119, 095, 066, 111, 097, 114, 100, 095, 066, 097, 099, 107, 112, 097, 099, 107
        };

        private static byte[] cake2 = new byte[116]
        {
            047, 071, 097, 109, 101, 047, 065, 099, 099, 101, 115, 115, 111, 114, 105, 101, 115, 047, 070, 079, 082, 084, 095, 066, 097, 099, 107, 112, 097, 099, 107, 115, 047, 070, 095, 077, 069, 068, 095, 083, 104, 097, 116, 116, 101, 114, 070, 108, 121, 095, 066, 097, 099, 107, 112, 097, 099, 107, 047, 077, 101, 115, 104, 101, 115, 047, 070, 095, 077, 069, 068, 095, 083, 104, 097, 116, 116, 101, 114, 095, 070, 108, 121, 095, 080, 097, 099, 107, 046, 070, 095, 077, 069, 068, 095, 083, 104, 097, 116, 116, 101, 114, 095, 070, 108, 121, 095, 080, 097, 099, 107, 000, 000, 000, 000, 000
        };

        private static byte[] fx1 = new byte[110]
        {
            047, 071, 097, 109, 101, 047, 069, 102, 102, 101, 099, 116, 115, 047, 070, 111, 114, 116, 095, 069, 102, 102, 101, 099, 116, 115, 047, 069, 102, 102, 101, 099, 116, 115, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 065, 116, 104, 101, 110, 097, 095, 080, 097, 114, 116, 115, 047, 067, 067, 080, 077, 095, 070, 095, 083, 110, 111, 119, 066, 111, 097, 114, 100, 095, 066, 097, 099, 107, 080, 097, 099, 107, 046, 067, 067, 080, 077, 095, 070, 095, 083, 110, 111, 119, 066, 111, 097, 114, 100, 095, 066, 097, 099, 107, 080, 097, 099, 107
        };

        private static byte[] fx2 = new byte[110]
        {
            013, 010, 047, 071, 097, 109, 101, 047, 065, 099, 099, 101, 115, 115, 111, 114, 105, 101, 115, 047, 070, 079, 082, 084, 095, 066, 097, 099, 107, 112, 097, 099, 107, 115, 047, 070, 095, 077, 069, 068, 095, 083, 104, 097, 116, 116, 101, 114, 070, 108, 121, 095, 066, 097, 099, 107, 112, 097, 099, 107, 047, 070, 088, 047, 080, 095, 066, 097, 099, 107, 112, 097, 099, 107, 095, 083, 104, 097, 116, 116, 101, 114, 102, 108, 121, 046, 080, 095, 066, 097, 099, 107, 112, 097, 099, 107, 095, 083, 104, 097, 116, 116, 101, 114, 102, 108, 121, 000, 000, 000
        };

        private static void ReplaceByte7()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 115259741L, cake1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 115260385L, fx1);
        }

        private static void RevertByte8()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 115259741L, cake2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 115260385L, fx2);
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (checkPak())
            {
                txtbunny.Text = "[LOG] " + "BackBling Added Successfully";

                string path = Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak";
                if (File.Exists(path))
                {
                    RevertByte8();
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
                    ReplaceByte7();
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
