namespace DriveIT
{
    partial class frmMarkeVozilaDodaj
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
            this.btnDodajParking = new System.Windows.Forms.Button();
            this.lblDodajMarkuVozila = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblDrzava = new System.Windows.Forms.Label();
            this.txtDrzava = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(290, 207);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 50;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodajParking
            // 
            this.btnDodajParking.Location = new System.Drawing.Point(157, 208);
            this.btnDodajParking.Name = "btnDodajParking";
            this.btnDodajParking.Size = new System.Drawing.Size(75, 23);
            this.btnDodajParking.TabIndex = 49;
            this.btnDodajParking.Text = "Dodaj Parking";
            this.btnDodajParking.UseVisualStyleBackColor = true;
            this.btnDodajParking.Click += new System.EventHandler(this.btnDodajParking_Click);
            // 
            // lblDodajMarkuVozila
            // 
            this.lblDodajMarkuVozila.AutoSize = true;
            this.lblDodajMarkuVozila.Location = new System.Drawing.Point(157, 37);
            this.lblDodajMarkuVozila.Name = "lblDodajMarkuVozila";
            this.lblDodajMarkuVozila.Size = new System.Drawing.Size(97, 13);
            this.lblDodajMarkuVozila.TabIndex = 48;
            this.lblDodajMarkuVozila.Text = "Dodaj marku vozila";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(15, 87);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 47;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(157, 87);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(250, 20);
            this.txtNaziv.TabIndex = 46;
            // 
            // lblDrzava
            // 
            this.lblDrzava.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblDrzava.AutoSize = true;
            this.lblDrzava.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDrzava.Location = new System.Drawing.Point(15, 132);
            this.lblDrzava.Name = "lblDrzava";
            this.lblDrzava.Size = new System.Drawing.Size(80, 13);
            this.lblDrzava.TabIndex = 45;
            this.lblDrzava.Text = "Država porijetla";
            // 
            // txtDrzava
            // 
            this.txtDrzava.Location = new System.Drawing.Point(157, 132);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.Size = new System.Drawing.Size(250, 20);
            this.txtDrzava.TabIndex = 44;
            // 
            // frmMarkeVozilaDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodajParking);
            this.Controls.Add(this.lblDodajMarkuVozila);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblDrzava);
            this.Controls.Add(this.txtDrzava);
            this.Name = "frmMarkeVozilaDodaj";
            this.Text = "MarkeVozilaDodaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodajParking;
        private System.Windows.Forms.Label lblDodajMarkuVozila;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblDrzava;
        private System.Windows.Forms.TextBox txtDrzava;
    }
}