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
            this.lblNalogZaServis = new System.Windows.Forms.Label();
            this.cbKorisnik = new System.Windows.Forms.ComboBox();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtVozilo = new System.Windows.Forms.TextBox();
            this.lblVozilo = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnKreirajNalog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNalogZaServis
            // 
            this.lblNalogZaServis.AutoSize = true;
            this.lblNalogZaServis.Location = new System.Drawing.Point(39, 41);
            this.lblNalogZaServis.Name = "lblNalogZaServis";
            this.lblNalogZaServis.Size = new System.Drawing.Size(79, 13);
            this.lblNalogZaServis.TabIndex = 0;
            this.lblNalogZaServis.Text = "Nalog za servis";
            // 
            // cbKorisnik
            // 
            this.cbKorisnik.FormattingEnabled = true;
            this.cbKorisnik.Location = new System.Drawing.Point(149, 135);
            this.cbKorisnik.Name = "cbKorisnik";
            this.cbKorisnik.Size = new System.Drawing.Size(121, 21);
            this.cbKorisnik.TabIndex = 1;
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Location = new System.Drawing.Point(53, 142);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(44, 13);
            this.lblKorisnik.TabIndex = 2;
            this.lblKorisnik.Text = "Korisnik";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(149, 205);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(303, 129);
            this.txtOpis.TabIndex = 3;
            this.txtOpis.Text = "";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(53, 205);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(58, 13);
            this.lblOpis.TabIndex = 4;
            this.lblOpis.Text = "Opis kvara";
            // 
            // txtVozilo
            // 
            this.txtVozilo.Enabled = false;
            this.txtVozilo.Location = new System.Drawing.Point(149, 85);
            this.txtVozilo.Name = "txtVozilo";
            this.txtVozilo.Size = new System.Drawing.Size(121, 20);
            this.txtVozilo.TabIndex = 5;
            // 
            // lblVozilo
            // 
            this.lblVozilo.AutoSize = true;
            this.lblVozilo.Location = new System.Drawing.Point(53, 92);
            this.lblVozilo.Name = "lblVozilo";
            this.lblVozilo.Size = new System.Drawing.Size(58, 13);
            this.lblVozilo.TabIndex = 6;
            this.lblVozilo.Text = "Šifra vozila";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(377, 379);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKreirajNalog
            // 
            this.btnKreirajNalog.Location = new System.Drawing.Point(149, 379);
            this.btnKreirajNalog.Name = "btnKreirajNalog";
            this.btnKreirajNalog.Size = new System.Drawing.Size(75, 23);
            this.btnKreirajNalog.TabIndex = 8;
            this.btnKreirajNalog.Text = "Kreiraj nalog";
            this.btnKreirajNalog.UseVisualStyleBackColor = true;
            this.btnKreirajNalog.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmNalogZaPopravak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.btnKreirajNalog);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.lblVozilo);
            this.Controls.Add(this.txtVozilo);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.cbKorisnik);
            this.Controls.Add(this.lblNalogZaServis);
            this.Name = "frmNalogZaPopravak";
            this.Text = "NalogKreiraj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNalogZaServis;
        private System.Windows.Forms.ComboBox cbKorisnik;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtVozilo;
        private System.Windows.Forms.Label lblVozilo;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnKreirajNalog;
    }
}