﻿namespace DriveIT
{
    partial class frmVozila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVozila));
            this.btnIzlaz = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idvoziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sasijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumprveregistracijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaproizvodnjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumnabavkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snagakwDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sjedistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nosivostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registracijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prometnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servisnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipvozilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelvozilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelvozila1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nalogzaservisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parking1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slikavoziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipvozila1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugovorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodatnaopremaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPretraga = new MetroFramework.Controls.MetroLabel();
            this.txtPretragaVozila = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDodajVozilo = new MetroFramework.Controls.MetroButton();
            this.btnoOsvjezi = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzlaz.Highlight = false;
            this.btnIzlaz.Location = new System.Drawing.Point(679, 604);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(280, 80);
            this.btnIzlaz.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnIzlaz.StyleManager = null;
            this.btnIzlaz.TabIndex = 0;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvoziloDataGridViewTextBoxColumn,
            this.sasijaDataGridViewTextBoxColumn,
            this.datumprveregistracijeDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn,
            this.godinaproizvodnjeDataGridViewTextBoxColumn,
            this.datumnabavkeDataGridViewTextBoxColumn,
            this.snagakwDataGridViewTextBoxColumn,
            this.sjedistaDataGridViewTextBoxColumn,
            this.nosivostDataGridViewTextBoxColumn,
            this.registracijaDataGridViewTextBoxColumn,
            this.prometnaDataGridViewTextBoxColumn,
            this.servisnaDataGridViewTextBoxColumn,
            this.kilometriDataGridViewTextBoxColumn,
            this.tipvozilaDataGridViewTextBoxColumn,
            this.modelvozilaDataGridViewTextBoxColumn,
            this.parkingDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.modelvozila1DataGridViewTextBoxColumn,
            this.nalogzaservisDataGridViewTextBoxColumn,
            this.parking1DataGridViewTextBoxColumn,
            this.slikavoziloDataGridViewTextBoxColumn,
            this.tipvozila1DataGridViewTextBoxColumn,
            this.ugovorDataGridViewTextBoxColumn,
            this.dodatnaopremaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.voziloBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(934, 331);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idvoziloDataGridViewTextBoxColumn
            // 
            this.idvoziloDataGridViewTextBoxColumn.DataPropertyName = "id_vozilo";
            this.idvoziloDataGridViewTextBoxColumn.HeaderText = "šifra";
            this.idvoziloDataGridViewTextBoxColumn.Name = "idvoziloDataGridViewTextBoxColumn";
            this.idvoziloDataGridViewTextBoxColumn.ReadOnly = true;
            this.idvoziloDataGridViewTextBoxColumn.Width = 30;
            // 
            // sasijaDataGridViewTextBoxColumn
            // 
            this.sasijaDataGridViewTextBoxColumn.DataPropertyName = "sasija";
            this.sasijaDataGridViewTextBoxColumn.HeaderText = "sasija";
            this.sasijaDataGridViewTextBoxColumn.Name = "sasijaDataGridViewTextBoxColumn";
            this.sasijaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumprveregistracijeDataGridViewTextBoxColumn
            // 
            this.datumprveregistracijeDataGridViewTextBoxColumn.DataPropertyName = "datum_prve_registracije";
            this.datumprveregistracijeDataGridViewTextBoxColumn.HeaderText = "prva registracija";
            this.datumprveregistracijeDataGridViewTextBoxColumn.Name = "datumprveregistracijeDataGridViewTextBoxColumn";
            this.datumprveregistracijeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bojaDataGridViewTextBoxColumn
            // 
            this.bojaDataGridViewTextBoxColumn.DataPropertyName = "boja";
            this.bojaDataGridViewTextBoxColumn.HeaderText = "boja";
            this.bojaDataGridViewTextBoxColumn.Name = "bojaDataGridViewTextBoxColumn";
            this.bojaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // godinaproizvodnjeDataGridViewTextBoxColumn
            // 
            this.godinaproizvodnjeDataGridViewTextBoxColumn.DataPropertyName = "godina_proizvodnje";
            this.godinaproizvodnjeDataGridViewTextBoxColumn.HeaderText = "godina proizvodnje";
            this.godinaproizvodnjeDataGridViewTextBoxColumn.Name = "godinaproizvodnjeDataGridViewTextBoxColumn";
            this.godinaproizvodnjeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumnabavkeDataGridViewTextBoxColumn
            // 
            this.datumnabavkeDataGridViewTextBoxColumn.DataPropertyName = "datum_nabavke";
            this.datumnabavkeDataGridViewTextBoxColumn.HeaderText = "nabavljeno";
            this.datumnabavkeDataGridViewTextBoxColumn.Name = "datumnabavkeDataGridViewTextBoxColumn";
            this.datumnabavkeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // snagakwDataGridViewTextBoxColumn
            // 
            this.snagakwDataGridViewTextBoxColumn.DataPropertyName = "snaga_kw";
            this.snagakwDataGridViewTextBoxColumn.HeaderText = "snaga (KW)";
            this.snagakwDataGridViewTextBoxColumn.Name = "snagakwDataGridViewTextBoxColumn";
            this.snagakwDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sjedistaDataGridViewTextBoxColumn
            // 
            this.sjedistaDataGridViewTextBoxColumn.DataPropertyName = "sjedista";
            this.sjedistaDataGridViewTextBoxColumn.HeaderText = "sjedišta";
            this.sjedistaDataGridViewTextBoxColumn.Name = "sjedistaDataGridViewTextBoxColumn";
            this.sjedistaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nosivostDataGridViewTextBoxColumn
            // 
            this.nosivostDataGridViewTextBoxColumn.DataPropertyName = "nosivost";
            this.nosivostDataGridViewTextBoxColumn.HeaderText = "nosivost";
            this.nosivostDataGridViewTextBoxColumn.Name = "nosivostDataGridViewTextBoxColumn";
            this.nosivostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registracijaDataGridViewTextBoxColumn
            // 
            this.registracijaDataGridViewTextBoxColumn.DataPropertyName = "registracija";
            this.registracijaDataGridViewTextBoxColumn.HeaderText = "registracija";
            this.registracijaDataGridViewTextBoxColumn.Name = "registracijaDataGridViewTextBoxColumn";
            this.registracijaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prometnaDataGridViewTextBoxColumn
            // 
            this.prometnaDataGridViewTextBoxColumn.DataPropertyName = "prometna";
            this.prometnaDataGridViewTextBoxColumn.HeaderText = "prometna knjižica";
            this.prometnaDataGridViewTextBoxColumn.Name = "prometnaDataGridViewTextBoxColumn";
            this.prometnaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // servisnaDataGridViewTextBoxColumn
            // 
            this.servisnaDataGridViewTextBoxColumn.DataPropertyName = "servisna";
            this.servisnaDataGridViewTextBoxColumn.HeaderText = "servisna knjižica";
            this.servisnaDataGridViewTextBoxColumn.Name = "servisnaDataGridViewTextBoxColumn";
            this.servisnaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kilometriDataGridViewTextBoxColumn
            // 
            this.kilometriDataGridViewTextBoxColumn.DataPropertyName = "kilometri";
            this.kilometriDataGridViewTextBoxColumn.HeaderText = "kilometraža";
            this.kilometriDataGridViewTextBoxColumn.Name = "kilometriDataGridViewTextBoxColumn";
            this.kilometriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipvozilaDataGridViewTextBoxColumn
            // 
            this.tipvozilaDataGridViewTextBoxColumn.DataPropertyName = "tip_vozila";
            this.tipvozilaDataGridViewTextBoxColumn.HeaderText = "tip vozila";
            this.tipvozilaDataGridViewTextBoxColumn.Name = "tipvozilaDataGridViewTextBoxColumn";
            this.tipvozilaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelvozilaDataGridViewTextBoxColumn
            // 
            this.modelvozilaDataGridViewTextBoxColumn.DataPropertyName = "model_vozila";
            this.modelvozilaDataGridViewTextBoxColumn.HeaderText = "model vozila";
            this.modelvozilaDataGridViewTextBoxColumn.Name = "modelvozilaDataGridViewTextBoxColumn";
            this.modelvozilaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parkingDataGridViewTextBoxColumn
            // 
            this.parkingDataGridViewTextBoxColumn.DataPropertyName = "parking";
            this.parkingDataGridViewTextBoxColumn.HeaderText = "parking";
            this.parkingDataGridViewTextBoxColumn.Name = "parkingDataGridViewTextBoxColumn";
            this.parkingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelvozila1DataGridViewTextBoxColumn
            // 
            this.modelvozila1DataGridViewTextBoxColumn.DataPropertyName = "model_vozila1";
            this.modelvozila1DataGridViewTextBoxColumn.HeaderText = "model_vozila1";
            this.modelvozila1DataGridViewTextBoxColumn.Name = "modelvozila1DataGridViewTextBoxColumn";
            this.modelvozila1DataGridViewTextBoxColumn.ReadOnly = true;
            this.modelvozila1DataGridViewTextBoxColumn.Visible = false;
            // 
            // nalogzaservisDataGridViewTextBoxColumn
            // 
            this.nalogzaservisDataGridViewTextBoxColumn.DataPropertyName = "nalog_za_servis";
            this.nalogzaservisDataGridViewTextBoxColumn.HeaderText = "nalog_za_servis";
            this.nalogzaservisDataGridViewTextBoxColumn.Name = "nalogzaservisDataGridViewTextBoxColumn";
            this.nalogzaservisDataGridViewTextBoxColumn.ReadOnly = true;
            this.nalogzaservisDataGridViewTextBoxColumn.Visible = false;
            // 
            // parking1DataGridViewTextBoxColumn
            // 
            this.parking1DataGridViewTextBoxColumn.DataPropertyName = "parking1";
            this.parking1DataGridViewTextBoxColumn.HeaderText = "parking1";
            this.parking1DataGridViewTextBoxColumn.Name = "parking1DataGridViewTextBoxColumn";
            this.parking1DataGridViewTextBoxColumn.ReadOnly = true;
            this.parking1DataGridViewTextBoxColumn.Visible = false;
            // 
            // slikavoziloDataGridViewTextBoxColumn
            // 
            this.slikavoziloDataGridViewTextBoxColumn.DataPropertyName = "slika_vozilo";
            this.slikavoziloDataGridViewTextBoxColumn.HeaderText = "slika_vozilo";
            this.slikavoziloDataGridViewTextBoxColumn.Name = "slikavoziloDataGridViewTextBoxColumn";
            this.slikavoziloDataGridViewTextBoxColumn.ReadOnly = true;
            this.slikavoziloDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipvozila1DataGridViewTextBoxColumn
            // 
            this.tipvozila1DataGridViewTextBoxColumn.DataPropertyName = "tip_vozila1";
            this.tipvozila1DataGridViewTextBoxColumn.HeaderText = "tip_vozila1";
            this.tipvozila1DataGridViewTextBoxColumn.Name = "tipvozila1DataGridViewTextBoxColumn";
            this.tipvozila1DataGridViewTextBoxColumn.ReadOnly = true;
            this.tipvozila1DataGridViewTextBoxColumn.Visible = false;
            // 
            // ugovorDataGridViewTextBoxColumn
            // 
            this.ugovorDataGridViewTextBoxColumn.DataPropertyName = "ugovor";
            this.ugovorDataGridViewTextBoxColumn.HeaderText = "ugovor";
            this.ugovorDataGridViewTextBoxColumn.Name = "ugovorDataGridViewTextBoxColumn";
            this.ugovorDataGridViewTextBoxColumn.ReadOnly = true;
            this.ugovorDataGridViewTextBoxColumn.Visible = false;
            // 
            // dodatnaopremaDataGridViewTextBoxColumn
            // 
            this.dodatnaopremaDataGridViewTextBoxColumn.DataPropertyName = "dodatna_oprema";
            this.dodatnaopremaDataGridViewTextBoxColumn.HeaderText = "dodatna_oprema";
            this.dodatnaopremaDataGridViewTextBoxColumn.Name = "dodatnaopremaDataGridViewTextBoxColumn";
            this.dodatnaopremaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dodatnaopremaDataGridViewTextBoxColumn.Visible = false;
            // 
            // voziloBindingSource
            // 
            this.voziloBindingSource.DataSource = typeof(DriveIT.Database.vozilo);
            // 
            // lblPretraga
            // 
            this.lblPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.CustomBackground = true;
            this.lblPretraga.CustomForeColor = false;
            this.lblPretraga.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblPretraga.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblPretraga.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblPretraga.Location = new System.Drawing.Point(685, 108);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(60, 19);
            this.lblPretraga.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblPretraga.StyleManager = null;
            this.lblPretraga.TabIndex = 1;
            this.lblPretraga.Text = "Pretraga";
            this.lblPretraga.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblPretraga.UseStyleColors = false;
            // 
            // txtPretragaVozila
            // 
            this.txtPretragaVozila.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPretragaVozila.CustomBackground = false;
            this.txtPretragaVozila.CustomForeColor = false;
            this.txtPretragaVozila.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtPretragaVozila.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtPretragaVozila.Location = new System.Drawing.Point(751, 104);
            this.txtPretragaVozila.Multiline = false;
            this.txtPretragaVozila.Name = "txtPretragaVozila";
            this.txtPretragaVozila.SelectedText = "";
            this.txtPretragaVozila.Size = new System.Drawing.Size(150, 23);
            this.txtPretragaVozila.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPretragaVozila.StyleManager = null;
            this.txtPretragaVozila.TabIndex = 2;
            this.txtPretragaVozila.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPretragaVozila.UseStyleColors = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(907, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 620);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(422, 133);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Highlight = false;
            this.btnDodajVozilo.Location = new System.Drawing.Point(26, 77);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(280, 80);
            this.btnDodajVozilo.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDodajVozilo.StyleManager = null;
            this.btnDodajVozilo.TabIndex = 8;
            this.btnDodajVozilo.Text = "Dodaj novo vozilo";
            this.btnDodajVozilo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // btnoOsvjezi
            // 
            this.btnoOsvjezi.Highlight = false;
            this.btnoOsvjezi.Location = new System.Drawing.Point(340, 77);
            this.btnoOsvjezi.Name = "btnoOsvjezi";
            this.btnoOsvjezi.Size = new System.Drawing.Size(280, 80);
            this.btnoOsvjezi.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnoOsvjezi.StyleManager = null;
            this.btnoOsvjezi.TabIndex = 9;
            this.btnoOsvjezi.Text = "Osvježi";
            this.btnoOsvjezi.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnoOsvjezi.Click += new System.EventHandler(this.btnoOsvjezi_Click);
            // 
            // frmVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.btnoOsvjezi);
            this.Controls.Add(this.btnDodajVozilo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPretragaVozila);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmVozila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vozila";
            this.Load += new System.EventHandler(this.frmVozila_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private MetroFramework.Controls.MetroButton btnIzlaz;

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource voziloBindingSource;
        private MetroFramework.Controls.MetroLabel lblPretraga;
        private MetroFramework.Controls.MetroTextBox txtPretragaVozila;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton btnDodajVozilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvoziloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sasijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumprveregistracijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaproizvodnjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumnabavkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snagakwDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sjedistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nosivostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registracijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prometnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servisnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipvozilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelvozilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelvozila1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nalogzaservisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parking1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slikavoziloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipvozila1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugovorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dodatnaopremaDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btnoOsvjezi;

    }
}