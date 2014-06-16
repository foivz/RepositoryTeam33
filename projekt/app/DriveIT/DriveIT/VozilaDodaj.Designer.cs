namespace DriveIT
{
    partial class frmVozilaDodaj
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lblDodajVozilo = new System.Windows.Forms.Label();
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.lblSjedista = new System.Windows.Forms.Label();
            this.txtSjedista = new System.Windows.Forms.TextBox();
            this.lblSnaga = new System.Windows.Forms.Label();
            this.txtSnaga = new System.Windows.Forms.TextBox();
            this.lblDatumNabave = new System.Windows.Forms.Label();
            this.lblGodinaProizvodnje = new System.Windows.Forms.Label();
            this.lblBoja = new System.Windows.Forms.Label();
            this.txtBoja = new System.Windows.Forms.TextBox();
            this.lblPrvaReg = new System.Windows.Forms.Label();
            this.lblSasija = new System.Windows.Forms.Label();
            this.txtBrSasije = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblTipVozila = new System.Windows.Forms.Label();
            this.lblKilometri = new System.Windows.Forms.Label();
            this.txtKilometraza = new System.Windows.Forms.TextBox();
            this.lblServisna = new System.Windows.Forms.Label();
            this.txtServisna = new System.Windows.Forms.TextBox();
            this.lblPrometna = new System.Windows.Forms.Label();
            this.txtPrometna = new System.Windows.Forms.TextBox();
            this.lblRegistracija = new System.Windows.Forms.Label();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.lblNosivost = new System.Windows.Forms.Label();
            this.txtNosivost = new System.Windows.Forms.TextBox();
            this.lblParking = new System.Windows.Forms.Label();
            this.dtPickerPrvaRegistracija = new System.Windows.Forms.DateTimePicker();
            this.txtGodinaProizvodnje = new System.Windows.Forms.TextBox();
            this.dtPickerNabavka = new System.Windows.Forms.DateTimePicker();
            this.txtParking = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.ComboBox();
            this.txtTipVozila = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(525, 507);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 34;
            this.btnOdustani.TabStop = false;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // lblDodajVozilo
            // 
            this.lblDodajVozilo.AutoSize = true;
            this.lblDodajVozilo.Location = new System.Drawing.Point(447, 28);
            this.lblDodajVozilo.Name = "lblDodajVozilo";
            this.lblDodajVozilo.Size = new System.Drawing.Size(65, 13);
            this.lblDodajVozilo.TabIndex = 33;
            this.lblDodajVozilo.Text = "Dodaj vozilo";
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Location = new System.Drawing.Point(190, 487);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(250, 43);
            this.btnDodajVozilo.TabIndex = 32;
            this.btnDodajVozilo.Text = "Dodaj vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = true;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajDobavljac_Click);
            // 
            // lblSjedista
            // 
            this.lblSjedista.AutoSize = true;
            this.lblSjedista.Location = new System.Drawing.Point(48, 431);
            this.lblSjedista.Name = "lblSjedista";
            this.lblSjedista.Size = new System.Drawing.Size(51, 13);
            this.lblSjedista.TabIndex = 31;
            this.lblSjedista.Text = "Sjedišta *";
            // 
            // txtSjedista
            // 
            this.txtSjedista.Location = new System.Drawing.Point(190, 431);
            this.txtSjedista.Name = "txtSjedista";
            this.txtSjedista.Size = new System.Drawing.Size(148, 20);
            this.txtSjedista.TabIndex = 30;
            // 
            // lblSnaga
            // 
            this.lblSnaga.AutoSize = true;
            this.lblSnaga.Location = new System.Drawing.Point(48, 371);
            this.lblSnaga.Name = "lblSnaga";
            this.lblSnaga.Size = new System.Drawing.Size(72, 13);
            this.lblSnaga.TabIndex = 29;
            this.lblSnaga.Text = "Snaga (KW) *";
            // 
            // txtSnaga
            // 
            this.txtSnaga.Location = new System.Drawing.Point(190, 371);
            this.txtSnaga.Name = "txtSnaga";
            this.txtSnaga.Size = new System.Drawing.Size(148, 20);
            this.txtSnaga.TabIndex = 28;
            // 
            // lblDatumNabave
            // 
            this.lblDatumNabave.AutoSize = true;
            this.lblDatumNabave.Location = new System.Drawing.Point(48, 312);
            this.lblDatumNabave.Name = "lblDatumNabave";
            this.lblDatumNabave.Size = new System.Drawing.Size(77, 13);
            this.lblDatumNabave.TabIndex = 27;
            this.lblDatumNabave.Text = "Datum nabave";
            // 
            // lblGodinaProizvodnje
            // 
            this.lblGodinaProizvodnje.AutoSize = true;
            this.lblGodinaProizvodnje.Location = new System.Drawing.Point(48, 253);
            this.lblGodinaProizvodnje.Name = "lblGodinaProizvodnje";
            this.lblGodinaProizvodnje.Size = new System.Drawing.Size(105, 13);
            this.lblGodinaProizvodnje.TabIndex = 25;
            this.lblGodinaProizvodnje.Text = "Godina proizvodnje *";
            // 
            // lblBoja
            // 
            this.lblBoja.AutoSize = true;
            this.lblBoja.Location = new System.Drawing.Point(48, 197);
            this.lblBoja.Name = "lblBoja";
            this.lblBoja.Size = new System.Drawing.Size(35, 13);
            this.lblBoja.TabIndex = 23;
            this.lblBoja.Text = "Boja *";
            // 
            // txtBoja
            // 
            this.txtBoja.Location = new System.Drawing.Point(190, 197);
            this.txtBoja.Name = "txtBoja";
            this.txtBoja.Size = new System.Drawing.Size(148, 20);
            this.txtBoja.TabIndex = 22;
            // 
            // lblPrvaReg
            // 
            this.lblPrvaReg.AutoSize = true;
            this.lblPrvaReg.Location = new System.Drawing.Point(48, 146);
            this.lblPrvaReg.Name = "lblPrvaReg";
            this.lblPrvaReg.Size = new System.Drawing.Size(82, 13);
            this.lblPrvaReg.TabIndex = 21;
            this.lblPrvaReg.Text = "Prva registracija";
            // 
            // lblSasija
            // 
            this.lblSasija.AutoSize = true;
            this.lblSasija.Location = new System.Drawing.Point(48, 98);
            this.lblSasija.Name = "lblSasija";
            this.lblSasija.Size = new System.Drawing.Size(54, 13);
            this.lblSasija.TabIndex = 19;
            this.lblSasija.Text = "Broj šasije";
            // 
            // txtBrSasije
            // 
            this.txtBrSasije.Location = new System.Drawing.Point(190, 98);
            this.txtBrSasije.Name = "txtBrSasije";
            this.txtBrSasije.Size = new System.Drawing.Size(148, 20);
            this.txtBrSasije.TabIndex = 18;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(422, 431);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(73, 13);
            this.lblModel.TabIndex = 48;
            this.lblModel.Text = "Model vozila *";
            // 
            // lblTipVozila
            // 
            this.lblTipVozila.AutoSize = true;
            this.lblTipVozila.Location = new System.Drawing.Point(422, 371);
            this.lblTipVozila.Name = "lblTipVozila";
            this.lblTipVozila.Size = new System.Drawing.Size(59, 13);
            this.lblTipVozila.TabIndex = 46;
            this.lblTipVozila.Text = "Tip vozila *";
            // 
            // lblKilometri
            // 
            this.lblKilometri.AutoSize = true;
            this.lblKilometri.Location = new System.Drawing.Point(422, 312);
            this.lblKilometri.Name = "lblKilometri";
            this.lblKilometri.Size = new System.Drawing.Size(68, 13);
            this.lblKilometri.TabIndex = 44;
            this.lblKilometri.Text = "Kilometraža *";
            // 
            // txtKilometraza
            // 
            this.txtKilometraza.Location = new System.Drawing.Point(564, 312);
            this.txtKilometraza.Name = "txtKilometraza";
            this.txtKilometraza.Size = new System.Drawing.Size(148, 20);
            this.txtKilometraza.TabIndex = 43;
            // 
            // lblServisna
            // 
            this.lblServisna.AutoSize = true;
            this.lblServisna.Location = new System.Drawing.Point(422, 253);
            this.lblServisna.Name = "lblServisna";
            this.lblServisna.Size = new System.Drawing.Size(86, 13);
            this.lblServisna.TabIndex = 42;
            this.lblServisna.Text = "Servisna knjižica";
            // 
            // txtServisna
            // 
            this.txtServisna.Location = new System.Drawing.Point(564, 253);
            this.txtServisna.Name = "txtServisna";
            this.txtServisna.Size = new System.Drawing.Size(148, 20);
            this.txtServisna.TabIndex = 41;
            // 
            // lblPrometna
            // 
            this.lblPrometna.AutoSize = true;
            this.lblPrometna.Location = new System.Drawing.Point(422, 197);
            this.lblPrometna.Name = "lblPrometna";
            this.lblPrometna.Size = new System.Drawing.Size(90, 13);
            this.lblPrometna.TabIndex = 40;
            this.lblPrometna.Text = "Prometna knjižica";
            // 
            // txtPrometna
            // 
            this.txtPrometna.Location = new System.Drawing.Point(564, 197);
            this.txtPrometna.Name = "txtPrometna";
            this.txtPrometna.Size = new System.Drawing.Size(148, 20);
            this.txtPrometna.TabIndex = 39;
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.Location = new System.Drawing.Point(422, 146);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(101, 13);
            this.lblRegistracija.TabIndex = 38;
            this.lblRegistracija.Text = "Registarska oznaka";
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(564, 146);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(148, 20);
            this.txtRegistracija.TabIndex = 37;
            // 
            // lblNosivost
            // 
            this.lblNosivost.AutoSize = true;
            this.lblNosivost.Location = new System.Drawing.Point(422, 98);
            this.lblNosivost.Name = "lblNosivost";
            this.lblNosivost.Size = new System.Drawing.Size(48, 13);
            this.lblNosivost.TabIndex = 36;
            this.lblNosivost.Text = "Nosivost";
            // 
            // txtNosivost
            // 
            this.txtNosivost.Location = new System.Drawing.Point(564, 98);
            this.txtNosivost.Name = "txtNosivost";
            this.txtNosivost.Size = new System.Drawing.Size(148, 20);
            this.txtNosivost.TabIndex = 35;
            // 
            // lblParking
            // 
            this.lblParking.AutoSize = true;
            this.lblParking.Location = new System.Drawing.Point(764, 98);
            this.lblParking.Name = "lblParking";
            this.lblParking.Size = new System.Drawing.Size(50, 13);
            this.lblParking.TabIndex = 50;
            this.lblParking.Text = "Parking *";
            // 
            // dtPickerPrvaRegistracija
            // 
            this.dtPickerPrvaRegistracija.Location = new System.Drawing.Point(190, 138);
            this.dtPickerPrvaRegistracija.Name = "dtPickerPrvaRegistracija";
            this.dtPickerPrvaRegistracija.Size = new System.Drawing.Size(148, 20);
            this.dtPickerPrvaRegistracija.TabIndex = 51;
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(190, 250);
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(148, 20);
            this.txtGodinaProizvodnje.TabIndex = 52;
            // 
            // dtPickerNabavka
            // 
            this.dtPickerNabavka.Location = new System.Drawing.Point(190, 309);
            this.dtPickerNabavka.Name = "dtPickerNabavka";
            this.dtPickerNabavka.Size = new System.Drawing.Size(148, 20);
            this.dtPickerNabavka.TabIndex = 53;
            // 
            // txtParking
            // 
            this.txtParking.FormattingEnabled = true;
            this.txtParking.Location = new System.Drawing.Point(863, 95);
            this.txtParking.Name = "txtParking";
            this.txtParking.Size = new System.Drawing.Size(121, 21);
            this.txtParking.TabIndex = 54;
            // 
            // txtModel
            // 
            this.txtModel.FormattingEnabled = true;
            this.txtModel.Location = new System.Drawing.Point(564, 428);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(148, 21);
            this.txtModel.TabIndex = 55;
            // 
            // txtTipVozila
            // 
            this.txtTipVozila.FormattingEnabled = true;
            this.txtTipVozila.Location = new System.Drawing.Point(564, 371);
            this.txtTipVozila.Name = "txtTipVozila";
            this.txtTipVozila.Size = new System.Drawing.Size(148, 21);
            this.txtTipVozila.TabIndex = 56;
            // 
            // frmVozilaDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 576);
            this.Controls.Add(this.txtTipVozila);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtParking);
            this.Controls.Add(this.dtPickerNabavka);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.dtPickerPrvaRegistracija);
            this.Controls.Add(this.lblParking);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblTipVozila);
            this.Controls.Add(this.lblKilometri);
            this.Controls.Add(this.txtKilometraza);
            this.Controls.Add(this.lblServisna);
            this.Controls.Add(this.txtServisna);
            this.Controls.Add(this.lblPrometna);
            this.Controls.Add(this.txtPrometna);
            this.Controls.Add(this.lblRegistracija);
            this.Controls.Add(this.txtRegistracija);
            this.Controls.Add(this.lblNosivost);
            this.Controls.Add(this.txtNosivost);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.lblDodajVozilo);
            this.Controls.Add(this.btnDodajVozilo);
            this.Controls.Add(this.lblSjedista);
            this.Controls.Add(this.txtSjedista);
            this.Controls.Add(this.lblSnaga);
            this.Controls.Add(this.txtSnaga);
            this.Controls.Add(this.lblDatumNabave);
            this.Controls.Add(this.lblGodinaProizvodnje);
            this.Controls.Add(this.lblBoja);
            this.Controls.Add(this.txtBoja);
            this.Controls.Add(this.lblPrvaReg);
            this.Controls.Add(this.lblSasija);
            this.Controls.Add(this.txtBrSasije);
            this.Name = "frmVozilaDodaj";
            this.Text = "VozilaDodaj";
            this.Load += new System.EventHandler(this.frmVozilaDodaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblDodajVozilo;
        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.Label lblSjedista;
        private System.Windows.Forms.TextBox txtSjedista;
        private System.Windows.Forms.Label lblSnaga;
        private System.Windows.Forms.TextBox txtSnaga;
        private System.Windows.Forms.Label lblDatumNabave;
        private System.Windows.Forms.Label lblGodinaProizvodnje;
        private System.Windows.Forms.Label lblBoja;
        private System.Windows.Forms.TextBox txtBoja;
        private System.Windows.Forms.Label lblPrvaReg;
        private System.Windows.Forms.Label lblSasija;
        private System.Windows.Forms.TextBox txtBrSasije;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblTipVozila;
        private System.Windows.Forms.Label lblKilometri;
        private System.Windows.Forms.TextBox txtKilometraza;
        private System.Windows.Forms.Label lblServisna;
        private System.Windows.Forms.TextBox txtServisna;
        private System.Windows.Forms.Label lblPrometna;
        private System.Windows.Forms.TextBox txtPrometna;
        private System.Windows.Forms.Label lblRegistracija;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.Label lblNosivost;
        private System.Windows.Forms.TextBox txtNosivost;
        private System.Windows.Forms.Label lblParking;
        private System.Windows.Forms.DateTimePicker dtPickerPrvaRegistracija;
        private System.Windows.Forms.TextBox txtGodinaProizvodnje;
        private System.Windows.Forms.DateTimePicker dtPickerNabavka;
        private System.Windows.Forms.ComboBox txtParking;
        private System.Windows.Forms.ComboBox txtModel;
        private System.Windows.Forms.ComboBox txtTipVozila;
    }
}