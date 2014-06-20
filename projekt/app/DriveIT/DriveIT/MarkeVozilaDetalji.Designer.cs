namespace DriveIT
{
    partial class frmMarkeVozilaDetalji
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
            this.btnAzurirajMarku = new System.Windows.Forms.Button();
            this.lblDodajMarkuVozila = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblDrzava = new System.Windows.Forms.Label();
            this.txtDrzava = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(330, 223);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 57;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnAzurirajMarku
            // 
            this.btnAzurirajMarku.Location = new System.Drawing.Point(222, 223);
            this.btnAzurirajMarku.Name = "btnAzurirajMarku";
            this.btnAzurirajMarku.Size = new System.Drawing.Size(75, 23);
            this.btnAzurirajMarku.TabIndex = 56;
            this.btnAzurirajMarku.Text = "Ažuriraj marku";
            this.btnAzurirajMarku.UseVisualStyleBackColor = true;
            this.btnAzurirajMarku.Click += new System.EventHandler(this.btnAzurirajMarku_Click);
            // 
            // lblDodajMarkuVozila
            // 
            this.lblDodajMarkuVozila.AutoSize = true;
            this.lblDodajMarkuVozila.Location = new System.Drawing.Point(219, 9);
            this.lblDodajMarkuVozila.Name = "lblDodajMarkuVozila";
            this.lblDodajMarkuVozila.Size = new System.Drawing.Size(103, 13);
            this.lblDodajMarkuVozila.TabIndex = 55;
            this.lblDodajMarkuVozila.Text = "Ažuriraj marku vozila";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(80, 102);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 54;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(222, 102);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(250, 20);
            this.txtNaziv.TabIndex = 53;
            // 
            // lblDrzava
            // 
            this.lblDrzava.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblDrzava.AutoSize = true;
            this.lblDrzava.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDrzava.Location = new System.Drawing.Point(80, 147);
            this.lblDrzava.Name = "lblDrzava";
            this.lblDrzava.Size = new System.Drawing.Size(80, 13);
            this.lblDrzava.TabIndex = 52;
            this.lblDrzava.Text = "Država porijetla";
            // 
            // txtDrzava
            // 
            this.txtDrzava.Location = new System.Drawing.Point(222, 147);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.Size = new System.Drawing.Size(250, 20);
            this.txtDrzava.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Šifra";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(222, 60);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(250, 20);
            this.txtId.TabIndex = 58;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(433, 223);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 60;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // frmMarkeVozilaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnAzurirajMarku);
            this.Controls.Add(this.lblDodajMarkuVozila);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblDrzava);
            this.Controls.Add(this.txtDrzava);
            this.Name = "frmMarkeVozilaDetalji";
            this.Text = "MarkeVozilaDetalji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnAzurirajMarku;
        private System.Windows.Forms.Label lblDodajMarkuVozila;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblDrzava;
        private System.Windows.Forms.TextBox txtDrzava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnObrisi;
    }
}