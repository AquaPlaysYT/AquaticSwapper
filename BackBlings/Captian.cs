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
    public partial class Captian : MetroForm
    {
        public Captian()
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

        //mesh

        private static byte[] captian1 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 065, 099, 099, 101, 115, 115, 111, 114, 105, 101, 115, 047, 070, 079, 082, 084, 095, 066, 097, 099, 107, 112, 097, 099, 107, 115, 047, 066, 097, 099, 107, 112, 097, 099, 107, 095, 077, 097, 115, 116, 101, 114, 095, 075, 101, 121, 047, 077, 101, 115, 104, 101, 115, 047, 077, 095, 077, 069, 068, 095, 077, 097, 115, 116, 101, 114, 095, 075, 101, 121, 095, 066, 097, 099, 107, 112, 097, 099, 107, 046, 077, 095, 077, 069, 068, 095, 077, 097, 115, 116, 101, 114, 095, 075, 101, 121, 095, 066, 097, 099, 107, 112, 097, 099, 107
        };

        private static byte[] captian2 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 065, 116, 104, 101, 110, 097, 047, 073, 116, 101, 109, 115, 047, 071, 097, 109, 101, 112, 108, 097, 121, 047, 066, 097, 099, 107, 080, 097, 099, 107, 115, 047, 065, 115, 104, 116, 111, 110, 047, 067, 104, 105, 099, 097, 103, 111, 047, 077, 101, 115, 104, 101, 115, 047, 065, 115, 104, 116, 111, 110, 095, 067, 104, 105, 099, 097, 103, 111, 095, 071, 097, 100, 103, 101, 116, 046, 065, 115, 104, 116, 111, 110, 095, 067, 104, 105, 099, 097, 103, 111, 095, 071, 097, 100, 103, 101, 116, 000, 000, 000, 000, 000, 000, 000, 000
        };

       
        private static void ReplaceByte1()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 115112280L, captian1);         
        }

        private static void RevertByte2()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 115112280L, captian2);
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (checkPak())
            {
                txtbunny.Text = "[LOG] " + "BackBling Added Successfully";

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
                txtbunny.Text = "[LOG] " + "BackBling Reverted Successfully";

                string path = Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak";
                if (File.Exists(path))
                {
                    ReplaceByte1();
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
