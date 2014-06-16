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
    public partial class frmUgovoriDetalji : Form
    {
        public frmUgovoriDetalji()
        {
            InitializeComponent();
        }

        private void frmUgovoriDetalji_Load(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void getDetails(string i)
        {

            T33_DBEntities db = new T33_DBEntities();
            int b = int.Parse(i);

            var ugovor = db.ugovor.Where<ugovor>(x => x.id_ugovor == b).First<ugovor>();

            txtId.Text = i;
            txtKupac.Text = Convert.ToString(ugovor.kupac);
            txtVozilo.Text = Convert.ToString(ugovor.vozilo);

            dtPickerDatum.Value = (DateTime)ugovor.datum;
            txtDobavljac.Text = Convert.ToString(ugovor.dobavljac);

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

            T33_DBEntities db = new T33_DBEntities();
            int b = Convert.ToInt32(txtId.Text);
            var ugovor = db.ugovor.Where<ugovor>(x => x.id_ugovor == b).First<ugovor>();

            db.ugovor.Remove(ugovor);
            db.SaveChanges();

            MessageBox.Show("Ugovor uspješno obrisan");
            System.Threading.Thread.Sleep(700);
            this.Close();


        }

        private void btnAzurirajUgovor_Click(object sender, EventArgs e)
        {
            T33_DBEntities db = new T33_DBEntities();
            int b = Convert.ToInt32(txtId.Text);
            var ugovor = db.ugovor.Where<ugovor>(x => x.id_ugovor == b).First<ugovor>();


            ugovor.kupac = Convert.ToInt32(txtKupac.Text);
            ugovor.vozilo = Convert.ToInt32(txtVozilo.Text);
            ugovor.datum = (DateTime) dtPickerDatum.Value;
            ugovor.dobavljac_iddobavljac = Convert.ToInt32(txtDobavljac.Text);

            db.SaveChanges();

            MessageBox.Show("Ugovor uspješno ažuriran");
            System.Threading.Thread.Sleep(700);
            this.Close();
        }



    }
}
