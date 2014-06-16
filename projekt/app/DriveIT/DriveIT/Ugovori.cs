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
    public partial class frmUgovori : Form
    {
        private void PrikaziUgovore()
        {
            T33_DBEntities db = new T33_DBEntities();
            var ugovori = db.ugovor.ToList<ugovor>();
            ugovorBindingSource.DataSource = ugovori;
        }


        /*private void prikaziDetalje(string i)
        {

            frmVozilaDetalji detalji_vozila = new frmVozilaDetalji();
            detalji_vozila.getDetails(i);
            detalji_vozila.ShowDialog();
        }*/



        /*Konstruktor*/
        public frmUgovori()
        {
            InitializeComponent();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }


 
        private void frmUgovori_Load(object sender, EventArgs e)
        {
            PrikaziUgovore();

        }

        private void btnDodajUgovor_Click(object sender, EventArgs e)
        {
            frmUgovoriDodaj novi_ugovor = new frmUgovoriDodaj();
            novi_ugovor.ShowDialog();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            PrikaziUgovore();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* string i = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            prikaziDetalje(i);*/
        }
    }
}
