namespace DriveIT
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.lblKorisnickoIme = new MetroFramework.Controls.MetroLabel();
            this.txtKorisnickoIme = new MetroFramework.Controls.MetroTextBox();
            this.lblLozinka = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lozinka = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Highlight = false;
            this.btnLogin.Location = new System.Drawing.Point(70, 401);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(207, 55);
            this.btnLogin.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnLogin.StyleManager = null;
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.CustomBackground = true;
            this.lblKorisnickoIme.CustomForeColor = false;
            this.lblKorisnickoIme.Enabled = false;
            this.lblKorisnickoIme.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblKorisnickoIme.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblKorisnickoIme.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(131, 160);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(93, 19);
            this.lblKorisnickoIme.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblKorisnickoIme.StyleManager = null;
            this.lblKorisnickoIme.TabIndex = 2;
            this.lblKorisnickoIme.Text = "Korisničko ime";
            this.lblKorisnickoIme.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblKorisnickoIme.UseStyleColors = false;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.CustomBackground = false;
            this.txtKorisnickoIme.CustomForeColor = false;
            this.txtKorisnickoIme.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtKorisnickoIme.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtKorisnickoIme.Location = new System.Drawing.Point(70, 182);
            this.txtKorisnickoIme.Multiline = false;
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.SelectedText = "";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(207, 30);
            this.txtKorisnickoIme.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKorisnickoIme.StyleManager = null;
            this.txtKorisnickoIme.TabIndex = 1;
            this.txtKorisnickoIme.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKorisnickoIme.UseStyleColors = false;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.BackColor = System.Drawing.SystemColors.Control;
            this.lblLozinka.CustomBackground = true;
            this.lblLozinka.CustomForeColor = false;
            this.lblLozinka.Enabled = false;
            this.lblLozinka.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblLozinka.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblLozinka.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblLozinka.Location = new System.Drawing.Point(145, 233);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(52, 19);
            this.lblLozinka.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblLozinka.StyleManager = null;
            this.lblLozinka.TabIndex = 100;
            this.lblLozinka.Text = "Lozinka";
            this.lblLozinka.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblLozinka.UseStyleColors = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 104);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Lozinka
            // 
            this.Lozinka.BackColor = System.Drawing.SystemColors.Menu;
            this.Lozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lozinka.Location = new System.Drawing.Point(70, 270);
            this.Lozinka.Name = "Lozinka";
            this.Lozinka.Size = new System.Drawing.Size(207, 30);
            this.Lozinka.TabIndex = 2;
            this.Lozinka.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Lozinka_KeyDown);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 511);
            this.Controls.Add(this.Lozinka);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.btnLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.frmDriveIT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroLabel lblKorisnickoIme;
        private MetroFramework.Controls.MetroTextBox txtKorisnickoIme;
        private MetroFramework.Controls.MetroLabel lblLozinka;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Lozinka;
    }
}

