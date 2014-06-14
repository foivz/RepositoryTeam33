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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDobavljaci));
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnIzlaz, "btnIzlaz");
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDobavljaci
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnIzlaz);
            this.Name = "frmDobavljaci";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIzlaz;
    }
}