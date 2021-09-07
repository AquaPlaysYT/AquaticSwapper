using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Skin_Swapper__Sorry_.Skin_Forms;

namespace Skin_Swapper__Sorry_
{
    public partial class Ren : MetroForm
    {
        public Ren()
        {
            InitializeComponent();
        }

        private void MetroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Ren_Load(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Renegade Skin3 = new Renegade();
            Skin3.Show();
            this.Hide();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Needs fixing, will update it soon!");
        }
    }
}
