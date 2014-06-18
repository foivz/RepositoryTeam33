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
    public partial class frmVrsteVozilaDodaj : Form
    {
        public frmVrsteVozilaDodaj()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajModelVozila_Click(object sender, EventArgs e)
        {
            T33_DBEntities db = new T33_DBEntities();
            tip_vozila tip_vozilo = new tip_vozila();

            tip_vozilo.naziv = txtNaziv.Text;
            tip_vozilo.podtip = txtPodtip.Text;

            db.tip_vozila.Add(tip_vozilo);

            try
            {

                db.SaveChanges();
                MessageBox.Show("Vrsta vozila je uspješno dodana !");
                System.Threading.Thread.Sleep(700);

                this.Close();

            }
            catch
            {
                MessageBox.Show("Greška !");
            }
        }

        private void frmVrsteVozilaDodaj_Load(object sender, EventArgs e)
        {
           
        }
    }
}
