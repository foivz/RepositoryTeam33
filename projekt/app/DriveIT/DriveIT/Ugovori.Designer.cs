namespace DriveIT
{
    partial class frmUgovori
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
            this.btnIzlaz = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ugovorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idugovorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kupacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljaciddobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kupac1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozilo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Highlight = false;
            this.btnIzlaz.Location = new System.Drawing.Point(442, 379);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnIzlaz.StyleManager = null;
            this.btnIzlaz.TabIndex = 0;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idugovorDataGridViewTextBoxColumn,
            this.kupacDataGridViewTextBoxColumn,
            this.voziloDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.dobavljaciddobavljacDataGridViewTextBoxColumn,
            this.dobavljacDataGridViewTextBoxColumn,
            this.kupac1DataGridViewTextBoxColumn,
            this.vozilo1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ugovorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(487, 276);
            this.dataGridView1.TabIndex = 1;
            // 
            // ugovorBindingSource
            // 
            this.ugovorBindingSource.DataSource = typeof(DriveIT.Database.ugovor);
            // 
            // idugovorDataGridViewTextBoxColumn
            // 
            this.idugovorDataGridViewTextBoxColumn.DataPropertyName = "id_ugovor";
            this.idugovorDataGridViewTextBoxColumn.HeaderText = "id_ugovor";
            this.idugovorDataGridViewTextBoxColumn.Name = "idugovorDataGridViewTextBoxColumn";
            // 
            // kupacDataGridViewTextBoxColumn
            // 
            this.kupacDataGridViewTextBoxColumn.DataPropertyName = "kupac";
            this.kupacDataGridViewTextBoxColumn.HeaderText = "kupac";
            this.kupacDataGridViewTextBoxColumn.Name = "kupacDataGridViewTextBoxColumn";
            // 
            // voziloDataGridViewTextBoxColumn
            // 
            this.voziloDataGridViewTextBoxColumn.DataPropertyName = "vozilo";
            this.voziloDataGridViewTextBoxColumn.HeaderText = "vozilo";
            this.voziloDataGridViewTextBoxColumn.Name = "voziloDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // dobavljaciddobavljacDataGridViewTextBoxColumn
            // 
            this.dobavljaciddobavljacDataGridViewTextBoxColumn.DataPropertyName = "dobavljac_iddobavljac";
            this.dobavljaciddobavljacDataGridViewTextBoxColumn.HeaderText = "dobavljac_iddobavljac";
            this.dobavljaciddobavljacDataGridViewTextBoxColumn.Name = "dobavljaciddobavljacDataGridViewTextBoxColumn";
            // 
            // dobavljacDataGridViewTextBoxColumn
            // 
            this.dobavljacDataGridViewTextBoxColumn.DataPropertyName = "dobavljac";
            this.dobavljacDataGridViewTextBoxColumn.HeaderText = "dobavljac";
            this.dobavljacDataGridViewTextBoxColumn.Name = "dobavljacDataGridViewTextBoxColumn";
            // 
            // kupac1DataGridViewTextBoxColumn
            // 
            this.kupac1DataGridViewTextBoxColumn.DataPropertyName = "kupac1";
            this.kupac1DataGridViewTextBoxColumn.HeaderText = "kupac1";
            this.kupac1DataGridViewTextBoxColumn.Name = "kupac1DataGridViewTextBoxColumn";
            // 
            // vozilo1DataGridViewTextBoxColumn
            // 
            this.vozilo1DataGridViewTextBoxColumn.DataPropertyName = "vozilo1";
            this.vozilo1DataGridViewTextBoxColumn.HeaderText = "vozilo1";
            this.vozilo1DataGridViewTextBoxColumn.Name = "vozilo1DataGridViewTextBoxColumn";
            // 
            // frmUgovori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 419);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIzlaz);
            this.Name = "frmUgovori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ugovori";
            this.Load += new System.EventHandler(this.frmUgovori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnIzlaz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idugovorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kupacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljaciddobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kupac1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vozilo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ugovorBindingSource;
    }
}