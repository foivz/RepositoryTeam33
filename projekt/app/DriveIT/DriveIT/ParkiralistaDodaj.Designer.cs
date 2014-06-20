namespace DriveIT
{
    partial class frmParkiralistaDodaj
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblKapacitet = new System.Windows.Forms.Label();
            this.txtKapacitet = new System.Windows.Forms.TextBox();
            this.lblDodajParkiraliste = new System.Windows.Forms.Label();
            this.btnDodajParking = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(39, 78);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 40;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(181, 78);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(250, 20);
            this.txtNaziv.TabIndex = 39;
            // 
            // lblKapacitet
            // 
            this.lblKapacitet.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblKapacitet.AutoSize = true;
            this.lblKapacitet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKapacitet.Location = new System.Drawing.Point(39, 123);
            this.lblKapacitet.Name = "lblKapacitet";
            this.lblKapacitet.Size = new System.Drawing.Size(52, 13);
            this.lblKapacitet.TabIndex = 38;
            this.lblKapacitet.Text = "Kapacitet";
            // 
            // txtKapacitet
            // 
            this.txtKapacitet.Location = new System.Drawing.Point(181, 123);
            this.txtKapacitet.Name = "txtKapacitet";
            this.txtKapacitet.Size = new System.Drawing.Size(250, 20);
            this.txtKapacitet.TabIndex = 37;
            // 
            // lblDodajParkiraliste
            // 
            this.lblDodajParkiraliste.AutoSize = true;
            this.lblDodajParkiraliste.Location = new System.Drawing.Point(181, 28);
            this.lblDodajParkiraliste.Name = "lblDodajParkiraliste";
            this.lblDodajParkiraliste.Size = new System.Drawing.Size(89, 13);
            this.lblDodajParkiraliste.TabIndex = 41;
            this.lblDodajParkiraliste.Text = "Dodaj Parkiralište";
            // 
            // btnDodajParking
            // 
            this.btnDodajParking.Location = new System.Drawing.Point(181, 199);
            this.btnDodajParking.Name = "btnDodajParking";
            this.btnDodajParking.Size = new System.Drawing.Size(75, 23);
            this.btnDodajParking.TabIndex = 42;
            this.btnDodajParking.Text = "Dodaj Parking";
            this.btnDodajParking.UseVisualStyleBackColor = true;
            this.btnDodajParking.Click += new System.EventHandler(this.btnDodajParking_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(314, 198);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 43;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // frmParkiralistaDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodajParking);
            this.Controls.Add(this.lblDodajParkiraliste);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblKapacitet);
            this.Controls.Add(this.txtKapacitet);
            this.Name = "frmParkiralistaDodaj";
            this.Text = "ParkiralistaDodaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblKapacitet;
        private System.Windows.Forms.TextBox txtKapacitet;
        private System.Windows.Forms.Label lblDodajParkiraliste;
        private System.Windows.Forms.Button btnDodajParking;
        private System.Windows.Forms.Button btnOdustani;
    }
}