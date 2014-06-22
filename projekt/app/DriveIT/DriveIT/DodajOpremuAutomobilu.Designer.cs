namespace DriveIT
{
    partial class frmDodajOpremuAutomobilu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodajOpremuAutomobilu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblOprema = new MetroFramework.Controls.MetroLabel();
            this.btnOdustani = new MetroFramework.Controls.MetroButton();
            this.btnOsvjezi = new MetroFramework.Controls.MetroButton();
            this.btnDodaj = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDodajOpremuAutomobilu = new MetroFramework.Controls.MetroLabel();
            this.cbOprema = new System.Windows.Forms.ComboBox();
            this.iddodatnaopremaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljaciddobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raspoloživoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodatnaopremaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatnaopremaBindingSource)).BeginInit();
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
            this.iddodatnaopremaDataGridViewTextBoxColumn,
            this.dobavljaciddobavljacDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.raspoloživoDataGridViewTextBoxColumn,
            this.dobavljacDataGridViewTextBoxColumn,
            this.voziloDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dodatnaopremaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(277, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(377, 170);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblOprema
            // 
            this.lblOprema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOprema.AutoSize = true;
            this.lblOprema.CustomBackground = true;
            this.lblOprema.CustomForeColor = false;
            this.lblOprema.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblOprema.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblOprema.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblOprema.Location = new System.Drawing.Point(292, 328);
            this.lblOprema.Name = "lblOprema";
            this.lblOprema.Size = new System.Drawing.Size(75, 25);
            this.lblOprema.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblOprema.StyleManager = null;
            this.lblOprema.TabIndex = 6;
            this.lblOprema.Text = "Oprema";
            this.lblOprema.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblOprema.UseStyleColors = false;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOdustani.Highlight = false;
            this.btnOdustani.Location = new System.Drawing.Point(654, 447);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(280, 80);
            this.btnOdustani.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnOdustani.StyleManager = null;
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOsvjezi.Highlight = false;
            this.btnOsvjezi.Location = new System.Drawing.Point(358, 447);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(280, 80);
            this.btnOsvjezi.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnOsvjezi.StyleManager = null;
            this.btnOsvjezi.TabIndex = 9;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDodaj.Highlight = false;
            this.btnDodaj.Location = new System.Drawing.Point(51, 447);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(280, 80);
            this.btnDodaj.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDodaj.StyleManager = null;
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj opremu";
            this.btnDodaj.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click_1);
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
            // lblDodajOpremuAutomobilu
            // 
            this.lblDodajOpremuAutomobilu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDodajOpremuAutomobilu.AutoSize = true;
            this.lblDodajOpremuAutomobilu.CustomBackground = true;
            this.lblDodajOpremuAutomobilu.CustomForeColor = false;
            this.lblDodajOpremuAutomobilu.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDodajOpremuAutomobilu.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDodajOpremuAutomobilu.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDodajOpremuAutomobilu.Location = new System.Drawing.Point(358, 45);
            this.lblDodajOpremuAutomobilu.Name = "lblDodajOpremuAutomobilu";
            this.lblDodajOpremuAutomobilu.Size = new System.Drawing.Size(214, 25);
            this.lblDodajOpremuAutomobilu.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDodajOpremuAutomobilu.StyleManager = null;
            this.lblDodajOpremuAutomobilu.TabIndex = 12;
            this.lblDodajOpremuAutomobilu.Text = "Dodaj opremu automobilu";
            this.lblDodajOpremuAutomobilu.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDodajOpremuAutomobilu.UseStyleColors = false;
            // 
            // cbOprema
            // 
            this.cbOprema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOprema.FormattingEnabled = true;
            this.cbOprema.Location = new System.Drawing.Point(373, 332);
            this.cbOprema.Name = "cbOprema";
            this.cbOprema.Size = new System.Drawing.Size(265, 21);
            this.cbOprema.TabIndex = 13;
            // 
            // iddodatnaopremaDataGridViewTextBoxColumn
            // 
            this.iddodatnaopremaDataGridViewTextBoxColumn.DataPropertyName = "id_dodatna_oprema";
            this.iddodatnaopremaDataGridViewTextBoxColumn.HeaderText = "sifra";
            this.iddodatnaopremaDataGridViewTextBoxColumn.Name = "iddodatnaopremaDataGridViewTextBoxColumn";
            this.iddodatnaopremaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddodatnaopremaDataGridViewTextBoxColumn.Width = 30;
            // 
            // dobavljaciddobavljacDataGridViewTextBoxColumn
            // 
            this.dobavljaciddobavljacDataGridViewTextBoxColumn.DataPropertyName = "dobavljac_iddobavljac";
            this.dobavljaciddobavljacDataGridViewTextBoxColumn.HeaderText = "dobavljac_iddobavljac";
            this.dobavljaciddobavljacDataGridViewTextBoxColumn.Name = "dobavljaciddobavljacDataGridViewTextBoxColumn";
            this.dobavljaciddobavljacDataGridViewTextBoxColumn.ReadOnly = true;
            this.dobavljaciddobavljacDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bojaDataGridViewTextBoxColumn
            // 
            this.bojaDataGridViewTextBoxColumn.DataPropertyName = "boja";
            this.bojaDataGridViewTextBoxColumn.HeaderText = "boja";
            this.bojaDataGridViewTextBoxColumn.Name = "bojaDataGridViewTextBoxColumn";
            this.bojaDataGridViewTextBoxColumn.ReadOnly = true;
            this.bojaDataGridViewTextBoxColumn.Visible = false;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn.Visible = false;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // raspoloživoDataGridViewTextBoxColumn
            // 
            this.raspoloživoDataGridViewTextBoxColumn.DataPropertyName = "raspoloživo";
            this.raspoloživoDataGridViewTextBoxColumn.HeaderText = "raspoloživo";
            this.raspoloživoDataGridViewTextBoxColumn.Name = "raspoloživoDataGridViewTextBoxColumn";
            this.raspoloživoDataGridViewTextBoxColumn.ReadOnly = true;
            this.raspoloživoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dobavljacDataGridViewTextBoxColumn
            // 
            this.dobavljacDataGridViewTextBoxColumn.DataPropertyName = "dobavljac";
            this.dobavljacDataGridViewTextBoxColumn.HeaderText = "dobavljac";
            this.dobavljacDataGridViewTextBoxColumn.Name = "dobavljacDataGridViewTextBoxColumn";
            this.dobavljacDataGridViewTextBoxColumn.ReadOnly = true;
            this.dobavljacDataGridViewTextBoxColumn.Visible = false;
            // 
            // voziloDataGridViewTextBoxColumn
            // 
            this.voziloDataGridViewTextBoxColumn.DataPropertyName = "vozilo";
            this.voziloDataGridViewTextBoxColumn.HeaderText = "vozilo";
            this.voziloDataGridViewTextBoxColumn.Name = "voziloDataGridViewTextBoxColumn";
            this.voziloDataGridViewTextBoxColumn.ReadOnly = true;
            this.voziloDataGridViewTextBoxColumn.Visible = false;
            // 
            // dodatnaopremaBindingSource
            // 
            this.dodatnaopremaBindingSource.DataSource = typeof(DriveIT.Database.dodatna_oprema);
            // 
            // frmDodajOpremuAutomobilu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.cbOprema);
            this.Controls.Add(this.lblDodajOpremuAutomobilu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.lblOprema);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmDodajOpremuAutomobilu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodajOpremuAutomobilu";
            this.Load += new System.EventHandler(this.frmDodajOpremuAutomobilu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatnaopremaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dodatnaopremaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddodatnaopremaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljaciddobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raspoloživoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel lblOprema;
        private MetroFramework.Controls.MetroButton btnOdustani;
        private MetroFramework.Controls.MetroButton btnOsvjezi;
        private MetroFramework.Controls.MetroButton btnDodaj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lblDodajOpremuAutomobilu;
        private System.Windows.Forms.ComboBox cbOprema;
    }
}