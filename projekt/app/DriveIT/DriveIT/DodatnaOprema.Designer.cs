namespace DriveIT
{
    partial class frmDodatnaOprema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodatnaOprema));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.lblVrsteDodatneOpreme = new MetroFramework.Controls.MetroLabel();
            this.btnDodajDodatnuOpremu = new MetroFramework.Controls.MetroButton();
            this.btnOsvjeziPrikaz = new MetroFramework.Controls.MetroButton();
            this.btnIzlaz = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatnaopremaBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(57, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(824, 308);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iddodatnaopremaDataGridViewTextBoxColumn
            // 
            this.iddodatnaopremaDataGridViewTextBoxColumn.DataPropertyName = "id_dodatna_oprema";
            this.iddodatnaopremaDataGridViewTextBoxColumn.HeaderText = "šifra";
            this.iddodatnaopremaDataGridViewTextBoxColumn.MinimumWidth = 3;
            this.iddodatnaopremaDataGridViewTextBoxColumn.Name = "iddodatnaopremaDataGridViewTextBoxColumn";
            this.iddodatnaopremaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddodatnaopremaDataGridViewTextBoxColumn.Width = 30;
            // 
            // dobavljaciddobavljacDataGridViewTextBoxColumn
            // 
            this.dobavljaciddobavljacDataGridViewTextBoxColumn.DataPropertyName = "dobavljac_iddobavljac";
            this.dobavljaciddobavljacDataGridViewTextBoxColumn.HeaderText = "dobavljač";
            this.dobavljaciddobavljacDataGridViewTextBoxColumn.Name = "dobavljaciddobavljacDataGridViewTextBoxColumn";
            this.dobavljaciddobavljacDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // lblVrsteDodatneOpreme
            // 
            this.lblVrsteDodatneOpreme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVrsteDodatneOpreme.AutoSize = true;
            this.lblVrsteDodatneOpreme.CustomBackground = true;
            this.lblVrsteDodatneOpreme.CustomForeColor = false;
            this.lblVrsteDodatneOpreme.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblVrsteDodatneOpreme.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblVrsteDodatneOpreme.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblVrsteDodatneOpreme.Location = new System.Drawing.Point(358, 26);
            this.lblVrsteDodatneOpreme.Name = "lblVrsteDodatneOpreme";
            this.lblVrsteDodatneOpreme.Size = new System.Drawing.Size(181, 25);
            this.lblVrsteDodatneOpreme.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblVrsteDodatneOpreme.StyleManager = null;
            this.lblVrsteDodatneOpreme.TabIndex = 15;
            this.lblVrsteDodatneOpreme.Text = "Vrste dodatne opreme";
            this.lblVrsteDodatneOpreme.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblVrsteDodatneOpreme.UseStyleColors = false;
            // 
            // btnDodajDodatnuOpremu
            // 
            this.btnDodajDodatnuOpremu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDodajDodatnuOpremu.Highlight = false;
            this.btnDodajDodatnuOpremu.Location = new System.Drawing.Point(78, 114);
            this.btnDodajDodatnuOpremu.Name = "btnDodajDodatnuOpremu";
            this.btnDodajDodatnuOpremu.Size = new System.Drawing.Size(280, 80);
            this.btnDodajDodatnuOpremu.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDodajDodatnuOpremu.StyleManager = null;
            this.btnDodajDodatnuOpremu.TabIndex = 16;
            this.btnDodajDodatnuOpremu.Text = "Dodaj dodatnu opremu";
            this.btnDodajDodatnuOpremu.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDodajDodatnuOpremu.Click += new System.EventHandler(this.btnDodajDodatnuOpremu_Click);
            // 
            // btnOsvjeziPrikaz
            // 
            this.btnOsvjeziPrikaz.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOsvjeziPrikaz.Highlight = false;
            this.btnOsvjeziPrikaz.Location = new System.Drawing.Point(389, 114);
            this.btnOsvjeziPrikaz.Name = "btnOsvjeziPrikaz";
            this.btnOsvjeziPrikaz.Size = new System.Drawing.Size(280, 80);
            this.btnOsvjeziPrikaz.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnOsvjeziPrikaz.StyleManager = null;
            this.btnOsvjeziPrikaz.TabIndex = 17;
            this.btnOsvjeziPrikaz.Text = "Osvježi";
            this.btnOsvjeziPrikaz.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnOsvjeziPrikaz.Click += new System.EventHandler(this.btnOsvjeziPrikaz_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzlaz.Highlight = false;
            this.btnIzlaz.Location = new System.Drawing.Point(663, 604);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(280, 80);
            this.btnIzlaz.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnIzlaz.StyleManager = null;
            this.btnIzlaz.TabIndex = 18;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 613);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frmDodatnaOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnOsvjeziPrikaz);
            this.Controls.Add(this.btnDodajDodatnuOpremu);
            this.Controls.Add(this.lblVrsteDodatneOpreme);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmDodatnaOprema";
            this.Text = "DodatnaOprema";
            this.Load += new System.EventHandler(this.frmDodatnaOprema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatnaopremaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private MetroFramework.Controls.MetroLabel lblVrsteDodatneOpreme;
        private MetroFramework.Controls.MetroButton btnDodajDodatnuOpremu;
        private MetroFramework.Controls.MetroButton btnOsvjeziPrikaz;
        private MetroFramework.Controls.MetroButton btnIzlaz;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}