namespace DriveIT
{
    partial class frmModeliVozila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModeliVozila));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idmodelvozilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markavozilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markavozila1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelvozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblVrsteVozila = new MetroFramework.Controls.MetroLabel();
            this.btnOsvjezi = new MetroFramework.Controls.MetroButton();
            this.btnDodajVozilo = new MetroFramework.Controls.MetroButton();
            this.btnIzlaz = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelvozilaBindingSource)).BeginInit();
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
            this.idmodelvozilaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.markavozilaDataGridViewTextBoxColumn,
            this.markavozila1DataGridViewTextBoxColumn,
            this.voziloDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.modelvozilaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(880, 210);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idmodelvozilaDataGridViewTextBoxColumn
            // 
            this.idmodelvozilaDataGridViewTextBoxColumn.DataPropertyName = "id_model_vozila";
            this.idmodelvozilaDataGridViewTextBoxColumn.HeaderText = "šifra";
            this.idmodelvozilaDataGridViewTextBoxColumn.Name = "idmodelvozilaDataGridViewTextBoxColumn";
            this.idmodelvozilaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmodelvozilaDataGridViewTextBoxColumn.Width = 30;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markavozilaDataGridViewTextBoxColumn
            // 
            this.markavozilaDataGridViewTextBoxColumn.DataPropertyName = "marka_vozila";
            this.markavozilaDataGridViewTextBoxColumn.HeaderText = "marka";
            this.markavozilaDataGridViewTextBoxColumn.Name = "markavozilaDataGridViewTextBoxColumn";
            this.markavozilaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markavozila1DataGridViewTextBoxColumn
            // 
            this.markavozila1DataGridViewTextBoxColumn.DataPropertyName = "marka_vozila1";
            this.markavozila1DataGridViewTextBoxColumn.HeaderText = "marka_vozila1";
            this.markavozila1DataGridViewTextBoxColumn.Name = "markavozila1DataGridViewTextBoxColumn";
            this.markavozila1DataGridViewTextBoxColumn.ReadOnly = true;
            this.markavozila1DataGridViewTextBoxColumn.Visible = false;
            // 
            // voziloDataGridViewTextBoxColumn
            // 
            this.voziloDataGridViewTextBoxColumn.DataPropertyName = "vozilo";
            this.voziloDataGridViewTextBoxColumn.HeaderText = "vozilo";
            this.voziloDataGridViewTextBoxColumn.Name = "voziloDataGridViewTextBoxColumn";
            this.voziloDataGridViewTextBoxColumn.ReadOnly = true;
            this.voziloDataGridViewTextBoxColumn.Visible = false;
            // 
            // modelvozilaBindingSource
            // 
            this.modelvozilaBindingSource.DataSource = typeof(DriveIT.Database.model_vozila);
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
            this.lblVrsteVozila.Location = new System.Drawing.Point(388, 42);
            this.lblVrsteVozila.Name = "lblVrsteVozila";
            this.lblVrsteVozila.Size = new System.Drawing.Size(97, 25);
            this.lblVrsteVozila.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblVrsteVozila.StyleManager = null;
            this.lblVrsteVozila.TabIndex = 15;
            this.lblVrsteVozila.Text = "Vrste vozila";
            this.lblVrsteVozila.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblVrsteVozila.UseStyleColors = false;
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOsvjezi.Highlight = false;
            this.btnOsvjezi.Location = new System.Drawing.Point(375, 150);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(280, 80);
            this.btnOsvjezi.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnOsvjezi.StyleManager = null;
            this.btnOsvjezi.TabIndex = 16;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDodajVozilo.Highlight = false;
            this.btnDodajVozilo.Location = new System.Drawing.Point(59, 150);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(280, 80);
            this.btnDodajVozilo.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDodajVozilo.StyleManager = null;
            this.btnDodajVozilo.TabIndex = 17;
            this.btnDodajVozilo.Text = "Dodaj vozilo";
            this.btnDodajVozilo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzlaz.Highlight = false;
            this.btnIzlaz.Location = new System.Drawing.Point(654, 591);
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
            this.pictureBox1.Location = new System.Drawing.Point(25, 607);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frmModeliVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnDodajVozilo);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.lblVrsteVozila);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmModeliVozila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modeli";
            this.Load += new System.EventHandler(this.frmModeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelvozilaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource modelvozilaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmodelvozilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markavozilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markavozila1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel lblVrsteVozila;
        private MetroFramework.Controls.MetroButton btnOsvjezi;
        private MetroFramework.Controls.MetroButton btnDodajVozilo;
        private MetroFramework.Controls.MetroButton btnIzlaz;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}