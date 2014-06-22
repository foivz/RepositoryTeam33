namespace DriveIT
{
    partial class DioDodaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DioDodaj));
            this.addBtn = new MetroFramework.Controls.MetroButton();
            this.txtNaziv = new MetroFramework.Controls.MetroTextBox();
            this.lblKorisnickoIme = new MetroFramework.Controls.MetroLabel();
            this.txtOpis = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtKolicina = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCijena = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOdustani = new MetroFramework.Controls.MetroButton();
            this.lblDodajDio = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addBtn.Highlight = false;
            this.addBtn.Location = new System.Drawing.Point(124, 454);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(280, 80);
            this.addBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.addBtn.StyleManager = null;
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Dodaj novi dio";
            this.addBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNaziv.CustomBackground = false;
            this.txtNaziv.CustomForeColor = false;
            this.txtNaziv.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNaziv.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtNaziv.Location = new System.Drawing.Point(368, 145);
            this.txtNaziv.Multiline = false;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.SelectedText = "";
            this.txtNaziv.Size = new System.Drawing.Size(207, 30);
            this.txtNaziv.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNaziv.StyleManager = null;
            this.txtNaziv.TabIndex = 8;
            this.txtNaziv.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNaziv.UseStyleColors = false;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.CustomBackground = true;
            this.lblKorisnickoIme.CustomForeColor = false;
            this.lblKorisnickoIme.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblKorisnickoIme.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblKorisnickoIme.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(308, 150);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(54, 25);
            this.lblKorisnickoIme.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblKorisnickoIme.StyleManager = null;
            this.lblKorisnickoIme.TabIndex = 7;
            this.lblKorisnickoIme.Text = "Naziv";
            this.lblKorisnickoIme.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblKorisnickoIme.UseStyleColors = false;
            // 
            // txtOpis
            // 
            this.txtOpis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOpis.CustomBackground = false;
            this.txtOpis.CustomForeColor = false;
            this.txtOpis.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtOpis.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtOpis.Location = new System.Drawing.Point(368, 209);
            this.txtOpis.Multiline = false;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.SelectedText = "";
            this.txtOpis.Size = new System.Drawing.Size(207, 30);
            this.txtOpis.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOpis.StyleManager = null;
            this.txtOpis.TabIndex = 10;
            this.txtOpis.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOpis.UseStyleColors = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(315, 214);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Opis";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKolicina.CustomBackground = false;
            this.txtKolicina.CustomForeColor = false;
            this.txtKolicina.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtKolicina.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtKolicina.Location = new System.Drawing.Point(368, 279);
            this.txtKolicina.Multiline = false;
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.SelectedText = "";
            this.txtKolicina.Size = new System.Drawing.Size(207, 30);
            this.txtKolicina.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKolicina.StyleManager = null;
            this.txtKolicina.TabIndex = 12;
            this.txtKolicina.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKolicina.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(292, 284);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Količina";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // txtCijena
            // 
            this.txtCijena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCijena.CustomBackground = false;
            this.txtCijena.CustomForeColor = false;
            this.txtCijena.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCijena.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtCijena.Location = new System.Drawing.Point(368, 348);
            this.txtCijena.Multiline = false;
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.SelectedText = "";
            this.txtCijena.Size = new System.Drawing.Size(207, 30);
            this.txtCijena.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCijena.StyleManager = null;
            this.txtCijena.TabIndex = 14;
            this.txtCijena.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCijena.UseStyleColors = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = false;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel3.Location = new System.Drawing.Point(303, 353);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.StyleManager = null;
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Cijena";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = false;
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
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOdustani.Highlight = false;
            this.btnOdustani.Location = new System.Drawing.Point(526, 454);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(280, 80);
            this.btnOdustani.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnOdustani.StyleManager = null;
            this.btnOdustani.TabIndex = 16;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // lblDodajDio
            // 
            this.lblDodajDio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDodajDio.AutoSize = true;
            this.lblDodajDio.CustomBackground = true;
            this.lblDodajDio.CustomForeColor = false;
            this.lblDodajDio.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDodajDio.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDodajDio.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDodajDio.Location = new System.Drawing.Point(391, 42);
            this.lblDodajDio.Name = "lblDodajDio";
            this.lblDodajDio.Size = new System.Drawing.Size(123, 25);
            this.lblDodajDio.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDodajDio.StyleManager = null;
            this.lblDodajDio.TabIndex = 17;
            this.lblDodajDio.Text = "Dodaj novi dio";
            this.lblDodajDio.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDodajDio.UseStyleColors = false;
            // 
            // DioDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.lblDodajDio);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.addBtn);
            this.Name = "DioDodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj dio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton addBtn;
        private MetroFramework.Controls.MetroTextBox txtNaziv;
        private MetroFramework.Controls.MetroLabel lblKorisnickoIme;
        private MetroFramework.Controls.MetroTextBox txtOpis;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtKolicina;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtCijena;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnOdustani;
        private MetroFramework.Controls.MetroLabel lblDodajDio;
    }
}