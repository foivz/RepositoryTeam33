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
    public partial class frmDodajOpremuAutomobilu : Form
    {
        private static int identifikator;
        T33_DBEntities db = new T33_DBEntities();

        public frmDodajOpremuAutomobilu()
        {
            InitializeComponent();

            cbOprema.DataSource = db.dodatna_oprema.ToList();
            cbOprema.ValueMember = "id_dodatna_oprema";
            cbOprema.DisplayMember = "naziv";
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prikaziDetalje() {
            dataGridView1.DataSource = db.vozilo.Where(x => x.id_vozilo == identifikator).First().dodatna_oprema.ToList();
        }

        public void getId(int i){

            identifikator = i;

        }

        private void frmDodajOpremuAutomobilu_Load(object sender, EventArgs e)
        {
            prikaziDetalje();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            prikaziDetalje();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
           /* int odabrana_oprema ;
            bool prolazi = Int32.TryParse(cbOprema.SelectedValue.ToString(),out odabrana_oprema );

            //var vozilo_oprema = new dodatna_oprema();
            var vozilo_oprema = new dodatna_oprema();

            vozilo_oprema.vozilo.Add(new vozilo {dodatna_oprema = odabrana_oprema });
            //vozilo_oprema.vozilo.Add(new vozilo {id_vozilo = identifikator });


            db.vozilo.Add(vozilo_oprema);

            db.SaveChanges();


            //dataGridView1.DataSource = db.vozilo.Where(x => x.id_vozilo == identifikator)..First().dodatna_oprema.ToList();*/
        }


    }
}
