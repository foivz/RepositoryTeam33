namespace DriveIT
{
    partial class frmParkiralistaDetalji
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
            this.btnAzurirajParking = new System.Windows.Forms.Button();
            this.lblAžurirajjParkiraliste = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblKapacitet = new System.Windows.Forms.Label();
            this.txtKapacitet = new System.Windows.Forms.TextBox();
            this.lblSifra = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(247, 204);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 50;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnAzurirajParking
            // 
            this.btnAzurirajParking.Location = new System.Drawing.Point(153, 204);
            this.btnAzurirajParking.Name = "btnAzurirajParking";
            this.btnAzurirajParking.Size = new System.Drawing.Size(75, 23);
            this.btnAzurirajParking.TabIndex = 49;
            this.btnAzurirajParking.Text = "Ažuriraj";
            this.btnAzurirajParking.UseVisualStyleBackColor = true;
            this.btnAzurirajParking.Click += new System.EventHandler(this.btnAzurirajParking_Click);
            // 
            // lblAžurirajjParkiraliste
            // 
            this.lblAžurirajjParkiraliste.AutoSize = true;
            this.lblAžurirajjParkiraliste.Location = new System.Drawing.Point(150, 19);
            this.lblAžurirajjParkiraliste.Name = "lblAžurirajjParkiraliste";
            this.lblAžurirajjParkiraliste.Size = new System.Drawing.Size(95, 13);
            this.lblAžurirajjParkiraliste.TabIndex = 48;
            this.lblAžurirajjParkiraliste.Text = "Ažuriraj Parkiralište";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 101);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 47;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(154, 101);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(250, 20);
            this.txtNaziv.TabIndex = 46;
            // 
            // lblKapacitet
            // 
            this.lblKapacitet.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblKapacitet.AutoSize = true;
            this.lblKapacitet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKapacitet.Location = new System.Drawing.Point(12, 146);
            this.lblKapacitet.Name = "lblKapacitet";
            this.lblKapacitet.Size = new System.Drawing.Size(52, 13);
            this.lblKapacitet.TabIndex = 45;
            this.lblKapacitet.Text = "Kapacitet";
            // 
            // txtKapacitet
            // 
            this.txtKapacitet.Location = new System.Drawing.Point(154, 146);
            this.txtKapacitet.Name = "txtKapacitet";
            this.txtKapacitet.Size = new System.Drawing.Size(250, 20);
            this.txtKapacitet.TabIndex = 44;
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(11, 59);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(28, 13);
            this.lblSifra.TabIndex = 52;
            this.lblSifra.Text = "Šifra";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(153, 59);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(250, 20);
            this.txtId.TabIndex = 51;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(340, 204);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 53;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // frmParkiralistaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 272);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnAzurirajParking);
            this.Controls.Add(this.lblAžurirajjParkiraliste);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblKapacitet);
            this.Controls.Add(this.txtKapacitet);
            this.Name = "frmParkiralistaDetalji";
            this.Text = "ParkiralistaDetalji";
            this.Load += new System.EventHandler(this.ParkiralistaDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnAzurirajParking;
        private System.Windows.Forms.Label lblAžurirajjParkiraliste;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblKapacitet;
        private System.Windows.Forms.TextBox txtKapacitet;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnObrisi;
    }
}