namespace DriveIT
{
    partial class frmVozilaDetalji
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
            this.dtPickerNabavka = new System.Windows.Forms.DateTimePicker();
            this.dtPickerPrvaRegistracija = new System.Windows.Forms.DateTimePicker();
            this.prodajBtn = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iddodatnaopremaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljaciddobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raspoloživoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodatnaopremaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnDodajOpremu = new MetroFramework.Controls.MetroButton();
            this.lblID = new MetroFramework.Controls.MetroLabel();
            this.lblSasija = new MetroFramework.Controls.MetroLabel();
            this.lblSjedista = new MetroFramework.Controls.MetroLabel();
            this.lblBoja = new MetroFramework.Controls.MetroLabel();
            this.lblGodinaProizvodnje = new MetroFramework.Controls.MetroLabel();
            this.lblDatumNabave = new MetroFramework.Controls.MetroLabel();
            this.lblSnaga = new MetroFramework.Controls.MetroLabel();
            this.lblPrvaReg = new MetroFramework.Controls.MetroLabel();
            this.txtIdVozilo = new MetroFramework.Controls.MetroTextBox();
            this.txtBrSasije = new MetroFramework.Controls.MetroTextBox();
            this.txtBoja = new MetroFramework.Controls.MetroTextBox();
            this.txtGodinaProizvodnje = new MetroFramework.Controls.MetroTextBox();
            this.txtSnaga = new MetroFramework.Controls.MetroTextBox();
            this.txtSjedista = new MetroFramework.Controls.MetroTextBox();
            this.lblNosivost = new MetroFramework.Controls.MetroLabel();
            this.lblRegistracija = new MetroFramework.Controls.MetroLabel();
            this.lblPrometna = new MetroFramework.Controls.MetroLabel();
            this.lblServisna = new MetroFramework.Controls.MetroLabel();
            this.lblKilometri = new MetroFramework.Controls.MetroLabel();
            this.lblDodatna = new MetroFramework.Controls.MetroLabel();
            this.txtNosivost = new MetroFramework.Controls.MetroTextBox();
            this.txtRegistracija = new MetroFramework.Controls.MetroTextBox();
            this.txtPrometna = new MetroFramework.Controls.MetroTextBox();
            this.txtServisna = new MetroFramework.Controls.MetroTextBox();
            this.txtKilometraza = new MetroFramework.Controls.MetroTextBox();
            this.btnObrisiVozilo = new MetroFramework.Controls.MetroButton();
            this.btnOdustani = new MetroFramework.Controls.MetroButton();
            this.btnAzurirajVozilo = new MetroFramework.Controls.MetroButton();
            this.btnNalog = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatnaopremaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPickerNabavka
            // 
            this.dtPickerNabavka.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtPickerNabavka.Location = new System.Drawing.Point(231, 304);
            this.dtPickerNabavka.Name = "dtPickerNabavka";
            this.dtPickerNabavka.Size = new System.Drawing.Size(148, 20);
            this.dtPickerNabavka.TabIndex = 86;
            // 
            // dtPickerPrvaRegistracija
            // 
            this.dtPickerPrvaRegistracija.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtPickerPrvaRegistracija.Location = new System.Drawing.Point(231, 156);
            this.dtPickerPrvaRegistracija.Name = "dtPickerPrvaRegistracija";
            this.dtPickerPrvaRegistracija.Size = new System.Drawing.Size(148, 20);
            this.dtPickerPrvaRegistracija.TabIndex = 84;
            // 
            // prodajBtn
            // 
            this.prodajBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.prodajBtn.Highlight = false;
            this.prodajBtn.Location = new System.Drawing.Point(765, 418);
            this.prodajBtn.Name = "prodajBtn";
            this.prodajBtn.Size = new System.Drawing.Size(187, 85);
            this.prodajBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.prodajBtn.StyleManager = null;
            this.prodajBtn.TabIndex = 92;
            this.prodajBtn.Text = "PRODAJ";
            this.prodajBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.prodajBtn.Click += new System.EventHandler(this.prodajBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddodatnaopremaDataGridViewTextBoxColumn,
            this.dobavljaciddobavljacDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.raspoloživoDataGridViewTextBoxColumn,
            this.dobavljacDataGridViewTextBoxColumn,
            this.voziloDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dodatnaopremaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(52, 386);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(474, 186);
            this.dataGridView1.TabIndex = 95;
            // 
            // iddodatnaopremaDataGridViewTextBoxColumn
            // 
            this.iddodatnaopremaDataGridViewTextBoxColumn.DataPropertyName = "id_dodatna_oprema";
            this.iddodatnaopremaDataGridViewTextBoxColumn.HeaderText = "sifra";
            this.iddodatnaopremaDataGridViewTextBoxColumn.Name = "iddodatnaopremaDataGridViewTextBoxColumn";
            this.iddodatnaopremaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddodatnaopremaDataGridViewTextBoxColumn.Width = 30;
            // 
            // dobavljaciddobavljacDataGridViewTextBoxColumn
            // 
            this.dobavljaciddobavljacDataGridViewTextBoxColumn.DataPropertyName = "dobavljac_iddobavljac";
            this.dobavljaciddobavljacDataGridViewTextBoxColumn.HeaderText = "dobavljac_iddobavljac";
            this.dobavljaciddobavljacDataGridViewTextBoxColumn.Name = "dobavljaciddobavljacDataGridViewTextBoxColumn";
            this.dobavljaciddobavljacDataGridViewTextBoxColumn.ReadOnly = true;
            this.dobavljaciddobavljacDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bojaDataGridViewTextBoxColumn
            // 
            this.bojaDataGridViewTextBoxColumn.DataPropertyName = "boja";
            this.bojaDataGridViewTextBoxColumn.HeaderText = "boja";
            this.bojaDataGridViewTextBoxColumn.Name = "bojaDataGridViewTextBoxColumn";
            this.bojaDataGridViewTextBoxColumn.ReadOnly = true;
            this.bojaDataGridViewTextBoxColumn.Visible = false;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn.Visible = false;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // raspoloživoDataGridViewTextBoxColumn
            // 
            this.raspoloživoDataGridViewTextBoxColumn.DataPropertyName = "raspoloživo";
            this.raspoloživoDataGridViewTextBoxColumn.HeaderText = "raspoloživo";
            this.raspoloživoDataGridViewTextBoxColumn.Name = "raspoloživoDataGridViewTextBoxColumn";
            this.raspoloživoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dobavljacDataGridViewTextBoxColumn
            // 
            this.dobavljacDataGridViewTextBoxColumn.DataPropertyName = "dobavljac";
            this.dobavljacDataGridViewTextBoxColumn.HeaderText = "dobavljac";
            this.dobavljacDataGridViewTextBoxColumn.Name = "dobavljacDataGridViewTextBoxColumn";
            this.dobavljacDataGridViewTextBoxColumn.ReadOnly = true;
            this.dobavljacDataGridViewTextBoxColumn.Visible = false;
            // 
            // voziloDataGridViewTextBoxColumn
            // 
            this.voziloDataGridViewTextBoxColumn.DataPropertyName = "vozilo";
            this.voziloDataGridViewTextBoxColumn.HeaderText = "vozilo";
            this.voziloDataGridViewTextBoxColumn.Name = "voziloDataGridViewTextBoxColumn";
            this.voziloDataGridViewTextBoxColumn.ReadOnly = true;
            this.voziloDataGridViewTextBoxColumn.Visible = false;
            // 
            // dodatnaopremaBindingSource
            // 
            this.dodatnaopremaBindingSource.DataSource = typeof(DriveIT.Database.dodatna_oprema);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Highlight = false;
            this.metroButton1.Location = new System.Drawing.Point(765, 57);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(187, 80);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.StyleManager = null;
            this.metroButton1.TabIndex = 96;
            this.metroButton1.Text = "Slike";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnDodajOpremu
            // 
            this.btnDodajOpremu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodajOpremu.Highlight = false;
            this.btnDodajOpremu.Location = new System.Drawing.Point(765, 175);
            this.btnDodajOpremu.Name = "btnDodajOpremu";
            this.btnDodajOpremu.Size = new System.Drawing.Size(187, 80);
            this.btnDodajOpremu.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDodajOpremu.StyleManager = null;
            this.btnDodajOpremu.TabIndex = 97;
            this.btnDodajOpremu.Text = "Dodaj opremu";
            this.btnDodajOpremu.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDodajOpremu.Click += new System.EventHandler(this.btnDodajOpremu_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.CustomBackground = true;
            this.lblID.CustomForeColor = false;
            this.lblID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblID.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblID.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblID.Location = new System.Drawing.Point(132, 57);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(93, 25);
            this.lblID.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblID.StyleManager = null;
            this.lblID.TabIndex = 98;
            this.lblID.Text = "Šifra vozila";
            this.lblID.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblID.UseStyleColors = false;
            // 
            // lblSasija
            // 
            this.lblSasija.AutoSize = true;
            this.lblSasija.CustomBackground = true;
            this.lblSasija.CustomForeColor = false;
            this.lblSasija.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSasija.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblSasija.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblSasija.Location = new System.Drawing.Point(138, 106);
            this.lblSasija.Name = "lblSasija";
            this.lblSasija.Size = new System.Drawing.Size(87, 25);
            this.lblSasija.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSasija.StyleManager = null;
            this.lblSasija.TabIndex = 99;
            this.lblSasija.Text = "Broj šasije";
            this.lblSasija.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSasija.UseStyleColors = false;
            // 
            // lblSjedista
            // 
            this.lblSjedista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSjedista.AutoSize = true;
            this.lblSjedista.CustomBackground = true;
            this.lblSjedista.CustomForeColor = false;
            this.lblSjedista.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSjedista.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblSjedista.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblSjedista.Location = new System.Drawing.Point(455, 106);
            this.lblSjedista.Name = "lblSjedista";
            this.lblSjedista.Size = new System.Drawing.Size(114, 25);
            this.lblSjedista.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSjedista.StyleManager = null;
            this.lblSjedista.TabIndex = 100;
            this.lblSjedista.Text = "Broj sjedišta *";
            this.lblSjedista.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSjedista.UseStyleColors = false;
            // 
            // lblBoja
            // 
            this.lblBoja.AutoSize = true;
            this.lblBoja.CustomBackground = true;
            this.lblBoja.CustomForeColor = false;
            this.lblBoja.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBoja.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblBoja.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblBoja.Location = new System.Drawing.Point(168, 201);
            this.lblBoja.Name = "lblBoja";
            this.lblBoja.Size = new System.Drawing.Size(57, 25);
            this.lblBoja.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBoja.StyleManager = null;
            this.lblBoja.TabIndex = 101;
            this.lblBoja.Text = "Boja *";
            this.lblBoja.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblBoja.UseStyleColors = false;
            // 
            // lblGodinaProizvodnje
            // 
            this.lblGodinaProizvodnje.AutoSize = true;
            this.lblGodinaProizvodnje.CustomBackground = true;
            this.lblGodinaProizvodnje.CustomForeColor = false;
            this.lblGodinaProizvodnje.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblGodinaProizvodnje.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblGodinaProizvodnje.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblGodinaProizvodnje.Location = new System.Drawing.Point(52, 253);
            this.lblGodinaProizvodnje.Name = "lblGodinaProizvodnje";
            this.lblGodinaProizvodnje.Size = new System.Drawing.Size(173, 25);
            this.lblGodinaProizvodnje.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblGodinaProizvodnje.StyleManager = null;
            this.lblGodinaProizvodnje.TabIndex = 102;
            this.lblGodinaProizvodnje.Text = "Godina proizvodnje *";
            this.lblGodinaProizvodnje.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblGodinaProizvodnje.UseStyleColors = false;
            // 
            // lblDatumNabave
            // 
            this.lblDatumNabave.AutoSize = true;
            this.lblDatumNabave.CustomBackground = true;
            this.lblDatumNabave.CustomForeColor = false;
            this.lblDatumNabave.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDatumNabave.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDatumNabave.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDatumNabave.Location = new System.Drawing.Point(102, 299);
            this.lblDatumNabave.Name = "lblDatumNabave";
            this.lblDatumNabave.Size = new System.Drawing.Size(123, 25);
            this.lblDatumNabave.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDatumNabave.StyleManager = null;
            this.lblDatumNabave.TabIndex = 103;
            this.lblDatumNabave.Text = "Datum nabave";
            this.lblDatumNabave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDatumNabave.UseStyleColors = false;
            // 
            // lblSnaga
            // 
            this.lblSnaga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSnaga.AutoSize = true;
            this.lblSnaga.CustomBackground = true;
            this.lblSnaga.CustomForeColor = false;
            this.lblSnaga.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSnaga.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblSnaga.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblSnaga.Location = new System.Drawing.Point(458, 57);
            this.lblSnaga.Name = "lblSnaga";
            this.lblSnaga.Size = new System.Drawing.Size(111, 25);
            this.lblSnaga.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSnaga.StyleManager = null;
            this.lblSnaga.TabIndex = 104;
            this.lblSnaga.Text = "Snaga (KW) *";
            this.lblSnaga.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSnaga.UseStyleColors = false;
            // 
            // lblPrvaReg
            // 
            this.lblPrvaReg.AutoSize = true;
            this.lblPrvaReg.CustomBackground = true;
            this.lblPrvaReg.CustomForeColor = false;
            this.lblPrvaReg.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPrvaReg.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblPrvaReg.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblPrvaReg.Location = new System.Drawing.Point(93, 151);
            this.lblPrvaReg.Name = "lblPrvaReg";
            this.lblPrvaReg.Size = new System.Drawing.Size(132, 25);
            this.lblPrvaReg.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblPrvaReg.StyleManager = null;
            this.lblPrvaReg.TabIndex = 105;
            this.lblPrvaReg.Text = "Prva registracija";
            this.lblPrvaReg.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblPrvaReg.UseStyleColors = false;
            // 
            // txtIdVozilo
            // 
            this.txtIdVozilo.CustomBackground = false;
            this.txtIdVozilo.CustomForeColor = false;
            this.txtIdVozilo.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtIdVozilo.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtIdVozilo.Location = new System.Drawing.Point(231, 57);
            this.txtIdVozilo.Multiline = false;
            this.txtIdVozilo.Name = "txtIdVozilo";
            this.txtIdVozilo.SelectedText = "";
            this.txtIdVozilo.Size = new System.Drawing.Size(148, 23);
            this.txtIdVozilo.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdVozilo.StyleManager = null;
            this.txtIdVozilo.TabIndex = 106;
            this.txtIdVozilo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdVozilo.UseStyleColors = false;
            // 
            // txtBrSasije
            // 
            this.txtBrSasije.CustomBackground = false;
            this.txtBrSasije.CustomForeColor = false;
            this.txtBrSasije.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtBrSasije.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtBrSasije.Location = new System.Drawing.Point(231, 108);
            this.txtBrSasije.Multiline = false;
            this.txtBrSasije.Name = "txtBrSasije";
            this.txtBrSasije.SelectedText = "";
            this.txtBrSasije.Size = new System.Drawing.Size(148, 23);
            this.txtBrSasije.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBrSasije.StyleManager = null;
            this.txtBrSasije.TabIndex = 107;
            this.txtBrSasije.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBrSasije.UseStyleColors = false;
            // 
            // txtBoja
            // 
            this.txtBoja.CustomBackground = false;
            this.txtBoja.CustomForeColor = false;
            this.txtBoja.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtBoja.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtBoja.Location = new System.Drawing.Point(231, 201);
            this.txtBoja.Multiline = false;
            this.txtBoja.Name = "txtBoja";
            this.txtBoja.SelectedText = "";
            this.txtBoja.Size = new System.Drawing.Size(148, 23);
            this.txtBoja.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoja.StyleManager = null;
            this.txtBoja.TabIndex = 108;
            this.txtBoja.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoja.UseStyleColors = false;
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.CustomBackground = false;
            this.txtGodinaProizvodnje.CustomForeColor = false;
            this.txtGodinaProizvodnje.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtGodinaProizvodnje.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(231, 255);
            this.txtGodinaProizvodnje.Multiline = false;
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.SelectedText = "";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(148, 23);
            this.txtGodinaProizvodnje.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGodinaProizvodnje.StyleManager = null;
            this.txtGodinaProizvodnje.TabIndex = 109;
            this.txtGodinaProizvodnje.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGodinaProizvodnje.UseStyleColors = false;
            // 
            // txtSnaga
            // 
            this.txtSnaga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSnaga.CustomBackground = false;
            this.txtSnaga.CustomForeColor = false;
            this.txtSnaga.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtSnaga.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtSnaga.Location = new System.Drawing.Point(575, 57);
            this.txtSnaga.Multiline = false;
            this.txtSnaga.Name = "txtSnaga";
            this.txtSnaga.SelectedText = "";
            this.txtSnaga.Size = new System.Drawing.Size(148, 23);
            this.txtSnaga.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSnaga.StyleManager = null;
            this.txtSnaga.TabIndex = 110;
            this.txtSnaga.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSnaga.UseStyleColors = false;
            // 
            // txtSjedista
            // 
            this.txtSjedista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSjedista.CustomBackground = false;
            this.txtSjedista.CustomForeColor = false;
            this.txtSjedista.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtSjedista.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtSjedista.Location = new System.Drawing.Point(575, 108);
            this.txtSjedista.Multiline = false;
            this.txtSjedista.Name = "txtSjedista";
            this.txtSjedista.SelectedText = "";
            this.txtSjedista.Size = new System.Drawing.Size(148, 23);
            this.txtSjedista.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSjedista.StyleManager = null;
            this.txtSjedista.TabIndex = 111;
            this.txtSjedista.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSjedista.UseStyleColors = false;
            // 
            // lblNosivost
            // 
            this.lblNosivost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNosivost.AutoSize = true;
            this.lblNosivost.CustomBackground = true;
            this.lblNosivost.CustomForeColor = false;
            this.lblNosivost.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNosivost.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblNosivost.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblNosivost.Location = new System.Drawing.Point(493, 151);
            this.lblNosivost.Name = "lblNosivost";
            this.lblNosivost.Size = new System.Drawing.Size(76, 25);
            this.lblNosivost.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblNosivost.StyleManager = null;
            this.lblNosivost.TabIndex = 112;
            this.lblNosivost.Text = "Nosivost";
            this.lblNosivost.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNosivost.UseStyleColors = false;
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.CustomBackground = true;
            this.lblRegistracija.CustomForeColor = false;
            this.lblRegistracija.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRegistracija.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblRegistracija.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblRegistracija.Location = new System.Drawing.Point(414, 201);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(155, 25);
            this.lblRegistracija.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblRegistracija.StyleManager = null;
            this.lblRegistracija.TabIndex = 113;
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
            this.lblPrometna.Location = new System.Drawing.Point(427, 253);
            this.lblPrometna.Name = "lblPrometna";
            this.lblPrometna.Size = new System.Drawing.Size(142, 25);
            this.lblPrometna.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblPrometna.StyleManager = null;
            this.lblPrometna.TabIndex = 114;
            this.lblPrometna.Text = "Prometna knjžica";
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
            this.lblServisna.Location = new System.Drawing.Point(434, 299);
            this.lblServisna.Name = "lblServisna";
            this.lblServisna.Size = new System.Drawing.Size(135, 25);
            this.lblServisna.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblServisna.StyleManager = null;
            this.lblServisna.TabIndex = 115;
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
            this.lblKilometri.Location = new System.Drawing.Point(434, 358);
            this.lblKilometri.Name = "lblKilometri";
            this.lblKilometri.Size = new System.Drawing.Size(138, 25);
            this.lblKilometri.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblKilometri.StyleManager = null;
            this.lblKilometri.TabIndex = 116;
            this.lblKilometri.Text = "Broj kilometara *";
            this.lblKilometri.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblKilometri.UseStyleColors = false;
            // 
            // lblDodatna
            // 
            this.lblDodatna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDodatna.AutoSize = true;
            this.lblDodatna.CustomBackground = true;
            this.lblDodatna.CustomForeColor = false;
            this.lblDodatna.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDodatna.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDodatna.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDodatna.Location = new System.Drawing.Point(231, 358);
            this.lblDodatna.Name = "lblDodatna";
            this.lblDodatna.Size = new System.Drawing.Size(141, 25);
            this.lblDodatna.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDodatna.StyleManager = null;
            this.lblDodatna.TabIndex = 117;
            this.lblDodatna.Text = "Dodatna oprema";
            this.lblDodatna.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDodatna.UseStyleColors = false;
            // 
            // txtNosivost
            // 
            this.txtNosivost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNosivost.CustomBackground = false;
            this.txtNosivost.CustomForeColor = false;
            this.txtNosivost.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtNosivost.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtNosivost.Location = new System.Drawing.Point(575, 153);
            this.txtNosivost.Multiline = false;
            this.txtNosivost.Name = "txtNosivost";
            this.txtNosivost.SelectedText = "";
            this.txtNosivost.Size = new System.Drawing.Size(148, 23);
            this.txtNosivost.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNosivost.StyleManager = null;
            this.txtNosivost.TabIndex = 118;
            this.txtNosivost.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNosivost.UseStyleColors = false;
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegistracija.CustomBackground = false;
            this.txtRegistracija.CustomForeColor = false;
            this.txtRegistracija.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtRegistracija.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtRegistracija.Location = new System.Drawing.Point(575, 201);
            this.txtRegistracija.Multiline = false;
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.SelectedText = "";
            this.txtRegistracija.Size = new System.Drawing.Size(148, 23);
            this.txtRegistracija.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRegistracija.StyleManager = null;
            this.txtRegistracija.TabIndex = 119;
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
            this.txtPrometna.Location = new System.Drawing.Point(575, 255);
            this.txtPrometna.Multiline = false;
            this.txtPrometna.Name = "txtPrometna";
            this.txtPrometna.SelectedText = "";
            this.txtPrometna.Size = new System.Drawing.Size(148, 23);
            this.txtPrometna.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrometna.StyleManager = null;
            this.txtPrometna.TabIndex = 120;
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
            this.txtServisna.Location = new System.Drawing.Point(575, 301);
            this.txtServisna.Multiline = false;
            this.txtServisna.Name = "txtServisna";
            this.txtServisna.SelectedText = "";
            this.txtServisna.Size = new System.Drawing.Size(148, 23);
            this.txtServisna.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServisna.StyleManager = null;
            this.txtServisna.TabIndex = 121;
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
            this.txtKilometraza.Location = new System.Drawing.Point(578, 358);
            this.txtKilometraza.Multiline = false;
            this.txtKilometraza.Name = "txtKilometraza";
            this.txtKilometraza.SelectedText = "";
            this.txtKilometraza.Size = new System.Drawing.Size(145, 23);
            this.txtKilometraza.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKilometraza.StyleManager = null;
            this.txtKilometraza.TabIndex = 122;
            this.txtKilometraza.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKilometraza.UseStyleColors = false;
            // 
            // btnObrisiVozilo
            // 
            this.btnObrisiVozilo.Highlight = false;
            this.btnObrisiVozilo.Location = new System.Drawing.Point(339, 604);
            this.btnObrisiVozilo.Name = "btnObrisiVozilo";
            this.btnObrisiVozilo.Size = new System.Drawing.Size(187, 80);
            this.btnObrisiVozilo.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnObrisiVozilo.StyleManager = null;
            this.btnObrisiVozilo.TabIndex = 123;
            this.btnObrisiVozilo.Text = "Obriši vozilo";
            this.btnObrisiVozilo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnObrisiVozilo.Click += new System.EventHandler(this.btnObrisiVozilo_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.Highlight = false;
            this.btnOdustani.Location = new System.Drawing.Point(765, 604);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(187, 80);
            this.btnOdustani.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnOdustani.StyleManager = null;
            this.btnOdustani.TabIndex = 124;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnAzurirajVozilo
            // 
            this.btnAzurirajVozilo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAzurirajVozilo.Highlight = false;
            this.btnAzurirajVozilo.Location = new System.Drawing.Point(52, 604);
            this.btnAzurirajVozilo.Name = "btnAzurirajVozilo";
            this.btnAzurirajVozilo.Size = new System.Drawing.Size(187, 80);
            this.btnAzurirajVozilo.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAzurirajVozilo.StyleManager = null;
            this.btnAzurirajVozilo.TabIndex = 125;
            this.btnAzurirajVozilo.Text = "Ažuriraj vozilo";
            this.btnAzurirajVozilo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAzurirajVozilo.Click += new System.EventHandler(this.btnAzurirajVozilo_Click);
            // 
            // btnNalog
            // 
            this.btnNalog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNalog.Highlight = false;
            this.btnNalog.Location = new System.Drawing.Point(765, 299);
            this.btnNalog.Name = "btnNalog";
            this.btnNalog.Size = new System.Drawing.Size(187, 80);
            this.btnNalog.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnNalog.StyleManager = null;
            this.btnNalog.TabIndex = 126;
            this.btnNalog.Text = "Nalog za popravak";
            this.btnNalog.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnNalog.Click += new System.EventHandler(this.btnNalog_Click);
            // 
            // frmVozilaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.btnNalog);
            this.Controls.Add(this.btnAzurirajVozilo);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnObrisiVozilo);
            this.Controls.Add(this.txtKilometraza);
            this.Controls.Add(this.txtServisna);
            this.Controls.Add(this.txtPrometna);
            this.Controls.Add(this.txtRegistracija);
            this.Controls.Add(this.txtNosivost);
            this.Controls.Add(this.lblDodatna);
            this.Controls.Add(this.lblKilometri);
            this.Controls.Add(this.lblServisna);
            this.Controls.Add(this.lblPrometna);
            this.Controls.Add(this.lblRegistracija);
            this.Controls.Add(this.lblNosivost);
            this.Controls.Add(this.txtSjedista);
            this.Controls.Add(this.txtSnaga);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.txtBoja);
            this.Controls.Add(this.txtBrSasije);
            this.Controls.Add(this.txtIdVozilo);
            this.Controls.Add(this.lblPrvaReg);
            this.Controls.Add(this.lblSnaga);
            this.Controls.Add(this.lblDatumNabave);
            this.Controls.Add(this.lblGodinaProizvodnje);
            this.Controls.Add(this.lblBoja);
            this.Controls.Add(this.lblSjedista);
            this.Controls.Add(this.lblSasija);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnDodajOpremu);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.prodajBtn);
            this.Controls.Add(this.dtPickerNabavka);
            this.Controls.Add(this.dtPickerPrvaRegistracija);
            this.Name = "frmVozilaDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VozilaDetalji";
            this.Load += new System.EventHandler(this.VozilaDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatnaopremaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPickerNabavka;
        private System.Windows.Forms.DateTimePicker dtPickerPrvaRegistracija;
        private MetroFramework.Controls.MetroButton prodajBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dodatnaopremaBindingSource;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnDodajOpremu;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddodatnaopremaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljaciddobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raspoloživoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel lblID;
        private MetroFramework.Controls.MetroLabel lblSasija;
        private MetroFramework.Controls.MetroLabel lblSjedista;
        private MetroFramework.Controls.MetroLabel lblBoja;
        private MetroFramework.Controls.MetroLabel lblGodinaProizvodnje;
        private MetroFramework.Controls.MetroLabel lblDatumNabave;
        private MetroFramework.Controls.MetroLabel lblSnaga;
        private MetroFramework.Controls.MetroLabel lblPrvaReg;
        private MetroFramework.Controls.MetroTextBox txtIdVozilo;
        private MetroFramework.Controls.MetroTextBox txtBrSasije;
        private MetroFramework.Controls.MetroTextBox txtBoja;
        private MetroFramework.Controls.MetroTextBox txtGodinaProizvodnje;
        private MetroFramework.Controls.MetroTextBox txtSnaga;
        private MetroFramework.Controls.MetroTextBox txtSjedista;
        private MetroFramework.Controls.MetroLabel lblNosivost;
        private MetroFramework.Controls.MetroLabel lblRegistracija;
        private MetroFramework.Controls.MetroLabel lblPrometna;
        private MetroFramework.Controls.MetroLabel lblServisna;
        private MetroFramework.Controls.MetroLabel lblKilometri;
        private MetroFramework.Controls.MetroLabel lblDodatna;
        private MetroFramework.Controls.MetroTextBox txtNosivost;
        private MetroFramework.Controls.MetroTextBox txtRegistracija;
        private MetroFramework.Controls.MetroTextBox txtPrometna;
        private MetroFramework.Controls.MetroTextBox txtServisna;
        private MetroFramework.Controls.MetroTextBox txtKilometraza;
        private MetroFramework.Controls.MetroButton btnObrisiVozilo;
        private MetroFramework.Controls.MetroButton btnOdustani;
        private MetroFramework.Controls.MetroButton btnAzurirajVozilo;
        private MetroFramework.Controls.MetroButton btnNalog;
    }
}