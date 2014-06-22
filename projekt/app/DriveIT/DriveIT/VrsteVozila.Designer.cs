namespace DriveIT
{
    partial class frmVrsteVozila
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
            this.tipvozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblVrsteVozila = new System.Windows.Forms.Label();
            this.idtipvozilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podtipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipvozilaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(373, 70);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 9;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Location = new System.Drawing.Point(162, 70);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(110, 23);
            this.btnOsvjezi.TabIndex = 8;
            this.btnOsvjezi.Text = "Osvježi prikaz";
            this.btnOsvjezi.UseVisualStyleBackColor = true;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnDodajVrstuVozila
            // 
            this.btnDodajVrstuVozila.Location = new System.Drawing.Point(55, 70);
            this.btnDodajVrstuVozila.Name = "btnDodajVrstuVozila";
            this.btnDodajVrstuVozila.Size = new System.Drawing.Size(75, 23);
            this.btnDodajVrstuVozila.TabIndex = 7;
            this.btnDodajVrstuVozila.Text = "Dodaj Vozilo";
            this.btnDodajVrstuVozila.UseVisualStyleBackColor = true;
            this.btnDodajVrstuVozila.Click += new System.EventHandler(this.btnDodajVrstuVozila_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtipvozilaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.podtipDataGridViewTextBoxColumn,
            this.voziloDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tipvozilaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(78, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(430, 220);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tipvozilaBindingSource
            // 
            this.tipvozilaBindingSource.DataSource = typeof(DriveIT.Database.tip_vozila);
            // 
            // lblVrsteVozila
            // 
            this.lblVrsteVozila.AutoSize = true;
            this.lblVrsteVozila.Location = new System.Drawing.Point(52, 36);
            this.lblVrsteVozila.Name = "lblVrsteVozila";
            this.lblVrsteVozila.Size = new System.Drawing.Size(61, 13);
            this.lblVrsteVozila.TabIndex = 5;
            this.lblVrsteVozila.Text = "Vrste vozila";
            // 
            // idtipvozilaDataGridViewTextBoxColumn
            // 
            this.idtipvozilaDataGridViewTextBoxColumn.DataPropertyName = "id_tip_vozila";
            this.idtipvozilaDataGridViewTextBoxColumn.HeaderText = "šifra";
            this.idtipvozilaDataGridViewTextBoxColumn.Name = "idtipvozilaDataGridViewTextBoxColumn";
            this.idtipvozilaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtipvozilaDataGridViewTextBoxColumn.Width = 30;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // podtipDataGridViewTextBoxColumn
            // 
            this.podtipDataGridViewTextBoxColumn.DataPropertyName = "podtip";
            this.podtipDataGridViewTextBoxColumn.HeaderText = "podtip";
            this.podtipDataGridViewTextBoxColumn.Name = "podtipDataGridViewTextBoxColumn";
            this.podtipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // voziloDataGridViewTextBoxColumn
            // 
            this.voziloDataGridViewTextBoxColumn.DataPropertyName = "vozilo";
            this.voziloDataGridViewTextBoxColumn.HeaderText = "vozilo";
            this.voziloDataGridViewTextBoxColumn.Name = "voziloDataGridViewTextBoxColumn";
            this.voziloDataGridViewTextBoxColumn.ReadOnly = true;
            this.voziloDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmVrsteVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnDodajVrstuVozila);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblVrsteVozila);
            this.Name = "frmVrsteVozila";
            this.Text = "VrsteVozila";
            this.Load += new System.EventHandler(this.frmVrsteVozila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipvozilaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Button btnDodajVrstuVozila;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblVrsteVozila;
        private System.Windows.Forms.BindingSource tipvozilaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipvozilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podtipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloDataGridViewTextBoxColumn;
    }
}