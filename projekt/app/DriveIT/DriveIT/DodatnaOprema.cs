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
    public partial class frmDodatnaOprema : Form
    {

        T33_DBEntities db = new T33_DBEntities();

        public frmDodatnaOprema()
        {
            InitializeComponent();
        }

        private void prikaziDodatnuOpremu()
        {
            

           BindingSource dodatna_oprema = new BindingSource();


           dodatna_oprema.DataSource = (from l in db.dodatna_oprema
                                        join d in db.dobavljac on l.dobavljac_iddobavljac equals d.id_dobavljac
                                        select new {
                                            l.id_dodatna_oprema,dobavljac_iddobavljac = d.tvrtka,l.naziv,l.model,l.boja,l.kolicina,l.cijena,l.raspoloživo 
                                        }).ToList();
           dodatnaopremaBindingSource.DataSource = dodatna_oprema;     

        }

        private void prikaziDetalje(string i)
        {
            frmDodatnaOpremaDetalji detalji_opreme = new frmDodatnaOpremaDetalji();
            detalji_opreme.getDetails(i);
            detalji_opreme.ShowDialog();
        }

        private void frmDodatnaOprema_Load(object sender, EventArgs e)
        {
            prikaziDodatnuOpremu();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string i = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            prikaziDetalje(i);
        }

        private void btnDodajDodatnuOpremu_Click(object sender, EventArgs e)
        {
            frmDodatnaOpremaDodaj dodaj_opremu = new frmDodatnaOpremaDodaj();
            dodaj_opremu.Show();
        }

        private void btnOsvjeziPrikaz_Click(object sender, EventArgs e)
        {
            prikaziDodatnuOpremu();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
