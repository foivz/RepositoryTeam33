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
    public partial class frmMarkeVozilaDetalji : Form
    {
        T33_DBEntities db = new T33_DBEntities();

        public frmMarkeVozilaDetalji()
        {
            InitializeComponent();
        }

        public void getDetails(string i)
        {
            int b = int.Parse(i);

            var marka = db.marka_vozila.Where<marka_vozila>(x => x.id_marka_vozila == b).First<marka_vozila>();

            txtId.Text = Convert.ToString(marka.id_marka_vozila);
            txtNaziv.Text = marka.naziv;
            txtDrzava.Text = marka.drzava;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObriši_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txtId.Text);

            marka_vozila marka = db.marka_vozila.First(i => i.id_marka_vozila == id);
            db.marka_vozila.Remove(marka);
            db.SaveChanges();


            MessageBox.Show("Marka vozila uspješno obrisan");
            System.Threading.Thread.Sleep(700);
            this.Close();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            var marka = db.marka_vozila.Where<marka_vozila>(x => x.id_marka_vozila == id).First<marka_vozila>();

            marka.naziv = txtNaziv.Text;
            marka.drzava = txtDrzava.Text;

            db.SaveChanges();

            MessageBox.Show("Marke vozila su  uspješno ažurirane !");
            System.Threading.Thread.Sleep(700);
            this.Close();

        }


    }
}
