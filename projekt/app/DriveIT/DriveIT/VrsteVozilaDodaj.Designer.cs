namespace DriveIT
{
    partial class frmVrsteVozilaDodaj
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
            this.components = new System.ComponentModel.Container();
            this.tipvozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodajModelVozila = new System.Windows.Forms.Button();
            this.lblDodajModelVozila = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblPodtip = new System.Windows.Forms.Label();
            this.txtPodtip = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tipvozilaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tipvozilaBindingSource
            // 
            this.tipvozilaBindingSource.DataSource = typeof(DriveIT.Database.tip_vozila);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(296, 219);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 57;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodajModelVozila
            // 
            this.btnDodajModelVozila.Location = new System.Drawing.Point(163, 220);
            this.btnDodajModelVozila.Name = "btnDodajModelVozila";
            this.btnDodajModelVozila.Size = new System.Drawing.Size(75, 23);
            this.btnDodajModelVozila.TabIndex = 56;
            this.btnDodajModelVozila.Text = "Dodaj vrstu vozila";
            this.btnDodajModelVozila.UseVisualStyleBackColor = true;
            this.btnDodajModelVozila.Click += new System.EventHandler(this.btnDodajModelVozila_Click);
            // 
            // lblDodajModelVozila
            // 
            this.lblDodajModelVozila.AutoSize = true;
            this.lblDodajModelVozila.Location = new System.Drawing.Point(163, 49);
            this.lblDodajModelVozila.Name = "lblDodajModelVozila";
            this.lblDodajModelVozila.Size = new System.Drawing.Size(91, 13);
            this.lblDodajModelVozila.TabIndex = 55;
            this.lblDodajModelVozila.Text = "Dodaj vrstu vozila";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(21, 99);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 54;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(163, 99);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(250, 20);
            this.txtNaziv.TabIndex = 53;
            // 
            // lblPodtip
            // 
            this.lblPodtip.AutoSize = true;
            this.lblPodtip.Location = new System.Drawing.Point(21, 154);
            this.lblPodtip.Name = "lblPodtip";
            this.lblPodtip.Size = new System.Drawing.Size(37, 13);
            this.lblPodtip.TabIndex = 59;
            this.lblPodtip.Text = "Podtip";
            // 
            // txtPodtip
            // 
            this.txtPodtip.Location = new System.Drawing.Point(163, 154);
            this.txtPodtip.Name = "txtPodtip";
            this.txtPodtip.Size = new System.Drawing.Size(250, 20);
            this.txtPodtip.TabIndex = 58;
            // 
            // frmVrsteVozilaDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 304);
            this.Controls.Add(this.lblPodtip);
            this.Controls.Add(this.txtPodtip);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodajModelVozila);
            this.Controls.Add(this.lblDodajModelVozila);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmVrsteVozilaDodaj";
            this.Text = "VrsteVozilaDodaj";
            this.Load += new System.EventHandler(this.frmVrsteVozilaDodaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipvozilaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tipvozilaBindingSource;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodajModelVozila;
        private System.Windows.Forms.Label lblDodajModelVozila;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblPodtip;
        private System.Windows.Forms.TextBox txtPodtip;

    }
}