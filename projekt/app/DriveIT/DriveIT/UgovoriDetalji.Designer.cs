namespace DriveIT
{
    partial class frmUgovoriDetalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUgovoriDetalji));
            this.dtPickerDatum = new System.Windows.Forms.DateTimePicker();
            this.lblSifra = new MetroFramework.Controls.MetroLabel();
            this.lblKupac = new MetroFramework.Controls.MetroLabel();
            this.lblVozilo = new MetroFramework.Controls.MetroLabel();
            this.lblDobavljac = new MetroFramework.Controls.MetroLabel();
            this.lblDatum = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.txtKupac = new MetroFramework.Controls.MetroTextBox();
            this.txtVozilo = new MetroFramework.Controls.MetroTextBox();
            this.txtDobavljac = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOdustani = new MetroFramework.Controls.MetroButton();
            this.btnAzuriraj = new MetroFramework.Controls.MetroButton();
            this.btnObrisi = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPickerDatum
            // 
            this.dtPickerDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPickerDatum.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtPickerDatum.Location = new System.Drawing.Point(202, 356);
            this.dtPickerDatum.Name = "dtPickerDatum";
            this.dtPickerDatum.Size = new System.Drawing.Size(280, 20);
            this.dtPickerDatum.TabIndex = 46;
            // 
            // lblSifra
            // 
            this.lblSifra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSifra.AutoSize = true;
            this.lblSifra.CustomBackground = true;
            this.lblSifra.CustomForeColor = false;
            this.lblSifra.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSifra.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblSifra.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblSifra.Location = new System.Drawing.Point(151, 173);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(45, 25);
            this.lblSifra.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSifra.StyleManager = null;
            this.lblSifra.TabIndex = 50;
            this.lblSifra.Text = "Šifra";
            this.lblSifra.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSifra.UseStyleColors = false;
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
            this.lblKupac.Location = new System.Drawing.Point(138, 232);
            this.lblKupac.Name = "lblKupac";
            this.lblKupac.Size = new System.Drawing.Size(58, 25);
            this.lblKupac.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblKupac.StyleManager = null;
            this.lblKupac.TabIndex = 51;
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
            this.lblVozilo.Location = new System.Drawing.Point(139, 293);
            this.lblVozilo.Name = "lblVozilo";
            this.lblVozilo.Size = new System.Drawing.Size(57, 25);
            this.lblVozilo.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblVozilo.StyleManager = null;
            this.lblVozilo.TabIndex = 52;
            this.lblVozilo.Text = "Vozilo";
            this.lblVozilo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblVozilo.UseStyleColors = false;
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
            this.lblDobavljac.Location = new System.Drawing.Point(110, 413);
            this.lblDobavljac.Name = "lblDobavljac";
            this.lblDobavljac.Size = new System.Drawing.Size(86, 25);
            this.lblDobavljac.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDobavljac.StyleManager = null;
            this.lblDobavljac.TabIndex = 53;
            this.lblDobavljac.Text = "Dobavljač";
            this.lblDobavljac.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDobavljac.UseStyleColors = false;
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
            this.lblDatum.Location = new System.Drawing.Point(133, 351);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(63, 25);
            this.lblDatum.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDatum.StyleManager = null;
            this.lblDatum.TabIndex = 54;
            this.lblDatum.Text = "Datum";
            this.lblDatum.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDatum.UseStyleColors = false;
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.CustomBackground = false;
            this.txtId.CustomForeColor = false;
            this.txtId.Enabled = false;
            this.txtId.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtId.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtId.Location = new System.Drawing.Point(203, 175);
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.SelectedText = "";
            this.txtId.Size = new System.Drawing.Size(280, 23);
            this.txtId.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.StyleManager = null;
            this.txtId.TabIndex = 55;
            this.txtId.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.UseStyleColors = false;
            // 
            // txtKupac
            // 
            this.txtKupac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKupac.CustomBackground = false;
            this.txtKupac.CustomForeColor = false;
            this.txtKupac.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtKupac.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtKupac.Location = new System.Drawing.Point(202, 234);
            this.txtKupac.Multiline = false;
            this.txtKupac.Name = "txtKupac";
            this.txtKupac.SelectedText = "";
            this.txtKupac.Size = new System.Drawing.Size(280, 23);
            this.txtKupac.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKupac.StyleManager = null;
            this.txtKupac.TabIndex = 56;
            this.txtKupac.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKupac.UseStyleColors = false;
            // 
            // txtVozilo
            // 
            this.txtVozilo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVozilo.CustomBackground = false;
            this.txtVozilo.CustomForeColor = false;
            this.txtVozilo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtVozilo.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtVozilo.Location = new System.Drawing.Point(202, 295);
            this.txtVozilo.Multiline = false;
            this.txtVozilo.Name = "txtVozilo";
            this.txtVozilo.SelectedText = "";
            this.txtVozilo.Size = new System.Drawing.Size(280, 23);
            this.txtVozilo.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVozilo.StyleManager = null;
            this.txtVozilo.TabIndex = 57;
            this.txtVozilo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVozilo.UseStyleColors = false;
            // 
            // txtDobavljac
            // 
            this.txtDobavljac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDobavljac.CustomBackground = false;
            this.txtDobavljac.CustomForeColor = false;
            this.txtDobavljac.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDobavljac.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtDobavljac.Location = new System.Drawing.Point(202, 413);
            this.txtDobavljac.Multiline = false;
            this.txtDobavljac.Name = "txtDobavljac";
            this.txtDobavljac.SelectedText = "";
            this.txtDobavljac.Size = new System.Drawing.Size(280, 23);
            this.txtDobavljac.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDobavljac.StyleManager = null;
            this.txtDobavljac.TabIndex = 58;
            this.txtDobavljac.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDobavljac.UseStyleColors = false;
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
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.Highlight = false;
            this.btnOdustani.Location = new System.Drawing.Point(562, 374);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(280, 80);
            this.btnOdustani.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnOdustani.StyleManager = null;
            this.btnOdustani.TabIndex = 60;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAzuriraj.Highlight = false;
            this.btnAzuriraj.Location = new System.Drawing.Point(562, 173);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(280, 80);
            this.btnAzuriraj.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAzuriraj.StyleManager = null;
            this.btnAzuriraj.TabIndex = 61;
            this.btnAzuriraj.Text = "Ažuriraj ugovor";
            this.btnAzuriraj.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisi.Highlight = false;
            this.btnObrisi.Location = new System.Drawing.Point(562, 274);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(280, 80);
            this.btnObrisi.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnObrisi.StyleManager = null;
            this.btnObrisi.TabIndex = 62;
            this.btnObrisi.Text = "Obriši ";
            this.btnObrisi.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // frmUgovoriDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDobavljac);
            this.Controls.Add(this.txtVozilo);
            this.Controls.Add(this.txtKupac);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblDobavljac);
            this.Controls.Add(this.lblVozilo);
            this.Controls.Add(this.lblKupac);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.dtPickerDatum);
            this.Name = "frmUgovoriDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji o ugovorima";
            this.Load += new System.EventHandler(this.frmUgovoriDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPickerDatum;
        private MetroFramework.Controls.MetroLabel lblSifra;
        private MetroFramework.Controls.MetroLabel lblKupac;
        private MetroFramework.Controls.MetroLabel lblVozilo;
        private MetroFramework.Controls.MetroLabel lblDobavljac;
        private MetroFramework.Controls.MetroLabel lblDatum;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroTextBox txtKupac;
        private MetroFramework.Controls.MetroTextBox txtVozilo;
        private MetroFramework.Controls.MetroTextBox txtDobavljac;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnOdustani;
        private MetroFramework.Controls.MetroButton btnAzuriraj;
        private MetroFramework.Controls.MetroButton btnObrisi;
    }
}