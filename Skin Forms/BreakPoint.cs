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
using System.Threading;

namespace Skin_Swapper__Sorry_.Skin_Forms
{
    public partial class BreakPoint : MetroForm
    {
        public BreakPoint()
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

        private static byte[] breakcid1 = new byte[111]
        {
            047, 071, 097, 109, 101, 047, 065, 116, 104, 101, 110, 097, 047, 073, 116, 101, 109, 115, 047, 067, 111, 115, 109, 101, 116, 105, 099, 115, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 067, 073, 068, 095, 050, 056, 049, 095, 065, 116, 104, 101, 110, 097, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 070, 095, 083, 110, 111, 119, 066, 111, 097, 114, 100, 046, 067, 073, 068, 095, 050, 056, 049, 095, 065, 116, 104, 101, 110, 097, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 070, 095, 083, 110, 111, 119, 066, 111, 097, 114, 100,
        };

        private static byte[] breakcid2 = new byte[111]
        {
            047, 071, 097, 109, 101, 047, 065, 116, 104, 101, 110, 097, 047, 073, 116, 101, 109, 115, 047, 067, 111, 115, 109, 101, 116, 105, 099, 115, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 067, 073, 068, 095, 052, 050, 057, 095, 065, 116, 104, 101, 110, 097, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 070, 095, 078, 101, 111, 110, 076, 105, 110, 101, 115, 046, 067, 073, 068, 095, 052, 050, 057, 095, 065, 116, 104, 101, 110, 097, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 070, 095, 078, 101, 111, 110, 076, 105, 110, 101, 115,
        };

        private static void RevertBreak()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk0-WindowsClient.pak", 350992463L, breakcid1);
        }

        private static void ReplaceBreak()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk0-WindowsClient.pak", 350992463L, breakcid2);
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (checkPak())
            {
                txtbreak.Text = "[LOG] " + "Skin Added Successfully";

                string path = Properties.Settings.Default.pakFiles + "\\pakchunk0-WindowsClient.pak";
                if (File.Exists(path))
                {
                    ReplaceBreak();
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
                            
                string path = Properties.Settings.Default.pakFiles + "\\pakchunk0-WindowsClient.pak";
                if (File.Exists(path))
                {
                    RevertBreak();
                }
                else
                {

                }

                txtbreak.Text = "[LOG] " + "Skin Reverted Successfully";
            }
            else
            {
                MessageBox.Show("Please Select your pak folder in settings!");
            }
        }   
    }
}
