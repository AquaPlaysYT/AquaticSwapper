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
    public partial class Scarlet_BB : MetroForm
    {
        public Scarlet_BB()
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

        private static byte[] poolpartymesh1 = new byte[142]
        {
            047, 071, 097, 109, 101, 047, 065, 099, 099, 101, 115, 115, 111, 114, 105, 101, 115, 047, 070, 079, 082, 084, 095, 066, 097, 099, 107, 112, 097, 099, 107, 115, 047, 077, 095, 077, 069, 068, 095, 083, 117, 109, 109, 101, 114, 072, 101, 114, 111, 101, 115, 095, 085, 110, 105, 099, 111, 114, 110, 047, 077, 101, 115, 104, 101, 115, 047, 066, 097, 099, 107, 112, 097, 099, 107, 095, 083, 117, 109, 109, 101, 114, 095, 072, 101, 114, 111, 101, 115, 095, 085, 110, 105, 099, 111, 114, 110, 095, 069, 120, 112, 111, 114, 116, 046, 066, 097, 099, 107, 112, 097, 099, 107, 095, 083, 117, 109, 109, 101, 114, 095, 072, 101, 114, 111, 101, 115, 095, 085, 110, 105, 099, 111, 114, 110, 095, 069, 120, 112, 111, 114, 116
        };

        private static byte[] poolpartymesh2 = new byte[142]
        {
            047, 071, 097, 109, 101, 047, 065, 099, 099, 101, 115, 115, 111, 114, 105, 101, 115, 047, 070, 079, 082, 084, 095, 066, 097, 099, 107, 112, 097, 099, 107, 115, 047, 070, 095, 077, 069, 068, 095, 077, 097, 115, 097, 107, 111, 095, 066, 097, 099, 107, 112, 097, 099, 107, 047, 077, 101, 115, 104, 101, 115, 047, 070, 095, 077, 069, 068, 095, 077, 097, 115, 097, 107, 111, 095, 080, 097, 099, 107, 046, 070, 095, 077, 069, 068, 095, 077, 097, 115, 097, 107, 111, 095, 080, 097, 099, 107, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        private static void ReplaceBytepool()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 115528043L, poolpartymesh1);
        }

        private static void RevertBytepool()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 115528043L, poolpartymesh2);
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (checkPak())
            {
                txtbunny.Text = "[LOG] " + "BackBling Added Successfully";

                string path = Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak";
                if (File.Exists(path))
                {
                    RevertBytepool();
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
                    ReplaceBytepool();
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
