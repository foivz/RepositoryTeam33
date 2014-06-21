namespace DriveIT
{
    partial class frmUgovori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUgovori));
            this.btnIzlaz = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idugovorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kupacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljaciddobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kupac1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozilo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugovorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPretragaUgovori = new MetroFramework.Controls.MetroLabel();
            this.txtPretragaUgovori = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDodajUgovor = new MetroFramework.Controls.MetroButton();
            this.btnOsvjezi = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzlaz.Highlight = false;
            this.btnIzlaz.Location = new System.Drawing.Point(679, 604);
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
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idugovorDataGridViewTextBoxColumn,
            this.kupacDataGridViewTextBoxColumn,
            this.voziloDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.dobavljaciddobavljacDataGridViewTextBoxColumn,
            this.dobavljacDataGridViewTextBoxColumn,
            this.kupac1DataGridViewTextBoxColumn,
            this.vozilo1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ugovorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(934, 331);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idugovorDataGridViewTextBoxColumn
            // 
            this.idugovorDataGridViewTextBoxColumn.DataPropertyName = "id_ugovor";
            this.idugovorDataGridViewTextBoxColumn.HeaderText = "id_ugovor";
            this.idugovorDataGridViewTextBoxColumn.Name = "idugovorDataGridViewTextBoxColumn";
            // 
            // kupacDataGridViewTextBoxColumn
            // 
            this.kupacDataGridViewTextBoxColumn.DataPropertyName = "kupac";
            this.kupacDataGridViewTextBoxColumn.HeaderText = "kupac";
            this.kupacDataGridViewTextBoxColumn.Name = "kupacDataGridViewTextBoxColumn";
            // 
            // voziloDataGridViewTextBoxColumn
            // 
            this.voziloDataGridViewTextBoxColumn.DataPropertyName = "vozilo";
            this.voziloDataGridViewTextBoxColumn.HeaderText = "vozilo";
            this.voziloDataGridViewTextBoxColumn.Name = "voziloDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // dobavljaciddobavljacDataGridViewTextBoxColumn
            // 
            this.dobavljaciddobavljacDataGridViewTextBoxColumn.DataPropertyName = "dobavljac_iddobavljac";
            this.dobavljaciddobavljacDataGridViewTextBoxColumn.HeaderText = "dobavljac_iddobavljac";
            this.dobavljaciddobavljacDataGridViewTextBoxColumn.Name = "dobavljaciddobavljacDataGridViewTextBoxColumn";
            // 
            // dobavljacDataGridViewTextBoxColumn
            // 
            this.dobavljacDataGridViewTextBoxColumn.DataPropertyName = "dobavljac";
            this.dobavljacDataGridViewTextBoxColumn.HeaderText = "dobavljac";
            this.dobavljacDataGridViewTextBoxColumn.Name = "dobavljacDataGridViewTextBoxColumn";
            this.dobavljacDataGridViewTextBoxColumn.Visible = false;
            // 
            // kupac1DataGridViewTextBoxColumn
            // 
            this.kupac1DataGridViewTextBoxColumn.DataPropertyName = "kupac1";
            this.kupac1DataGridViewTextBoxColumn.HeaderText = "kupac1";
            this.kupac1DataGridViewTextBoxColumn.Name = "kupac1DataGridViewTextBoxColumn";
            this.kupac1DataGridViewTextBoxColumn.Visible = false;
            // 
            // vozilo1DataGridViewTextBoxColumn
            // 
            this.vozilo1DataGridViewTextBoxColumn.DataPropertyName = "vozilo1";
            this.vozilo1DataGridViewTextBoxColumn.HeaderText = "vozilo1";
            this.vozilo1DataGridViewTextBoxColumn.Name = "vozilo1DataGridViewTextBoxColumn";
            this.vozilo1DataGridViewTextBoxColumn.Visible = false;
            // 
            // ugovorBindingSource
            // 
            this.ugovorBindingSource.DataSource = typeof(DriveIT.Database.ugovor);
            // 
            // lblPretragaUgovori
            // 
            this.lblPretragaUgovori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPretragaUgovori.AutoSize = true;
            this.lblPretragaUgovori.CustomBackground = true;
            this.lblPretragaUgovori.CustomForeColor = false;
            this.lblPretragaUgovori.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblPretragaUgovori.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblPretragaUgovori.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblPretragaUgovori.Location = new System.Drawing.Point(681, 81);
            this.lblPretragaUgovori.Name = "lblPretragaUgovori";
            this.lblPretragaUgovori.Size = new System.Drawing.Size(64, 19);
            this.lblPretragaUgovori.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblPretragaUgovori.StyleManager = null;
            this.lblPretragaUgovori.TabIndex = 2;
            this.lblPretragaUgovori.Text = "Pretraga ";
            this.lblPretragaUgovori.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblPretragaUgovori.UseStyleColors = false;
            // 
            // txtPretragaUgovori
            // 
            this.txtPretragaUgovori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPretragaUgovori.CustomBackground = false;
            this.txtPretragaUgovori.CustomForeColor = false;
            this.txtPretragaUgovori.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtPretragaUgovori.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtPretragaUgovori.Location = new System.Drawing.Point(751, 77);
            this.txtPretragaUgovori.Multiline = false;
            this.txtPretragaUgovori.Name = "txtPretragaUgovori";
            this.txtPretragaUgovori.SelectedText = "";
            this.txtPretragaUgovori.Size = new System.Drawing.Size(150, 23);
            this.txtPretragaUgovori.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPretragaUgovori.StyleManager = null;
            this.txtPretragaUgovori.TabIndex = 3;
            this.txtPretragaUgovori.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPretragaUgovori.UseStyleColors = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(907, 77);
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
            this.pictureBox2.Location = new System.Drawing.Point(25, 629);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(358, 104);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnDodajUgovor
            // 
            this.btnDodajUgovor.Highlight = false;
            this.btnDodajUgovor.Location = new System.Drawing.Point(25, 50);
            this.btnDodajUgovor.Name = "btnDodajUgovor";
            this.btnDodajUgovor.Size = new System.Drawing.Size(280, 80);
            this.btnDodajUgovor.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDodajUgovor.StyleManager = null;
            this.btnDodajUgovor.TabIndex = 8;
            this.btnDodajUgovor.Text = "Dodaj novi ugovor";
            this.btnDodajUgovor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDodajUgovor.Click += new System.EventHandler(this.btnDodajUgovor_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Highlight = false;
            this.btnOsvjezi.Location = new System.Drawing.Point(323, 50);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(280, 80);
            this.btnOsvjezi.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnOsvjezi.StyleManager = null;
            this.btnOsvjezi.TabIndex = 9;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // frmUgovori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnDodajUgovor);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPretragaUgovori);
            this.Controls.Add(this.lblPretragaUgovori);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIzlaz);
            this.Name = "frmUgovori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ugovori";
            this.Load += new System.EventHandler(this.frmUgovori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnIzlaz;
        private System.Windows.Forms.DataGridView dataGridView1;

        private MetroFramework.Controls.MetroLabel lblPretragaUgovori;
        private MetroFramework.Controls.MetroTextBox txtPretragaUgovori;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton btnDodajUgovor;
        private System.Windows.Forms.BindingSource ugovorBindingSource;
        private MetroFramework.Controls.MetroButton btnOsvjezi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idugovorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kupacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljaciddobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kupac1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vozilo1DataGridViewTextBoxColumn;

    }
}