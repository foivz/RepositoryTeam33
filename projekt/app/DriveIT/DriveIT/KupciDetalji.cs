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
    public partial class frmKupciDetalji : Form
    {
        public frmKupciDetalji()
        {
            InitializeComponent();
        }

        private void frmKupciDetalji_Load(object sender, EventArgs e)
        {

        }


        public void getDetails(string i)
        {

            T33_DBEntities db = new T33_DBEntities();
            int b = int.Parse(i);
            var kupac = db.kupac.Where<kupac>(x => x.id_kupac == b).First<kupac>();

            txtId.Text = Convert.ToString(kupac.id_kupac);
            txtTipKupca.Text = Convert.ToString(kupac.tip_kupca);
            txtIme.Text = kupac.ime;
            txtPrezime.Text = kupac.prezime;
            txtTvrtka.Text = kupac.tvrtka;
            txtTelefon.Text = kupac.telefon;
            txtAdresa.Text = kupac.adresa;
            txtFaks.Text = kupac.faks;
            txtEmail.Text = kupac.email;

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            T33_DBEntities db = new T33_DBEntities();
            int b = Convert.ToInt32(txtId.Text);
            var kupac = db.kupac.Where<kupac>(x => x.id_kupac == b).First<kupac>();

            db.kupac.Remove(kupac);
            db.SaveChanges();

            MessageBox.Show("Kupac uspješno obrisan");
            System.Threading.Thread.Sleep(700);
            this.Close();

        }

        private void btnAzurirajKupca_Click(object sender, EventArgs e)
        {

            T33_DBEntities db = new T33_DBEntities();

            int id = Convert.ToInt32(txtId.Text);

            kupac kupac = db.kupac.First(x=>x.id_kupac == id );

            kupac.tip_kupca = Convert.ToInt32(txtTipKupca.Text);
            kupac.ime = txtTipKupca.Text;
            kupac.prezime = txtPrezime.Text;
            kupac.tvrtka = txtTvrtka.Text;
            kupac.adresa = txtAdresa.Text;
            kupac.email = txtEmail.Text;
            kupac.telefon = txtTelefon.Text;
            kupac.faks = txtFaks.Text;

            db.SaveChanges();

            MessageBox.Show("Kupac je uspješno ažuriran");
            System.Threading.Thread.Sleep(700);

            this.Close();




        }
    }
}
