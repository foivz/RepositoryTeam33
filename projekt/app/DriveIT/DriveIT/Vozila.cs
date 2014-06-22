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
        T33_DBEntities db = new T33_DBEntities();

        public frmVozila()
        {
            InitializeComponent();
        }

       
        private void PrikaziVozila()
        {
            
            //BindingList<vozilo> listaVozila = null;
            //var vozila = db.vozilo.Where<vozilo>(x => x.id_vozilo == 2).First<vozilo>();
            //var vozila = db.vozilo.Where<vozilo>;


            BindingSource upit = new BindingSource();
            upit.DataSource =
                        (from v in db.vozilo
                         join p in db.parking on v.parking equals p.id_parking
                         join t in db.tip_vozila on v.tip_vozila equals t.id_tip_vozila
                         join m in db.model_vozila on v.model_vozila equals m.id_model_vozila
                         join r in db.marka_vozila on m.marka_vozila equals r.id_marka_vozila
                         select new
                         {
                             v.id_vozilo,
                             v.sasija,
                             v.datum_prve_registracije,
                             v.boja,
                             v.godina_proizvodnje,
                             v.sjedista,
                             v.nosivost,
                             v.snaga_kw,
                             v.datum_nabavke,
                             v.registracija,
                             v.prometna,
                             v.servisna,
                             v.kilometri,
                             tip_vozila = t.naziv,
                             model_vozila = r.naziv + " " + m.naziv,
                             parking = p.naziv,
                             v.zadnje_paljenje
                         }).ToList();
            voziloBindingSource.DataSource = upit;

            //var vozila = db.vozilo.ToList<vozilo>();
            voziloBindingSource.DataSource = upit;

        }

        private void prikaziDetalje(string i) {

            frmVozilaDetalji detalji_vozila = new frmVozilaDetalji();
            detalji_vozila.getDetails(i);
            detalji_vozila.ShowDialog();
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
