namespace DriveIT
{
    partial class frmDobavljaci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDobavljaci));
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dobavljacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iddobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tvrtkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozilo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodatnaopremaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugovorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnIzlaz, "btnIzlaz");
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddobavljacDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.tvrtkaDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.faksDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.voziloDataGridViewTextBoxColumn,
            this.vozilo1DataGridViewTextBoxColumn,
            this.dodatnaopremaDataGridViewTextBoxColumn,
            this.ugovorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dobavljacBindingSource;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // dobavljacBindingSource
            // 
            this.dobavljacBindingSource.DataSource = typeof(DriveIT.Database.dobavljac);
            // 
            // iddobavljacDataGridViewTextBoxColumn
            // 
            this.iddobavljacDataGridViewTextBoxColumn.DataPropertyName = "id_dobavljac";
            resources.ApplyResources(this.iddobavljacDataGridViewTextBoxColumn, "iddobavljacDataGridViewTextBoxColumn");
            this.iddobavljacDataGridViewTextBoxColumn.Name = "iddobavljacDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            resources.ApplyResources(this.imeDataGridViewTextBoxColumn, "imeDataGridViewTextBoxColumn");
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            resources.ApplyResources(this.prezimeDataGridViewTextBoxColumn, "prezimeDataGridViewTextBoxColumn");
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // tvrtkaDataGridViewTextBoxColumn
            // 
            this.tvrtkaDataGridViewTextBoxColumn.DataPropertyName = "tvrtka";
            resources.ApplyResources(this.tvrtkaDataGridViewTextBoxColumn, "tvrtkaDataGridViewTextBoxColumn");
            this.tvrtkaDataGridViewTextBoxColumn.Name = "tvrtkaDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            resources.ApplyResources(this.adresaDataGridViewTextBoxColumn, "adresaDataGridViewTextBoxColumn");
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            resources.ApplyResources(this.telefonDataGridViewTextBoxColumn, "telefonDataGridViewTextBoxColumn");
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // faksDataGridViewTextBoxColumn
            // 
            this.faksDataGridViewTextBoxColumn.DataPropertyName = "faks";
            resources.ApplyResources(this.faksDataGridViewTextBoxColumn, "faksDataGridViewTextBoxColumn");
            this.faksDataGridViewTextBoxColumn.Name = "faksDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            resources.ApplyResources(this.emailDataGridViewTextBoxColumn, "emailDataGridViewTextBoxColumn");
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // voziloDataGridViewTextBoxColumn
            // 
            this.voziloDataGridViewTextBoxColumn.DataPropertyName = "vozilo";
            resources.ApplyResources(this.voziloDataGridViewTextBoxColumn, "voziloDataGridViewTextBoxColumn");
            this.voziloDataGridViewTextBoxColumn.Name = "voziloDataGridViewTextBoxColumn";
            // 
            // vozilo1DataGridViewTextBoxColumn
            // 
            this.vozilo1DataGridViewTextBoxColumn.DataPropertyName = "vozilo1";
            resources.ApplyResources(this.vozilo1DataGridViewTextBoxColumn, "vozilo1DataGridViewTextBoxColumn");
            this.vozilo1DataGridViewTextBoxColumn.Name = "vozilo1DataGridViewTextBoxColumn";
            // 
            // dodatnaopremaDataGridViewTextBoxColumn
            // 
            this.dodatnaopremaDataGridViewTextBoxColumn.DataPropertyName = "dodatna_oprema";
            resources.ApplyResources(this.dodatnaopremaDataGridViewTextBoxColumn, "dodatnaopremaDataGridViewTextBoxColumn");
            this.dodatnaopremaDataGridViewTextBoxColumn.Name = "dodatnaopremaDataGridViewTextBoxColumn";
            // 
            // ugovorDataGridViewTextBoxColumn
            // 
            this.ugovorDataGridViewTextBoxColumn.DataPropertyName = "ugovor";
            resources.ApplyResources(this.ugovorDataGridViewTextBoxColumn, "ugovorDataGridViewTextBoxColumn");
            this.ugovorDataGridViewTextBoxColumn.Name = "ugovorDataGridViewTextBoxColumn";
            // 
            // frmDobavljaci
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIzlaz);
            this.Name = "frmDobavljaci";
            this.Load += new System.EventHandler(this.frmDobavljaci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tvrtkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vozilo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dodatnaopremaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugovorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dobavljacBindingSource;
    }
}