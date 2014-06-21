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
            this.notifikacijeGrid = new System.Windows.Forms.DataGridView();
            this.saveBtn = new MetroFramework.Controls.MetroButton();
            this.lblDugoPaljenaVozila = new MetroFramework.Controls.MetroLabel();
            this.upaliBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.notifikacijeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // notifikacijeGrid
            // 
            this.notifikacijeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notifikacijeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notifikacijeGrid.Location = new System.Drawing.Point(404, 145);
            this.notifikacijeGrid.Name = "notifikacijeGrid";
            this.notifikacijeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.notifikacijeGrid.Size = new System.Drawing.Size(552, 210);
            this.notifikacijeGrid.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Highlight = false;
            this.saveBtn.Location = new System.Drawing.Point(881, 79);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.saveBtn.StyleManager = null;
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // lblDugoPaljenaVozila
            // 
            this.lblDugoPaljenaVozila.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDugoPaljenaVozila.AutoSize = true;
            this.lblDugoPaljenaVozila.CustomBackground = true;
            this.lblDugoPaljenaVozila.CustomForeColor = false;
            this.lblDugoPaljenaVozila.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDugoPaljenaVozila.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDugoPaljenaVozila.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDugoPaljenaVozila.Location = new System.Drawing.Point(404, 115);
            this.lblDugoPaljenaVozila.Name = "lblDugoPaljenaVozila";
            this.lblDugoPaljenaVozila.Size = new System.Drawing.Size(235, 25);
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
            this.upaliBtn.Location = new System.Drawing.Point(881, 361);
            this.upaliBtn.Name = "upaliBtn";
            this.upaliBtn.Size = new System.Drawing.Size(75, 23);
            this.upaliBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.upaliBtn.StyleManager = null;
            this.upaliBtn.TabIndex = 4;
            this.upaliBtn.Text = "Upali";
            this.upaliBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.upaliBtn.Click += new System.EventHandler(this.upaliBtn_Click);
            // 
            // frmMehanicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 462);
            this.Controls.Add(this.upaliBtn);
            this.Controls.Add(this.lblDugoPaljenaVozila);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.notifikacijeGrid);
            this.Name = "frmMehanicar";
            this.Text = "frmMehanicar";
            this.Load += new System.EventHandler(this.frmMehanicar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notifikacijeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView notifikacijeGrid;
        private MetroFramework.Controls.MetroButton saveBtn;
        private MetroFramework.Controls.MetroLabel lblDugoPaljenaVozila;
        private MetroFramework.Controls.MetroButton upaliBtn;
    }
}