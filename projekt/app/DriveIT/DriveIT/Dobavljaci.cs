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
    public partial class frmDobavljaci : Form
    {
        private void filter()
        {
            
            T33_DBEntities db = new T33_DBEntities();
            var dobavljaci = db.dobavljac.ToList<dobavljac>();
            dobavljacBindingSource.DataSource = dobavljaci;

            BindingSource bs = new BindingSource();
            bs.DataSource = dobavljaci;
            dataGridView1.DataSource = bs;

            bs.Filter = string.Format("ime LIKE '%{0}%'",txtPretragaDobavljaci.Text );
        }

        private void PrikaziDobavljace()
        {
            T33_DBEntities db = new T33_DBEntities();
            var dobavljaci = db.dobavljac.ToList<dobavljac>();
            dobavljacBindingSource.DataSource = dobavljaci;
           
        }


        private void prikaziDetalje(string i)
        {

            frmDobavljaciDetalji detalji_dobavljac = new frmDobavljaciDetalji();
            detalji_dobavljac.getDetails(i);
            detalji_dobavljac.ShowDialog();
        }

        /*Konstruktor*/
        public frmDobavljaci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDobavljaci_Load(object sender, EventArgs e)
        {
            PrikaziDobavljace();
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajDobavljaca_Click(object sender, EventArgs e)
        {
            /*otvaranje nove forme za dodavanje dobavljaca*/
            frmDobavljaciDodaj novi_dobavljac = new frmDobavljaciDodaj();
            novi_dobavljac.ShowDialog();

        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            PrikaziDobavljace();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string i = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            prikaziDetalje(i);
        }

        private void txtPretragaDobavljaci_TextChanged(object sender, EventArgs e)
        {

            filter();
            PrikaziDobavljace();
            MessageBox.Show("radi");



        }

       
    }
}
