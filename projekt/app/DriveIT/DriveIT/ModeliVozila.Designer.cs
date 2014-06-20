namespace DriveIT
{
    partial class frmModeliVozila
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
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.btnDodajVrstuVozila = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idmodelvozilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markavozilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markavozila1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelvozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblVrsteVozila = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelvozilaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(417, 91);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 14;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Location = new System.Drawing.Point(206, 91);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(110, 23);
            this.btnOsvjezi.TabIndex = 13;
            this.btnOsvjezi.Text = "Osvježi prikaz";
            this.btnOsvjezi.UseVisualStyleBackColor = true;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnDodajVrstuVozila
            // 
            this.btnDodajVrstuVozila.Location = new System.Drawing.Point(99, 91);
            this.btnDodajVrstuVozila.Name = "btnDodajVrstuVozila";
            this.btnDodajVrstuVozila.Size = new System.Drawing.Size(75, 23);
            this.btnDodajVrstuVozila.TabIndex = 12;
            this.btnDodajVrstuVozila.Text = "Dodaj Vozilo";
            this.btnDodajVrstuVozila.UseVisualStyleBackColor = true;
            this.btnDodajVrstuVozila.Click += new System.EventHandler(this.btnDodajVrstuVozila_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmodelvozilaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.markavozilaDataGridViewTextBoxColumn,
            this.markavozila1DataGridViewTextBoxColumn,
            this.voziloDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.modelvozilaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(99, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(393, 210);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idmodelvozilaDataGridViewTextBoxColumn
            // 
            this.idmodelvozilaDataGridViewTextBoxColumn.DataPropertyName = "id_model_vozila";
            this.idmodelvozilaDataGridViewTextBoxColumn.HeaderText = "id_model_vozila";
            this.idmodelvozilaDataGridViewTextBoxColumn.Name = "idmodelvozilaDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // markavozilaDataGridViewTextBoxColumn
            // 
            this.markavozilaDataGridViewTextBoxColumn.DataPropertyName = "marka_vozila";
            this.markavozilaDataGridViewTextBoxColumn.HeaderText = "marka_vozila";
            this.markavozilaDataGridViewTextBoxColumn.Name = "markavozilaDataGridViewTextBoxColumn";
            // 
            // markavozila1DataGridViewTextBoxColumn
            // 
            this.markavozila1DataGridViewTextBoxColumn.DataPropertyName = "marka_vozila1";
            this.markavozila1DataGridViewTextBoxColumn.HeaderText = "marka_vozila1";
            this.markavozila1DataGridViewTextBoxColumn.Name = "markavozila1DataGridViewTextBoxColumn";
            this.markavozila1DataGridViewTextBoxColumn.Visible = false;
            // 
            // voziloDataGridViewTextBoxColumn
            // 
            this.voziloDataGridViewTextBoxColumn.DataPropertyName = "vozilo";
            this.voziloDataGridViewTextBoxColumn.HeaderText = "vozilo";
            this.voziloDataGridViewTextBoxColumn.Name = "voziloDataGridViewTextBoxColumn";
            this.voziloDataGridViewTextBoxColumn.Visible = false;
            // 
            // modelvozilaBindingSource
            // 
            this.modelvozilaBindingSource.DataSource = typeof(DriveIT.Database.model_vozila);
            // 
            // lblVrsteVozila
            // 
            this.lblVrsteVozila.AutoSize = true;
            this.lblVrsteVozila.Location = new System.Drawing.Point(96, 57);
            this.lblVrsteVozila.Name = "lblVrsteVozila";
            this.lblVrsteVozila.Size = new System.Drawing.Size(61, 13);
            this.lblVrsteVozila.TabIndex = 10;
            this.lblVrsteVozila.Text = "Vrste vozila";
            // 
            // frmModeliVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnDodajVrstuVozila);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblVrsteVozila);
            this.Name = "frmModeliVozila";
            this.Text = "Modeli";
            this.Load += new System.EventHandler(this.frmModeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelvozilaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Button btnDodajVrstuVozila;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblVrsteVozila;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmodelvozilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markavozilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markavozila1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource modelvozilaBindingSource;
    }
}