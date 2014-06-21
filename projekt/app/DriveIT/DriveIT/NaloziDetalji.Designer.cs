namespace DriveIT
{
    partial class NaloziDetalji
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
            this.lblDugoPaljenaVozila = new MetroFramework.Controls.MetroLabel();
            this.addBtn = new MetroFramework.Controls.MetroButton();
            this.djeloviGrid = new System.Windows.Forms.DataGridView();
            this.txtOpis = new MetroFramework.Controls.MetroTextBox();
            this.lblVozilo = new MetroFramework.Controls.MetroLabel();
            this.lvlObavljeno = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtVozilo = new MetroFramework.Controls.MetroTextBox();
            this.txtSati = new MetroFramework.Controls.MetroTextBox();
            this.txtCijena = new MetroFramework.Controls.MetroTextBox();
            this.lblSati = new MetroFramework.Controls.MetroLabel();
            this.btnAzuriraj = new MetroFramework.Controls.MetroButton();
            this.comboxObavljeno = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.djeloviGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDugoPaljenaVozila
            // 
            this.lblDugoPaljenaVozila.AutoSize = true;
            this.lblDugoPaljenaVozila.CustomBackground = true;
            this.lblDugoPaljenaVozila.CustomForeColor = false;
            this.lblDugoPaljenaVozila.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblDugoPaljenaVozila.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblDugoPaljenaVozila.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblDugoPaljenaVozila.Location = new System.Drawing.Point(30, 28);
            this.lblDugoPaljenaVozila.Name = "lblDugoPaljenaVozila";
            this.lblDugoPaljenaVozila.Size = new System.Drawing.Size(36, 19);
            this.lblDugoPaljenaVozila.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDugoPaljenaVozila.StyleManager = null;
            this.lblDugoPaljenaVozila.TabIndex = 4;
            this.lblDugoPaljenaVozila.Text = "Opis";
            this.lblDugoPaljenaVozila.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDugoPaljenaVozila.UseStyleColors = false;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addBtn.Highlight = false;
            this.addBtn.Location = new System.Drawing.Point(30, 161);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(134, 35);
            this.addBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.addBtn.StyleManager = null;
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Dodaj novi dio";
            this.addBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // djeloviGrid
            // 
            this.djeloviGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.djeloviGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.djeloviGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.djeloviGrid.Location = new System.Drawing.Point(30, 202);
            this.djeloviGrid.Name = "djeloviGrid";
            this.djeloviGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.djeloviGrid.Size = new System.Drawing.Size(542, 150);
            this.djeloviGrid.TabIndex = 6;
            // 
            // txtOpis
            // 
            this.txtOpis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOpis.CustomBackground = false;
            this.txtOpis.CustomForeColor = true;
            this.txtOpis.Enabled = false;
            this.txtOpis.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtOpis.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtOpis.Location = new System.Drawing.Point(100, 17);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.SelectedText = "";
            this.txtOpis.Size = new System.Drawing.Size(472, 30);
            this.txtOpis.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOpis.StyleManager = null;
            this.txtOpis.TabIndex = 11;
            this.txtOpis.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOpis.UseStyleColors = false;
            // 
            // lblVozilo
            // 
            this.lblVozilo.AutoSize = true;
            this.lblVozilo.CustomBackground = true;
            this.lblVozilo.CustomForeColor = false;
            this.lblVozilo.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblVozilo.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblVozilo.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblVozilo.Location = new System.Drawing.Point(30, 71);
            this.lblVozilo.Name = "lblVozilo";
            this.lblVozilo.Size = new System.Drawing.Size(45, 19);
            this.lblVozilo.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblVozilo.StyleManager = null;
            this.lblVozilo.TabIndex = 12;
            this.lblVozilo.Text = "Vozilo";
            this.lblVozilo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblVozilo.UseStyleColors = false;
            // 
            // lvlObavljeno
            // 
            this.lvlObavljeno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlObavljeno.AutoSize = true;
            this.lvlObavljeno.CustomBackground = true;
            this.lvlObavljeno.CustomForeColor = false;
            this.lvlObavljeno.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lvlObavljeno.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lvlObavljeno.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lvlObavljeno.Location = new System.Drawing.Point(336, 68);
            this.lvlObavljeno.Name = "lvlObavljeno";
            this.lvlObavljeno.Size = new System.Drawing.Size(43, 19);
            this.lvlObavljeno.Style = MetroFramework.MetroColorStyle.Blue;
            this.lvlObavljeno.StyleManager = null;
            this.lvlObavljeno.TabIndex = 13;
            this.lvlObavljeno.Text = "Status";
            this.lvlObavljeno.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lvlObavljeno.UseStyleColors = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.CustomForeColor = false;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel4.Location = new System.Drawing.Point(30, 107);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.StyleManager = null;
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Cijena";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseStyleColors = false;
            // 
            // txtVozilo
            // 
            this.txtVozilo.CustomBackground = false;
            this.txtVozilo.CustomForeColor = false;
            this.txtVozilo.Enabled = false;
            this.txtVozilo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtVozilo.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtVozilo.Location = new System.Drawing.Point(100, 60);
            this.txtVozilo.Multiline = false;
            this.txtVozilo.Name = "txtVozilo";
            this.txtVozilo.SelectedText = "";
            this.txtVozilo.Size = new System.Drawing.Size(207, 30);
            this.txtVozilo.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVozilo.StyleManager = null;
            this.txtVozilo.TabIndex = 16;
            this.txtVozilo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVozilo.UseStyleColors = false;
            // 
            // txtSati
            // 
            this.txtSati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSati.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSati.CustomBackground = true;
            this.txtSati.CustomForeColor = false;
            this.txtSati.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSati.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtSati.Location = new System.Drawing.Point(415, 108);
            this.txtSati.Multiline = false;
            this.txtSati.Name = "txtSati";
            this.txtSati.SelectedText = "";
            this.txtSati.Size = new System.Drawing.Size(157, 30);
            this.txtSati.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSati.StyleManager = null;
            this.txtSati.TabIndex = 18;
            this.txtSati.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSati.UseStyleColors = false;
            // 
            // txtCijena
            // 
            this.txtCijena.CustomBackground = false;
            this.txtCijena.CustomForeColor = false;
            this.txtCijena.Enabled = false;
            this.txtCijena.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCijena.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtCijena.Location = new System.Drawing.Point(100, 103);
            this.txtCijena.Multiline = false;
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.SelectedText = "";
            this.txtCijena.Size = new System.Drawing.Size(207, 30);
            this.txtCijena.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCijena.StyleManager = null;
            this.txtCijena.TabIndex = 19;
            this.txtCijena.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCijena.UseStyleColors = false;
            // 
            // lblSati
            // 
            this.lblSati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSati.AutoSize = true;
            this.lblSati.CustomBackground = true;
            this.lblSati.CustomForeColor = false;
            this.lblSati.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblSati.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblSati.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblSati.Location = new System.Drawing.Point(335, 113);
            this.lblSati.Name = "lblSati";
            this.lblSati.Size = new System.Drawing.Size(64, 19);
            this.lblSati.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSati.StyleManager = null;
            this.lblSati.TabIndex = 20;
            this.lblSati.Text = "Sati Rada";
            this.lblSati.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSati.UseStyleColors = false;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAzuriraj.Highlight = false;
            this.btnAzuriraj.Location = new System.Drawing.Point(365, 161);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(207, 35);
            this.btnAzuriraj.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAzuriraj.StyleManager = null;
            this.btnAzuriraj.TabIndex = 21;
            this.btnAzuriraj.Text = "Ažuriraj nalog";
            this.btnAzuriraj.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // comboxObavljeno
            // 
            this.comboxObavljeno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboxObavljeno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboxObavljeno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxObavljeno.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.comboxObavljeno.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.comboxObavljeno.FormattingEnabled = true;
            this.comboxObavljeno.ItemHeight = 23;
            this.comboxObavljeno.Items.AddRange(new object[] {
            "Nije obavljeno",
            "Obavljeno"});
            this.comboxObavljeno.Location = new System.Drawing.Point(415, 60);
            this.comboxObavljeno.Name = "comboxObavljeno";
            this.comboxObavljeno.Size = new System.Drawing.Size(157, 29);
            this.comboxObavljeno.Style = MetroFramework.MetroColorStyle.Blue;
            this.comboxObavljeno.StyleManager = null;
            this.comboxObavljeno.TabIndex = 22;
            this.comboxObavljeno.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // NaloziDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 364);
            this.Controls.Add(this.comboxObavljeno);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.lblSati);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtSati);
            this.Controls.Add(this.txtVozilo);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lvlObavljeno);
            this.Controls.Add(this.lblVozilo);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.djeloviGrid);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.lblDugoPaljenaVozila);
            this.Name = "NaloziDetalji";
            this.Text = "NaloziDetalji";
            this.Load += new System.EventHandler(this.NaloziDetalji_Load);
            this.Leave += new System.EventHandler(this.NaloziDetalji_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.djeloviGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblDugoPaljenaVozila;
        private MetroFramework.Controls.MetroButton addBtn;
        private System.Windows.Forms.DataGridView djeloviGrid;
        private MetroFramework.Controls.MetroTextBox txtOpis;
        private MetroFramework.Controls.MetroLabel lblVozilo;
        private MetroFramework.Controls.MetroLabel lvlObavljeno;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtVozilo;
        private MetroFramework.Controls.MetroTextBox txtSati;
        private MetroFramework.Controls.MetroTextBox txtCijena;
        private MetroFramework.Controls.MetroLabel lblSati;
        private MetroFramework.Controls.MetroButton btnAzuriraj;
        private MetroFramework.Controls.MetroComboBox comboxObavljeno;
    }
}