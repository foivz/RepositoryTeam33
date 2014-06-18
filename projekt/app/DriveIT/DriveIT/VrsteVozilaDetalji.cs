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
    public partial class frmVrsteVozilaDetalji : Form
    {

        T33_DBEntities db = new T33_DBEntities();

        public frmVrsteVozilaDetalji()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void getDetails(string i)
        {

            int b = int.Parse(i);
            var vrsta_vozila = db.tip_vozila.Where<tip_vozila>(x => x.id_tip_vozila == b).First<tip_vozila>();

            txtId.Text = i;
            txtNaziv.Text = vrsta_vozila.naziv;
            txtPodtip.Text = vrsta_vozila.podtip;
        
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            tip_vozila vrsta_vozila = db.tip_vozila.First(i => i.id_tip_vozila == id);

            db.tip_vozila.Remove(vrsta_vozila);
            db.SaveChanges();


            MessageBox.Show("Vrsta vozila uspješno obrisana");
            System.Threading.Thread.Sleep(700);
            this.Close();

        }

        private void btnAzurirajjModelVozila_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            tip_vozila vrsta_vozila = db.tip_vozila.First(i => i.id_tip_vozila == id);

            vrsta_vozila.id_tip_vozila = id;
            vrsta_vozila.naziv = txtNaziv.Text;
            vrsta_vozila.podtip = txtPodtip.Text;

            db.SaveChanges();

            MessageBox.Show("Vrsta vozila uspješno ažurirana");
            System.Threading.Thread.Sleep(700);
            this.Close();

        }
        
    }
}
