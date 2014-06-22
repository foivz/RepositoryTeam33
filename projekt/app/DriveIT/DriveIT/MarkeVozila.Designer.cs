namespace DriveIT
{
    partial class frmMarkeVozila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarkeVozila));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idmarkavozilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drzavaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelvozilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markavozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblVrste = new MetroFramework.Controls.MetroLabel();
            this.btnDodaj = new MetroFramework.Controls.MetroButton();
            this.btnOsvjezi = new MetroFramework.Controls.MetroButton();
            this.btnIzlaz = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markavozilaBindingSource)).BeginInit();
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
            this.idmarkavozilaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.drzavaDataGridViewTextBoxColumn,
            this.modelvozilaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.markavozilaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(66, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(590, 220);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idmarkavozilaDataGridViewTextBoxColumn
            // 
            this.idmarkavozilaDataGridViewTextBoxColumn.DataPropertyName = "id_marka_vozila";
            this.idmarkavozilaDataGridViewTextBoxColumn.FillWeight = 30F;
            this.idmarkavozilaDataGridViewTextBoxColumn.HeaderText = "šifra";
            this.idmarkavozilaDataGridViewTextBoxColumn.Name = "idmarkavozilaDataGridViewTextBoxColumn";
            this.idmarkavozilaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmarkavozilaDataGridViewTextBoxColumn.Width = 30;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drzavaDataGridViewTextBoxColumn
            // 
            this.drzavaDataGridViewTextBoxColumn.DataPropertyName = "drzava";
            this.drzavaDataGridViewTextBoxColumn.HeaderText = "drzava";
            this.drzavaDataGridViewTextBoxColumn.Name = "drzavaDataGridViewTextBoxColumn";
            this.drzavaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelvozilaDataGridViewTextBoxColumn
            // 
            this.modelvozilaDataGridViewTextBoxColumn.DataPropertyName = "model_vozila";
            this.modelvozilaDataGridViewTextBoxColumn.HeaderText = "model_vozila";
            this.modelvozilaDataGridViewTextBoxColumn.Name = "modelvozilaDataGridViewTextBoxColumn";
            this.modelvozilaDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelvozilaDataGridViewTextBoxColumn.Visible = false;
            // 
            // markavozilaBindingSource
            // 
            this.markavozilaBindingSource.DataSource = typeof(DriveIT.Database.marka_vozila);
            // 
            // lblVrste
            // 
            this.lblVrste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVrste.AutoSize = true;
            this.lblVrste.CustomBackground = true;
            this.lblVrste.CustomForeColor = false;
            this.lblVrste.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblVrste.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblVrste.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblVrste.Location = new System.Drawing.Point(393, 48);
            this.lblVrste.Name = "lblVrste";
            this.lblVrste.Size = new System.Drawing.Size(97, 25);
            this.lblVrste.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblVrste.StyleManager = null;
            this.lblVrste.TabIndex = 15;
            this.lblVrste.Text = "Vrste vozila";
            this.lblVrste.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblVrste.UseStyleColors = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDodaj.Highlight = false;
            this.btnDodaj.Location = new System.Drawing.Point(66, 109);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(280, 80);
            this.btnDodaj.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDodaj.StyleManager = null;
            this.btnDodaj.TabIndex = 16;
            this.btnDodaj.Text = "Dodaj novu marku";
            this.btnDodaj.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOsvjezi.Highlight = false;
            this.btnOsvjezi.Location = new System.Drawing.Point(376, 109);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(280, 80);
            this.btnOsvjezi.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnOsvjezi.StyleManager = null;
            this.btnOsvjezi.TabIndex = 17;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzlaz.Highlight = false;
            this.btnIzlaz.Location = new System.Drawing.Point(664, 588);
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
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 613);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frmMarkeVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblVrste);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMarkeVozila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MarkeVozila";
            this.Load += new System.EventHandler(this.frmMarkeVozila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markavozilaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource markavozilaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmarkavozilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drzavaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelvozilaDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel lblVrste;
        private MetroFramework.Controls.MetroButton btnDodaj;
        private MetroFramework.Controls.MetroButton btnOsvjezi;
        private MetroFramework.Controls.MetroButton btnIzlaz;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}