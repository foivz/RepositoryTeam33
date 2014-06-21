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
        T33_DBEntities db = new T33_DBEntities();

        private void PrikaziUgovore()
        {

            BindingSource upit = new BindingSource();
            upit.DataSource =
                        (from u in db.ugovor
                         join v in db.vozilo on u.vozilo equals v.id_vozilo
                         join m in db.model_vozila on v.model_vozila equals m.id_model_vozila
                         join k in db.kupac on  u.kupac equals k.id_kupac
                         join d in db.dobavljac on u.dobavljac_iddobavljac equals d.id_dobavljac
                         select new
                         {
                             u.id_ugovor,
                             kupac = k.ime +" "+ k.prezime,
                             vozilo = m.naziv ,
                             u.datum,
                             dobavljac_iddobavljac = d.tvrtka
                            
                         }).ToList();

            ugovorBindingSource.DataSource = upit;



            
           // var ugovori = db.ugovor.ToList<ugovor>();
            //ugovorBindingSource.DataSource = ugovori;
        }


        private void prikaziDetalje(string i)
        {

            frmUgovoriDetalji detalji_ugovora = new frmUgovoriDetalji();
            detalji_ugovora.getDetails(i);
            detalji_ugovora.ShowDialog();
        }



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
           string i = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
           prikaziDetalje(i);
        }
    }
}
