namespace DriveIT
{
    partial class frmNalogZaPopravak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNalogZaPopravak));
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.lblKreirajnalog = new MetroFramework.Controls.MetroLabel();
            this.lblVozilo = new MetroFramework.Controls.MetroLabel();
            this.lblKorisnik = new MetroFramework.Controls.MetroLabel();
            this.txtVozilo = new MetroFramework.Controls.MetroTextBox();
            this.lblOpis = new MetroFramework.Controls.MetroLabel();
            this.btnKreirajNalog = new MetroFramework.Controls.MetroButton();
            this.btnOdustani = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbKorisnik = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOpis
            // 
            this.txtOpis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOpis.Location = new System.Drawing.Point(129, 304);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(377, 158);
            this.txtOpis.TabIndex = 3;
            this.txtOpis.Text = "";
            // 
            // lblKreirajnalog
            // 
            this.lblKreirajnalog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKreirajnalog.AutoSize = true;
            this.lblKreirajnalog.CustomBackground = true;
            this.lblKreirajnalog.CustomForeColor = false;
            this.lblKreirajnalog.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblKreirajnalog.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblKreirajnalog.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblKreirajnalog.Location = new System.Drawing.Point(374, 34);
            this.lblKreirajnalog.Name = "lblKreirajnalog";
            this.lblKreirajnalog.Size = new System.Drawing.Size(156, 25);
            this.lblKreirajnalog.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblKreirajnalog.StyleManager = null;
            this.lblKreirajnalog.TabIndex = 9;
            this.lblKreirajnalog.Text = "Napravi novi nalog";
            this.lblKreirajnalog.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblKreirajnalog.UseStyleColors = false;
            // 
            // lblVozilo
            // 
            this.lblVozilo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVozilo.AutoSize = true;
            this.lblVozilo.CustomBackground = true;
            this.lblVozilo.CustomForeColor = false;
            this.lblVozilo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblVozilo.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblVozilo.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblVozilo.Location = new System.Drawing.Point(127, 133);
            this.lblVozilo.Name = "lblVozilo";
            this.lblVozilo.Size = new System.Drawing.Size(93, 25);
            this.lblVozilo.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblVozilo.StyleManager = null;
            this.lblVozilo.TabIndex = 10;
            this.lblVozilo.Text = "Šifra vozila";
            this.lblVozilo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblVozilo.UseStyleColors = false;
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.CustomBackground = true;
            this.lblKorisnik.CustomForeColor = false;
            this.lblKorisnik.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblKorisnik.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblKorisnik.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblKorisnik.Location = new System.Drawing.Point(150, 207);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(70, 25);
            this.lblKorisnik.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblKorisnik.StyleManager = null;
            this.lblKorisnik.TabIndex = 12;
            this.lblKorisnik.Text = "Korisnik";
            this.lblKorisnik.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblKorisnik.UseStyleColors = false;
            // 
            // txtVozilo
            // 
            this.txtVozilo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVozilo.CustomBackground = false;
            this.txtVozilo.CustomForeColor = false;
            this.txtVozilo.Enabled = false;
            this.txtVozilo.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtVozilo.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtVozilo.Location = new System.Drawing.Point(226, 135);
            this.txtVozilo.Multiline = false;
            this.txtVozilo.Name = "txtVozilo";
            this.txtVozilo.SelectedText = "";
            this.txtVozilo.Size = new System.Drawing.Size(280, 23);
            this.txtVozilo.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVozilo.StyleManager = null;
            this.txtVozilo.TabIndex = 13;
            this.txtVozilo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVozilo.UseStyleColors = false;
            // 
            // lblOpis
            // 
            this.lblOpis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOpis.AutoSize = true;
            this.lblOpis.CustomBackground = true;
            this.lblOpis.CustomForeColor = false;
            this.lblOpis.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblOpis.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblOpis.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblOpis.Location = new System.Drawing.Point(268, 276);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(92, 25);
            this.lblOpis.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblOpis.StyleManager = null;
            this.lblOpis.TabIndex = 14;
            this.lblOpis.Text = "Opis kvara";
            this.lblOpis.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblOpis.UseStyleColors = false;
            // 
            // btnKreirajNalog
            // 
            this.btnKreirajNalog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKreirajNalog.Highlight = false;
            this.btnKreirajNalog.Location = new System.Drawing.Point(563, 245);
            this.btnKreirajNalog.Name = "btnKreirajNalog";
            this.btnKreirajNalog.Size = new System.Drawing.Size(280, 80);
            this.btnKreirajNalog.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnKreirajNalog.StyleManager = null;
            this.btnKreirajNalog.TabIndex = 15;
            this.btnKreirajNalog.Text = "Kreiraj nalog";
            this.btnKreirajNalog.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnKreirajNalog.Click += new System.EventHandler(this.btnKreirajNalog_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.Highlight = false;
            this.btnOdustani.Location = new System.Drawing.Point(563, 382);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(280, 80);
            this.btnOdustani.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnOdustani.StyleManager = null;
            this.btnOdustani.TabIndex = 16;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 575);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // cbKorisnik
            // 
            this.cbKorisnik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKorisnik.BackColor = System.Drawing.Color.Gainsboro;
            this.cbKorisnik.FormattingEnabled = true;
            this.cbKorisnik.Location = new System.Drawing.Point(226, 211);
            this.cbKorisnik.Name = "cbKorisnik";
            this.cbKorisnik.Size = new System.Drawing.Size(280, 21);
            this.cbKorisnik.TabIndex = 18;
            // 
            // frmNalogZaPopravak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.cbKorisnik);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnKreirajNalog);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.txtVozilo);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.lblVozilo);
            this.Controls.Add(this.lblKreirajnalog);
            this.Controls.Add(this.txtOpis);
            this.Name = "frmNalogZaPopravak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreiraj nalog";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtOpis;
        private MetroFramework.Controls.MetroLabel lblKreirajnalog;
        private MetroFramework.Controls.MetroLabel lblVozilo;
        private MetroFramework.Controls.MetroLabel lblKorisnik;
        private MetroFramework.Controls.MetroTextBox txtVozilo;
        private MetroFramework.Controls.MetroLabel lblOpis;
        private MetroFramework.Controls.MetroButton btnKreirajNalog;
        private MetroFramework.Controls.MetroButton btnOdustani;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbKorisnik;
    }
}