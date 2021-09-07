﻿using MetroFramework.Forms;
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

namespace Skin_Swapper__Sorry_
{
    public partial class Ikonik : MetroForm
    {
        public Ikonik()
        {
            InitializeComponent();
        }

        private void Ikonik_Load(object sender, EventArgs e)
        {

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

        private static byte[] bodymeshikonik1 = new byte[122]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 070, 095, 077, 069, 068, 095, 082, 101, 100, 082, 105, 100, 105, 110, 103, 047, 077, 101, 115, 104, 047, 070, 095, 077, 069, 068, 095, 082, 101, 100, 082, 105, 100, 105, 110, 103, 046, 070, 095, 077, 069, 068, 095, 082, 101, 100, 082, 105, 100, 105, 110, 103, 095, 082, 101, 100, 082, 105, 100, 105, 110, 103, 072, 111, 111, 100, 095, 080, 114, 111, 116, 111, 095, 077, 069, 083, 072
        };

        private static byte[] bodymeshikonik2 = new byte[122]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 077, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 077, 095, 077, 069, 068, 095, 075, 112, 111, 112, 070, 097, 115, 104, 105, 111, 110, 047, 077, 101, 115, 104, 101, 115, 047, 077, 095, 077, 069, 068, 095, 075, 112, 111, 112, 095, 070, 097, 115, 104, 105, 111, 110, 046, 077, 095, 077, 069, 068, 095, 075, 112, 111, 112, 095, 070, 097, 115, 104, 105, 111, 110, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        private static byte[] meshskel1 = new byte[175]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 070, 095, 077, 069, 068, 095, 082, 101, 100, 082, 105, 100, 105, 110, 103, 047, 077, 101, 115, 104, 047, 070, 095, 077, 069, 068, 095, 082, 101, 100, 082, 105, 100, 105, 110, 103, 095, 082, 101, 100, 082, 105, 100, 105, 110, 103, 072, 111, 111, 100, 095, 080, 114, 111, 116, 111, 095, 077, 069, 083, 072, 095, 083, 107, 101, 108, 101, 116, 111, 110, 095, 065, 066, 080, 046, 070, 095, 077, 069, 068, 095, 082, 101, 100, 082, 105, 100, 105, 110, 103, 095, 082, 101, 100, 082, 105, 100, 105, 110, 103, 072, 111, 111, 100, 095, 080, 114, 111, 116, 111, 095, 077, 069, 083, 072, 095, 083, 107, 101, 108, 101, 116, 111, 110, 095, 065, 066, 080, 095, 067
        };

