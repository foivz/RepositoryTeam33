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
    public partial class frmNalozi : Form
    {

        T33_DBEntities db = new T33_DBEntities();
        

        public frmNalozi()
        {
            InitializeComponent();
        }

        private void prikaziNaloge() {

            //var nalog = db.nalog_za_servis.ToList<nalog_za_servis>();
            
            BindingSource upit = new BindingSource();
            upit.DataSource = 
                        (from n in db.nalog_za_servis 
                         join  v in db.vozilo on n.vozilo equals v.id_vozilo
                         join m in db.model_vozila on v.model_vozila equals m.id_model_vozila
                         join k in db.korisnik on n.korisnik equals k.id_korisnik
                         where n.vozilo == v.id_vozilo
                         select new {
                            n.id_nalog_za_servis,
                            n.opis,
                            vozilo = m.naziv,
                            korisnik = k.korisnicko_ime,
                            n.obavljen,
                            n.datum,
                            n.cijena,
                            n.sati_rada
                         }).ToList();

            nalogzaservisBindingSource.DataSource = upit;
        }



        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nalozi_Load(object sender, EventArgs e)
        {
            prikaziNaloge();
        }
    }
}
