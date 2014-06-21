namespace DriveIT
{
    partial class frmNalozi
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
            this.nalogzaservisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnDodajNalog = new System.Windows.Forms.Button();
            this.idnalogzaservisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obavljenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satiradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnik1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozilo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nalogzaservisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idnalogzaservisDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.voziloDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.obavljenDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.satiradaDataGridViewTextBoxColumn,
            this.dioDataGridViewTextBoxColumn,
            this.korisnik1DataGridViewTextBoxColumn,
            this.vozilo1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nalogzaservisBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(603, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // nalogzaservisBindingSource
            // 
            this.nalogzaservisBindingSource.DataSource = typeof(DriveIT.Database.nalog_za_servis);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(540, 112);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 1;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnDodajNalog
            // 
            this.btnDodajNalog.Location = new System.Drawing.Point(12, 112);
            this.btnDodajNalog.Name = "btnDodajNalog";
            this.btnDodajNalog.Size = new System.Drawing.Size(75, 23);
            this.btnDodajNalog.TabIndex = 2;
            this.btnDodajNalog.Text = "Dodaj Nalog";
            this.btnDodajNalog.UseVisualStyleBackColor = true;
            // 
            // idnalogzaservisDataGridViewTextBoxColumn
            // 
            this.idnalogzaservisDataGridViewTextBoxColumn.DataPropertyName = "id_nalog_za_servis";
            this.idnalogzaservisDataGridViewTextBoxColumn.HeaderText = "id_nalog_za_servis";
            this.idnalogzaservisDataGridViewTextBoxColumn.Name = "idnalogzaservisDataGridViewTextBoxColumn";
            this.idnalogzaservisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // voziloDataGridViewTextBoxColumn
            // 
            this.voziloDataGridViewTextBoxColumn.DataPropertyName = "vozilo";
            this.voziloDataGridViewTextBoxColumn.HeaderText = "vozilo";
            this.voziloDataGridViewTextBoxColumn.Name = "voziloDataGridViewTextBoxColumn";
            this.voziloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obavljenDataGridViewTextBoxColumn
            // 
            this.obavljenDataGridViewTextBoxColumn.DataPropertyName = "obavljen";
            this.obavljenDataGridViewTextBoxColumn.HeaderText = "obavljen";
            this.obavljenDataGridViewTextBoxColumn.Name = "obavljenDataGridViewTextBoxColumn";
            this.obavljenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // satiradaDataGridViewTextBoxColumn
            // 
            this.satiradaDataGridViewTextBoxColumn.DataPropertyName = "sati_rada";
            this.satiradaDataGridViewTextBoxColumn.HeaderText = "sati_rada";
            this.satiradaDataGridViewTextBoxColumn.Name = "satiradaDataGridViewTextBoxColumn";
            this.satiradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dioDataGridViewTextBoxColumn
            // 
            this.dioDataGridViewTextBoxColumn.DataPropertyName = "dio";
            this.dioDataGridViewTextBoxColumn.HeaderText = "dio";
            this.dioDataGridViewTextBoxColumn.Name = "dioDataGridViewTextBoxColumn";
            this.dioDataGridViewTextBoxColumn.ReadOnly = true;
            this.dioDataGridViewTextBoxColumn.Visible = false;
            // 
            // korisnik1DataGridViewTextBoxColumn
            // 
            this.korisnik1DataGridViewTextBoxColumn.DataPropertyName = "korisnik1";
            this.korisnik1DataGridViewTextBoxColumn.HeaderText = "korisnik1";
            this.korisnik1DataGridViewTextBoxColumn.Name = "korisnik1DataGridViewTextBoxColumn";
            this.korisnik1DataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnik1DataGridViewTextBoxColumn.Visible = false;
            // 
            // vozilo1DataGridViewTextBoxColumn
            // 
            this.vozilo1DataGridViewTextBoxColumn.DataPropertyName = "vozilo1";
            this.vozilo1DataGridViewTextBoxColumn.HeaderText = "vozilo1";
            this.vozilo1DataGridViewTextBoxColumn.Name = "vozilo1DataGridViewTextBoxColumn";
            this.vozilo1DataGridViewTextBoxColumn.ReadOnly = true;
            this.vozilo1DataGridViewTextBoxColumn.Visible = false;
            // 
            // frmNalozi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 565);
            this.Controls.Add(this.btnDodajNalog);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmNalozi";
            this.Text = "Nalozi";
            this.Load += new System.EventHandler(this.Nalozi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nalogzaservisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource nalogzaservisBindingSource;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnDodajNalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnalogzaservisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obavljenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satiradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnik1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vozilo1DataGridViewTextBoxColumn;
    }
}