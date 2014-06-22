namespace DriveIT
{
    partial class frmNalozi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNalozi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIzlaz = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPreglednaloga = new MetroFramework.Controls.MetroLabel();
            this.idnalogzaservisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obavljenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satiradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnik1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozilo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nalogzaservisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nalogzaservisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idnalogzaservisDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.voziloDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.obavljenDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.satiradaDataGridViewTextBoxColumn,
            this.dioDataGridViewTextBoxColumn,
            this.korisnik1DataGridViewTextBoxColumn,
            this.vozilo1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nalogzaservisBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(85, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(774, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzlaz.Highlight = false;
            this.btnIzlaz.Location = new System.Drawing.Point(655, 604);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(280, 80);
            this.btnIzlaz.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnIzlaz.StyleManager = null;
            this.btnIzlaz.TabIndex = 2;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 613);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblPreglednaloga
            // 
            this.lblPreglednaloga.AutoSize = true;
            this.lblPreglednaloga.CustomBackground = true;
            this.lblPreglednaloga.CustomForeColor = false;
            this.lblPreglednaloga.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPreglednaloga.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblPreglednaloga.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblPreglednaloga.Location = new System.Drawing.Point(379, 59);
            this.lblPreglednaloga.Name = "lblPreglednaloga";
            this.lblPreglednaloga.Size = new System.Drawing.Size(127, 25);
            this.lblPreglednaloga.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblPreglednaloga.StyleManager = null;
            this.lblPreglednaloga.TabIndex = 4;
            this.lblPreglednaloga.Text = "Pregled naloga";
            this.lblPreglednaloga.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblPreglednaloga.UseStyleColors = false;
            // 
            // idnalogzaservisDataGridViewTextBoxColumn
            // 
            this.idnalogzaservisDataGridViewTextBoxColumn.DataPropertyName = "id_nalog_za_servis";
            this.idnalogzaservisDataGridViewTextBoxColumn.HeaderText = "šifra";
            this.idnalogzaservisDataGridViewTextBoxColumn.Name = "idnalogzaservisDataGridViewTextBoxColumn";
            this.idnalogzaservisDataGridViewTextBoxColumn.ReadOnly = true;
            this.idnalogzaservisDataGridViewTextBoxColumn.Width = 30;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // voziloDataGridViewTextBoxColumn
            // 
            this.voziloDataGridViewTextBoxColumn.DataPropertyName = "vozilo";
            this.voziloDataGridViewTextBoxColumn.HeaderText = "vozilo";
            this.voziloDataGridViewTextBoxColumn.Name = "voziloDataGridViewTextBoxColumn";
            this.voziloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obavljenDataGridViewTextBoxColumn
            // 
            this.obavljenDataGridViewTextBoxColumn.DataPropertyName = "obavljen";
            this.obavljenDataGridViewTextBoxColumn.HeaderText = "obavljen";
            this.obavljenDataGridViewTextBoxColumn.Name = "obavljenDataGridViewTextBoxColumn";
            this.obavljenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // satiradaDataGridViewTextBoxColumn
            // 
            this.satiradaDataGridViewTextBoxColumn.DataPropertyName = "sati_rada";
            this.satiradaDataGridViewTextBoxColumn.HeaderText = "sati_rada";
            this.satiradaDataGridViewTextBoxColumn.Name = "satiradaDataGridViewTextBoxColumn";
            this.satiradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dioDataGridViewTextBoxColumn
            // 
            this.dioDataGridViewTextBoxColumn.DataPropertyName = "dio";
            this.dioDataGridViewTextBoxColumn.HeaderText = "dio";
            this.dioDataGridViewTextBoxColumn.Name = "dioDataGridViewTextBoxColumn";
            this.dioDataGridViewTextBoxColumn.ReadOnly = true;
            this.dioDataGridViewTextBoxColumn.Visible = false;
            // 
            // korisnik1DataGridViewTextBoxColumn
            // 
            this.korisnik1DataGridViewTextBoxColumn.DataPropertyName = "korisnik1";
            this.korisnik1DataGridViewTextBoxColumn.HeaderText = "korisnik1";
            this.korisnik1DataGridViewTextBoxColumn.Name = "korisnik1DataGridViewTextBoxColumn";
            this.korisnik1DataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnik1DataGridViewTextBoxColumn.Visible = false;
            // 
            // vozilo1DataGridViewTextBoxColumn
            // 
            this.vozilo1DataGridViewTextBoxColumn.DataPropertyName = "vozilo1";
            this.vozilo1DataGridViewTextBoxColumn.HeaderText = "vozilo1";
            this.vozilo1DataGridViewTextBoxColumn.Name = "vozilo1DataGridViewTextBoxColumn";
            this.vozilo1DataGridViewTextBoxColumn.ReadOnly = true;
            this.vozilo1DataGridViewTextBoxColumn.Visible = false;
            // 
            // nalogzaservisBindingSource
            // 
            this.nalogzaservisBindingSource.DataSource = typeof(DriveIT.Database.nalog_za_servis);
            // 
            // frmNalozi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.lblPreglednaloga);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmNalozi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nalozi";
            this.Load += new System.EventHandler(this.Nalozi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nalogzaservisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource nalogzaservisBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnalogzaservisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obavljenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satiradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnik1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vozilo1DataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btnIzlaz;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lblPreglednaloga;
    }
}