        private static byte[] meshskel2 = new byte[175]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 077, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 077, 095, 077, 069, 068, 095, 075, 112, 111, 112, 070, 097, 115, 104, 105, 111, 110, 047, 077, 101, 115, 104, 101, 115, 047, 077, 095, 077, 069, 068, 095, 075, 112, 111, 112, 095, 070, 097, 115, 104, 105, 111, 110, 065, 110, 105, 109, 066, 080, 046, 077, 095, 077, 069, 068, 095, 075, 112, 111, 112, 095, 070, 097, 115, 104, 105, 111, 110, 065, 110, 105, 109, 066, 080, 095, 067, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        private static byte[] baseskel1 = new byte[94]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 097, 115, 101, 047, 083, 075, 095, 077, 095, 070, 101, 109, 097, 108, 101, 095, 066, 097, 115, 101, 095, 083, 107, 101, 108, 101, 116, 111, 110, 046, 083, 075, 095, 077, 095, 070, 101, 109, 097, 108, 101, 095, 066, 097, 115, 101, 095, 083, 107, 101, 108, 101, 116, 111, 110
        };

        private static byte[] baseskel2 = new byte[94]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 077, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 097, 115, 101, 047, 083, 075, 095, 077, 095, 077, 097, 108, 101, 095, 066, 097, 115, 101, 095, 083, 107, 101, 108, 101, 116, 111, 110, 046, 083, 075, 095, 077, 095, 077, 097, 108, 101, 095, 066, 097, 115, 101, 095, 083, 107, 101, 108, 101, 116, 111, 110, 000, 000, 000, 000, 000, 000
        };

        private static byte[] headmatikonik1 = new byte[144]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 070, 095, 077, 069, 068, 095, 082, 101, 100, 082, 105, 100, 105, 110, 103, 047, 077, 097, 116, 101, 114, 105, 097, 108, 115, 047, 070, 095, 077, 069, 068, 095, 065, 083, 078, 095, 083, 116, 097, 114, 102, 105, 115, 104, 095, 072, 101, 097, 100, 095, 048, 049, 095, 082, 101, 100, 082, 105, 100, 105, 110, 103, 046, 070, 095, 077, 069, 068, 095, 065, 083, 078, 095, 083, 116, 097, 114, 102, 105, 115, 104, 095, 072, 101, 097, 100, 095, 048, 049, 095, 082, 101, 100, 082, 105, 100, 105, 110, 103
        };

        private static byte[] headmatikonik2 = new byte[144]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 077, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 072, 101, 097, 100, 115, 047, 077, 095, 077, 069, 068, 095, 065, 083, 078, 095, 074, 097, 101, 095, 072, 101, 097, 100, 095, 048, 049, 047, 077, 097, 116, 101, 114, 105, 097, 108, 115, 047, 077, 095, 077, 069, 068, 095, 065, 083, 078, 095, 074, 097, 101, 095, 072, 097, 105, 114, 095, 078, 111, 072, 097, 105, 114, 046, 077, 095, 077, 069, 068, 095, 065, 083, 078, 095, 074, 097, 101, 095, 072, 097, 105, 114, 095, 078, 111, 072, 097, 105, 114, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        private static byte[] bodymeshmat1 = new byte[118]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 070, 095, 077, 069, 068, 095, 082, 101, 100, 082, 105, 100, 105, 110, 103, 047, 077, 097, 116, 101, 114, 105, 097, 108, 115, 047, 077, 073, 095, 070, 095, 077, 069, 068, 095, 082, 101, 100, 082, 105, 100, 105, 110, 103, 095, 072, 101, 097, 100, 046, 077, 073, 095, 070, 095, 077, 069, 068, 095, 082, 101, 100, 082, 105, 100, 105, 110, 103, 095, 072, 101, 097, 100
        };

        private static byte[] bodymeshmat2 = new byte[118]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 070, 095, 077, 069, 068, 095, 082, 101, 100, 082, 105, 100, 105, 110, 103, 047, 077, 097, 116, 101, 114, 105, 097, 108, 115, 047, 077, 073, 095, 070, 095, 077, 069, 068, 095, 082, 101, 100, 082, 105, 100, 105, 110, 103, 095, 072, 101, 097, 049, 046, 077, 073, 095, 070, 095, 077, 069, 068, 095, 082, 101, 100, 082, 105, 100, 105, 110, 103, 095, 072, 101, 097, 049
        };

        private static byte[] headmeshikonik1 = new byte[131]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 072, 101, 097, 100, 115, 047, 070, 095, 077, 069, 068, 095, 065, 083, 078, 095, 083, 116, 097, 114, 102, 105, 115, 104, 095, 072, 101, 097, 100, 095, 048, 049, 047, 077, 101, 115, 104, 101, 115, 047, 070, 095, 077, 069, 068, 095, 065, 083, 078, 095, 083, 116, 097, 114, 102, 105, 115, 104, 095, 072, 101, 097, 100, 095, 048, 049, 046, 070, 095, 077, 069, 068, 095, 065, 083, 078, 095, 083, 116, 097, 114, 102, 105, 115, 104, 095, 072, 101, 097, 100, 095, 048, 040
        };

        private static byte[] headmeshikonik2 = new byte[131]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 077, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 072, 101, 097, 100, 115, 047, 077, 095, 077, 069, 068, 095, 065, 083, 078, 095, 074, 097, 101, 095, 072, 101, 097, 100, 095, 048, 049, 047, 077, 101, 115, 104, 047, 077, 095, 077, 069, 068, 095, 065, 083, 078, 095, 074, 097, 101, 095, 072, 101, 097, 100, 095, 048, 049, 046, 077, 095, 077, 069, 068, 095, 065, 083, 078, 095, 074, 097, 101, 095, 072, 101, 097, 100, 095, 048, 049, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        private static byte[] IkonikAnimBP1 = new byte[159]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 072, 101, 097, 100, 115, 047, 070, 095, 077, 069, 068, 095, 065, 083, 078, 095, 083, 116, 097, 114, 102, 105, 115, 104, 095, 072, 101, 097, 100, 095, 048, 049, 047, 077, 101, 115, 104, 101, 115, 047, 070, 095, 077, 069, 068, 095, 065, 083, 078, 095, 083, 116, 097, 114, 102, 105, 115, 104, 095, 072, 101, 097, 100, 095, 048, 049, 095, 065, 110, 105, 109, 066, 080, 095, 067, 104, 105, 108, 100, 046, 070, 095, 077, 069, 068, 095, 065, 083, 078, 095, 083, 116, 097, 114, 102, 105, 115, 104, 095, 072, 101, 097, 100, 095, 048, 049, 095, 065, 110, 105, 109, 066, 080, 095, 067, 104, 105, 108, 100, 095, 067
        };

        private static byte[] IkonikAnimBP2 = new byte[159]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 077, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 072, 101, 097, 100, 115, 047, 077, 095, 077, 069, 068, 095, 065, 083, 078, 095, 074, 097, 101, 095, 072, 101, 097, 100, 095, 048, 049, 047, 077, 101, 115, 104, 047, 077, 095, 077, 069, 068, 095, 065, 083, 078, 095, 074, 097, 101, 095, 072, 101, 097, 100, 095, 048, 049, 095, 065, 110, 105, 109, 066, 080, 095, 067, 104, 105, 108, 100, 046, 077, 095, 077, 069, 068, 095, 065, 083, 078, 095, 074, 097, 101, 095, 072, 101, 097, 100, 095, 048, 049, 095, 065, 110, 105, 109, 066, 080, 095, 067, 104, 105, 108, 100, 095, 067, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        private static byte[] IkonikEyelash1 = new byte[176]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 070, 095, 077, 069, 068, 095, 082, 101, 100, 082, 105, 100, 105, 110, 103, 047, 077, 101, 115, 104, 047, 070, 101, 109, 097, 108, 101, 095, 077, 101, 100, 105, 117, 109, 095, 083, 116, 097, 114, 102, 105, 115, 104, 095, 072, 101, 097, 100, 095, 048, 049, 095, 069, 121, 101, 108, 097, 115, 104, 101, 115, 095, 069, 120, 112, 111, 114, 116, 046, 070, 101, 109, 097, 108, 101, 095, 077, 101, 100, 105, 117, 109, 095, 083, 116, 097, 114, 102, 105, 115, 104, 095, 072, 101, 097, 100, 095, 048, 049, 095, 069, 121, 101, 108, 097, 115, 104, 101, 115, 095, 069, 120, 112, 111, 114, 116, 095, 069, 089, 069, 076, 065, 083, 072, 069, 083, 095, 077, 069, 083, 072
        };

        private static byte[] IkonikEyelash2 = new byte[176]
        {
            047, 071, 097, 109, 101, 047, 065, 099, 099, 101, 115, 115, 111, 114, 105, 101, 115, 047, 072, 097, 116, 115, 047, 077, 095, 077, 069, 068, 095, 075, 112, 111, 112, 095, 070, 097, 115, 104, 105, 111, 110, 095, 072, 097, 116, 047, 077, 101, 115, 104, 101, 115, 047, 077, 095, 077, 069, 068, 095, 075, 112, 111, 112, 095, 070, 097, 115, 104, 105, 111, 110, 095, 070, 097, 099, 101, 065, 099, 099, 046, 077, 095, 077, 069, 068, 095, 075, 112, 111, 112, 095, 070, 097, 115, 104, 105, 111, 110, 095, 070, 097, 099, 101, 065, 099, 099, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        private static byte[] ikonikskel1 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 067, 104, 097, 114, 097, 099, 116, 101, 114, 115, 047, 080, 108, 097, 121, 101, 114, 047, 070, 101, 109, 097, 108, 101, 047, 077, 101, 100, 105, 117, 109, 047, 066, 111, 100, 105, 101, 115, 047, 070, 095, 077, 069, 068, 095, 082, 101, 100, 082, 105, 100, 105, 110, 103, 047, 077, 101, 115, 104, 047, 070, 101, 109, 097, 108, 101, 095, 077, 101, 100, 105, 117, 109, 095, 083, 116, 097, 114, 102, 105, 115, 104, 095, 072, 101, 097, 100, 095, 048, 049, 095, 108, 097, 115, 104, 101, 095, 083, 107, 101, 108, 101, 116, 111, 110, 095, 065, 066, 080, 046, 070, 101, 109, 097, 108, 101, 095, 077, 101, 100, 105, 117, 109, 095, 083, 116, 097, 114, 102, 105, 115, 104, 095, 072, 101, 097, 100, 095, 048, 049, 095, 108, 097, 115, 104, 101, 095, 083, 107, 101, 108, 101, 116, 111, 110, 095, 065, 066, 080, 095, 067
        };

        private static byte[] ikonikskel2 = new byte[]
        {
            047, 071, 097, 109, 101, 047, 065, 099, 099, 101, 115, 115, 111, 114, 105, 101, 115, 047, 072, 097, 116, 115, 047, 077, 095, 077, 069, 068, 095, 075, 112, 111, 112, 095, 070, 097, 115, 104, 105, 111, 110, 095, 072, 097, 116, 047, 077, 101, 115, 104, 101, 115, 047, 077, 095, 077, 069, 068, 095, 075, 112, 111, 112, 095, 070, 097, 115, 104, 105, 111, 110, 095, 070, 097, 099, 101, 065, 099, 099, 095, 065, 110, 105, 109, 066, 080, 046, 077, 095, 077, 069, 068, 095, 075, 112, 111, 112, 095, 070, 097, 115, 104, 105, 111, 110, 095, 070, 097, 099, 101, 065, 099, 099, 095, 065, 110, 105, 109, 066, 080, 095, 067, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000, 000
        };

        private static void ReplaceByte7()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1222138447L, bodymeshikonik1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1222138706L, meshskel1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1222138254L, baseskel1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1271913190L, headmatikonik1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1271913446L, bodymeshmat1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1271913686L, headmeshikonik1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1271913952L, IkonikAnimBP1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1270845887L, IkonikEyelash1);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1270846196L, ikonikskel1);
        }

        private static void RevertByte8()
        {
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1222138447L, bodymeshikonik2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1222138706L, meshskel2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1222138254L, baseskel2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1271913190L, headmatikonik2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1271913446L, bodymeshmat2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1271913686L, headmeshikonik2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1271913952L, IkonikAnimBP2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1270845887L, IkonikEyelash2);
            ReplaceBytes(Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak", 1270846196L, ikonikskel2);
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (checkPak())
            {
                txtbunny.Text = "[LOG] " + "Skin Added Successfully";

                string path = Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak";
                if (File.Exists(path))
                {
                    RevertByte8();
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
                    ReplaceByte7();
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

        private void MetroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
