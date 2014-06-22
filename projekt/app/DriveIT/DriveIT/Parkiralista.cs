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
    public partial class frmParkiralista : Form
    {


        private void prikaziParkiralista() {
            T33_DBEntities db = new T33_DBEntities();
            var parkiralista = db.parking.ToList<parking>();
            parkingBindingSource.DataSource = parkiralista;
        }


        private void prikaziDetalje(string i)
        {
            frmParkiralistaDetalji detalji_parkiralista = new frmParkiralistaDetalji();
            detalji_parkiralista.getDetails(i);
            detalji_parkiralista.ShowDialog();
        }


        public frmParkiralista()
        {
            InitializeComponent();
        }

        private void frmParkiralista_Load(object sender, EventArgs e)
        {
            prikaziParkiralista();
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
            prikaziParkiralista();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            frmParkiralistaDodaj parkiraliste_dodaj = new frmParkiralistaDodaj();
            parkiraliste_dodaj.Show();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmParkiralistaDodaj parkiraliste_dodaj = new frmParkiralistaDodaj();
            parkiraliste_dodaj.Show();
        }
    }
}
