namespace DriveIT
{
    partial class frmUgovoriDodaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUgovoriDodaj));
            this.lblDodajUgovor = new MetroFramework.Controls.MetroLabel();
            this.cbKupac = new MetroFramework.Controls.MetroComboBox();
            this.cbVozilo = new MetroFramework.Controls.MetroComboBox();
            this.cbDobavljac = new MetroFramework.Controls.MetroComboBox();
            this.dtPickerDatum = new System.Windows.Forms.DateTimePicker();
            this.lblKupac = new MetroFramework.Controls.MetroLabel();
            this.lblVozilo = new MetroFramework.Controls.MetroLabel();
            this.lblDatum = new MetroFramework.Controls.MetroLabel();
            this.lblDobavljac = new MetroFramework.Controls.MetroLabel();
            this.btnNapraviKupoprodajni = new MetroFramework.Controls.MetroButton();
            this.btnOdustani = new MetroFramework.Controls.MetroButton();
            this.btnKreirajProdajni = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDodajUgovor
            // 
            this.lblDodajUgovor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDodajUgovor.AutoSize = true;
            this.lblDodajUgovor.CustomBackground = true;
            this.lblDodajUgovor.CustomForeColor = false;
            this.lblDodajUgovor.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDodajUgovor.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDodajUgovor.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDodajUgovor.Location = new System.Drawing.Point(381, 68);
            this.lblDodajUgovor.Name = "lblDodajUgovor";
            this.lblDodajUgovor.Size = new System.Drawing.Size(167, 25);
            this.lblDodajUgovor.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDodajUgovor.StyleManager = null;
            this.lblDodajUgovor.TabIndex = 39;
            this.lblDodajUgovor.Text = "Napravi novi ugovor";
            this.lblDodajUgovor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDodajUgovor.UseStyleColors = false;
            // 
            // cbKupac
            // 
            this.cbKupac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKupac.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbKupac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKupac.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.cbKupac.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.cbKupac.FormattingEnabled = true;
            this.cbKupac.ItemHeight = 23;
            this.cbKupac.Location = new System.Drawing.Point(197, 201);
            this.cbKupac.Name = "cbKupac";
            this.cbKupac.Size = new System.Drawing.Size(280, 29);
            this.cbKupac.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbKupac.StyleManager = null;
            this.cbKupac.TabIndex = 40;
            this.cbKupac.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cbVozilo
            // 
            this.cbVozilo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbVozilo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbVozilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVozilo.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.cbVozilo.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.cbVozilo.FormattingEnabled = true;
            this.cbVozilo.ItemHeight = 23;
            this.cbVozilo.Location = new System.Drawing.Point(197, 278);
            this.cbVozilo.Name = "cbVozilo";
            this.cbVozilo.Size = new System.Drawing.Size(280, 29);
            this.cbVozilo.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbVozilo.StyleManager = null;
            this.cbVozilo.TabIndex = 41;
            this.cbVozilo.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cbDobavljac
            // 
            this.cbDobavljac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDobavljac.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDobavljac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDobavljac.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.cbDobavljac.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.cbDobavljac.FormattingEnabled = true;
            this.cbDobavljac.ItemHeight = 23;
            this.cbDobavljac.Location = new System.Drawing.Point(197, 419);
            this.cbDobavljac.Name = "cbDobavljac";
            this.cbDobavljac.Size = new System.Drawing.Size(280, 29);
            this.cbDobavljac.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbDobavljac.StyleManager = null;
            this.cbDobavljac.TabIndex = 43;
            this.cbDobavljac.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // dtPickerDatum
            // 
            this.dtPickerDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPickerDatum.Location = new System.Drawing.Point(197, 356);
            this.dtPickerDatum.Name = "dtPickerDatum";
            this.dtPickerDatum.Size = new System.Drawing.Size(280, 20);
            this.dtPickerDatum.TabIndex = 44;
            // 
            // lblKupac
            // 
            this.lblKupac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKupac.AutoSize = true;
            this.lblKupac.CustomBackground = true;
            this.lblKupac.CustomForeColor = false;
            this.lblKupac.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblKupac.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblKupac.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblKupac.Location = new System.Drawing.Point(133, 205);
            this.lblKupac.Name = "lblKupac";
            this.lblKupac.Size = new System.Drawing.Size(58, 25);
            this.lblKupac.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblKupac.StyleManager = null;
            this.lblKupac.TabIndex = 45;
            this.lblKupac.Text = "Kupac";
            this.lblKupac.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblKupac.UseStyleColors = false;
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
            this.lblVozilo.Location = new System.Drawing.Point(134, 282);
            this.lblVozilo.Name = "lblVozilo";
            this.lblVozilo.Size = new System.Drawing.Size(57, 25);
            this.lblVozilo.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblVozilo.StyleManager = null;
            this.lblVozilo.TabIndex = 46;
            this.lblVozilo.Text = "Vozilo";
            this.lblVozilo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblVozilo.UseStyleColors = false;
            // 
            // lblDatum
            // 
            this.lblDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatum.AutoSize = true;
            this.lblDatum.CustomBackground = true;
            this.lblDatum.CustomForeColor = false;
            this.lblDatum.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDatum.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDatum.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDatum.Location = new System.Drawing.Point(128, 351);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(63, 25);
            this.lblDatum.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDatum.StyleManager = null;
            this.lblDatum.TabIndex = 47;
            this.lblDatum.Text = "Datum";
            this.lblDatum.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDatum.UseStyleColors = false;
            // 
            // lblDobavljac
            // 
            this.lblDobavljac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDobavljac.AutoSize = true;
            this.lblDobavljac.CustomBackground = true;
            this.lblDobavljac.CustomForeColor = false;
            this.lblDobavljac.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDobavljac.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDobavljac.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDobavljac.Location = new System.Drawing.Point(105, 423);
            this.lblDobavljac.Name = "lblDobavljac";
            this.lblDobavljac.Size = new System.Drawing.Size(86, 25);
            this.lblDobavljac.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDobavljac.StyleManager = null;
            this.lblDobavljac.TabIndex = 48;
            this.lblDobavljac.Text = "Dobavljač";
            this.lblDobavljac.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDobavljac.UseStyleColors = false;
            // 
            // btnNapraviKupoprodajni
            // 
            this.btnNapraviKupoprodajni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNapraviKupoprodajni.Highlight = false;
            this.btnNapraviKupoprodajni.Location = new System.Drawing.Point(598, 303);
            this.btnNapraviKupoprodajni.Name = "btnNapraviKupoprodajni";
            this.btnNapraviKupoprodajni.Size = new System.Drawing.Size(280, 80);
            this.btnNapraviKupoprodajni.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnNapraviKupoprodajni.StyleManager = null;
            this.btnNapraviKupoprodajni.TabIndex = 49;
            this.btnNapraviKupoprodajni.Text = "Kreiraj ugovor o kupnji";
            this.btnNapraviKupoprodajni.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnNapraviKupoprodajni.Click += new System.EventHandler(this.btnNapraviKupoprodajni_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.Highlight = false;
            this.btnOdustani.Location = new System.Drawing.Point(598, 407);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(280, 80);
            this.btnOdustani.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnOdustani.StyleManager = null;
            this.btnOdustani.TabIndex = 50;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnKreirajProdajni
            // 
            this.btnKreirajProdajni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKreirajProdajni.Highlight = false;
            this.btnKreirajProdajni.Location = new System.Drawing.Point(598, 201);
            this.btnKreirajProdajni.Name = "btnKreirajProdajni";
            this.btnKreirajProdajni.Size = new System.Drawing.Size(280, 80);
            this.btnKreirajProdajni.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnKreirajProdajni.StyleManager = null;
            this.btnKreirajProdajni.TabIndex = 51;
            this.btnKreirajProdajni.Text = "Kreiraj prodajni ugovor";
            this.btnKreirajProdajni.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnKreirajProdajni.Click += new System.EventHandler(this.btnKreirajProdajni_Click);
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
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // frmUgovoriDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 696);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKreirajProdajni);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnNapraviKupoprodajni);
            this.Controls.Add(this.lblDobavljac);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblVozilo);
            this.Controls.Add(this.lblKupac);
            this.Controls.Add(this.dtPickerDatum);
            this.Controls.Add(this.cbDobavljac);
            this.Controls.Add(this.cbVozilo);
            this.Controls.Add(this.cbKupac);
            this.Controls.Add(this.lblDodajUgovor);
            this.Name = "frmUgovoriDodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UgovoriDodaj";
            this.Load += new System.EventHandler(this.frmUgovoriDodaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblDodajUgovor;
        private MetroFramework.Controls.MetroComboBox cbKupac;
        private MetroFramework.Controls.MetroComboBox cbVozilo;
        private MetroFramework.Controls.MetroComboBox cbDobavljac;
        private System.Windows.Forms.DateTimePicker dtPickerDatum;
        private MetroFramework.Controls.MetroLabel lblKupac;
        private MetroFramework.Controls.MetroLabel lblVozilo;
        private MetroFramework.Controls.MetroLabel lblDatum;
        private MetroFramework.Controls.MetroLabel lblDobavljac;
        private MetroFramework.Controls.MetroButton btnNapraviKupoprodajni;
        private MetroFramework.Controls.MetroButton btnOdustani;
        private MetroFramework.Controls.MetroButton btnKreirajProdajni;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}