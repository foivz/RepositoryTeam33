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
    public partial class frmKupci : Form
    {


        private void prikaziKupce() {

            T33_DBEntities db = new T33_DBEntities();
            var kupci = db.kupac.ToList<kupac>();
            kupacBindingSource.DataSource = kupci;
        }


        private void prikaziDetalje(string i)
        {
            frmKupciDetalji detalji_kupca = new frmKupciDetalji();
            detalji_kupca.getDetails(i);
            detalji_kupca.ShowDialog();
        }



        public frmKupci()
        {
            InitializeComponent();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnDodajNovogKupca_Click(object sender, EventArgs e)
        {
            frmKupciDodaj novi_kupac = new frmKupciDodaj();
            novi_kupac.ShowDialog();
        }

        private void frmKupci_Load_1(object sender, EventArgs e)
        {
            prikaziKupce();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            prikaziKupce();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string i = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            prikaziDetalje(i);
        }
        

    }
}
