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
            this.dtPickerDatum = new System.Windows.Forms.DateTimePicker();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnAzurirajUgovor = new System.Windows.Forms.Button();
            this.lblDobavljac = new System.Windows.Forms.Label();
            this.txtDobavljac = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblVozilo = new System.Windows.Forms.Label();
            this.txtVozilo = new System.Windows.Forms.TextBox();
            this.lblKupac = new System.Windows.Forms.Label();
            this.txtKupac = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtPickerDatum
            // 
            this.dtPickerDatum.Location = new System.Drawing.Point(162, 234);
            this.dtPickerDatum.Name = "dtPickerDatum";
            this.dtPickerDatum.Size = new System.Drawing.Size(250, 20);
            this.dtPickerDatum.TabIndex = 46;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(497, 405);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 45;
            this.btnOdustani.TabStop = false;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnAzurirajUgovor
            // 
            this.btnAzurirajUgovor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAzurirajUgovor.Location = new System.Drawing.Point(162, 385);
            this.btnAzurirajUgovor.Name = "btnAzurirajUgovor";
            this.btnAzurirajUgovor.Size = new System.Drawing.Size(250, 43);
            this.btnAzurirajUgovor.TabIndex = 43;
            this.btnAzurirajUgovor.Text = "Ažuriraj ugovor";
            this.btnAzurirajUgovor.UseVisualStyleBackColor = true;
            this.btnAzurirajUgovor.Click += new System.EventHandler(this.btnAzurirajUgovor_Click);
            // 
            // lblDobavljac
            // 
            this.lblDobavljac.AutoSize = true;
            this.lblDobavljac.Location = new System.Drawing.Point(20, 298);
            this.lblDobavljac.Name = "lblDobavljac";
            this.lblDobavljac.Size = new System.Drawing.Size(55, 13);
            this.lblDobavljac.TabIndex = 42;
            this.lblDobavljac.Text = "Dobavljac";
            // 
            // txtDobavljac
            // 
            this.txtDobavljac.Location = new System.Drawing.Point(162, 298);
            this.txtDobavljac.Name = "txtDobavljac";
            this.txtDobavljac.Size = new System.Drawing.Size(250, 20);
            this.txtDobavljac.TabIndex = 41;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(20, 242);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(38, 13);
            this.lblDatum.TabIndex = 40;
            this.lblDatum.Text = "Datum";
            // 
            // lblVozilo
            // 
            this.lblVozilo.AutoSize = true;
            this.lblVozilo.Location = new System.Drawing.Point(20, 191);
            this.lblVozilo.Name = "lblVozilo";
            this.lblVozilo.Size = new System.Drawing.Size(35, 13);
            this.lblVozilo.TabIndex = 39;
            this.lblVozilo.Text = "Vozilo";
            // 
            // txtVozilo
            // 
            this.txtVozilo.Location = new System.Drawing.Point(162, 191);
            this.txtVozilo.Name = "txtVozilo";
            this.txtVozilo.Size = new System.Drawing.Size(250, 20);
            this.txtVozilo.TabIndex = 38;
            // 
            // lblKupac
            // 
            this.lblKupac.AutoSize = true;
            this.lblKupac.Location = new System.Drawing.Point(20, 143);
            this.lblKupac.Name = "lblKupac";
            this.lblKupac.Size = new System.Drawing.Size(38, 13);
            this.lblKupac.TabIndex = 37;
            this.lblKupac.Text = "Kupac";
            // 
            // txtKupac
            // 
            this.txtKupac.Location = new System.Drawing.Point(162, 143);
            this.txtKupac.Name = "txtKupac";
            this.txtKupac.Size = new System.Drawing.Size(250, 20);
            this.txtKupac.TabIndex = 36;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(20, 97);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 13);
            this.lblId.TabIndex = 48;
            this.lblId.Text = "Šifra";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(162, 97);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(250, 20);
            this.txtId.TabIndex = 47;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(497, 347);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 49;
            this.btnObrisi.TabStop = false;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // frmUgovoriDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 478);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dtPickerDatum);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnAzurirajUgovor);
            this.Controls.Add(this.lblDobavljac);
            this.Controls.Add(this.txtDobavljac);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblVozilo);
            this.Controls.Add(this.txtVozilo);
            this.Controls.Add(this.lblKupac);
            this.Controls.Add(this.txtKupac);
            this.Name = "frmUgovoriDetalji";
            this.Text = "UgovoriDetalji";
            this.Load += new System.EventHandler(this.frmUgovoriDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPickerDatum;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnAzurirajUgovor;
        private System.Windows.Forms.Label lblDobavljac;
        private System.Windows.Forms.TextBox txtDobavljac;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblVozilo;
        private System.Windows.Forms.TextBox txtVozilo;
        private System.Windows.Forms.Label lblKupac;
        private System.Windows.Forms.TextBox txtKupac;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnObrisi;
    }
}