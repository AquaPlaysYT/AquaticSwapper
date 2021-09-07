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

namespace Skin_Swapper__Sorry_.Skin_Forms
{
    public partial class Ranger : MetroForm
    {
        public Ranger()
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

        private static byte[] body1 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 077, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 077, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 048, 052, 047, 083, 107, 105, 110, 115, 047, 066, 082, 095, 048, 049, 047, 077, 097, 116, 101, 114, 105, 097, 108, 047, 077, 095, 077, 069, 068, 095, 083, 111, 108, 100, 105, 101, 114, 095, 048, 052, 095, 072, 073, 083, 095, 066, 082, 048, 049, 046, 077, 095, 077, 069, 068, 095, 083, 111, 108, 100, 105, 101, 114, 095, 048, 052, 095, 072, 073, 083, 095, 066, 082, 048, 049
        };

        private static byte[] body2 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 077, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 077, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 048, 052, 047, 083, 107, 105, 110, 115, 047, 084, 086, 095, 051, 050, 047, 077, 097, 116, 101, 114, 105, 097, 108, 115, 047, 077, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 084, 086, 051, 050, 046, 077, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 084, 086, 051, 050, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

       
        private static void ReplaceByte3()
        {          
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1220820010L, body1);
        }

        private static void RevertByte4()
        {          
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1220820010L, body2);
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
    }
}
