namespace DriveIT
{
    partial class frmVrsteVozilaDetalji
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
            this.lblPodtip = new System.Windows.Forms.Label();
            this.txtPodtip = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnAzurirajjModelVozila = new System.Windows.Forms.Button();
            this.lblDodajModelVozila = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblSifra = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPodtip
            // 
            this.lblPodtip.AutoSize = true;
            this.lblPodtip.Location = new System.Drawing.Point(81, 190);
            this.lblPodtip.Name = "lblPodtip";
            this.lblPodtip.Size = new System.Drawing.Size(37, 13);
            this.lblPodtip.TabIndex = 66;
            this.lblPodtip.Text = "Podtip";
            // 
            // txtPodtip
            // 
            this.txtPodtip.Location = new System.Drawing.Point(223, 190);
            this.txtPodtip.Name = "txtPodtip";
            this.txtPodtip.Size = new System.Drawing.Size(250, 20);
            this.txtPodtip.TabIndex = 65;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(331, 256);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 64;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnAzurirajjModelVozila
            // 
            this.btnAzurirajjModelVozila.Location = new System.Drawing.Point(192, 256);
            this.btnAzurirajjModelVozila.Name = "btnAzurirajjModelVozila";
            this.btnAzurirajjModelVozila.Size = new System.Drawing.Size(106, 23);
            this.btnAzurirajjModelVozila.TabIndex = 63;
            this.btnAzurirajjModelVozila.Text = "Ažuriraj vrstu vozila";
            this.btnAzurirajjModelVozila.UseVisualStyleBackColor = true;
            this.btnAzurirajjModelVozila.Click += new System.EventHandler(this.btnAzurirajjModelVozila_Click);
            // 
            // lblDodajModelVozila
            // 
            this.lblDodajModelVozila.AutoSize = true;
            this.lblDodajModelVozila.Location = new System.Drawing.Point(220, 46);
            this.lblDodajModelVozila.Name = "lblDodajModelVozila";
            this.lblDodajModelVozila.Size = new System.Drawing.Size(97, 13);
            this.lblDodajModelVozila.TabIndex = 62;
            this.lblDodajModelVozila.Text = "Ažuriraj vrstu vozila";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(81, 135);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 61;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(223, 135);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(250, 20);
            this.txtNaziv.TabIndex = 60;
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(81, 93);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(28, 13);
            this.lblSifra.TabIndex = 68;
            this.lblSifra.Text = "Šifra";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(223, 93);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(250, 20);
            this.txtId.TabIndex = 67;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(454, 256);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 69;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // frmVrsteVozilaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblPodtip);
            this.Controls.Add(this.txtPodtip);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnAzurirajjModelVozila);
            this.Controls.Add(this.lblDodajModelVozila);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmVrsteVozilaDetalji";
            this.Text = "VrsteVozilaDetalji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPodtip;
        private System.Windows.Forms.TextBox txtPodtip;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnAzurirajjModelVozila;
        private System.Windows.Forms.Label lblDodajModelVozila;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnObrisi;
    }
}