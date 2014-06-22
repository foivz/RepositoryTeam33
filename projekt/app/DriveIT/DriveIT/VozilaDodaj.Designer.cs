namespace DriveIT
{
    partial class frmVozilaDodaj
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
            this.dtPickerPrvaRegistracija = new System.Windows.Forms.DateTimePicker();
            this.dtPickerNabavka = new System.Windows.Forms.DateTimePicker();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblSasija = new MetroFramework.Controls.MetroLabel();
            this.lblDatumNabave = new MetroFramework.Controls.MetroLabel();
            this.lblGodinaProizvodnje = new MetroFramework.Controls.MetroLabel();
            this.lblBoja = new MetroFramework.Controls.MetroLabel();
            this.lblPrvaReg = new MetroFramework.Controls.MetroLabel();
            this.lblSnaga = new MetroFramework.Controls.MetroLabel();
            this.lblSjedista = new MetroFramework.Controls.MetroLabel();
            this.txtBrSasije = new MetroFramework.Controls.MetroTextBox();
            this.txtBoja = new MetroFramework.Controls.MetroTextBox();
            this.txtGodinaProizvodnje = new MetroFramework.Controls.MetroTextBox();
            this.txtSnaga = new MetroFramework.Controls.MetroTextBox();
            this.txtSjedista = new MetroFramework.Controls.MetroTextBox();
            this.lblDodajVozilo = new MetroFramework.Controls.MetroLabel();
            this.lblNosivost = new MetroFramework.Controls.MetroLabel();
            this.lblRegistracija = new MetroFramework.Controls.MetroLabel();
            this.lblPrometna = new MetroFramework.Controls.MetroLabel();
            this.lblServisna = new MetroFramework.Controls.MetroLabel();
            this.lblKilometri = new MetroFramework.Controls.MetroLabel();
            this.lblTipVozila = new MetroFramework.Controls.MetroLabel();
            this.lblModel = new MetroFramework.Controls.MetroLabel();
            this.txtNosivost = new MetroFramework.Controls.MetroTextBox();
            this.txtRegistracija = new MetroFramework.Controls.MetroTextBox();
            this.txtPrometna = new MetroFramework.Controls.MetroTextBox();
            this.txtServisna = new MetroFramework.Controls.MetroTextBox();
            this.txtKilometraza = new MetroFramework.Controls.MetroTextBox();
            this.lblParking = new MetroFramework.Controls.MetroLabel();
            this.lblCijena = new MetroFramework.Controls.MetroLabel();
            this.lblDobavljac = new MetroFramework.Controls.MetroLabel();
            this.txtCijena = new MetroFramework.Controls.MetroTextBox();
            this.btnOdustani = new MetroFramework.Controls.MetroButton();
            this.btnDodajVozilo = new MetroFramework.Controls.MetroButton();
            this.txtTipVozila = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.ComboBox();
            this.txtParking = new System.Windows.Forms.ComboBox();
            this.cbDobavljac = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtPickerPrvaRegistracija
            // 
            this.dtPickerPrvaRegistracija.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtPickerPrvaRegistracija.Location = new System.Drawing.Point(190, 144);
            this.dtPickerPrvaRegistracija.Name = "dtPickerPrvaRegistracija";
            this.dtPickerPrvaRegistracija.Size = new System.Drawing.Size(220, 20);
            this.dtPickerPrvaRegistracija.TabIndex = 51;
            // 
            // dtPickerNabavka
            // 
            this.dtPickerNabavka.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtPickerNabavka.Location = new System.Drawing.Point(190, 299);
            this.dtPickerNabavka.Name = "dtPickerNabavka";
            this.dtPickerNabavka.Size = new System.Drawing.Size(220, 20);
            this.dtPickerNabavka.TabIndex = 53;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroButton1.Highlight = false;
            this.metroButton1.Location = new System.Drawing.Point(61, 589);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(223, 80);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.StyleManager = null;
            this.metroButton1.TabIndex = 61;
            this.metroButton1.Text = "Učitaj slike";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblSasija
            // 
            this.lblSasija.AutoSize = true;
            this.lblSasija.CustomBackground = true;
            this.lblSasija.CustomForeColor = false;
            this.lblSasija.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSasija.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblSasija.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblSasija.Location = new System.Drawing.Point(97, 93);
            this.lblSasija.Name = "lblSasija";
            this.lblSasija.Size = new System.Drawing.Size(87, 25);
            this.lblSasija.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSasija.StyleManager = null;
            this.lblSasija.TabIndex = 63;
            this.lblSasija.Text = "Broj šasije";
            this.lblSasija.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSasija.UseStyleColors = false;
            // 
            // lblDatumNabave
            // 
            this.lblDatumNabave.AutoSize = true;
            this.lblDatumNabave.CustomBackground = true;
            this.lblDatumNabave.CustomForeColor = false;
            this.lblDatumNabave.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDatumNabave.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDatumNabave.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDatumNabave.Location = new System.Drawing.Point(61, 294);
            this.lblDatumNabave.Name = "lblDatumNabave";
            this.lblDatumNabave.Size = new System.Drawing.Size(123, 25);
            this.lblDatumNabave.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDatumNabave.StyleManager = null;
            this.lblDatumNabave.TabIndex = 64;
            this.lblDatumNabave.Text = "Datum nabave";
            this.lblDatumNabave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDatumNabave.UseStyleColors = false;
            // 
            // lblGodinaProizvodnje
            // 
            this.lblGodinaProizvodnje.AutoSize = true;
            this.lblGodinaProizvodnje.CustomBackground = true;
            this.lblGodinaProizvodnje.CustomForeColor = false;
            this.lblGodinaProizvodnje.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblGodinaProizvodnje.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblGodinaProizvodnje.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblGodinaProizvodnje.Location = new System.Drawing.Point(11, 242);
            this.lblGodinaProizvodnje.Name = "lblGodinaProizvodnje";
            this.lblGodinaProizvodnje.Size = new System.Drawing.Size(173, 25);
            this.lblGodinaProizvodnje.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblGodinaProizvodnje.StyleManager = null;
            this.lblGodinaProizvodnje.TabIndex = 65;
            this.lblGodinaProizvodnje.Text = "Godina proizvodnje *";
            this.lblGodinaProizvodnje.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblGodinaProizvodnje.UseStyleColors = false;
            // 
            // lblBoja
            // 
            this.lblBoja.AutoSize = true;
            this.lblBoja.CustomBackground = true;
            this.lblBoja.CustomForeColor = false;
            this.lblBoja.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBoja.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblBoja.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBoja.Location = new System.Drawing.Point(127, 193);
            this.lblBoja.Name = "lblBoja";
            this.lblBoja.Size = new System.Drawing.Size(57, 25);
            this.lblBoja.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBoja.StyleManager = null;
            this.lblBoja.TabIndex = 66;
            this.lblBoja.Text = "Boja *";
            this.lblBoja.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBoja.UseStyleColors = false;
            // 
            // lblPrvaReg
            // 
            this.lblPrvaReg.AutoSize = true;
            this.lblPrvaReg.CustomBackground = true;
            this.lblPrvaReg.CustomForeColor = false;
            this.lblPrvaReg.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPrvaReg.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblPrvaReg.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblPrvaReg.Location = new System.Drawing.Point(52, 139);
            this.lblPrvaReg.Name = "lblPrvaReg";
            this.lblPrvaReg.Size = new System.Drawing.Size(132, 25);
            this.lblPrvaReg.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblPrvaReg.StyleManager = null;
            this.lblPrvaReg.TabIndex = 67;
            this.lblPrvaReg.Text = "Prva registracija";
            this.lblPrvaReg.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblPrvaReg.UseStyleColors = false;
            // 
            // lblSnaga
            // 
            this.lblSnaga.AutoSize = true;
            this.lblSnaga.CustomBackground = true;
            this.lblSnaga.CustomForeColor = false;
            this.lblSnaga.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSnaga.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblSnaga.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblSnaga.Location = new System.Drawing.Point(73, 349);
            this.lblSnaga.Name = "lblSnaga";
            this.lblSnaga.Size = new System.Drawing.Size(111, 25);
            this.lblSnaga.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSnaga.StyleManager = null;
            this.lblSnaga.TabIndex = 68;
            this.lblSnaga.Text = "Snaga (KW) *";
            this.lblSnaga.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSnaga.UseStyleColors = false;
            // 
            // lblSjedista
            // 
            this.lblSjedista.AutoSize = true;
            this.lblSjedista.CustomBackground = true;
            this.lblSjedista.CustomForeColor = false;
            this.lblSjedista.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSjedista.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblSjedista.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblSjedista.Location = new System.Drawing.Point(70, 404);
            this.lblSjedista.Name = "lblSjedista";
            this.lblSjedista.Size = new System.Drawing.Size(114, 25);
            this.lblSjedista.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSjedista.StyleManager = null;
            this.lblSjedista.TabIndex = 69;
            this.lblSjedista.Text = "Broj sjedišta *";
            this.lblSjedista.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSjedista.UseStyleColors = false;
            // 
            // txtBrSasije
            // 
            this.txtBrSasije.CustomBackground = false;
            this.txtBrSasije.CustomForeColor = false;
            this.txtBrSasije.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtBrSasije.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtBrSasije.Location = new System.Drawing.Point(190, 95);
            this.txtBrSasije.Multiline = false;
            this.txtBrSasije.Name = "txtBrSasije";
            this.txtBrSasije.SelectedText = "";
            this.txtBrSasije.Size = new System.Drawing.Size(220, 23);
            this.txtBrSasije.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBrSasije.StyleManager = null;
            this.txtBrSasije.TabIndex = 70;
            this.txtBrSasije.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBrSasije.UseStyleColors = false;
            // 
            // txtBoja
            // 
            this.txtBoja.CustomBackground = false;
            this.txtBoja.CustomForeColor = false;
            this.txtBoja.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtBoja.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtBoja.Location = new System.Drawing.Point(190, 193);
            this.txtBoja.Multiline = false;
            this.txtBoja.Name = "txtBoja";
            this.txtBoja.SelectedText = "";
            this.txtBoja.Size = new System.Drawing.Size(220, 23);
            this.txtBoja.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoja.StyleManager = null;
            this.txtBoja.TabIndex = 71;
            this.txtBoja.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoja.UseStyleColors = false;
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.CustomBackground = false;
            this.txtGodinaProizvodnje.CustomForeColor = false;
            this.txtGodinaProizvodnje.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtGodinaProizvodnje.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(190, 244);
            this.txtGodinaProizvodnje.Multiline = false;
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.SelectedText = "";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(220, 23);
            this.txtGodinaProizvodnje.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGodinaProizvodnje.StyleManager = null;
            this.txtGodinaProizvodnje.TabIndex = 72;
            this.txtGodinaProizvodnje.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGodinaProizvodnje.UseStyleColors = false;
            // 
            // txtSnaga
            // 
            this.txtSnaga.CustomBackground = false;
            this.txtSnaga.CustomForeColor = false;
            this.txtSnaga.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtSnaga.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtSnaga.Location = new System.Drawing.Point(190, 351);
            this.txtSnaga.Multiline = false;
            this.txtSnaga.Name = "txtSnaga";
            this.txtSnaga.SelectedText = "";
            this.txtSnaga.Size = new System.Drawing.Size(220, 23);
            this.txtSnaga.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSnaga.StyleManager = null;
            this.txtSnaga.TabIndex = 73;
            this.txtSnaga.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSnaga.UseStyleColors = false;
            // 
            // txtSjedista
            // 
            this.txtSjedista.CustomBackground = false;
            this.txtSjedista.CustomForeColor = false;
            this.txtSjedista.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtSjedista.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtSjedista.Location = new System.Drawing.Point(190, 406);
            this.txtSjedista.Multiline = false;
            this.txtSjedista.Name = "txtSjedista";
            this.txtSjedista.SelectedText = "";
            this.txtSjedista.Size = new System.Drawing.Size(220, 23);
            this.txtSjedista.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSjedista.StyleManager = null;
            this.txtSjedista.TabIndex = 74;
            this.txtSjedista.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSjedista.UseStyleColors = false;
            // 
            // lblDodajVozilo
            // 
            this.lblDodajVozilo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDodajVozilo.AutoSize = true;
            this.lblDodajVozilo.CustomBackground = true;
            this.lblDodajVozilo.CustomForeColor = false;
            this.lblDodajVozilo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDodajVozilo.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDodajVozilo.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDodajVozilo.Location = new System.Drawing.Point(431, 21);
            this.lblDodajVozilo.Name = "lblDodajVozilo";
            this.lblDodajVozilo.Size = new System.Drawing.Size(106, 25);
            this.lblDodajVozilo.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDodajVozilo.StyleManager = null;
            this.lblDodajVozilo.TabIndex = 75;
            this.lblDodajVozilo.Text = "Dodaj vozilo";
            this.lblDodajVozilo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDodajVozilo.UseStyleColors = false;
            // 
            // lblNosivost
            // 
            this.lblNosivost.AutoSize = true;
            this.lblNosivost.CustomBackground = true;
            this.lblNosivost.CustomForeColor = false;
            this.lblNosivost.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNosivost.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblNosivost.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblNosivost.Location = new System.Drawing.Point(108, 458);
            this.lblNosivost.Name = "lblNosivost";
            this.lblNosivost.Size = new System.Drawing.Size(76, 25);
            this.lblNosivost.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblNosivost.StyleManager = null;
            this.lblNosivost.TabIndex = 76;
            this.lblNosivost.Text = "Nosivost";
            this.lblNosivost.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNosivost.UseStyleColors = false;
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.CustomBackground = true;
            this.lblRegistracija.CustomForeColor = false;
            this.lblRegistracija.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRegistracija.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblRegistracija.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblRegistracija.Location = new System.Drawing.Point(29, 508);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(155, 25);
            this.lblRegistracija.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblRegistracija.StyleManager = null;
            this.lblRegistracija.TabIndex = 77;
            this.lblRegistracija.Text = "Registarska oznaka";
            this.lblRegistracija.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblRegistracija.UseStyleColors = false;
            // 
            // lblPrometna
            // 
            this.lblPrometna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrometna.AutoSize = true;
            this.lblPrometna.CustomBackground = true;
            this.lblPrometna.CustomForeColor = false;
            this.lblPrometna.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPrometna.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblPrometna.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblPrometna.Location = new System.Drawing.Point(479, 106);
            this.lblPrometna.Name = "lblPrometna";
            this.lblPrometna.Size = new System.Drawing.Size(146, 25);
            this.lblPrometna.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblPrometna.StyleManager = null;
            this.lblPrometna.TabIndex = 78;
            this.lblPrometna.Text = "Prometna knjižica";
            this.lblPrometna.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblPrometna.UseStyleColors = false;
            // 
            // lblServisna
            // 
            this.lblServisna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServisna.AutoSize = true;
            this.lblServisna.CustomBackground = true;
            this.lblServisna.CustomForeColor = false;
            this.lblServisna.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblServisna.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblServisna.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblServisna.Location = new System.Drawing.Point(490, 154);
            this.lblServisna.Name = "lblServisna";
            this.lblServisna.Size = new System.Drawing.Size(135, 25);
            this.lblServisna.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblServisna.StyleManager = null;
            this.lblServisna.TabIndex = 79;
            this.lblServisna.Text = "Servisna knjižica";
            this.lblServisna.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblServisna.UseStyleColors = false;
            // 
            // lblKilometri
            // 
            this.lblKilometri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKilometri.AutoSize = true;
            this.lblKilometri.CustomBackground = true;
            this.lblKilometri.CustomForeColor = false;
            this.lblKilometri.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblKilometri.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblKilometri.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblKilometri.Location = new System.Drawing.Point(487, 206);
            this.lblKilometri.Name = "lblKilometri";
            this.lblKilometri.Size = new System.Drawing.Size(138, 25);
            this.lblKilometri.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblKilometri.StyleManager = null;
            this.lblKilometri.TabIndex = 80;
            this.lblKilometri.Text = "Broj kilometara *";
            this.lblKilometri.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblKilometri.UseStyleColors = false;
            // 
            // lblTipVozila
            // 
            this.lblTipVozila.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipVozila.AutoSize = true;
            this.lblTipVozila.CustomBackground = true;
            this.lblTipVozila.CustomForeColor = false;
            this.lblTipVozila.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTipVozila.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblTipVozila.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblTipVozila.Location = new System.Drawing.Point(530, 257);
            this.lblTipVozila.Name = "lblTipVozila";
            this.lblTipVozila.Size = new System.Drawing.Size(95, 25);
            this.lblTipVozila.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblTipVozila.StyleManager = null;
            this.lblTipVozila.TabIndex = 81;
            this.lblTipVozila.Text = "Tip vozila *";
            this.lblTipVozila.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblTipVozila.UseStyleColors = false;
            // 
            // lblModel
            // 
            this.lblModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModel.AutoSize = true;
            this.lblModel.CustomBackground = true;
            this.lblModel.CustomForeColor = false;
            this.lblModel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblModel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblModel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblModel.Location = new System.Drawing.Point(505, 309);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(120, 25);
            this.lblModel.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblModel.StyleManager = null;
            this.lblModel.TabIndex = 82;
            this.lblModel.Text = "Model vozila *";
            this.lblModel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblModel.UseStyleColors = false;
            // 
            // txtNosivost
            // 
            this.txtNosivost.CustomBackground = false;
            this.txtNosivost.CustomForeColor = false;
            this.txtNosivost.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNosivost.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtNosivost.Location = new System.Drawing.Point(190, 460);
            this.txtNosivost.Multiline = false;
            this.txtNosivost.Name = "txtNosivost";
            this.txtNosivost.SelectedText = "";
            this.txtNosivost.Size = new System.Drawing.Size(220, 23);
            this.txtNosivost.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNosivost.StyleManager = null;
            this.txtNosivost.TabIndex = 83;
            this.txtNosivost.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNosivost.UseStyleColors = false;
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.CustomBackground = false;
            this.txtRegistracija.CustomForeColor = false;
            this.txtRegistracija.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtRegistracija.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtRegistracija.Location = new System.Drawing.Point(190, 510);
            this.txtRegistracija.Multiline = false;
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.SelectedText = "";
            this.txtRegistracija.Size = new System.Drawing.Size(220, 23);
            this.txtRegistracija.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRegistracija.StyleManager = null;
            this.txtRegistracija.TabIndex = 84;
            this.txtRegistracija.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRegistracija.UseStyleColors = false;
            // 
            // txtPrometna
            // 
            this.txtPrometna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrometna.CustomBackground = false;
            this.txtPrometna.CustomForeColor = false;
            this.txtPrometna.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtPrometna.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtPrometna.Location = new System.Drawing.Point(631, 108);
            this.txtPrometna.Multiline = false;
            this.txtPrometna.Name = "txtPrometna";
            this.txtPrometna.SelectedText = "";
            this.txtPrometna.Size = new System.Drawing.Size(220, 23);
            this.txtPrometna.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrometna.StyleManager = null;
            this.txtPrometna.TabIndex = 85;
            this.txtPrometna.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrometna.UseStyleColors = false;
            // 
            // txtServisna
            // 
            this.txtServisna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServisna.CustomBackground = false;
            this.txtServisna.CustomForeColor = false;
            this.txtServisna.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtServisna.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtServisna.Location = new System.Drawing.Point(631, 156);
            this.txtServisna.Multiline = false;
            this.txtServisna.Name = "txtServisna";
            this.txtServisna.SelectedText = "";
            this.txtServisna.Size = new System.Drawing.Size(220, 23);
            this.txtServisna.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServisna.StyleManager = null;
            this.txtServisna.TabIndex = 86;
            this.txtServisna.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServisna.UseStyleColors = false;
            // 
            // txtKilometraza
            // 
            this.txtKilometraza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKilometraza.CustomBackground = false;
            this.txtKilometraza.CustomForeColor = false;
            this.txtKilometraza.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtKilometraza.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtKilometraza.Location = new System.Drawing.Point(631, 208);
            this.txtKilometraza.Multiline = false;
            this.txtKilometraza.Name = "txtKilometraza";
            this.txtKilometraza.SelectedText = "";
            this.txtKilometraza.Size = new System.Drawing.Size(220, 23);
            this.txtKilometraza.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKilometraza.StyleManager = null;
            this.txtKilometraza.TabIndex = 87;
            this.txtKilometraza.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKilometraza.UseStyleColors = false;
            // 
            // lblParking
            // 
            this.lblParking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblParking.AutoSize = true;
            this.lblParking.CustomBackground = true;
            this.lblParking.CustomForeColor = false;
            this.lblParking.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblParking.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblParking.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblParking.Location = new System.Drawing.Point(545, 366);
            this.lblParking.Name = "lblParking";
            this.lblParking.Size = new System.Drawing.Size(80, 25);
            this.lblParking.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblParking.StyleManager = null;
            this.lblParking.TabIndex = 90;
            this.lblParking.Text = "Parking *";
            this.lblParking.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblParking.UseStyleColors = false;
            // 
            // lblCijena
            // 
            this.lblCijena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCijena.AutoSize = true;
            this.lblCijena.CustomBackground = true;
            this.lblCijena.CustomForeColor = false;
            this.lblCijena.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCijena.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblCijena.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblCijena.Location = new System.Drawing.Point(496, 421);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(129, 25);
            this.lblCijena.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblCijena.StyleManager = null;
            this.lblCijena.TabIndex = 91;
            this.lblCijena.Text = "Nabavna cijena";
            this.lblCijena.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblCijena.UseStyleColors = false;
            // 
            // lblDobavljac
            // 
            this.lblDobavljac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDobavljac.AutoSize = true;
            this.lblDobavljac.CustomBackground = true;
            this.lblDobavljac.CustomForeColor = false;
            this.lblDobavljac.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDobavljac.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDobavljac.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDobavljac.Location = new System.Drawing.Point(539, 473);
            this.lblDobavljac.Name = "lblDobavljac";
            this.lblDobavljac.Size = new System.Drawing.Size(86, 25);
            this.lblDobavljac.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDobavljac.StyleManager = null;
            this.lblDobavljac.TabIndex = 92;
            this.lblDobavljac.Text = "Dobavljač";
            this.lblDobavljac.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDobavljac.UseStyleColors = false;
            // 
            // txtCijena
            // 
            this.txtCijena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCijena.CustomBackground = false;
            this.txtCijena.CustomForeColor = false;
            this.txtCijena.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtCijena.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtCijena.Location = new System.Drawing.Point(631, 419);
            this.txtCijena.Multiline = false;
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.SelectedText = "";
            this.txtCijena.Size = new System.Drawing.Size(220, 23);
            this.txtCijena.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCijena.StyleManager = null;
            this.txtCijena.TabIndex = 94;
            this.txtCijena.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCijena.UseStyleColors = false;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.Highlight = false;
            this.btnOdustani.Location = new System.Drawing.Point(673, 589);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(223, 80);
            this.btnOdustani.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnOdustani.StyleManager = null;
            this.btnOdustani.TabIndex = 96;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDodajVozilo.Highlight = false;
            this.btnDodajVozilo.Location = new System.Drawing.Point(363, 589);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(223, 80);
            this.btnDodajVozilo.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDodajVozilo.StyleManager = null;
            this.btnDodajVozilo.TabIndex = 97;
            this.btnDodajVozilo.Text = "Dodaj vozilo";
            this.btnDodajVozilo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // txtTipVozila
            // 
            this.txtTipVozila.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTipVozila.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTipVozila.FormattingEnabled = true;
            this.txtTipVozila.Location = new System.Drawing.Point(631, 261);
            this.txtTipVozila.Name = "txtTipVozila";
            this.txtTipVozila.Size = new System.Drawing.Size(220, 21);
            this.txtTipVozila.TabIndex = 98;
            // 
            // txtModel
            // 
            this.txtModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModel.BackColor = System.Drawing.Color.Gainsboro;
            this.txtModel.FormattingEnabled = true;
            this.txtModel.Location = new System.Drawing.Point(632, 312);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(219, 21);
            this.txtModel.TabIndex = 99;
            // 
            // txtParking
            // 
            this.txtParking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParking.BackColor = System.Drawing.Color.Gainsboro;
            this.txtParking.FormattingEnabled = true;
            this.txtParking.Location = new System.Drawing.Point(632, 369);
            this.txtParking.Name = "txtParking";
            this.txtParking.Size = new System.Drawing.Size(219, 21);
            this.txtParking.TabIndex = 100;
            // 
            // cbDobavljac
            // 
            this.cbDobavljac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDobavljac.BackColor = System.Drawing.Color.Gainsboro;
            this.cbDobavljac.FormattingEnabled = true;
            this.cbDobavljac.Location = new System.Drawing.Point(631, 476);
            this.cbDobavljac.Name = "cbDobavljac";
            this.cbDobavljac.Size = new System.Drawing.Size(220, 21);
            this.cbDobavljac.TabIndex = 101;
            // 
            // frmVozilaDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.cbDobavljac);
            this.Controls.Add(this.txtParking);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtTipVozila);
            this.Controls.Add(this.btnDodajVozilo);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.lblDobavljac);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lblParking);
            this.Controls.Add(this.txtKilometraza);
            this.Controls.Add(this.txtServisna);
            this.Controls.Add(this.txtPrometna);
            this.Controls.Add(this.txtRegistracija);
            this.Controls.Add(this.txtNosivost);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblTipVozila);
            this.Controls.Add(this.lblKilometri);
            this.Controls.Add(this.lblServisna);
            this.Controls.Add(this.lblPrometna);
            this.Controls.Add(this.lblRegistracija);
            this.Controls.Add(this.lblNosivost);
            this.Controls.Add(this.lblDodajVozilo);
            this.Controls.Add(this.txtSjedista);
            this.Controls.Add(this.txtSnaga);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.txtBoja);
            this.Controls.Add(this.txtBrSasije);
            this.Controls.Add(this.lblSjedista);
            this.Controls.Add(this.lblSnaga);
            this.Controls.Add(this.lblPrvaReg);
            this.Controls.Add(this.lblBoja);
            this.Controls.Add(this.lblGodinaProizvodnje);
            this.Controls.Add(this.lblDatumNabave);
            this.Controls.Add(this.lblSasija);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dtPickerNabavka);
            this.Controls.Add(this.dtPickerPrvaRegistracija);
            this.Name = "frmVozilaDodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj vozilo";
            this.Load += new System.EventHandler(this.frmVozilaDodaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPickerPrvaRegistracija;
        private System.Windows.Forms.DateTimePicker dtPickerNabavka;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroLabel lblSasija;
        private MetroFramework.Controls.MetroLabel lblDatumNabave;
        private MetroFramework.Controls.MetroLabel lblGodinaProizvodnje;
        private MetroFramework.Controls.MetroLabel lblBoja;
        private MetroFramework.Controls.MetroLabel lblPrvaReg;
        private MetroFramework.Controls.MetroLabel lblSnaga;
        private MetroFramework.Controls.MetroLabel lblSjedista;
        private MetroFramework.Controls.MetroTextBox txtBrSasije;
        private MetroFramework.Controls.MetroTextBox txtBoja;
        private MetroFramework.Controls.MetroTextBox txtGodinaProizvodnje;
        private MetroFramework.Controls.MetroTextBox txtSnaga;
        private MetroFramework.Controls.MetroTextBox txtSjedista;
        private MetroFramework.Controls.MetroLabel lblDodajVozilo;
        private MetroFramework.Controls.MetroLabel lblNosivost;
        private MetroFramework.Controls.MetroLabel lblRegistracija;
        private MetroFramework.Controls.MetroLabel lblPrometna;
        private MetroFramework.Controls.MetroLabel lblServisna;
        private MetroFramework.Controls.MetroLabel lblKilometri;
        private MetroFramework.Controls.MetroLabel lblTipVozila;
        private MetroFramework.Controls.MetroLabel lblModel;
        private MetroFramework.Controls.MetroTextBox txtNosivost;
        private MetroFramework.Controls.MetroTextBox txtRegistracija;
        private MetroFramework.Controls.MetroTextBox txtPrometna;
        private MetroFramework.Controls.MetroTextBox txtServisna;
        private MetroFramework.Controls.MetroTextBox txtKilometraza;
        private MetroFramework.Controls.MetroLabel lblParking;
        private MetroFramework.Controls.MetroLabel lblCijena;
        private MetroFramework.Controls.MetroLabel lblDobavljac;
        private MetroFramework.Controls.MetroTextBox txtCijena;
        private MetroFramework.Controls.MetroButton btnOdustani;
        private MetroFramework.Controls.MetroButton btnDodajVozilo;
        private System.Windows.Forms.ComboBox txtTipVozila;
        private System.Windows.Forms.ComboBox txtModel;
        private System.Windows.Forms.ComboBox txtParking;
        private System.Windows.Forms.ComboBox cbDobavljac;
    }
}