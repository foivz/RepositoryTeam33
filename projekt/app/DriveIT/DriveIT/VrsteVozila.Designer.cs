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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVrsteVozila));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idtipvozilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podtipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipvozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblVrsteVozila = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIzlaz = new MetroFramework.Controls.MetroButton();
            this.btnOsvjezi = new MetroFramework.Controls.MetroButton();
            this.btnDodaj = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipvozilaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtipvozilaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.podtipDataGridViewTextBoxColumn,
            this.voziloDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tipvozilaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(461, 282);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // tipvozilaBindingSource
            // 
            this.tipvozilaBindingSource.DataSource = typeof(DriveIT.Database.tip_vozila);
            // 
            // lblVrsteVozila
            // 
            this.lblVrsteVozila.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVrsteVozila.AutoSize = true;
            this.lblVrsteVozila.CustomBackground = true;
            this.lblVrsteVozila.CustomForeColor = false;
            this.lblVrsteVozila.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblVrsteVozila.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblVrsteVozila.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblVrsteVozila.Location = new System.Drawing.Point(401, 37);
            this.lblVrsteVozila.Name = "lblVrsteVozila";
            this.lblVrsteVozila.Size = new System.Drawing.Size(97, 25);
            this.lblVrsteVozila.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblVrsteVozila.StyleManager = null;
            this.lblVrsteVozila.TabIndex = 10;
            this.lblVrsteVozila.Text = "Vrste vozila";
            this.lblVrsteVozila.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblVrsteVozila.UseStyleColors = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 575);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzlaz.Highlight = false;
            this.btnIzlaz.Location = new System.Drawing.Point(592, 428);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(280, 80);
            this.btnIzlaz.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnIzlaz.StyleManager = null;
            this.btnIzlaz.TabIndex = 12;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOsvjezi.Highlight = false;
            this.btnOsvjezi.Location = new System.Drawing.Point(401, 116);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(280, 80);
            this.btnOsvjezi.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnOsvjezi.StyleManager = null;
            this.btnOsvjezi.TabIndex = 13;
            this.btnOsvjezi.Text = "Osvjezi";
            this.btnOsvjezi.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodaj.Highlight = false;
            this.btnDodaj.Location = new System.Drawing.Point(55, 116);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(280, 80);
            this.btnDodaj.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDodaj.StyleManager = null;
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj vozilo";
            this.btnDodaj.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmVrsteVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblVrsteVozila);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmVrsteVozila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VrsteVozila";
            this.Load += new System.EventHandler(this.frmVrsteVozila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipvozilaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tipvozilaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipvozilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podtipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel lblVrsteVozila;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnIzlaz;
        private MetroFramework.Controls.MetroButton btnOsvjezi;
        private MetroFramework.Controls.MetroButton btnDodaj;
    }
}