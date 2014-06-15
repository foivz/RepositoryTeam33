using DriveIT.Database;
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
            //brisanje vozila
        }

        private void VozilaDetalji_Load(object sender, EventArgs e)
        {
            
        }



        public void getDetails(string i){

            
            T33_DBEntities db = new T33_DBEntities();
            int b = int.Parse(i);

            

            var vozila = db.vozilo.Where<vozilo>(x => x.id_vozilo == b).First<vozilo>();
            txtBoja.Text = vozila.boja;
            txtBrSasije.Text = vozila.sasija;
            txtGodinaProizvodnje.Text = Convert.ToString(vozila.godina_proizvodnje);
            dtPickerPrvaRegistracija.Value = (DateTime)vozila.datum_prve_registracije;
            dtPickerNabavka.Value = (DateTime) vozila.datum_nabavke;

            txtId.Text = Convert.ToString(vozila.id_vozilo);
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


            marka_vozila marka = db.marka_vozila.First(i => i.drzava == "Njemacka");
            marka.drzava = "Njemačka";








            db.SaveChanges();
        }



    }
}
