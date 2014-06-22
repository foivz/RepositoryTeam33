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

        public frmVrsteVozila()
        {
            InitializeComponent();
        }


        private void prikaziVrsteVozila() {
            T33_DBEntities db = new T33_DBEntities();
            var vrste_vozila = db.tip_vozila.ToList<tip_vozila>();
            tipvozilaBindingSource.DataSource = vrste_vozila;
        }


        private void prikaziDetalje(string i) {
            frmVrsteVozilaDetalji vrste_vozila_detalji = new frmVrsteVozilaDetalji();
            vrste_vozila_detalji.getDetails(i);
            vrste_vozila_detalji.ShowDialog();

        }

        private void frmVrsteVozila_Load(object sender, EventArgs e)
        {
            prikaziVrsteVozila();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string i = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            prikaziDetalje(i);
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            prikaziVrsteVozila();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            frmVrsteVozilaDodaj vrsta_vozila = new frmVrsteVozilaDodaj();
            vrsta_vozila.ShowDialog();
        }
    }
}
