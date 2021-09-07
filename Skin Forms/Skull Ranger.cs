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
    public partial class Skull_Ranger : MetroForm
    {
        public Skull_Ranger()
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
            080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 070, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 048, 049, 047, 083, 107, 105, 110, 115, 047, 070, 101, 109, 097, 108, 101, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 083, 116, 114, 101, 101, 116, 082, 097, 099, 101, 114, 066, 108, 097, 099, 107, 047, 077, 097, 116, 101, 114, 105, 097, 108, 115, 047, 070, 095, 077, 069, 068, 095, 095, 095, 083, 116, 114, 101, 101, 116, 082, 097, 099, 101, 114, 066, 108, 097, 099, 107, 046, 070, 095, 077, 069, 068, 095, 095, 095, 083, 116, 114, 101, 101, 116, 082, 097, 099, 101, 114, 066, 108, 097, 099, 107
        };

        private static byte[] body2 = new byte[]
        {
            080, 108, 097, 121, 101, 114, 047, 077, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 077, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 048, 052, 047, 083, 107, 105, 110, 115, 047, 072, 087, 048, 049, 095, 082, 101, 100, 047, 077, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 048, 052, 095, 072, 087, 048, 049, 095, 082, 101, 100, 046, 077, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 048, 052, 095, 072, 087, 048, 049, 095, 082, 101, 100, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        private static byte[] skin1 = new byte[]
        {
            080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 070, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 048, 049, 047, 083, 107, 105, 110, 115, 047, 070, 101, 109, 097, 108, 101, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 083, 116, 114, 101, 101, 116, 082, 097, 099, 101, 114, 066, 108, 097, 099, 107, 047, 077, 097, 116, 101, 114, 105, 097, 108, 115, 047, 070, 095, 077, 069, 068, 095, 083, 116, 114, 101, 101, 116, 082, 097, 099, 101, 114, 066, 108, 097, 099, 107, 095, 072, 101, 097, 100, 095, 048, 049, 046, 070, 095, 077, 069, 068, 095, 083, 116, 114, 101, 101, 116, 082, 097, 099, 101, 114, 066, 108, 097, 099, 107, 095, 072, 101, 097, 100, 095, 048, 049
        };

        private static byte[] skin2 = new byte[]
        {
            080, 108, 097, 121, 101, 114, 047, 077, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 077, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 048, 052, 047, 083, 107, 105, 110, 115, 047, 072, 087, 048, 049, 095, 082, 101, 100, 047, 077, 095, 077, 101, 100, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 072, 101, 097, 100, 095, 048, 049, 095, 072, 087, 048, 049, 046, 077, 095, 077, 101, 100, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 072, 101, 097, 100, 095, 048, 049, 095, 072, 087, 048, 049, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        private static byte[] hatmat1 = new byte[]
        {
            065, 099, 099, 101, 115, 115, 111, 114, 105, 101, 115, 047, 072, 097, 116, 115, 047, 077, 097, 116, 101, 114, 105, 097, 108, 115, 047, 072, 097, 116, 095, 070, 095, 083, 116, 114, 101, 101, 116, 082, 097, 099, 101, 114, 066, 108, 097, 099, 107, 046, 072, 097, 116, 095, 070, 095, 083, 116, 114, 101, 101, 116, 082, 097, 099, 101, 114, 066, 108, 097, 099, 107
        };

        private static byte[] hatmat2 = new byte[]
        {
            065, 099, 099, 101, 115, 115, 111, 114, 105, 101, 115, 047, 072, 097, 116, 115, 047, 077, 097, 116, 101, 114, 105, 097, 108, 115, 047, 072, 097, 116, 095, 077, 095, 078, 105, 110, 106, 097, 095, 048, 051, 095, 086, 049, 046, 072, 097, 116, 095, 077, 095, 078, 105, 110, 106, 097, 095, 048, 051, 095, 086, 049, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        private static void ReplaceByte3()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1545952356L, body1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1587891007L, skin1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1588670784L, hatmat1);
           
        }

        private static void RevertByte4()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1545952356L, body2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1587891007L, skin2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1588670784L, hatmat2);
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

        private void Skull_Ranger_Load(object sender, EventArgs e)
        {
            txtbunny.ForeColor = Color.Red;
            txtbunny.Text = "[LOG] " + "This skin is currently disabled!";
        }
    }
}
