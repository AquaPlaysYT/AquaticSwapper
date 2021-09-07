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
    public partial class Sarah_Stw : MetroForm
    {
        public Sarah_Stw()
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
        //1

        private static byte[] body1 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 070, 095, 077, 069, 068, 095, 068, 117, 114, 114, 098, 117, 114, 103, 101, 114, 080, 074, 115, 047, 077, 101, 115, 104, 101, 115, 047, 070, 095, 077, 069, 068, 095, 068, 117, 114, 114, 098, 117, 114, 103, 101, 114, 080, 074, 115, 095, 048, 049, 095, 066, 111, 100, 121, 046, 070, 095, 077, 069, 068, 095, 068, 117, 114, 114, 098, 117, 114, 103, 101, 114, 080, 074, 115, 095, 048, 049, 095, 066, 111, 100, 121, 013, 010
        };

        private static byte[] body2 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 083, 109, 097, 108, 108, 047, 066, 111, 100, 105, 101, 115, 047, 070, 095, 083, 077, 076, 095, 078, 105, 110, 106, 097, 095, 048, 049, 047, 077, 101, 115, 104, 047, 083, 075, 095, 070, 095, 078, 105, 110, 106, 097, 095, 048, 049, 095, 066, 111, 100, 121, 046, 083, 075, 095, 070, 095, 078, 105, 110, 106, 097, 095, 048, 049, 095, 066, 111, 100, 121, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        //2

        private static byte[] anim1 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 070, 095, 077, 069, 068, 095, 068, 117, 114, 114, 098, 117, 114, 103, 101, 114, 080, 074, 115, 047, 077, 101, 115, 104, 101, 115, 047, 070, 095, 077, 069, 068, 095, 068, 117, 114, 114, 098, 117, 114, 103, 101, 114, 080, 074, 115, 095, 048, 049, 095, 066, 111, 100, 121, 095, 065, 110, 105, 109, 066, 080, 046, 070, 095, 077, 069, 068, 095, 068, 117, 114, 114, 098, 117, 114, 103, 101, 114, 080, 074, 115, 095, 048, 049, 095, 066, 111, 100, 121, 095, 065, 110, 105, 109, 066, 080, 095, 067
        };

        private static byte[] anim2 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 083, 109, 097, 108, 108, 047, 066, 111, 100, 105, 101, 115, 047, 070, 095, 083, 077, 076, 095, 078, 105, 110, 106, 097, 095, 048, 049, 047, 077, 101, 115, 104, 047, 083, 075, 095, 070, 095, 078, 105, 110, 106, 097, 095, 048, 049, 095, 066, 111, 100, 121, 095, 083, 107, 101, 108, 101, 116, 111, 110, 095, 065, 110, 105, 109, 066, 080, 046, 083, 075, 095, 070, 095, 078, 105, 110, 106, 097, 095, 048, 049, 095, 066, 111, 100, 121, 095, 083, 107, 101, 108, 101, 116, 111, 110, 095, 065, 110, 105, 109, 066, 080, 095, 067, 000, 000, 000, 000, 000, 000, 000, 000
        };

        //3

        private static byte[] head1 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 070, 095, 077, 069, 068, 095, 068, 117, 114, 114, 098, 117, 114, 103, 101, 114, 080, 074, 115, 047, 077, 101, 115, 104, 101, 115, 047, 080, 097, 114, 116, 115, 047, 070, 095, 077, 069, 068, 095, 068, 117, 114, 114, 098, 117, 114, 103, 101, 114, 080, 074, 115, 095, 048, 049, 095, 072, 101, 097, 100, 046, 070, 095, 077, 069, 068, 095, 068, 117, 114, 114, 098, 117, 114, 103, 101, 114, 080, 074, 115, 095, 048, 049, 095, 072, 101, 097, 100,
        };

        private static byte[] head2 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 065, 099, 099, 101, 115, 115, 111, 114, 105, 101, 115, 047, 072, 097, 116, 115, 047, 077, 101, 115, 104, 047, 072, 097, 116, 095, 069, 109, 112, 116, 121, 046, 072, 097, 116, 095, 069, 109, 112, 116, 121, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        //4

        private static byte[] hatmat1 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 072, 101, 097, 100, 115, 047, 070, 095, 077, 069, 068, 095, 067, 065, 085, 095, 068, 117, 114, 114, 098, 117, 114, 103, 101, 114, 095, 080, 074, 095, 072, 101, 097, 100, 095, 048, 049, 047, 077, 101, 115, 104, 101, 115, 047, 070, 095, 077, 069, 068, 095, 067, 065, 085, 095, 068, 117, 114, 114, 098, 117, 114, 103, 101, 114, 095, 080, 074, 095, 072, 101, 097, 100, 095, 048, 049, 046, 070, 095, 077, 069, 068, 095, 067, 065, 085, 095, 068, 117, 114, 114, 098, 117, 114, 103, 101, 114, 095, 080, 074, 095, 072, 101, 097, 100, 095, 048, 049
        };

        private static byte[] hatmat2 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 083, 109, 097, 108, 108, 047, 072, 101, 097, 100, 115, 047, 070, 095, 083, 077, 076, 095, 067, 065, 085, 095, 083, 097, 114, 097, 104, 095, 072, 101, 097, 100, 095, 048, 049, 047, 077, 101, 115, 104, 101, 115, 047, 070, 095, 083, 077, 076, 095, 067, 065, 085, 095, 083, 097, 114, 097, 104, 095, 072, 101, 097, 100, 095, 048, 049, 046, 070, 095, 083, 077, 076, 095, 067, 065, 085, 095, 083, 097, 114, 097, 104, 095, 072, 101, 097, 100, 095, 048, 049, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        //name

        private static byte[] name1 = new byte[]
        {
            000, 000, 000, 079, 110, 101, 115, 105, 101
        };

        private static byte[] name2 = new byte[]
        {
             000, 000, 000, 083, 097, 114, 097, 104, 000
        };

        //desc

        private static byte[] desc1 = new byte[]
        {
             083, 109, 097, 115, 104, 032, 116, 104, 097, 116, 032, 115, 110, 111, 111, 122, 101, 032, 098, 117, 116, 116, 111, 110, 046
        };

        private static byte[] desc2 = new byte[]
        { 
             083, 097, 114, 097, 104, 032, 084, 104, 101, 032, 078, 105, 110, 106, 097, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };


        private static void ReplaceByte3()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1221923429L, body1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1221923680L, anim1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1272592823L, head1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1271698146L, hatmat1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 121471378L, name1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 122571157L, desc1);
        }

        private static void RevertByte4()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1221923429L, body2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1221923680L, anim2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1272592823L, head2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1271698146L, hatmat2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 121471378L, name2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 122571157L, desc2);
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

        private void Sarah_Stw_Load(object sender, EventArgs e)
        {
            
        }
    }
}
