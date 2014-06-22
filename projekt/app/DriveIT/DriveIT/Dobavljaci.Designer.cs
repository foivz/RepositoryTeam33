namespace DriveIT
{
    partial class frmDobavljaci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDobavljaci));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblPretragaDobavljaci = new MetroFramework.Controls.MetroLabel();
            this.txtPretragaDobavljaci = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDodajDobavljaca = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.btnOsvjezi = new MetroFramework.Controls.MetroButton();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.iddobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tvrtkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodatnaopremaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugovorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddobavljacDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.tvrtkaDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.faksDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dodatnaopremaDataGridViewTextBoxColumn,
            this.ugovorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dobavljacBindingSource;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LblPretragaDobavljaci
            // 
            resources.ApplyResources(this.LblPretragaDobavljaci, "LblPretragaDobavljaci");
            this.LblPretragaDobavljaci.CustomBackground = true;
            this.LblPretragaDobavljaci.CustomForeColor = false;
            this.LblPretragaDobavljaci.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.LblPretragaDobavljaci.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.LblPretragaDobavljaci.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.LblPretragaDobavljaci.Name = "LblPretragaDobavljaci";
            this.LblPretragaDobavljaci.Style = MetroFramework.MetroColorStyle.Blue;
            this.LblPretragaDobavljaci.StyleManager = null;
            this.LblPretragaDobavljaci.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LblPretragaDobavljaci.UseStyleColors = false;
            // 
            // txtPretragaDobavljaci
            // 
            resources.ApplyResources(this.txtPretragaDobavljaci, "txtPretragaDobavljaci");
            this.txtPretragaDobavljaci.CustomBackground = false;
            this.txtPretragaDobavljaci.CustomForeColor = false;
            this.txtPretragaDobavljaci.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtPretragaDobavljaci.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtPretragaDobavljaci.Multiline = false;
            this.txtPretragaDobavljaci.Name = "txtPretragaDobavljaci";
            this.txtPretragaDobavljaci.SelectedText = "";
            this.txtPretragaDobavljaci.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPretragaDobavljaci.StyleManager = null;
            this.txtPretragaDobavljaci.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPretragaDobavljaci.UseStyleColors = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // btnDodajDobavljaca
            // 
            this.btnDodajDobavljaca.Highlight = false;
            resources.ApplyResources(this.btnDodajDobavljaca, "btnDodajDobavljaca");
            this.btnDodajDobavljaca.Name = "btnDodajDobavljaca";
            this.btnDodajDobavljaca.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDodajDobavljaca.StyleManager = null;
            this.btnDodajDobavljaca.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDodajDobavljaca.Click += new System.EventHandler(this.btnDodajDobavljaca_Click);
            // 
            // metroButton2
            // 
            resources.ApplyResources(this.metroButton2, "metroButton2");
            this.metroButton2.Highlight = false;
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.StyleManager = null;
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Highlight = false;
            resources.ApplyResources(this.btnOsvjezi, "btnOsvjezi");
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnOsvjezi.StyleManager = null;
            this.btnOsvjezi.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // iddobavljacDataGridViewTextBoxColumn
            // 
            this.iddobavljacDataGridViewTextBoxColumn.DataPropertyName = "id_dobavljac";
            this.iddobavljacDataGridViewTextBoxColumn.FillWeight = 30F;
            resources.ApplyResources(this.iddobavljacDataGridViewTextBoxColumn, "iddobavljacDataGridViewTextBoxColumn");
            this.iddobavljacDataGridViewTextBoxColumn.Name = "iddobavljacDataGridViewTextBoxColumn";
            this.iddobavljacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            resources.ApplyResources(this.imeDataGridViewTextBoxColumn, "imeDataGridViewTextBoxColumn");
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            resources.ApplyResources(this.prezimeDataGridViewTextBoxColumn, "prezimeDataGridViewTextBoxColumn");
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tvrtkaDataGridViewTextBoxColumn
            // 
            this.tvrtkaDataGridViewTextBoxColumn.DataPropertyName = "tvrtka";
            resources.ApplyResources(this.tvrtkaDataGridViewTextBoxColumn, "tvrtkaDataGridViewTextBoxColumn");
            this.tvrtkaDataGridViewTextBoxColumn.Name = "tvrtkaDataGridViewTextBoxColumn";
            this.tvrtkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            resources.ApplyResources(this.adresaDataGridViewTextBoxColumn, "adresaDataGridViewTextBoxColumn");
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            resources.ApplyResources(this.telefonDataGridViewTextBoxColumn, "telefonDataGridViewTextBoxColumn");
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faksDataGridViewTextBoxColumn
            // 
            this.faksDataGridViewTextBoxColumn.DataPropertyName = "faks";
            resources.ApplyResources(this.faksDataGridViewTextBoxColumn, "faksDataGridViewTextBoxColumn");
            this.faksDataGridViewTextBoxColumn.Name = "faksDataGridViewTextBoxColumn";
            this.faksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            resources.ApplyResources(this.emailDataGridViewTextBoxColumn, "emailDataGridViewTextBoxColumn");
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dodatnaopremaDataGridViewTextBoxColumn
            // 
            this.dodatnaopremaDataGridViewTextBoxColumn.DataPropertyName = "dodatna_oprema";
            resources.ApplyResources(this.dodatnaopremaDataGridViewTextBoxColumn, "dodatnaopremaDataGridViewTextBoxColumn");
            this.dodatnaopremaDataGridViewTextBoxColumn.Name = "dodatnaopremaDataGridViewTextBoxColumn";
            this.dodatnaopremaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ugovorDataGridViewTextBoxColumn
            // 
            this.ugovorDataGridViewTextBoxColumn.DataPropertyName = "ugovor";
            resources.ApplyResources(this.ugovorDataGridViewTextBoxColumn, "ugovorDataGridViewTextBoxColumn");
            this.ugovorDataGridViewTextBoxColumn.Name = "ugovorDataGridViewTextBoxColumn";
            this.ugovorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dobavljacBindingSource
            // 
            this.dobavljacBindingSource.DataSource = typeof(DriveIT.Database.dobavljac);
            // 
            // frmDobavljaci
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btnDodajDobavljaca);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPretragaDobavljaci);
            this.Controls.Add(this.LblPretragaDobavljaci);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmDobavljaci";
            this.Load += new System.EventHandler(this.frmDobavljaci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vozilo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dobavljacBindingSource;
        private MetroFramework.Controls.MetroLabel LblPretragaDobavljaci;
        private MetroFramework.Controls.MetroTextBox txtPretragaDobavljaci;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton btnDodajDobavljaca;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btnOsvjezi;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tvrtkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dodatnaopremaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugovorDataGridViewTextBoxColumn;
    }
}