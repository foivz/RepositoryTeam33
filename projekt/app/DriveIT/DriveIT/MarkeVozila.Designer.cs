namespace DriveIT
{
    partial class frmMarkeVozila
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
            this.idmarkavozilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drzavaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelvozilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markavozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblVrsteVozila = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markavozilaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(384, 99);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 14;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Location = new System.Drawing.Point(173, 99);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(110, 23);
            this.btnOsvjezi.TabIndex = 13;
            this.btnOsvjezi.Text = "Osvježi prikaz";
            this.btnOsvjezi.UseVisualStyleBackColor = true;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnDodajVrstuVozila
            // 
            this.btnDodajVrstuVozila.Location = new System.Drawing.Point(66, 99);
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
            this.idmarkavozilaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.drzavaDataGridViewTextBoxColumn,
            this.modelvozilaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.markavozilaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(66, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 220);
            this.dataGridView1.TabIndex = 11;
            // 
            // idmarkavozilaDataGridViewTextBoxColumn
            // 
            this.idmarkavozilaDataGridViewTextBoxColumn.DataPropertyName = "id_marka_vozila";
            this.idmarkavozilaDataGridViewTextBoxColumn.HeaderText = "id_marka_vozila";
            this.idmarkavozilaDataGridViewTextBoxColumn.Name = "idmarkavozilaDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // drzavaDataGridViewTextBoxColumn
            // 
            this.drzavaDataGridViewTextBoxColumn.DataPropertyName = "drzava";
            this.drzavaDataGridViewTextBoxColumn.HeaderText = "drzava";
            this.drzavaDataGridViewTextBoxColumn.Name = "drzavaDataGridViewTextBoxColumn";
            // 
            // modelvozilaDataGridViewTextBoxColumn
            // 
            this.modelvozilaDataGridViewTextBoxColumn.DataPropertyName = "model_vozila";
            this.modelvozilaDataGridViewTextBoxColumn.HeaderText = "model_vozila";
            this.modelvozilaDataGridViewTextBoxColumn.Name = "modelvozilaDataGridViewTextBoxColumn";
            this.modelvozilaDataGridViewTextBoxColumn.Visible = false;
            // 
            // markavozilaBindingSource
            // 
            this.markavozilaBindingSource.DataSource = typeof(DriveIT.Database.marka_vozila);
            // 
            // lblVrsteVozila
            // 
            this.lblVrsteVozila.AutoSize = true;
            this.lblVrsteVozila.Location = new System.Drawing.Point(63, 65);
            this.lblVrsteVozila.Name = "lblVrsteVozila";
            this.lblVrsteVozila.Size = new System.Drawing.Size(61, 13);
            this.lblVrsteVozila.TabIndex = 10;
            this.lblVrsteVozila.Text = "Vrste vozila";
            // 
            // frmMarkeVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 428);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnDodajVrstuVozila);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblVrsteVozila);
            this.Name = "frmMarkeVozila";
            this.Text = "MarkeVozila";
            this.Load += new System.EventHandler(this.frmMarkeVozila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markavozilaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Button btnDodajVrstuVozila;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblVrsteVozila;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmarkavozilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drzavaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelvozilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource markavozilaBindingSource;
    }
}