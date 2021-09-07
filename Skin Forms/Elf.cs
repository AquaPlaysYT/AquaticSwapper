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
    public partial class Elf : MetroForm
    {
        public Elf()
        {
            InitializeComponent();
        }

        private void Elf_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Might cause your game to courrupt, use at your own risk!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ReplaceBytes(string pak, long offset, byte[] bytes)
        {
            BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(pak, FileMode.Open, FileAccess.ReadWrite));
            binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
            binaryWriter.Write(bytes);

            binaryWriter.Close();
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

        private static void ReplaceByte10()
        {         
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1220936753L, Body);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1272695125L, Hat);
        }

        private static void RevertByte11()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1220936753L, Body1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1272695125L, Hat1);
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (checkPak())
            {
               
                string path = Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak";
                if (File.Exists(path))
                {
                    
                    RevertByte11();
                    txtelf.Text = "[LOG] " + "Skin Added Successfully";
                }
                else
                {
                    txtelf.Text = "[LOG] " + "Error Pak files are not set!";
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
                    
                    ReplaceByte10();
                    txtelf.Text = "[LOG] " + "Skin Reverted Successfully";
                }
                else
                {
                    txtelf.Text = "[LOG] " + "Error Pak files are not set!";
                }
            }
            else
            {
                MessageBox.Show("Please Select your pak folder in settings!");
            }
        }

        private static byte[] Body = new byte[]
        {
            47,
            71,
            97,
            109,
            101,
            47,
            67,
            104,
            97,
            114,
            97,
            99,
            116,
            101,
            114,
            115,
            47,
            80,
            108,
            97,
            121,
            101,
            114,
            47,
            77,
            97,
            108,
            101,
            47,
            77,
            101,
            100,
            105,
            117,
            109,
            47,
            66,
            111,
            100,
            105,
            101,
            115,
            47,
            77,
            95,
            77,
            101,
            100,
            95,
            83,
            111,
            108,
            100,
            105,
            101,
            114,
            95,
            48,
            52,
            47,
            83,
            107,
            105,
            110,
            115,
            47,
            66,
            82,
            95,
            52,
            51,
            47,
            77,
            97,
            116,
            101,
            114,
            105,
            97,
            108,
            115,
            47,
            77,
            95,
            77,
            101,
            100,
            95,
            83,
            111,
            108,
            100,
            105,
            101,
            114,
            95,
            48,
            52,
            95,
            66,
            82,
            48,
            52,
            51,
            46,
            77,
            95,
            77,
            101,
            100,
            95,
            83,
            111,
            108,
            100,
            105,
            101,
            114,
            95,
            48,
            52,
            95,
            66,
            82,
            48,
            52,
            51
        };

        // Token: 0x04000588 RID: 1416
        private static byte[] Body1 = new byte[]
        {
            47,
            71,
            97,
            109,
            101,
            47,
            67,
            104,
            97,
            114,
            97,
            99,
            116,
            101,
            114,
            115,
            47,
            80,
            108,
            97,
            121,
            101,
            114,
            47,
            77,
            97,
            108,
            101,
            47,
            77,
            101,
            100,
            105,
            117,
            109,
            47,
            66,
            111,
            100,
            105,
            101,
            115,
            47,
            77,
            95,
            77,
            101,
            100,
            95,
            83,
            111,
            108,
            100,
            105,
            101,
            114,
            95,
            48,
            52,
            47,
            83,
            107,
            105,
            110,
            115,
            47,
            66,
            82,
            95,
            69,
            108,
            102,
            47,
            77,
            97,
            116,
            101,
            114,
            105,
            97,
            108,
            115,
            47,
            77,
            95,
            77,
            101,
            100,
            95,
            83,
            111,
            108,
            100,
            105,
            101,
            114,
            95,
            69,
            108,
            102,
            46,
            77,
            95,
            77,
            101,
            100,
            95,
            83,
            111,
            108,
            100,
            105,
            101,
            114,
            95,
            69,
            108,
            102,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };

        // Token: 0x04000589 RID: 1417
        private static byte[] Hat = new byte[]
        {
            47,
            71,
            97,
            109,
            101,
            47,
            65,
            99,
            99,
            101,
            115,
            115,
            111,
            114,
            105,
            101,
            115,
            47,
            72,
            97,
            116,
            115,
            47,
            77,
            101,
            115,
            104,
            47,
            77,
            97,
            108,
            101,
            95,
            67,
            111,
            109,
            109,
            97,
            110,
            100,
            111,
            95,
            72,
            101,
            108,
            109,
            101,
            116,
            95,
            66,
            82,
            48,
            52,
            51,
            46,
            77,
            97,
            108,
            101,
            95,
            67,
            111,
            109,
            109,
            97,
            110,
            100,
            111,
            95,
            72,
            101,
            108,
            109,
            101,
            116,
            95,
            66,
            82,
            48,
            52,
            51
        };

        // Token: 0x0400058A RID: 1418
        private static byte[] Hat1 = new byte[]
        {
            47,
            71,
            97,
            109,
            101,
            47,
            65,
            99,
            99,
            101,
            115,
            115,
            111,
            114,
            105,
            101,
            115,
            47,
            72,
            97,
            116,
            115,
            47,
            77,
            101,
            115,
            104,
            47,
            77,
            97,
            108,
            101,
            95,
            67,
            111,
            109,
            109,
            97,
            110,
            100,
            111,
            95,
            69,
            108,
            102,
            46,
            77,
            97,
            108,
            101,
            95,
            67,
            111,
            109,
            109,
            97,
            110,
            100,
            111,
            95,
            69,
            108,
            102,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };       
    }
}
    

