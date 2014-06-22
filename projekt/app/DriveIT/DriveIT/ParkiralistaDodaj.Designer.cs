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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParkiralistaDodaj));
            this.lblNaziv = new MetroFramework.Controls.MetroLabel();
            this.lblKapacitet = new MetroFramework.Controls.MetroLabel();
            this.txtNaziv = new MetroFramework.Controls.MetroTextBox();
            this.txtKapacitet = new MetroFramework.Controls.MetroTextBox();
            this.btnDodajParkiraliste = new MetroFramework.Controls.MetroButton();
            this.btnOdustani = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblDodaj = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.CustomBackground = true;
            this.lblNaziv.CustomForeColor = false;
            this.lblNaziv.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNaziv.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblNaziv.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblNaziv.Location = new System.Drawing.Point(295, 232);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(54, 25);
            this.lblNaziv.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblNaziv.StyleManager = null;
            this.lblNaziv.TabIndex = 44;
            this.lblNaziv.Text = "Naziv";
            this.lblNaziv.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNaziv.UseStyleColors = false;
            // 
            // lblKapacitet
            // 
            this.lblKapacitet.AutoSize = true;
            this.lblKapacitet.CustomBackground = true;
            this.lblKapacitet.CustomForeColor = false;
            this.lblKapacitet.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblKapacitet.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblKapacitet.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblKapacitet.Location = new System.Drawing.Point(278, 285);
            this.lblKapacitet.Name = "lblKapacitet";
            this.lblKapacitet.Size = new System.Drawing.Size(71, 25);
            this.lblKapacitet.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblKapacitet.StyleManager = null;
            this.lblKapacitet.TabIndex = 45;
            this.lblKapacitet.Text = "Kapcitet";
            this.lblKapacitet.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblKapacitet.UseStyleColors = false;
            // 
            // txtNaziv
            // 
            this.txtNaziv.CustomBackground = false;
            this.txtNaziv.CustomForeColor = false;
            this.txtNaziv.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNaziv.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtNaziv.Location = new System.Drawing.Point(355, 234);
            this.txtNaziv.Multiline = false;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.SelectedText = "";
            this.txtNaziv.Size = new System.Drawing.Size(280, 23);
            this.txtNaziv.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNaziv.StyleManager = null;
            this.txtNaziv.TabIndex = 46;
            this.txtNaziv.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNaziv.UseStyleColors = false;
            // 
            // txtKapacitet
            // 
            this.txtKapacitet.CustomBackground = false;
            this.txtKapacitet.CustomForeColor = false;
            this.txtKapacitet.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtKapacitet.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtKapacitet.Location = new System.Drawing.Point(355, 287);
            this.txtKapacitet.Multiline = false;
            this.txtKapacitet.Name = "txtKapacitet";
            this.txtKapacitet.SelectedText = "";
            this.txtKapacitet.Size = new System.Drawing.Size(280, 23);
            this.txtKapacitet.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKapacitet.StyleManager = null;
            this.txtKapacitet.TabIndex = 47;
            this.txtKapacitet.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKapacitet.UseStyleColors = false;
            // 
            // btnDodajParkiraliste
            // 
            this.btnDodajParkiraliste.Highlight = false;
            this.btnDodajParkiraliste.Location = new System.Drawing.Point(124, 415);
            this.btnDodajParkiraliste.Name = "btnDodajParkiraliste";
            this.btnDodajParkiraliste.Size = new System.Drawing.Size(280, 80);
            this.btnDodajParkiraliste.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDodajParkiraliste.StyleManager = null;
            this.btnDodajParkiraliste.TabIndex = 48;
            this.btnDodajParkiraliste.Text = "Dodaj parkiralište";
            this.btnDodajParkiraliste.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDodajParkiraliste.Click += new System.EventHandler(this.btnDodajParkiraliste_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Highlight = false;
            this.btnOdustani.Location = new System.Drawing.Point(526, 415);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(280, 80);
            this.btnOdustani.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnOdustani.StyleManager = null;
            this.btnOdustani.TabIndex = 49;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 575);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // LblDodaj
            // 
            this.LblDodaj.AutoSize = true;
            this.LblDodaj.CustomBackground = true;
            this.LblDodaj.CustomForeColor = false;
            this.LblDodaj.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblDodaj.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.LblDodaj.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.LblDodaj.Location = new System.Drawing.Point(355, 48);
            this.LblDodaj.Name = "LblDodaj";
            this.LblDodaj.Size = new System.Drawing.Size(186, 25);
            this.LblDodaj.Style = MetroFramework.MetroColorStyle.Blue;
            this.LblDodaj.StyleManager = null;
            this.LblDodaj.TabIndex = 51;
            this.LblDodaj.Text = "Dodaj novo parkiralište";
            this.LblDodaj.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LblDodaj.UseStyleColors = false;
            // 
            // frmParkiralistaDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.LblDodaj);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodajParkiraliste);
            this.Controls.Add(this.txtKapacitet);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblKapacitet);
            this.Controls.Add(this.lblNaziv);
            this.Name = "frmParkiralistaDodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj parkiralište";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblNaziv;
        private MetroFramework.Controls.MetroLabel lblKapacitet;
        private MetroFramework.Controls.MetroTextBox txtNaziv;
        private MetroFramework.Controls.MetroTextBox txtKapacitet;
        private MetroFramework.Controls.MetroButton btnDodajParkiraliste;
        private MetroFramework.Controls.MetroButton btnOdustani;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel LblDodaj;
    }
}