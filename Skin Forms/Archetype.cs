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
    public partial class Archetype : MetroForm
    {
        public Archetype()
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

        private static byte[] bodyanim1 = new byte[]
        {   
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 077, 097, 108, 101, 047, 077, 101 ,100 ,105 ,117 ,109 ,047 ,066 ,111 ,100 ,105 ,101 ,115 ,047 ,077 ,095 ,077 ,069 ,068 ,095 ,067 ,111 ,109 ,109 ,097 ,110 ,100, 111 ,095 ,068 ,097 ,114 ,107 ,080 ,097 ,105 ,110 ,116 ,098 ,097 ,108 ,108 ,101 ,114 ,047 ,077 ,101 ,115 ,104 ,101 ,115 ,047 ,077 ,095 ,077 ,069 ,068 ,095 ,067 ,111 ,109 ,109 ,097 ,110 ,100 ,111 ,095 ,068 ,097 ,114 ,107 ,080 ,097 ,105 ,110 ,116 ,098 ,097 ,108 ,108 ,101 ,114 ,095 ,065 ,110 ,105 ,109 ,066 ,108 ,117 ,101 ,112 ,114 ,105 ,110 ,116 ,046 ,077 ,095 ,077 ,069 ,068 ,095 ,067 ,111 ,109 ,109 ,097 ,110 ,100 ,111 ,095 ,068 ,097 ,114 ,107 ,080 ,097 ,105 ,110 ,116 ,098 ,097 ,108 ,108 ,101 ,114 ,095 ,065 ,110 ,105 ,109 ,066 ,108 ,117 ,101 ,112 ,114 ,105 ,110 ,116 ,095 ,067
        };

        private static byte[] bodyanim2 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 067, 104 ,097 ,114 ,097 ,099 ,116 ,101 ,114 ,115 ,047 ,080 ,108 ,097 ,121 ,101 ,114 ,047 ,077 ,097 ,108 ,101 ,047 ,077 ,101 ,100 ,105 ,117 ,109 ,047 ,066 ,111 ,100 ,105 ,101 ,115 ,047 ,077 ,095 ,077 ,069 ,068 ,095 ,077 ,111 ,100 ,101 ,114 ,110 ,077 ,105 ,108 ,105 ,116 ,097 ,114 ,121 ,095 ,051 ,065 ,047 ,077 ,101 ,115 ,104 ,101 ,115 ,047 ,077 ,095 ,077 ,069 ,068 ,095 ,077 ,111 ,100 ,101 ,114 ,110 ,077 ,105 ,108 ,105 ,116 ,097 ,114 ,121 ,095 ,051 ,065 ,095 ,083 ,107 ,101 ,108 ,101 ,116 ,111 ,110 ,095 ,065 ,066 ,080 ,046 ,077 ,095 ,077 ,069 ,068 ,095 ,077 ,111 ,100 ,101 ,114 ,110 ,077 ,105 ,108 ,105 ,116 ,097 ,114 ,121 ,095 ,051 ,065 ,095 ,083 ,107 ,101 ,108 ,101 ,116 ,111 ,110 ,095 ,065 ,066 ,080 ,095 ,067 ,000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        private static byte[] body1 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 077, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 077, 095, 077, 069, 068, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 068, 097, 114, 107, 080, 097, 105, 110, 116, 098, 097, 108, 108, 101, 114, 047, 077, 101, 115, 104, 101, 115, 047, 077, 095, 077, 069, 068, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 068, 097, 114, 107, 080, 097, 105, 110, 116, 098, 097, 108, 108, 101, 114, 046, 077, 095, 077, 069, 068, 095, 067, 111, 109, 109, 097, 110, 100, 111, 095, 068, 097, 114, 107, 080, 097, 105, 110, 116, 098, 097, 108, 108, 101, 114
        };

        private static byte[] body2 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 077, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 077, 095, 077, 069, 068, 095, 077, 111, 100, 101, 114, 110, 077, 105, 108, 105, 116, 097, 114, 121, 095, 051, 065, 047, 077, 101, 115, 104, 101, 115, 047, 077, 095, 077, 069, 068, 095, 077, 111, 100, 101, 114, 110, 077, 105, 108, 105, 116, 097, 114, 121, 095, 051, 065, 046, 077, 095, 077, 069, 068, 095, 077, 111, 100, 101, 114, 110, 077, 105, 108, 105, 116, 097, 114, 121, 095, 051, 065, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        private static void RevertBreak()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1221268356L, bodyanim1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1221268071L, body1);
        }

        private static void ReplaceBreak()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1221268356L, bodyanim2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1221268071L, body2);
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (checkPak())
            {
                txtbreak.Text = "[LOG] " + "Skin Added Successfully";

                string path = Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak";
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

                string path = Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak";
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
