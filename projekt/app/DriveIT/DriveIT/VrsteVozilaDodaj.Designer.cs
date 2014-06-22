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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVrsteVozilaDodaj));
            this.tipvozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDodajVrstu = new MetroFramework.Controls.MetroLabel();
            this.lblNaziv = new MetroFramework.Controls.MetroLabel();
            this.lblPodtip = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNaziv = new MetroFramework.Controls.MetroTextBox();
            this.txtPodtip = new MetroFramework.Controls.MetroTextBox();
            this.btnOdustani = new MetroFramework.Controls.MetroButton();
            this.btnDodajModeleVozila = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.tipvozilaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tipvozilaBindingSource
            // 
            this.tipvozilaBindingSource.DataSource = typeof(DriveIT.Database.tip_vozila);
            // 
            // lblDodajVrstu
            // 
            this.lblDodajVrstu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDodajVrstu.AutoSize = true;
            this.lblDodajVrstu.CustomBackground = true;
            this.lblDodajVrstu.CustomForeColor = false;
            this.lblDodajVrstu.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDodajVrstu.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDodajVrstu.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDodajVrstu.Location = new System.Drawing.Point(398, 43);
            this.lblDodajVrstu.Name = "lblDodajVrstu";
            this.lblDodajVrstu.Size = new System.Drawing.Size(146, 25);
            this.lblDodajVrstu.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDodajVrstu.StyleManager = null;
            this.lblDodajVrstu.TabIndex = 60;
            this.lblDodajVrstu.Text = "Dodaj vrstu vozila";
            this.lblDodajVrstu.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDodajVrstu.UseStyleColors = false;
            // 
            // lblNaziv
            // 
            this.lblNaziv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.CustomBackground = true;
            this.lblNaziv.CustomForeColor = false;
            this.lblNaziv.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNaziv.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblNaziv.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblNaziv.Location = new System.Drawing.Point(273, 182);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(54, 25);
            this.lblNaziv.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblNaziv.StyleManager = null;
            this.lblNaziv.TabIndex = 61;
            this.lblNaziv.Text = "Naziv";
            this.lblNaziv.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNaziv.UseStyleColors = false;
            // 
            // lblPodtip
            // 
            this.lblPodtip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPodtip.AutoSize = true;
            this.lblPodtip.CustomBackground = true;
            this.lblPodtip.CustomForeColor = false;
            this.lblPodtip.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPodtip.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblPodtip.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblPodtip.Location = new System.Drawing.Point(267, 237);
            this.lblPodtip.Name = "lblPodtip";
            this.lblPodtip.Size = new System.Drawing.Size(60, 25);
            this.lblPodtip.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblPodtip.StyleManager = null;
            this.lblPodtip.TabIndex = 62;
            this.lblPodtip.Text = "Podtip";
            this.lblPodtip.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblPodtip.UseStyleColors = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 575);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNaziv.CustomBackground = false;
            this.txtNaziv.CustomForeColor = false;
            this.txtNaziv.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNaziv.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtNaziv.Location = new System.Drawing.Point(333, 184);
            this.txtNaziv.Multiline = false;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.SelectedText = "";
            this.txtNaziv.Size = new System.Drawing.Size(280, 23);
            this.txtNaziv.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNaziv.StyleManager = null;
            this.txtNaziv.TabIndex = 64;
            this.txtNaziv.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNaziv.UseStyleColors = false;
            // 
            // txtPodtip
            // 
            this.txtPodtip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPodtip.CustomBackground = false;
            this.txtPodtip.CustomForeColor = false;
            this.txtPodtip.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPodtip.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtPodtip.Location = new System.Drawing.Point(333, 239);
            this.txtPodtip.Multiline = false;
            this.txtPodtip.Name = "txtPodtip";
            this.txtPodtip.SelectedText = "";
            this.txtPodtip.Size = new System.Drawing.Size(280, 23);
            this.txtPodtip.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPodtip.StyleManager = null;
            this.txtPodtip.TabIndex = 65;
            this.txtPodtip.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPodtip.UseStyleColors = false;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOdustani.Highlight = false;
            this.btnOdustani.Location = new System.Drawing.Point(526, 383);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(280, 80);
            this.btnOdustani.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnOdustani.StyleManager = null;
            this.btnOdustani.TabIndex = 66;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click_1);
            // 
            // btnDodajModeleVozila
            // 
            this.btnDodajModeleVozila.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDodajModeleVozila.Highlight = false;
            this.btnDodajModeleVozila.Location = new System.Drawing.Point(124, 383);
            this.btnDodajModeleVozila.Name = "btnDodajModeleVozila";
            this.btnDodajModeleVozila.Size = new System.Drawing.Size(280, 80);
            this.btnDodajModeleVozila.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDodajModeleVozila.StyleManager = null;
            this.btnDodajModeleVozila.TabIndex = 67;
            this.btnDodajModeleVozila.Text = "Dodaj";
            this.btnDodajModeleVozila.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDodajModeleVozila.Click += new System.EventHandler(this.btnDodajModeleVozila_Click);
            // 
            // frmVrsteVozilaDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.btnDodajModeleVozila);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtPodtip);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPodtip);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblDodajVrstu);
            this.Name = "frmVrsteVozilaDodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj vrstu vozila";
            this.Load += new System.EventHandler(this.frmVrsteVozilaDodaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipvozilaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tipvozilaBindingSource;
        private MetroFramework.Controls.MetroLabel lblDodajVrstu;
        private MetroFramework.Controls.MetroLabel lblNaziv;
        private MetroFramework.Controls.MetroLabel lblPodtip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtNaziv;
        private MetroFramework.Controls.MetroTextBox txtPodtip;
        private MetroFramework.Controls.MetroButton btnOdustani;
        private MetroFramework.Controls.MetroButton btnDodajModeleVozila;

    }
}