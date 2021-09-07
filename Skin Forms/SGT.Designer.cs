namespace Skin_Swapper__Sorry_
{
    partial class SGT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SGT));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtsgt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroButton1.Location = new System.Drawing.Point(7, 41);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(94, 23);
            this.metroButton1.TabIndex = 20;
            this.metroButton1.Text = "Swap";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(184, 41);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(94, 23);
            this.metroButton2.TabIndex = 21;
            this.metroButton2.Text = "Revert";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.MetroButton2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 18);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(136, 19);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "SGT Winter - Director";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseStyleColors = true;
            // 
            // txtsgt
            // 
            // 
            // 
            // 
            this.txtsgt.CustomButton.Image = null;
            this.txtsgt.CustomButton.Location = new System.Drawing.Point(189, 2);
            this.txtsgt.CustomButton.Name = "";
            this.txtsgt.CustomButton.Size = new System.Drawing.Size(79, 79);
            this.txtsgt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtsgt.CustomButton.TabIndex = 1;
            this.txtsgt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtsgt.CustomButton.UseSelectable = true;
            this.txtsgt.CustomButton.Visible = false;
            this.txtsgt.Lines = new string[0];
            this.txtsgt.Location = new System.Drawing.Point(7, 70);
            this.txtsgt.MaxLength = 32767;
            this.txtsgt.Name = "txtsgt";
            this.txtsgt.PasswordChar = '\0';
            this.txtsgt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsgt.SelectedText = "";
            this.txtsgt.SelectionLength = 0;
            this.txtsgt.SelectionStart = 0;
            this.txtsgt.ShortcutsEnabled = true;
            this.txtsgt.Size = new System.Drawing.Size(271, 84);
            this.txtsgt.TabIndex = 44;
            this.txtsgt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtsgt.UseSelectable = true;
            this.txtsgt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtsgt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 155);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(271, 38);
            this.metroLabel1.TabIndex = 43;
            this.metroLabel1.Text = "Please Make Sure Have Right Config Settings\r\nBecause That Could Cause Some Issues" +
    "";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SGT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 194);
            this.Controls.Add(this.txtsgt);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(285, 194);
            this.MinimumSize = new System.Drawing.Size(285, 194);
            this.Name = "SGT";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.SGT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtsgt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}