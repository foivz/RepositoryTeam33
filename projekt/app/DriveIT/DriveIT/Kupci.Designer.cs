namespace DriveIT
{
    partial class frmKupci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKupci));
            this.btnIzlaz = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idkupacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipkupcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tvrtkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipkupca1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugovorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kupacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPretragaKupci = new MetroFramework.Controls.MetroLabel();
            this.txtPretragaKupci = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDodajNovogKupca = new MetroFramework.Controls.MetroButton();
            this.btnAzuriraj = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzlaz.Highlight = false;
            this.btnIzlaz.Location = new System.Drawing.Point(679, 593);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(280, 80);
            this.btnIzlaz.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnIzlaz.StyleManager = null;
            this.btnIzlaz.TabIndex = 0;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkupacDataGridViewTextBoxColumn,
            this.tipkupcaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.tvrtkaDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.faksDataGridViewTextBoxColumn,
            this.tipkupca1DataGridViewTextBoxColumn,
            this.ugovorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kupacBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(934, 331);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idkupacDataGridViewTextBoxColumn
            // 
            this.idkupacDataGridViewTextBoxColumn.DataPropertyName = "id_kupac";
            this.idkupacDataGridViewTextBoxColumn.HeaderText = "šifra";
            this.idkupacDataGridViewTextBoxColumn.Name = "idkupacDataGridViewTextBoxColumn";
            this.idkupacDataGridViewTextBoxColumn.ReadOnly = true;
            this.idkupacDataGridViewTextBoxColumn.Width = 30;
            // 
            // tipkupcaDataGridViewTextBoxColumn
            // 
            this.tipkupcaDataGridViewTextBoxColumn.DataPropertyName = "tip_kupca";
            this.tipkupcaDataGridViewTextBoxColumn.HeaderText = "kupac";
            this.tipkupcaDataGridViewTextBoxColumn.Name = "tipkupcaDataGridViewTextBoxColumn";
            this.tipkupcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tvrtkaDataGridViewTextBoxColumn
            // 
            this.tvrtkaDataGridViewTextBoxColumn.DataPropertyName = "tvrtka";
            this.tvrtkaDataGridViewTextBoxColumn.HeaderText = "tvrtka";
            this.tvrtkaDataGridViewTextBoxColumn.Name = "tvrtkaDataGridViewTextBoxColumn";
            this.tvrtkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faksDataGridViewTextBoxColumn
            // 
            this.faksDataGridViewTextBoxColumn.DataPropertyName = "faks";
            this.faksDataGridViewTextBoxColumn.HeaderText = "faks";
            this.faksDataGridViewTextBoxColumn.Name = "faksDataGridViewTextBoxColumn";
            this.faksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipkupca1DataGridViewTextBoxColumn
            // 
            this.tipkupca1DataGridViewTextBoxColumn.DataPropertyName = "tip_kupca1";
            this.tipkupca1DataGridViewTextBoxColumn.HeaderText = "tip_kupca1";
            this.tipkupca1DataGridViewTextBoxColumn.Name = "tipkupca1DataGridViewTextBoxColumn";
            this.tipkupca1DataGridViewTextBoxColumn.ReadOnly = true;
            this.tipkupca1DataGridViewTextBoxColumn.Visible = false;
            // 
            // ugovorDataGridViewTextBoxColumn
            // 
            this.ugovorDataGridViewTextBoxColumn.DataPropertyName = "ugovor";
            this.ugovorDataGridViewTextBoxColumn.HeaderText = "ugovor";
            this.ugovorDataGridViewTextBoxColumn.Name = "ugovorDataGridViewTextBoxColumn";
            this.ugovorDataGridViewTextBoxColumn.ReadOnly = true;
            this.ugovorDataGridViewTextBoxColumn.Visible = false;
            // 
            // kupacBindingSource
            // 
            this.kupacBindingSource.DataSource = typeof(DriveIT.Database.kupac);
            // 
            // lblPretragaKupci
            // 
            this.lblPretragaKupci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPretragaKupci.AutoSize = true;
            this.lblPretragaKupci.CustomBackground = true;
            this.lblPretragaKupci.CustomForeColor = false;
            this.lblPretragaKupci.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblPretragaKupci.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblPretragaKupci.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblPretragaKupci.Location = new System.Drawing.Point(685, 85);
            this.lblPretragaKupci.Name = "lblPretragaKupci";
            this.lblPretragaKupci.Size = new System.Drawing.Size(60, 19);
            this.lblPretragaKupci.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblPretragaKupci.StyleManager = null;
            this.lblPretragaKupci.TabIndex = 2;
            this.lblPretragaKupci.Text = "Pretraga";
            this.lblPretragaKupci.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblPretragaKupci.UseStyleColors = false;
            // 
            // txtPretragaKupci
            // 
            this.txtPretragaKupci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPretragaKupci.CustomBackground = false;
            this.txtPretragaKupci.CustomForeColor = false;
            this.txtPretragaKupci.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtPretragaKupci.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtPretragaKupci.Location = new System.Drawing.Point(751, 81);
            this.txtPretragaKupci.Multiline = false;
            this.txtPretragaKupci.Name = "txtPretragaKupci";
            this.txtPretragaKupci.SelectedText = "";
            this.txtPretragaKupci.Size = new System.Drawing.Size(150, 23);
            this.txtPretragaKupci.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPretragaKupci.StyleManager = null;
            this.txtPretragaKupci.TabIndex = 3;
            this.txtPretragaKupci.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPretragaKupci.UseStyleColors = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(907, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(40, 606);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(434, 140);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnDodajNovogKupca
            // 
            this.btnDodajNovogKupca.Highlight = false;
            this.btnDodajNovogKupca.Location = new System.Drawing.Point(25, 54);
            this.btnDodajNovogKupca.Name = "btnDodajNovogKupca";
            this.btnDodajNovogKupca.Size = new System.Drawing.Size(280, 80);
            this.btnDodajNovogKupca.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDodajNovogKupca.StyleManager = null;
            this.btnDodajNovogKupca.TabIndex = 8;
            this.btnDodajNovogKupca.Text = "Dodaj novog kupca";
            this.btnDodajNovogKupca.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDodajNovogKupca.Click += new System.EventHandler(this.btnDodajNovogKupca_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Highlight = false;
            this.btnAzuriraj.Location = new System.Drawing.Point(333, 54);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(280, 80);
            this.btnAzuriraj.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAzuriraj.StyleManager = null;
            this.btnAzuriraj.TabIndex = 9;
            this.btnAzuriraj.Text = "Osvježi prikaz";
            this.btnAzuriraj.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // frmKupci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnDodajNovogKupca);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPretragaKupci);
            this.Controls.Add(this.lblPretragaKupci);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIzlaz);
            this.Name = "frmKupci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kupci";
            this.Load += new System.EventHandler(this.frmKupci_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnIzlaz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel lblPretragaKupci;
        private MetroFramework.Controls.MetroTextBox txtPretragaKupci;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton btnDodajNovogKupca;
        private System.Windows.Forms.BindingSource kupacBindingSource;
        private MetroFramework.Controls.MetroButton btnAzuriraj;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkupacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipkupcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tvrtkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipkupca1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugovorDataGridViewTextBoxColumn;
    }
}