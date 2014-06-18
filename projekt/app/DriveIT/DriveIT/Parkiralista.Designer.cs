namespace DriveIT
{
    partial class frmParkiralista
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
            this.lblParkiralista = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDodajParking = new System.Windows.Forms.Button();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.parkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idparkingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapacitetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParkiralista
            // 
            this.lblParkiralista.AutoSize = true;
            this.lblParkiralista.Location = new System.Drawing.Point(57, 52);
            this.lblParkiralista.Name = "lblParkiralista";
            this.lblParkiralista.Size = new System.Drawing.Size(58, 13);
            this.lblParkiralista.TabIndex = 0;
            this.lblParkiralista.Text = "Parkirališta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idparkingDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.kapacitetDataGridViewTextBoxColumn,
            this.voziloDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.parkingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(83, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 250);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContextMenuStripChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDodajParking
            // 
            this.btnDodajParking.Location = new System.Drawing.Point(60, 86);
            this.btnDodajParking.Name = "btnDodajParking";
            this.btnDodajParking.Size = new System.Drawing.Size(75, 23);
            this.btnDodajParking.TabIndex = 2;
            this.btnDodajParking.Text = "Dodaj Parking";
            this.btnDodajParking.UseVisualStyleBackColor = true;
            this.btnDodajParking.Click += new System.EventHandler(this.btnDodajParking_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Location = new System.Drawing.Point(167, 86);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(110, 23);
            this.btnOsvjezi.TabIndex = 3;
            this.btnOsvjezi.Text = "Osvježi prikaz";
            this.btnOsvjezi.UseVisualStyleBackColor = true;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(378, 86);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 4;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // parkingBindingSource
            // 
            this.parkingBindingSource.DataSource = typeof(DriveIT.Database.parking);
            // 
            // idparkingDataGridViewTextBoxColumn
            // 
            this.idparkingDataGridViewTextBoxColumn.DataPropertyName = "id_parking";
            this.idparkingDataGridViewTextBoxColumn.HeaderText = "id_parking";
            this.idparkingDataGridViewTextBoxColumn.Name = "idparkingDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // kapacitetDataGridViewTextBoxColumn
            // 
            this.kapacitetDataGridViewTextBoxColumn.DataPropertyName = "kapacitet";
            this.kapacitetDataGridViewTextBoxColumn.HeaderText = "kapacitet";
            this.kapacitetDataGridViewTextBoxColumn.Name = "kapacitetDataGridViewTextBoxColumn";
            // 
            // voziloDataGridViewTextBoxColumn
            // 
            this.voziloDataGridViewTextBoxColumn.DataPropertyName = "vozilo";
            this.voziloDataGridViewTextBoxColumn.HeaderText = "vozilo";
            this.voziloDataGridViewTextBoxColumn.Name = "voziloDataGridViewTextBoxColumn";
            this.voziloDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmParkiralista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 458);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnDodajParking);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblParkiralista);
            this.Name = "frmParkiralista";
            this.Text = "Parkiralista";
            this.Load += new System.EventHandler(this.frmParkiralista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParkiralista;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDodajParking;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.BindingSource parkingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idparkingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapacitetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloDataGridViewTextBoxColumn;
    }
}