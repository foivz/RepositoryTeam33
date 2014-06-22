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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParkiralista));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idparkingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapacitetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblParkiralista = new MetroFramework.Controls.MetroLabel();
            this.btnIzlaz = new MetroFramework.Controls.MetroButton();
            this.btnDodaj = new MetroFramework.Controls.MetroButton();
            this.btnOsvjezi = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idparkingDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.kapacitetDataGridViewTextBoxColumn,
            this.voziloDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.parkingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(879, 308);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContextMenuStripChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idparkingDataGridViewTextBoxColumn
            // 
            this.idparkingDataGridViewTextBoxColumn.DataPropertyName = "id_parking";
            this.idparkingDataGridViewTextBoxColumn.HeaderText = "šifra";
            this.idparkingDataGridViewTextBoxColumn.Name = "idparkingDataGridViewTextBoxColumn";
            this.idparkingDataGridViewTextBoxColumn.ReadOnly = true;
            this.idparkingDataGridViewTextBoxColumn.Width = 30;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kapacitetDataGridViewTextBoxColumn
            // 
            this.kapacitetDataGridViewTextBoxColumn.DataPropertyName = "kapacitet";
            this.kapacitetDataGridViewTextBoxColumn.HeaderText = "kapacitet";
            this.kapacitetDataGridViewTextBoxColumn.Name = "kapacitetDataGridViewTextBoxColumn";
            this.kapacitetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // voziloDataGridViewTextBoxColumn
            // 
            this.voziloDataGridViewTextBoxColumn.DataPropertyName = "vozilo";
            this.voziloDataGridViewTextBoxColumn.HeaderText = "vozilo";
            this.voziloDataGridViewTextBoxColumn.Name = "voziloDataGridViewTextBoxColumn";
            this.voziloDataGridViewTextBoxColumn.ReadOnly = true;
            this.voziloDataGridViewTextBoxColumn.Visible = false;
            // 
            // parkingBindingSource
            // 
            this.parkingBindingSource.DataSource = typeof(DriveIT.Database.parking);
            // 
            // lblParkiralista
            // 
            this.lblParkiralista.AutoSize = true;
            this.lblParkiralista.CustomBackground = true;
            this.lblParkiralista.CustomForeColor = false;
            this.lblParkiralista.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblParkiralista.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblParkiralista.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblParkiralista.Location = new System.Drawing.Point(371, 33);
            this.lblParkiralista.Name = "lblParkiralista";
            this.lblParkiralista.Size = new System.Drawing.Size(143, 25);
            this.lblParkiralista.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblParkiralista.StyleManager = null;
            this.lblParkiralista.TabIndex = 5;
            this.lblParkiralista.Text = "Prikaz parkirališta";
            this.lblParkiralista.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblParkiralista.UseStyleColors = false;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Highlight = false;
            this.btnIzlaz.Location = new System.Drawing.Point(649, 604);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(280, 80);
            this.btnIzlaz.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnIzlaz.StyleManager = null;
            this.btnIzlaz.TabIndex = 6;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Highlight = false;
            this.btnDodaj.Location = new System.Drawing.Point(34, 121);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(280, 80);
            this.btnDodaj.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDodaj.StyleManager = null;
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj parkiralište";
            this.btnDodaj.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Highlight = false;
            this.btnOsvjezi.Location = new System.Drawing.Point(354, 121);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(280, 80);
            this.btnOsvjezi.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnOsvjezi.StyleManager = null;
            this.btnOsvjezi.TabIndex = 8;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 617);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmParkiralista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.lblParkiralista);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmParkiralista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parkiralista";
            this.Load += new System.EventHandler(this.frmParkiralista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource parkingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idparkingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapacitetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel lblParkiralista;
        private MetroFramework.Controls.MetroButton btnIzlaz;
        private MetroFramework.Controls.MetroButton btnDodaj;
        private MetroFramework.Controls.MetroButton btnOsvjezi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}