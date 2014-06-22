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
        T33_DBEntities db = new T33_DBEntities();

        public frmModeliVozila()
        {
            InitializeComponent();

        }

        private void prikaziModeleVozila() {

            BindingSource modeliVozila = new BindingSource();

            modeliVozila.DataSource = (from m in db.model_vozila
                                       join mv in db.marka_vozila on m.marka_vozila equals mv.id_marka_vozila
                                       select new {m.id_model_vozila,m.naziv,marka_vozila = mv.naziv }).ToList();

            modelvozilaBindingSource.DataSource = modeliVozila;

        }

        private void prikaziDetalje(string i) {
            frmModeliVozilaDetalji detaljiModela = new frmModeliVozilaDetalji();
            detaljiModela.getDetails(i);
            detaljiModela.ShowDialog();
        }

        private void frmModeli_Load(object sender, EventArgs e)
        {
            prikaziModeleVozila();
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
            prikaziModeleVozila();
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            frmModeliVozilaDodaj modeli_vozila = new frmModeliVozilaDodaj();
            modeli_vozila.Show();
        }
    }
}
