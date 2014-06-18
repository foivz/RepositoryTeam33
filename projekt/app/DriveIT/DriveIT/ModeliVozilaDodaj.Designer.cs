namespace DriveIT
{
    partial class frmModeliVozilaDodaj
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
            this.btnDodajModelVozila = new System.Windows.Forms.Button();
            this.lblDodajModelVozila = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblMarkaVozila = new System.Windows.Forms.Label();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(297, 215);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 50;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodajModelVozila
            // 
            this.btnDodajModelVozila.Location = new System.Drawing.Point(164, 216);
            this.btnDodajModelVozila.Name = "btnDodajModelVozila";
            this.btnDodajModelVozila.Size = new System.Drawing.Size(75, 23);
            this.btnDodajModelVozila.TabIndex = 49;
            this.btnDodajModelVozila.Text = "Dodaj model vozila";
            this.btnDodajModelVozila.UseVisualStyleBackColor = true;
            this.btnDodajModelVozila.Click += new System.EventHandler(this.btnDodajModelVozila_Click);
            // 
            // lblDodajModelVozila
            // 
            this.lblDodajModelVozila.AutoSize = true;
            this.lblDodajModelVozila.Location = new System.Drawing.Point(164, 45);
            this.lblDodajModelVozila.Name = "lblDodajModelVozila";
            this.lblDodajModelVozila.Size = new System.Drawing.Size(96, 13);
            this.lblDodajModelVozila.TabIndex = 48;
            this.lblDodajModelVozila.Text = "Dodaj model vozila";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(22, 95);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 47;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(164, 95);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(250, 20);
            this.txtNaziv.TabIndex = 46;
            // 
            // lblMarkaVozila
            // 
            this.lblMarkaVozila.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblMarkaVozila.AutoSize = true;
            this.lblMarkaVozila.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMarkaVozila.Location = new System.Drawing.Point(22, 140);
            this.lblMarkaVozila.Name = "lblMarkaVozila";
            this.lblMarkaVozila.Size = new System.Drawing.Size(37, 13);
            this.lblMarkaVozila.TabIndex = 45;
            this.lblMarkaVozila.Text = "Marka";
            // 
            // cbMarka
            // 
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(164, 140);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(250, 21);
            this.cbMarka.TabIndex = 51;
            // 
            // frmModeliVozilaDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 281);
            this.Controls.Add(this.cbMarka);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodajModelVozila);
            this.Controls.Add(this.lblDodajModelVozila);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblMarkaVozila);
            this.Name = "frmModeliVozilaDodaj";
            this.Text = "ModeliVozilaDodaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodajModelVozila;
        private System.Windows.Forms.Label lblDodajModelVozila;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblMarkaVozila;
        private System.Windows.Forms.ComboBox cbMarka;
    }
}