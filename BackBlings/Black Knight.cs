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
    public partial class Black_Knight : MetroForm
    {
        public Black_Knight()
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

        private static byte[] tbmesh1 = new byte[113]
        {
            047, 071, 097, 109, 101, 047, 065, 099, 099, 101, 115, 115, 111, 114, 105, 101, 115, 047, 070, 079, 082, 084, 095, 066, 097, 099, 107, 112, 097, 099, 107, 115, 047, 077, 095, 077, 069, 068, 095, 084, 097, 099, 116, 105, 099, 097, 108, 066, 097, 100, 097, 115, 115, 095, 066, 097, 099, 107, 112, 097, 099, 107, 047, 077, 101, 115, 104, 101, 115, 047, 077, 095, 077, 069, 068, 095, 084, 097, 099, 116, 105, 099, 097, 108, 095, 066, 097, 100, 097, 115, 115, 046, 077, 095, 077, 069, 068, 095, 084, 097, 099, 116, 105, 099, 097, 108, 095, 066, 097, 100, 097, 115, 115
        };

        private static byte[] tbmesh2 = new byte[113]
        {
            047, 071, 097, 109, 101, 047, 065, 099, 099, 101, 115, 115, 111, 114, 105, 101, 115, 047, 070, 079, 082, 084, 095, 066, 097, 099, 107, 112, 097, 099, 107, 115, 047, 077, 101, 115, 104, 047, 083, 075, 095, 083, 104, 105, 101, 108, 100, 095, 066, 108, 097, 099, 107, 107, 110, 105, 103, 104, 116, 046, 083, 075, 095, 083, 104, 105, 101, 108, 100, 095, 066, 108, 097, 099, 107, 107, 110, 105, 103, 104, 116, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        private static byte[] tbmesh3 = new byte[91]
        {
            047, 071, 097, 109, 101, 047, 065, 099, 099, 101, 115, 115, 111, 114, 105, 101, 115, 047, 070, 079, 082, 084, 095, 066, 097, 099, 107, 112, 097, 099, 107, 115, 047, 077, 095, 077, 069, 068, 095, 084, 097, 099, 116, 105, 099, 097, 108, 066, 097, 100, 097, 115, 115, 095, 066, 097, 099, 107, 112, 097, 099, 107, 047, 077, 101, 115, 104, 101, 115, 047, 077, 095, 077, 069, 068, 095, 084, 097, 099, 116, 105, 099, 097, 108, 095, 066, 097, 100, 097, 115, 115
        };

        private static byte[] tbmesh4 = new byte[91]
        {
            047, 071, 097, 109, 101, 047, 065, 099, 099, 101, 115, 115, 111, 114, 105, 101, 115, 047, 070, 079, 082, 084, 095, 066, 097, 099, 107, 112, 097, 099, 107, 115, 047, 077, 101, 115, 104, 047, 083, 075, 095, 083, 104, 105, 101, 108, 100, 095, 066, 108, 097, 099, 107, 107, 110, 105, 103, 104, 116, 013, 010, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        private static void ReplaceByte3()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 115503452L, tbmesh1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 115503354L, tbmesh3);
        }

        private static void RevertByte4()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 115503452L, tbmesh2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 115503354L, tbmesh4);
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (checkPak())
            {
                metroTextBox1.Text = "[LOG] " + "BackBling Added Successfully";

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
                metroTextBox1.Text = "[LOG] " + "BackBling Reverted Successfully";

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
