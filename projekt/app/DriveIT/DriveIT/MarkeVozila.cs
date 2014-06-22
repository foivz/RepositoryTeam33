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

        private void prikaziDetalje(string i)
        {
            frmMarkeVozilaDetalji marka_detalji = new frmMarkeVozilaDetalji();
            marka_detalji.getDetails(i);
            marka_detalji.ShowDialog();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string i = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            prikaziDetalje(i);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmMarkeVozilaDodaj marke_vozila = new frmMarkeVozilaDodaj();
            marke_vozila.Show();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            prikaziMarkeVozila();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
