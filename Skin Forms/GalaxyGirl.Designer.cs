namespace Skin_Swapper__Sorry_
{
    partial class GalaxyGirl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GalaxyGirl));
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtbunny = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 18);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(156, 19);
            this.metroLabel3.TabIndex = 30;
            this.metroLabel3.Text = "DarkBomber - GalaxyGirl";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseStyleColors = true;
            this.metroLabel3.Click += new System.EventHandler(this.MetroLabel3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(184, 40);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(94, 23);
            this.metroButton2.TabIndex = 29;
            this.metroButton2.Text = "Revert";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.MetroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroButton1.Location = new System.Drawing.Point(7, 40);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(94, 23);
            this.metroButton1.TabIndex = 28;
            this.metroButton1.Text = "Swap";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // txtbunny
            // 
            // 
            // 
            // 
            this.txtbunny.CustomButton.Image = null;
            this.txtbunny.CustomButton.Location = new System.Drawing.Point(189, 2);
            this.txtbunny.CustomButton.Name = "";
            this.txtbunny.CustomButton.Size = new System.Drawing.Size(79, 79);
            this.txtbunny.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbunny.CustomButton.TabIndex = 1;
            this.txtbunny.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbunny.CustomButton.UseSelectable = true;
            this.txtbunny.CustomButton.Visible = false;
            this.txtbunny.Lines = new string[0];
            this.txtbunny.Location = new System.Drawing.Point(7, 69);
            this.txtbunny.MaxLength = 32767;
            this.txtbunny.Name = "txtbunny";
            this.txtbunny.PasswordChar = '\0';
            this.txtbunny.ReadOnly = true;
            this.txtbunny.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbunny.SelectedText = "";
            this.txtbunny.SelectionLength = 0;
            this.txtbunny.SelectionStart = 0;
            this.txtbunny.ShortcutsEnabled = true;
            this.txtbunny.Size = new System.Drawing.Size(271, 84);
            this.txtbunny.TabIndex = 46;
            this.txtbunny.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtbunny.UseSelectable = true;
            this.txtbunny.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbunny.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbunny.Click += new System.EventHandler(this.Txtbunny_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 154);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(271, 38);
            this.metroLabel1.TabIndex = 45;
            this.metroLabel1.Text = "Please Make Sure Have Right Config Settings\r\nBecause That Could Cause Some Issues" +
    "";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.Click += new System.EventHandler(this.MetroLabel1_Click);
            // 
            // GalaxyGirl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 194);
            this.Controls.Add(this.txtbunny);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(285, 194);
            this.MinimumSize = new System.Drawing.Size(285, 194);
            this.Name = "GalaxyGirl";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.GalaxyGirl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtbunny;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}