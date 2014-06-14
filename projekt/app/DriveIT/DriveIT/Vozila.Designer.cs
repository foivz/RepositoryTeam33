namespace DriveIT
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
            this.dobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelvozila1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nalogzaservisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parking1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slikavoziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipvozila1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugovorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodatnaopremaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.dobavljacDataGridViewTextBoxColumn,
            this.modelvozila1DataGridViewTextBoxColumn,
            this.nalogzaservisDataGridViewTextBoxColumn,
            this.parking1DataGridViewTextBoxColumn,
            this.slikavoziloDataGridViewTextBoxColumn,
            this.tipvozila1DataGridViewTextBoxColumn,
            this.ugovorDataGridViewTextBoxColumn,
            this.dodatnaopremaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.voziloBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(607, 178);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idvoziloDataGridViewTextBoxColumn
            // 
            this.idvoziloDataGridViewTextBoxColumn.DataPropertyName = "id_vozilo";
            this.idvoziloDataGridViewTextBoxColumn.HeaderText = "id_vozilo";
            this.idvoziloDataGridViewTextBoxColumn.Name = "idvoziloDataGridViewTextBoxColumn";
            // 
            // sasijaDataGridViewTextBoxColumn
            // 
            this.sasijaDataGridViewTextBoxColumn.DataPropertyName = "sasija";
            this.sasijaDataGridViewTextBoxColumn.HeaderText = "sasija";
            this.sasijaDataGridViewTextBoxColumn.Name = "sasijaDataGridViewTextBoxColumn";
            // 
            // datumprveregistracijeDataGridViewTextBoxColumn
            // 
            this.datumprveregistracijeDataGridViewTextBoxColumn.DataPropertyName = "datum_prve_registracije";
            this.datumprveregistracijeDataGridViewTextBoxColumn.HeaderText = "datum_prve_registracije";
            this.datumprveregistracijeDataGridViewTextBoxColumn.Name = "datumprveregistracijeDataGridViewTextBoxColumn";
            // 
            // bojaDataGridViewTextBoxColumn
            // 
            this.bojaDataGridViewTextBoxColumn.DataPropertyName = "boja";
            this.bojaDataGridViewTextBoxColumn.HeaderText = "boja";
            this.bojaDataGridViewTextBoxColumn.Name = "bojaDataGridViewTextBoxColumn";
            // 
            // godinaproizvodnjeDataGridViewTextBoxColumn
            // 
            this.godinaproizvodnjeDataGridViewTextBoxColumn.DataPropertyName = "godina_proizvodnje";
            this.godinaproizvodnjeDataGridViewTextBoxColumn.HeaderText = "godina_proizvodnje";
            this.godinaproizvodnjeDataGridViewTextBoxColumn.Name = "godinaproizvodnjeDataGridViewTextBoxColumn";
            // 
            // datumnabavkeDataGridViewTextBoxColumn
            // 
            this.datumnabavkeDataGridViewTextBoxColumn.DataPropertyName = "datum_nabavke";
            this.datumnabavkeDataGridViewTextBoxColumn.HeaderText = "datum_nabavke";
            this.datumnabavkeDataGridViewTextBoxColumn.Name = "datumnabavkeDataGridViewTextBoxColumn";
            // 
            // snagakwDataGridViewTextBoxColumn
            // 
            this.snagakwDataGridViewTextBoxColumn.DataPropertyName = "snaga_kw";
            this.snagakwDataGridViewTextBoxColumn.HeaderText = "snaga_kw";
            this.snagakwDataGridViewTextBoxColumn.Name = "snagakwDataGridViewTextBoxColumn";
            // 
            // sjedistaDataGridViewTextBoxColumn
            // 
            this.sjedistaDataGridViewTextBoxColumn.DataPropertyName = "sjedista";
            this.sjedistaDataGridViewTextBoxColumn.HeaderText = "sjedista";
            this.sjedistaDataGridViewTextBoxColumn.Name = "sjedistaDataGridViewTextBoxColumn";
            // 
            // nosivostDataGridViewTextBoxColumn
            // 
            this.nosivostDataGridViewTextBoxColumn.DataPropertyName = "nosivost";
            this.nosivostDataGridViewTextBoxColumn.HeaderText = "nosivost";
            this.nosivostDataGridViewTextBoxColumn.Name = "nosivostDataGridViewTextBoxColumn";
            // 
            // registracijaDataGridViewTextBoxColumn
            // 
            this.registracijaDataGridViewTextBoxColumn.DataPropertyName = "registracija";
            this.registracijaDataGridViewTextBoxColumn.HeaderText = "registracija";
            this.registracijaDataGridViewTextBoxColumn.Name = "registracijaDataGridViewTextBoxColumn";
            // 
            // prometnaDataGridViewTextBoxColumn
            // 
            this.prometnaDataGridViewTextBoxColumn.DataPropertyName = "prometna";
            this.prometnaDataGridViewTextBoxColumn.HeaderText = "prometna";
            this.prometnaDataGridViewTextBoxColumn.Name = "prometnaDataGridViewTextBoxColumn";
            // 
            // servisnaDataGridViewTextBoxColumn
            // 
            this.servisnaDataGridViewTextBoxColumn.DataPropertyName = "servisna";
            this.servisnaDataGridViewTextBoxColumn.HeaderText = "servisna";
            this.servisnaDataGridViewTextBoxColumn.Name = "servisnaDataGridViewTextBoxColumn";
            // 
            // kilometriDataGridViewTextBoxColumn
            // 
            this.kilometriDataGridViewTextBoxColumn.DataPropertyName = "kilometri";
            this.kilometriDataGridViewTextBoxColumn.HeaderText = "kilometri";
            this.kilometriDataGridViewTextBoxColumn.Name = "kilometriDataGridViewTextBoxColumn";
            // 
            // tipvozilaDataGridViewTextBoxColumn
            // 
            this.tipvozilaDataGridViewTextBoxColumn.DataPropertyName = "tip_vozila";
            this.tipvozilaDataGridViewTextBoxColumn.HeaderText = "tip_vozila";
            this.tipvozilaDataGridViewTextBoxColumn.Name = "tipvozilaDataGridViewTextBoxColumn";
            // 
            // modelvozilaDataGridViewTextBoxColumn
            // 
            this.modelvozilaDataGridViewTextBoxColumn.DataPropertyName = "model_vozila";
            this.modelvozilaDataGridViewTextBoxColumn.HeaderText = "model_vozila";
            this.modelvozilaDataGridViewTextBoxColumn.Name = "modelvozilaDataGridViewTextBoxColumn";
            // 
            // parkingDataGridViewTextBoxColumn
            // 
            this.parkingDataGridViewTextBoxColumn.DataPropertyName = "parking";
            this.parkingDataGridViewTextBoxColumn.HeaderText = "parking";
            this.parkingDataGridViewTextBoxColumn.Name = "parkingDataGridViewTextBoxColumn";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // dobavljacDataGridViewTextBoxColumn
            // 
            this.dobavljacDataGridViewTextBoxColumn.DataPropertyName = "dobavljac";
            this.dobavljacDataGridViewTextBoxColumn.HeaderText = "dobavljac";
            this.dobavljacDataGridViewTextBoxColumn.Name = "dobavljacDataGridViewTextBoxColumn";
            // 
            // modelvozila1DataGridViewTextBoxColumn
            // 
            this.modelvozila1DataGridViewTextBoxColumn.DataPropertyName = "model_vozila1";
            this.modelvozila1DataGridViewTextBoxColumn.HeaderText = "model_vozila1";
            this.modelvozila1DataGridViewTextBoxColumn.Name = "modelvozila1DataGridViewTextBoxColumn";
            // 
            // nalogzaservisDataGridViewTextBoxColumn
            // 
            this.nalogzaservisDataGridViewTextBoxColumn.DataPropertyName = "nalog_za_servis";
            this.nalogzaservisDataGridViewTextBoxColumn.HeaderText = "nalog_za_servis";
            this.nalogzaservisDataGridViewTextBoxColumn.Name = "nalogzaservisDataGridViewTextBoxColumn";
            // 
            // parking1DataGridViewTextBoxColumn
            // 
            this.parking1DataGridViewTextBoxColumn.DataPropertyName = "parking1";
            this.parking1DataGridViewTextBoxColumn.HeaderText = "parking1";
            this.parking1DataGridViewTextBoxColumn.Name = "parking1DataGridViewTextBoxColumn";
            // 
            // slikavoziloDataGridViewTextBoxColumn
            // 
            this.slikavoziloDataGridViewTextBoxColumn.DataPropertyName = "slika_vozilo";
            this.slikavoziloDataGridViewTextBoxColumn.HeaderText = "slika_vozilo";
            this.slikavoziloDataGridViewTextBoxColumn.Name = "slikavoziloDataGridViewTextBoxColumn";
            // 
            // tipvozila1DataGridViewTextBoxColumn
            // 
            this.tipvozila1DataGridViewTextBoxColumn.DataPropertyName = "tip_vozila1";
            this.tipvozila1DataGridViewTextBoxColumn.HeaderText = "tip_vozila1";
            this.tipvozila1DataGridViewTextBoxColumn.Name = "tipvozila1DataGridViewTextBoxColumn";
            // 
            // ugovorDataGridViewTextBoxColumn
            // 
            this.ugovorDataGridViewTextBoxColumn.DataPropertyName = "ugovor";
            this.ugovorDataGridViewTextBoxColumn.HeaderText = "ugovor";
            this.ugovorDataGridViewTextBoxColumn.Name = "ugovorDataGridViewTextBoxColumn";
            // 
            // dodatnaopremaDataGridViewTextBoxColumn
            // 
            this.dodatnaopremaDataGridViewTextBoxColumn.DataPropertyName = "dodatna_oprema";
            this.dodatnaopremaDataGridViewTextBoxColumn.HeaderText = "dodatna_oprema";
            this.dodatnaopremaDataGridViewTextBoxColumn.Name = "dodatnaopremaDataGridViewTextBoxColumn";
            // 
            // voziloBindingSource
            // 
            this.voziloBindingSource.DataSource = typeof(DriveIT.Database.vozilo);
            // 
            // frmVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmVozila";
            this.Text = "Vozila";
            this.Load += new System.EventHandler(this.frmVozila_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelvozila1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nalogzaservisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parking1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slikavoziloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipvozila1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugovorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dodatnaopremaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource voziloBindingSource;
    }
}