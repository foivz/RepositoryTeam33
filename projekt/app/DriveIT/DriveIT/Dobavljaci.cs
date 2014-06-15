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
        private void PrikaziDobavljace()
        {
            T33_DBEntities db = new T33_DBEntities();
            //BindingList<vozilo> listaVozila = null;
            //var vozila = db.vozilo.Where<vozilo>(x => x.id_vozilo == 2).First<vozilo>();
            //var vozila = db.vozilo.Where<vozilo>;
            var dobavljaci = db.dobavljac.ToList<dobavljac>();
            dobavljacBindingSource.DataSource = dobavljaci;
        }
        
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
    }
}
