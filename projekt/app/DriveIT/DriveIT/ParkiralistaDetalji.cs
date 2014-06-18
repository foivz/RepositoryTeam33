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
    public partial class frmParkiralistaDetalji : Form
    {
        public frmParkiralistaDetalji()
        {
            InitializeComponent();
        }

        private void ParkiralistaDetalji_Load(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void getDetails(string i)
        {
            T33_DBEntities db = new T33_DBEntities();
            int b = int.Parse(i);

            var parkiraliste = db.parking.Where<parking>(x => x.id_parking == b).First<parking>();

            txtId.Text = Convert.ToString(parkiraliste.id_parking);
            txtNaziv.Text = parkiraliste.naziv;
            txtKapacitet.Text = Convert.ToString(parkiraliste.kapacitet);
            
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            T33_DBEntities db = new T33_DBEntities();

            int id = Convert.ToInt32(txtId.Text);

            parking parking = db.parking.First(i => i.id_parking == id);
            db.parking.Remove(parking);
            db.SaveChanges();


            MessageBox.Show("parking uspješno obrisan");
            System.Threading.Thread.Sleep(700);
            this.Close();
        }

        private void btnAzurirajParking_Click(object sender, EventArgs e)
        {

            T33_DBEntities db = new T33_DBEntities();

            int id = Convert.ToInt32(txtId.Text);
            parking parking = db.parking.First(i => i.id_parking == id);

            parking.naziv = txtNaziv.Text;
            parking.kapacitet = Convert.ToInt32(txtKapacitet.Text);
            
            
            db.SaveChanges();
            MessageBox.Show("Parking uspješno ažuriran");
            System.Threading.Thread.Sleep(700);
            this.Close();
        }






    }
}
