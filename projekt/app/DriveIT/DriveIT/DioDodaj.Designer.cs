namespace DriveIT
{
    partial class DioDodaj
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
            this.addBtn = new MetroFramework.Controls.MetroButton();
            this.txtNaziv = new MetroFramework.Controls.MetroTextBox();
            this.lblKorisnickoIme = new MetroFramework.Controls.MetroLabel();
            this.txtOpis = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtKolicina = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCijena = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addBtn.Highlight = false;
            this.addBtn.Location = new System.Drawing.Point(80, 289);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(158, 43);
            this.addBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.addBtn.StyleManager = null;
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Dodaj novi dio";
            this.addBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.CustomBackground = false;
            this.txtNaziv.CustomForeColor = false;
            this.txtNaziv.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNaziv.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtNaziv.Location = new System.Drawing.Point(59, 48);
            this.txtNaziv.Multiline = false;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.SelectedText = "";
            this.txtNaziv.Size = new System.Drawing.Size(207, 30);
            this.txtNaziv.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNaziv.StyleManager = null;
            this.txtNaziv.TabIndex = 8;
            this.txtNaziv.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNaziv.UseStyleColors = false;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.CustomBackground = true;
            this.lblKorisnickoIme.CustomForeColor = false;
            this.lblKorisnickoIme.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblKorisnickoIme.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblKorisnickoIme.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(59, 26);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(41, 19);
            this.lblKorisnickoIme.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblKorisnickoIme.StyleManager = null;
            this.lblKorisnickoIme.TabIndex = 7;
            this.lblKorisnickoIme.Text = "Naziv";
            this.lblKorisnickoIme.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblKorisnickoIme.UseStyleColors = false;
            // 
            // txtOpis
            // 
            this.txtOpis.CustomBackground = false;
            this.txtOpis.CustomForeColor = false;
            this.txtOpis.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtOpis.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtOpis.Location = new System.Drawing.Point(59, 109);
            this.txtOpis.Multiline = false;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.SelectedText = "";
            this.txtOpis.Size = new System.Drawing.Size(207, 30);
            this.txtOpis.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOpis.StyleManager = null;
            this.txtOpis.TabIndex = 10;
            this.txtOpis.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOpis.UseStyleColors = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(59, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Opis";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // txtKolicina
            // 
            this.txtKolicina.CustomBackground = false;
            this.txtKolicina.CustomForeColor = false;
            this.txtKolicina.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtKolicina.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtKolicina.Location = new System.Drawing.Point(59, 173);
            this.txtKolicina.Multiline = false;
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.SelectedText = "";
            this.txtKolicina.Size = new System.Drawing.Size(207, 30);
            this.txtKolicina.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKolicina.StyleManager = null;
            this.txtKolicina.TabIndex = 12;
            this.txtKolicina.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKolicina.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(59, 151);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Količina";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // txtCijena
            // 
            this.txtCijena.CustomBackground = false;
            this.txtCijena.CustomForeColor = false;
            this.txtCijena.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCijena.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtCijena.Location = new System.Drawing.Point(59, 234);
            this.txtCijena.Multiline = false;
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.SelectedText = "";
            this.txtCijena.Size = new System.Drawing.Size(207, 30);
            this.txtCijena.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCijena.StyleManager = null;
            this.txtCijena.TabIndex = 14;
            this.txtCijena.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCijena.UseStyleColors = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = false;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel3.Location = new System.Drawing.Point(59, 212);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.StyleManager = null;
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Cijena";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = false;
            // 
            // DioDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 344);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.addBtn);
            this.Name = "DioDodaj";
            this.Text = "DioDodaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton addBtn;
        private MetroFramework.Controls.MetroTextBox txtNaziv;
        private MetroFramework.Controls.MetroLabel lblKorisnickoIme;
        private MetroFramework.Controls.MetroTextBox txtOpis;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtKolicina;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtCijena;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}