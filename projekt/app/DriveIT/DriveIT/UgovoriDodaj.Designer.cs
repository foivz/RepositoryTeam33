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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lblDodajUgovor = new System.Windows.Forms.Label();
            this.btnDodajUgovor = new System.Windows.Forms.Button();
            this.lblDobavljac = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblVozilo = new System.Windows.Forms.Label();
            this.lblKupac = new System.Windows.Forms.Label();
            this.dtPickerDatum = new System.Windows.Forms.DateTimePicker();
            this.cbKupac = new System.Windows.Forms.ComboBox();
            this.cbVozilo = new System.Windows.Forms.ComboBox();
            this.cbDobavljac = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(569, 348);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 34;
            this.btnOdustani.TabStop = false;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // lblDodajUgovor
            // 
            this.lblDodajUgovor.AutoSize = true;
            this.lblDodajUgovor.Location = new System.Drawing.Point(234, 15);
            this.lblDodajUgovor.Name = "lblDodajUgovor";
            this.lblDodajUgovor.Size = new System.Drawing.Size(71, 13);
            this.lblDodajUgovor.TabIndex = 33;
            this.lblDodajUgovor.Text = "Dodaj ugovor";
            // 
            // btnDodajUgovor
            // 
            this.btnDodajUgovor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajUgovor.Location = new System.Drawing.Point(234, 328);
            this.btnDodajUgovor.Name = "btnDodajUgovor";
            this.btnDodajUgovor.Size = new System.Drawing.Size(250, 43);
            this.btnDodajUgovor.TabIndex = 32;
            this.btnDodajUgovor.Text = "Kreiraj ugovor";
            this.btnDodajUgovor.UseVisualStyleBackColor = true;
            this.btnDodajUgovor.Click += new System.EventHandler(this.btnDodajDobavljac_Click);
            // 
            // lblDobavljac
            // 
            this.lblDobavljac.AutoSize = true;
            this.lblDobavljac.Location = new System.Drawing.Point(92, 241);
            this.lblDobavljac.Name = "lblDobavljac";
            this.lblDobavljac.Size = new System.Drawing.Size(55, 13);
            this.lblDobavljac.TabIndex = 25;
            this.lblDobavljac.Text = "Dobavljac";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(92, 185);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(38, 13);
            this.lblDatum.TabIndex = 23;
            this.lblDatum.Text = "Datum";
            // 
            // lblVozilo
            // 
            this.lblVozilo.AutoSize = true;
            this.lblVozilo.Location = new System.Drawing.Point(92, 134);
            this.lblVozilo.Name = "lblVozilo";
            this.lblVozilo.Size = new System.Drawing.Size(35, 13);
            this.lblVozilo.TabIndex = 21;
            this.lblVozilo.Text = "Vozilo";
            // 
            // lblKupac
            // 
            this.lblKupac.AutoSize = true;
            this.lblKupac.Location = new System.Drawing.Point(92, 86);
            this.lblKupac.Name = "lblKupac";
            this.lblKupac.Size = new System.Drawing.Size(38, 13);
            this.lblKupac.TabIndex = 19;
            this.lblKupac.Text = "Kupac";
            // 
            // dtPickerDatum
            // 
            this.dtPickerDatum.Location = new System.Drawing.Point(234, 177);
            this.dtPickerDatum.Name = "dtPickerDatum";
            this.dtPickerDatum.Size = new System.Drawing.Size(250, 20);
            this.dtPickerDatum.TabIndex = 35;
            // 
            // cbKupac
            // 
            this.cbKupac.FormattingEnabled = true;
            this.cbKupac.Location = new System.Drawing.Point(234, 83);
            this.cbKupac.Name = "cbKupac";
            this.cbKupac.Size = new System.Drawing.Size(250, 21);
            this.cbKupac.TabIndex = 36;
            // 
            // cbVozilo
            // 
            this.cbVozilo.FormattingEnabled = true;
            this.cbVozilo.Location = new System.Drawing.Point(234, 131);
            this.cbVozilo.Name = "cbVozilo";
            this.cbVozilo.Size = new System.Drawing.Size(250, 21);
            this.cbVozilo.TabIndex = 37;
            // 
            // cbDobavljac
            // 
            this.cbDobavljac.FormattingEnabled = true;
            this.cbDobavljac.Location = new System.Drawing.Point(237, 233);
            this.cbDobavljac.Name = "cbDobavljac";
            this.cbDobavljac.Size = new System.Drawing.Size(247, 21);
            this.cbDobavljac.TabIndex = 38;
            // 
            // frmUgovoriDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.cbDobavljac);
            this.Controls.Add(this.cbVozilo);
            this.Controls.Add(this.cbKupac);
            this.Controls.Add(this.dtPickerDatum);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.lblDodajUgovor);
            this.Controls.Add(this.btnDodajUgovor);
            this.Controls.Add(this.lblDobavljac);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblVozilo);
            this.Controls.Add(this.lblKupac);
            this.Name = "frmUgovoriDodaj";
            this.Text = "UgovoriDodaj";
            this.Load += new System.EventHandler(this.frmUgovoriDodaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblDodajUgovor;
        private System.Windows.Forms.Button btnDodajUgovor;
        private System.Windows.Forms.Label lblDobavljac;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblVozilo;
        private System.Windows.Forms.Label lblKupac;
        private System.Windows.Forms.DateTimePicker dtPickerDatum;
        private System.Windows.Forms.ComboBox cbKupac;
        private System.Windows.Forms.ComboBox cbVozilo;
        private System.Windows.Forms.ComboBox cbDobavljac;
    }
}