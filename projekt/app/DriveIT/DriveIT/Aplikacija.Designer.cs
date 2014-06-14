namespace DriveIT
{
    partial class frmAplikacija
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
            this.btnDobavljaci = new System.Windows.Forms.Button();
            this.btnKupci = new System.Windows.Forms.Button();
            this.btnVozila = new System.Windows.Forms.Button();
            this.btnUgovori = new System.Windows.Forms.Button();
            this.btnTlocrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDobavljaci
            // 
            this.btnDobavljaci.Location = new System.Drawing.Point(46, 62);
            this.btnDobavljaci.Name = "btnDobavljaci";
            this.btnDobavljaci.Size = new System.Drawing.Size(288, 104);
            this.btnDobavljaci.TabIndex = 0;
            this.btnDobavljaci.Text = "Dobavljaci";
            this.btnDobavljaci.UseVisualStyleBackColor = true;
            this.btnDobavljaci.Click += new System.EventHandler(this.btnDobavljaci_Click);
            // 
            // btnKupci
            // 
            this.btnKupci.Location = new System.Drawing.Point(436, 62);
            this.btnKupci.Name = "btnKupci";
            this.btnKupci.Size = new System.Drawing.Size(288, 104);
            this.btnKupci.TabIndex = 1;
            this.btnKupci.Text = "Kupci i interesanti";
            this.btnKupci.UseVisualStyleBackColor = true;
            this.btnKupci.Click += new System.EventHandler(this.btnKupci_Click);
            // 
            // btnVozila
            // 
            this.btnVozila.Location = new System.Drawing.Point(46, 196);
            this.btnVozila.Name = "btnVozila";
            this.btnVozila.Size = new System.Drawing.Size(288, 104);
            this.btnVozila.TabIndex = 2;
            this.btnVozila.Text = "Vozila";
            this.btnVozila.UseVisualStyleBackColor = true;
            this.btnVozila.Click += new System.EventHandler(this.btnVozila_Click);
            // 
            // btnUgovori
            // 
            this.btnUgovori.Location = new System.Drawing.Point(436, 196);
            this.btnUgovori.Name = "btnUgovori";
            this.btnUgovori.Size = new System.Drawing.Size(288, 104);
            this.btnUgovori.TabIndex = 3;
            this.btnUgovori.Text = "Ugovori";
            this.btnUgovori.UseVisualStyleBackColor = true;
            this.btnUgovori.Click += new System.EventHandler(this.btnUgovori_Click);
            // 
            // btnTlocrt
            // 
            this.btnTlocrt.Location = new System.Drawing.Point(46, 323);
            this.btnTlocrt.Name = "btnTlocrt";
            this.btnTlocrt.Size = new System.Drawing.Size(678, 189);
            this.btnTlocrt.TabIndex = 4;
            this.btnTlocrt.Text = "Tlocrt dvorista";
            this.btnTlocrt.UseVisualStyleBackColor = true;
            // 
            // frmAplikacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 662);
            this.Controls.Add(this.btnTlocrt);
            this.Controls.Add(this.btnUgovori);
            this.Controls.Add(this.btnVozila);
            this.Controls.Add(this.btnKupci);
            this.Controls.Add(this.btnDobavljaci);
            this.Name = "frmAplikacija";
            this.Text = "Aplikacija";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDobavljaci;
        private System.Windows.Forms.Button btnKupci;
        private System.Windows.Forms.Button btnVozila;
        private System.Windows.Forms.Button btnUgovori;
        private System.Windows.Forms.Button btnTlocrt;
    }
}