namespace Skin_Swapper__Sorry_
{
    partial class Elf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Elf));
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtelf = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(9, 17);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(183, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Rogue Agent - Codename Elf";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(186, 39);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(94, 23);
            this.metroButton2.TabIndex = 17;
            this.metroButton2.Text = "Revert";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.MetroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroButton1.Location = new System.Drawing.Point(9, 39);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(94, 23);
            this.metroButton1.TabIndex = 16;
            this.metroButton1.Text = "Swap";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // txtelf
            // 
            // 
            // 
            // 
            this.txtelf.CustomButton.Image = null;
            this.txtelf.CustomButton.Location = new System.Drawing.Point(189, 2);
            this.txtelf.CustomButton.Name = "";
            this.txtelf.CustomButton.Size = new System.Drawing.Size(79, 79);
            this.txtelf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtelf.CustomButton.TabIndex = 1;
            this.txtelf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtelf.CustomButton.UseSelectable = true;
            this.txtelf.CustomButton.Visible = false;
            this.txtelf.Lines = new string[0];
            this.txtelf.Location = new System.Drawing.Point(7, 69);
            this.txtelf.MaxLength = 32767;
            this.txtelf.Name = "txtelf";
            this.txtelf.PasswordChar = '\0';
            this.txtelf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtelf.SelectedText = "";
            this.txtelf.SelectionLength = 0;
            this.txtelf.SelectionStart = 0;
            this.txtelf.ShortcutsEnabled = true;
            this.txtelf.Size = new System.Drawing.Size(271, 84);
            this.txtelf.TabIndex = 42;
            this.txtelf.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtelf.UseSelectable = true;
            this.txtelf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtelf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 154);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(271, 38);
            this.metroLabel1.TabIndex = 41;
            this.metroLabel1.Text = "Please Make Sure Have Right Config Settings\r\nBecause That Could Cause Some Issues" +
    "";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Elf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 194);
            this.Controls.Add(this.txtelf);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(285, 194);
            this.MinimumSize = new System.Drawing.Size(285, 194);
            this.Name = "Elf";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Elf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtelf;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}