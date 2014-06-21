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
    public partial class frmDobavljaciDetalji : Form
    {
        public frmDobavljaciDetalji()
        {
            InitializeComponent();
        }

        private void frmDobavljaciDetalji_Load(object sender, EventArgs e)
        {

        }

        public void getDetails(string i)
        {

            T33_DBEntities db = new T33_DBEntities();
            int b = int.Parse(i);

            var dobavljac = db.dobavljac.Where<dobavljac>(x => x.id_dobavljac == b).First<dobavljac>();

            txtId.Text = Convert.ToString(dobavljac.id_dobavljac);
            txtIme.Text = dobavljac.ime;
            txtPrezime.Text = dobavljac.prezime;
            txtTvrtka.Text = dobavljac.tvrtka;
            txtAdresa.Text = dobavljac.adresa;
            txtTelefon.Text = dobavljac.telefon;
            txtFaks.Text = dobavljac.faks;
            txtEmail.Text = dobavljac.email;
        }


       private void btnDeleteDobavljac_Click(object sender, EventArgs e)
        {
            T33_DBEntities db = new T33_DBEntities();

            int id = Convert.ToInt32(txtId.Text);

            dobavljac dobavljac = db.dobavljac.First(i => i.id_dobavljac == id);
            db.dobavljac.Remove(dobavljac);
            db.SaveChanges();


            MessageBox.Show("Dobavljač uspješno obrisan");
            System.Threading.Thread.Sleep(700);
            this.Close();

        }
        

        private void btnAzurirajDobavljaca_Click(object sender, EventArgs e)
        {
            T33_DBEntities db = new T33_DBEntities();

            int id = Convert.ToInt32(txtId.Text);

            dobavljac dobavljac = db.dobavljac.First(i => i.id_dobavljac == id);

            dobavljac.ime = txtIme.Text;
            dobavljac.prezime = txtPrezime.Text;
            dobavljac.tvrtka = txtTvrtka.Text;
            dobavljac.adresa = txtAdresa.Text;
            dobavljac.email = txtEmail.Text;
            dobavljac.telefon = txtTelefon.Text;
            dobavljac.faks = txtFaks.Text;

            db.SaveChanges();

            MessageBox.Show("Dobavljaci su  uspješno ažurirani !");
            System.Threading.Thread.Sleep(700);
            this.Close();
        }

       

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }

       

        
    }
}