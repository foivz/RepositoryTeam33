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
    public partial class frmVrsteVozila : Form
    {
        private void prikaziVrsteVozila() {
            T33_DBEntities db = new T33_DBEntities();
            var vrste_vozila = db.tip_vozila.ToList<tip_vozila>();
            tipvozilaBindingSource.DataSource = vrste_vozila;
        }


        public frmVrsteVozila()
        {
            InitializeComponent();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            prikaziVrsteVozila();
        }

        private void frmVrsteVozila_Load(object sender, EventArgs e)
        {
            prikaziVrsteVozila();
        }

        private void btnDodajVrstuVozila_Click(object sender, EventArgs e)
        {
            frmVrsteVozilaDodaj vrsta_vozila = new frmVrsteVozilaDodaj();
            vrsta_vozila.ShowDialog();
        }
    }
}
