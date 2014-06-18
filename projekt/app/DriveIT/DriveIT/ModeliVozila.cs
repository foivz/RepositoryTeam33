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
    public partial class frmModeliVozila : Form
    {

        private void prikaziModeleVozila() {
            T33_DBEntities db = new T33_DBEntities();
            var model_vozila = db.model_vozila.ToList<model_vozila>();
            modelvozilaBindingSource.DataSource = model_vozila;
        }


        public frmModeliVozila()
        {
            InitializeComponent();

        }

        private void frmModeli_Load(object sender, EventArgs e)
        {
            prikaziModeleVozila();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            prikaziModeleVozila();
        }

        private void btnDodajVrstuVozila_Click(object sender, EventArgs e)
        {
            frmModeliVozilaDodaj modeli_vozila = new frmModeliVozilaDodaj();
            modeli_vozila.Show();
        }
    }
}
