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

namespace Skin_Swapper__Sorry_.Skin_Forms
{
    public partial class Dark_Vertex : MetroForm
    {
        public Dark_Vertex()
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

        private static byte[] vertexcid1 = new byte[123]
        {
            047, 071, 097, 109, 101, 047, 065, 116, 104, 101, 110, 097, 047, 073, 116, 101, 109, 115, 047, 067, 111, 115, 109, 101, 116, 105, 099, 115, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 067, 073, 068, 095, 049, 054, 055, 095, 065, 116, 104, 101, 110, 097, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 077, 095, 084, 097, 099, 116, 105, 099, 097, 108, 066, 097, 100, 097, 115, 115, 046, 067, 073, 068, 095, 049, 054, 055, 095, 065, 116, 104, 101, 110, 097, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 077, 095, 084, 097, 099, 116, 105, 099, 097, 108, 066, 097, 100, 097, 115, 115, 013, 010
        };


        private static byte[] vertexcid2 = new byte[123]
        {
            047, 071, 097, 109, 101, 047, 065, 116, 104, 101, 110, 097, 047, 073, 116, 101, 109, 115, 047, 067, 111, 115, 109, 101, 116, 105, 099, 115, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 067, 073, 068, 095, 051, 055, 049, 095, 065, 116, 104, 101, 110, 097, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 077, 095, 083, 112, 101, 101, 100, 121, 077, 105, 100, 110, 105, 103, 104, 116, 046, 067, 073, 068, 095, 051, 055, 049, 095, 065, 116, 104, 101, 110, 097, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 077, 095, 083, 112, 101, 101, 100, 121, 077, 105, 100, 110, 105, 103, 104, 116, 000, 000
        };

        private static void Revertvertex()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk0-WindowsClient.pak", 336542497L, vertexcid1);
        }

        private static void Replacevertex()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk0-WindowsClient.pak", 336542497L, vertexcid2);
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (checkPak())
            {
                txtdark.Text = "[LOG] " + "Skin Added Successfully";

                string path = Properties.Settings.Default.pakFiles + "\\pakchunk0-WindowsClient.pak";
                if (File.Exists(path))
                {
                    Replacevertex();
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
                txtdark.Text = "[LOG] " + "Skin Reverted Successfully";

                string path = Properties.Settings.Default.pakFiles + "\\pakchunk0-WindowsClient.pak";
                if (File.Exists(path))
                {
                    Revertvertex();
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
