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
    public partial class frmVozila : Form
    {

        private void PrikaziVozila()
        {
            T33_DBEntities db = new T33_DBEntities();
            //BindingList<vozilo> listaVozila = null;
            //var vozila = db.vozilo.Where<vozilo>(x => x.id_vozilo == 2).First<vozilo>();
            //var vozila = db.vozilo.Where<vozilo>;
            var vozila = db.vozilo.ToList<vozilo>();
            voziloBindingSource.DataSource = vozila;

        }

        private void prikaziDetalje(string i) {

            frmVozilaDetalji detalji_vozila = new frmVozilaDetalji();
            detalji_vozila.getDetails(i);
            detalji_vozila.ShowDialog();
        }

       
        public frmVozila()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string i = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            prikaziDetalje(i);


        }

        private void frmVozila_Load(object sender, EventArgs e)
        {
            PrikaziVozila();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVozila_Load_1(object sender, EventArgs e)
        {
            PrikaziVozila();
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            frmVozilaDodaj novo_vozilo = new frmVozilaDodaj();
            novo_vozilo.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PrikaziVozila();
        }

        
        



    }
}
