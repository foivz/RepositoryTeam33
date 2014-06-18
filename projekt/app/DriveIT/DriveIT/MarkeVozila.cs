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
    public partial class frmMarkeVozila : Form
    {
        public frmMarkeVozila()
        {
            InitializeComponent();
        }

        private void prikaziMarkeVozila()
        {
            T33_DBEntities db = new T33_DBEntities();
            var marka_vozila = db.marka_vozila.ToList<marka_vozila>();
            markavozilaBindingSource.DataSource = marka_vozila;
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            prikaziMarkeVozila();
        }

        private void frmMarkeVozila_Load(object sender, EventArgs e)
        {
            prikaziMarkeVozila();
        }

        private void btnDodajVrstuVozila_Click(object sender, EventArgs e)
        {
            frmMarkeVozilaDodaj marke_vozila = new frmMarkeVozilaDodaj();
            marke_vozila.Show();
        }
    }
}
