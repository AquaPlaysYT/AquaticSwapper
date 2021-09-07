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
    public partial class Galaxy : MetroForm
    {
        public Galaxy()
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

        private static byte[] galaxy1 = new byte[115]
        {
            071, 097, 109, 101, 047, 065, 099, 099, 101, 115, 115, 111, 114, 105, 101, 115, 047, 070, 079, 082, 084, 095, 066, 097, 099, 107, 112, 097, 099, 107, 115, 047, 070, 095, 077, 069, 068, 095, 083, 110, 111, 119, 098, 111, 097, 114, 100, 095, 066, 097, 099, 107, 112, 097, 099, 107, 047, 077, 101, 115, 104, 101, 115, 047, 070, 095, 077, 069, 068, 095, 083, 110, 111, 119, 095, 066, 111, 097, 114, 100, 095, 066, 097, 099, 107, 112, 097, 099, 107, 046, 070, 095, 077, 069, 068, 095, 083, 110, 111, 119, 095, 066, 111, 097, 114, 100, 095, 066, 097, 099, 107, 112, 097, 099, 107
        };

        private static byte[] galaxy2 = new byte[115]
        {
            071, 097, 109, 101, 047, 065, 099, 099, 101, 115, 115, 111, 114, 105, 101, 115, 047, 070, 079, 082, 084, 095, 066, 097, 099, 107, 112, 097, 099, 107, 115, 047, 077, 095, 077, 069, 068, 095, 067, 101, 108, 101, 115, 116, 105, 097, 108, 095, 066, 097, 099, 107, 112, 097, 099, 107, 047, 077, 095, 077, 069, 068, 095, 067, 101, 108, 101, 115, 116, 105, 097, 108, 046, 077, 095, 077, 069, 068, 095, 067, 101, 108, 101, 115, 116, 105, 097, 108, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        private static byte[] galaxy3 = new byte[109]
        {
            071, 097, 109, 101, 047, 069, 102, 102, 101, 099, 116, 115, 047, 070, 111, 114, 116, 095, 069, 102, 102, 101, 099, 116, 115, 047, 069, 102, 102, 101, 099, 116, 115, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 065, 116, 104, 101, 110, 097, 095, 080, 097, 114, 116, 115, 047, 067, 067, 080, 077, 095, 070, 095, 083, 110, 111, 119, 066, 111, 097, 114, 100, 095, 066, 097, 099, 107, 080, 097, 099, 107, 046, 067, 067, 080, 077, 095, 070, 095, 083, 110, 111, 119, 066, 111, 097, 114, 100, 095, 066, 097, 099, 107, 080, 097, 099, 107
        };

        private static byte[] galaxy4 = new byte[109]
        {
            071, 097, 109, 101, 047, 065, 099, 099, 101, 115, 115, 111, 114, 105, 101, 115, 047, 070, 079, 082, 084, 095, 066, 097, 099, 107, 112, 097, 099, 107, 115, 047, 077, 095, 077, 069, 068, 095, 067, 101, 108, 101, 115, 116, 105, 097, 108, 095, 066, 097, 099, 107, 112, 097, 099, 107, 047, 066, 080, 095, 066, 097, 099, 107, 112, 097, 099, 107, 095, 067, 101, 108, 101, 115, 116, 105, 097, 108, 046, 066, 080, 095, 066, 097, 099, 107, 112, 097, 099, 107, 095, 067, 101, 108, 101, 115, 116, 105, 097, 108, 095, 067, 000, 000, 000, 000, 000, 000, 000
        };

        private static void ReplaceBytecake()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 115259742L, galaxy1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 115260386L, galaxy3);
        }

        private static void RevertBytecake()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 115259742L, galaxy2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 115260386L, galaxy4);
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (checkPak())
            {
                txtbunny.Text = "[LOG] " + "BackBling Added Successfully";

                string path = Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak";
                if (File.Exists(path))
                {
                    RevertBytecake();
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
                    ReplaceBytecake();
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
