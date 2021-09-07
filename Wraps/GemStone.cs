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

namespace Skin_Swapper__Sorry_.Wraps
{
    public partial class GemStone : MetroForm
    {
        public GemStone()
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

        private static byte[] mat1 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 087, 101, 097, 112, 111, 110, 115, 047, 087, 101, 097, 112, 111, 110, 083, 107, 105, 110, 115, 047, 087, 114, 097, 112, 115, 047, 077, 097, 116, 101, 114, 105, 097, 108, 115, 047, 077, 073, 095, 087, 101, 097, 112, 111, 110, 087, 114, 097, 112, 095, 084, 114, 111, 112, 105, 099, 097, 108, 067, 097, 109, 111, 046, 077, 073, 095, 087, 101, 097, 112, 111, 110, 087, 114, 097, 112, 095, 084, 114, 111, 112, 105, 099, 097, 108, 067, 097, 109, 111
        };

        private static byte[] mat2 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 087, 101, 097, 112, 111, 110, 115, 047, 087, 101, 097, 112, 111, 110, 083, 107, 105, 110, 115, 047, 087, 114, 097, 112, 115, 047, 077, 097, 116, 101, 114, 105, 097, 108, 115, 047, 077, 073, 095, 087, 101, 097, 112, 111, 110, 087, 114, 097, 112, 095, 071, 101, 109, 046, 077, 073, 095, 087, 101, 097, 112, 111, 110, 087, 114, 097, 112, 095, 071, 101, 109, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        
        private static void ReplaceByte3()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 125788914L, mat1);         
        }

        private static void RevertByte4()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 125788914L, mat2);        
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (checkPak())
            {
                txtbunny.Text = "[LOG] " + "Wrap Added Successfully";

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
                txtbunny.Text = "[LOG] " + "Wrap Reverted Successfully";

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
