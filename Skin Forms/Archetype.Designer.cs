namespace Skin_Swapper__Sorry_.Skin_Forms
{
    partial class Archetype
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
            this.txtbreak = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txtbreak
            // 
            // 
            // 
            // 
            this.txtbreak.CustomButton.Image = null;
            this.txtbreak.CustomButton.Location = new System.Drawing.Point(189, 2);
            this.txtbreak.CustomButton.Name = "";
            this.txtbreak.CustomButton.Size = new System.Drawing.Size(79, 79);
            this.txtbreak.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbreak.CustomButton.TabIndex = 1;
            this.txtbreak.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbreak.CustomButton.UseSelectable = true;
            this.txtbreak.CustomButton.Visible = false;
            this.txtbreak.Lines = new string[0];
            this.txtbreak.Location = new System.Drawing.Point(7, 61);
            this.txtbreak.MaxLength = 32767;
            this.txtbreak.Name = "txtbreak";
            this.txtbreak.PasswordChar = '\0';
            this.txtbreak.ReadOnly = true;
            this.txtbreak.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbreak.SelectedText = "";
            this.txtbreak.SelectionLength = 0;
            this.txtbreak.SelectionStart = 0;
            this.txtbreak.ShortcutsEnabled = true;
            this.txtbreak.Size = new System.Drawing.Size(271, 84);
            this.txtbreak.TabIndex = 45;
            this.txtbreak.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtbreak.UseSelectable = true;
            this.txtbreak.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbreak.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 11);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(131, 19);
            this.metroLabel3.TabIndex = 44;
            this.metroLabel3.Text = "Enforcer - Archetype";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(184, 34);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(94, 23);
            this.metroButton2.TabIndex = 43;
            this.metroButton2.Text = "Revert";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.MetroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroButton1.Location = new System.Drawing.Point(7, 34);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(94, 23);
            this.metroButton1.TabIndex = 42;
            this.metroButton1.Text = "Swap";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 146);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(271, 38);
            this.metroLabel1.TabIndex = 41;
            this.metroLabel1.Text = "Please Make Sure Have Right Config Settings\r\nBecause That Could Cause Some Issues" +
    "";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Archetype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 194);
            this.Controls.Add(this.txtbreak);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Archetype";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtbreak;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}