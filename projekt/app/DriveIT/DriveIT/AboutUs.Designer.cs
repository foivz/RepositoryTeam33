namespace DriveIT
{
    partial class frmAboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAboutUs));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblPrvi = new System.Windows.Forms.Label();
            this.lblDrugi = new System.Windows.Forms.Label();
            this.lblTreci = new System.Windows.Forms.Label();
            this.lblCetvrti = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 104);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(248, 197);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(53, 13);
            this.lblTeam.TabIndex = 8;
            this.lblTeam.Text = "Tim .NOT";
            // 
            // lblPrvi
            // 
            this.lblPrvi.AutoSize = true;
            this.lblPrvi.Location = new System.Drawing.Point(242, 236);
            this.lblPrvi.Name = "lblPrvi";
            this.lblPrvi.Size = new System.Drawing.Size(66, 13);
            this.lblPrvi.TabIndex = 9;
            this.lblPrvi.Text = "Marko Alerić";
            // 
            // lblDrugi
            // 
            this.lblDrugi.AutoSize = true;
            this.lblDrugi.Location = new System.Drawing.Point(242, 262);
            this.lblDrugi.Name = "lblDrugi";
            this.lblDrugi.Size = new System.Drawing.Size(67, 13);
            this.lblDrugi.TabIndex = 10;
            this.lblDrugi.Text = "Mislav Boras";
            // 
            // lblTreci
            // 
            this.lblTreci.AutoSize = true;
            this.lblTreci.Location = new System.Drawing.Point(238, 284);
            this.lblTreci.Name = "lblTreci";
            this.lblTreci.Size = new System.Drawing.Size(75, 13);
            this.lblTreci.TabIndex = 11;
            this.lblTreci.Text = "Josip Primorac";
            // 
            // lblCetvrti
            // 
            this.lblCetvrti.AutoSize = true;
            this.lblCetvrti.Location = new System.Drawing.Point(239, 309);
            this.lblCetvrti.Name = "lblCetvrti";
            this.lblCetvrti.Size = new System.Drawing.Size(70, 13);
            this.lblCetvrti.TabIndex = 12;
            this.lblCetvrti.Text = "Andrea Pleše";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lovro Predovan";
            // 
            // frmAboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCetvrti);
            this.Controls.Add(this.lblTreci);
            this.Controls.Add(this.lblDrugi);
            this.Controls.Add(this.lblPrvi);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAboutUs";
            this.Text = "AboutUs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblPrvi;
        private System.Windows.Forms.Label lblDrugi;
        private System.Windows.Forms.Label lblTreci;
        private System.Windows.Forms.Label lblCetvrti;
        private System.Windows.Forms.Label label1;
    }
}