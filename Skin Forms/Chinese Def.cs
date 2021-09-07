using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Skin_Swapper__Sorry_
{
    public partial class Chinese_Def : MetroForm
    {
        public Chinese_Def()
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

        private void Chinese_Def_Load(object sender, EventArgs e)
        {

        }

        private static byte[] rookbodyanip1 = new byte[142]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 070, 095, 077, 069, 068, 095, 083, 116, 097, 114, 102, 105, 115, 104, 085, 110, 105, 102, 111, 114, 109, 095, 048, 049, 047, 077, 101, 115, 104, 101, 115, 047, 070, 095, 077, 069, 068, 095, 083, 116, 097, 114, 102, 105, 115, 104, 085, 110, 105, 102, 111, 114, 109, 095, 048, 049, 095, 065, 110, 105, 109, 066, 080, 046, 070, 095, 077, 069, 068, 095, 083, 116, 097, 114, 102, 105, 115, 104, 085, 110, 105, 102, 111, 114, 109, 095, 048, 049, 095, 065, 110, 105, 109, 066, 080, 095, 067
        };

        private static byte[] rookbodyanim2 = new byte[142]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 070, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 048, 049, 047, 077, 101, 115, 104, 101, 115, 047, 070, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 048, 049, 095, 083, 107, 101, 108, 101, 116, 111, 110, 095, 065, 110, 105, 109, 066, 080, 046, 070, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 048, 049, 095, 083, 107, 101, 108, 101, 116, 111, 110, 095, 065, 110, 105, 109, 066, 080, 095, 067, 000, 000, 000, 000, 000, 000
        };

        private static byte[] rookbody1 = new byte[126]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 070, 095, 077, 069, 068, 095, 083, 116, 097, 114, 102, 105, 115, 104, 085, 110, 105, 102, 111, 114, 109, 095, 048, 049, 047, 077, 101, 115, 104, 101, 115, 047, 070, 095, 077, 069, 068, 095, 083, 116, 097, 114, 102, 105, 115, 104, 085, 110, 105, 102, 111, 114, 109, 095, 048, 049, 046, 070, 095, 077, 069, 068, 095, 083, 116, 097, 114, 102, 105, 115, 104, 085, 110, 105, 102, 111, 114, 109, 095, 048, 049
        };

        private static byte[] rookbody2 = new byte[126]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 070, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 048, 049, 047, 077, 101, 115, 104, 101, 115, 047, 070, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 048, 049, 046, 070, 095, 077, 101, 100, 095, 083, 111, 108, 100, 105, 101, 114, 095, 048, 049, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        private static byte[] headphonesremove1 = new byte[116]
        {
            047, 071, 097, 109, 101, 047, 065, 099, 099, 101, 115, 115, 111, 114, 105, 101, 115, 047, 072, 097, 116, 115, 047, 070, 095, 077, 069, 068, 095, 083, 116, 097, 114, 102, 105, 115, 104, 085, 110, 105, 102, 111, 114, 109, 095, 072, 101, 097, 100, 112, 104, 111, 110, 101, 115, 047, 077, 101, 115, 104, 101, 115, 047, 083, 116, 097, 114, 102, 105, 115, 104, 085, 110, 105, 102, 111, 114, 109, 095, 072, 101, 097, 100, 112, 104, 111, 110, 101, 115, 046, 083, 116, 097, 114, 102, 105, 115, 104, 085, 110, 105, 102, 111, 114, 109, 095, 072, 101, 097, 100, 112, 104, 111, 110, 101, 115
        };


        private static byte[] headphonesremove2 = new byte[116]
        {
            047, 071, 097, 109, 101, 047, 065, 099, 099, 101, 115, 115, 111, 114, 105, 101, 115, 047, 072, 097, 116, 115, 047, 077, 101, 115, 104, 047, 072, 097, 116, 095, 069, 109, 112, 116, 121, 046, 072, 097, 116, 095, 069, 109, 112, 116, 121, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };


        private static void ReplaceByte10()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 267377509L, rookbodyanip1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 267377257L, rookbody1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 267385180L, headphonesremove1);
        }

        private static void RevertByte11()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 267377509L, rookbodyanim2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 267377257L, rookbody2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 267385180L, headphonesremove2);
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (checkPak())
            {
                txtdef.Text = "[LOG] " + "Skin Added Successfully";

                string path = Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak";
                if (File.Exists(path))
                {
                    RevertByte11();
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
                txtdef.Text = "[LOG] " + "Skin Reverted Successfully";

                string path = Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak";
                if (File.Exists(path))
                {
                    ReplaceByte10();
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
