namespace DriveIT
{
    partial class frmMehanicar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMehanicar));
            this.notifikacijeGrid = new System.Windows.Forms.DataGridView();
            this.saveBtn = new MetroFramework.Controls.MetroButton();
            this.lblDugoPaljenaVozila = new MetroFramework.Controls.MetroLabel();
            this.upaliBtn = new MetroFramework.Controls.MetroButton();
            this.nalogGrid = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.otvoriNalogBtn = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.notifikacijeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nalogGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifikacijeGrid
            // 
            this.notifikacijeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notifikacijeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notifikacijeGrid.Location = new System.Drawing.Point(420, 145);
            this.notifikacijeGrid.Name = "notifikacijeGrid";
            this.notifikacijeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.notifikacijeGrid.Size = new System.Drawing.Size(543, 331);
            this.notifikacijeGrid.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Highlight = false;
            this.saveBtn.Location = new System.Drawing.Point(692, 49);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(280, 80);
            this.saveBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.saveBtn.StyleManager = null;
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // lblDugoPaljenaVozila
            // 
            this.lblDugoPaljenaVozila.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDugoPaljenaVozila.AutoSize = true;
            this.lblDugoPaljenaVozila.CustomBackground = true;
            this.lblDugoPaljenaVozila.CustomForeColor = false;
            this.lblDugoPaljenaVozila.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDugoPaljenaVozila.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDugoPaljenaVozila.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDugoPaljenaVozila.Location = new System.Drawing.Point(420, 115);
            this.lblDugoPaljenaVozila.Name = "lblDugoPaljenaVozila";
            this.lblDugoPaljenaVozila.Size = new System.Drawing.Size(233, 25);
            this.lblDugoPaljenaVozila.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDugoPaljenaVozila.StyleManager = null;
            this.lblDugoPaljenaVozila.TabIndex = 3;
            this.lblDugoPaljenaVozila.Text = "Vozila koja dugo nisu paljena";
            this.lblDugoPaljenaVozila.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDugoPaljenaVozila.UseStyleColors = false;
            // 
            // upaliBtn
            // 
            this.upaliBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.upaliBtn.Highlight = false;
            this.upaliBtn.Location = new System.Drawing.Point(683, 509);
            this.upaliBtn.Name = "upaliBtn";
            this.upaliBtn.Size = new System.Drawing.Size(280, 80);
            this.upaliBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.upaliBtn.StyleManager = null;
            this.upaliBtn.TabIndex = 4;
            this.upaliBtn.Text = "Upali";
            this.upaliBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.upaliBtn.Click += new System.EventHandler(this.upaliBtn_Click);
            // 
            // nalogGrid
            // 
            this.nalogGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nalogGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nalogGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nalogGrid.Location = new System.Drawing.Point(24, 145);
            this.nalogGrid.Name = "nalogGrid";
            this.nalogGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nalogGrid.Size = new System.Drawing.Size(361, 331);
            this.nalogGrid.TabIndex = 5;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(24, 115);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Nalozi";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // otvoriNalogBtn
            // 
            this.otvoriNalogBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.otvoriNalogBtn.Highlight = false;
            this.otvoriNalogBtn.Location = new System.Drawing.Point(24, 509);
            this.otvoriNalogBtn.Name = "otvoriNalogBtn";
            this.otvoriNalogBtn.Size = new System.Drawing.Size(280, 80);
            this.otvoriNalogBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.otvoriNalogBtn.StyleManager = null;
            this.otvoriNalogBtn.TabIndex = 7;
            this.otvoriNalogBtn.Text = "Otvori nalog";
            this.otvoriNalogBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.otvoriNalogBtn.Click += new System.EventHandler(this.otvoriNalogBtn_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Highlight = false;
            this.metroButton1.Location = new System.Drawing.Point(683, 604);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(280, 80);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.StyleManager = null;
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Izlaz";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 618);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmMehanicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.otvoriNalogBtn);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.nalogGrid);
            this.Controls.Add(this.upaliBtn);
            this.Controls.Add(this.lblDugoPaljenaVozila);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.notifikacijeGrid);
            this.Name = "frmMehanicar";
            this.Text = "frmMehanicar";
            this.Load += new System.EventHandler(this.frmMehanicar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notifikacijeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nalogGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView notifikacijeGrid;
        private MetroFramework.Controls.MetroButton saveBtn;
        private MetroFramework.Controls.MetroLabel lblDugoPaljenaVozila;
        private MetroFramework.Controls.MetroButton upaliBtn;
        private System.Windows.Forms.DataGridView nalogGrid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton otvoriNalogBtn;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}