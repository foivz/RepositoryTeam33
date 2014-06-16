﻿using DriveIT.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriveIT
{
    public partial class frmVozilaDetalji : Form
    {
        public frmVozilaDetalji()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int id = Convert.ToInt32(txtIdVozilo.Text);

            T33_DBEntities db = new T33_DBEntities();
            vozilo vozilo = db.vozilo.Where<vozilo>(x => x.id_vozilo == id ).First<vozilo>();
            db.vozilo.Remove(vozilo);
            db.SaveChanges();

            MessageBox.Show("Vozilo uspješno obrisano");
            System.Threading.Thread.Sleep(700);
            this.Close();

        }

        private void VozilaDetalji_Load(object sender, EventArgs e)
        {
            
        }

        public void getDetails(string i){
            
            T33_DBEntities db = new T33_DBEntities();
            int b = int.Parse(i);

            var vozila = db.vozilo.Where<vozilo>(x => x.id_vozilo == b).First<vozilo>();

            txtIdVozilo.Text = i;
            txtBoja.Text = vozila.boja;
            txtBrSasije.Text = vozila.sasija;
            txtGodinaProizvodnje.Text = Convert.ToString(vozila.godina_proizvodnje);
            dtPickerPrvaRegistracija.Value = (DateTime)vozila.datum_prve_registracije;
            dtPickerNabavka.Value = (DateTime) vozila.datum_nabavke;

            txtIdVozilo.Text = Convert.ToString(vozila.id_vozilo);
            txtRegistracija.Text = vozila.registracija; 
            txtPrometna.Text = vozila.prometna;
            txtServisna.Text = vozila.servisna;
            txtSnaga.Text = Convert.ToString(vozila.snaga_kw);
            txtNosivost.Text = Convert.ToString(vozila.nosivost);
            txtSjedista.Text =  Convert.ToString(vozila.sjedista);
            txtKilometraza.Text = Convert.ToString(vozila.kilometri);

        }

        private void btnAzurirajVozilo_Click(object sender, EventArgs e)
        {

            T33_DBEntities db = new T33_DBEntities();

            //vozilo vozilo = db.vozilo.Where<vozilo>(x => x.id_vozilo == b).First<vozilo>();

            int id = Convert.ToInt32(txtIdVozilo.Text);

            vozilo vozilo = db.vozilo.First(i => i.id_vozilo == id );

            vozilo.sasija = txtBrSasije.Text;
            vozilo.datum_prve_registracije = dtPickerPrvaRegistracija.Value;
            vozilo.boja = txtBoja.Text;
            vozilo.godina_proizvodnje = Convert.ToInt32(txtGodinaProizvodnje.Text);
            vozilo.datum_nabavke = dtPickerNabavka.Value;
            vozilo.snaga_kw = Convert.ToInt32(txtSnaga.Text);
            vozilo.sjedista = Convert.ToInt32(txtSjedista.Text);
            vozilo.nosivost = Convert.ToInt32(txtNosivost.Text);
            vozilo.registracija = txtRegistracija.Text;
            vozilo.prometna = txtPrometna.Text;
            vozilo.servisna = txtServisna.Text;
            vozilo.kilometri = Convert.ToInt32(txtKilometraza.Text);


            db.SaveChanges();
            MessageBox.Show("Vozilo uspješno ažurirano !");
            System.Threading.Thread.Sleep(700);

            this.Close();

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
