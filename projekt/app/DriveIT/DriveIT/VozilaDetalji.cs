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
    public partial class frmVozilaDetalji : Form
    {
        private int idVozila;
        T33_DBEntities db = new T33_DBEntities();

        


        public frmVozilaDetalji()
        {
            InitializeComponent();
            

        }

        private void ucitajDodatnuOpremu() {

            BindingSource upit = new BindingSource();


            int id;
            bool park = Int32.TryParse(txtIdVozilo.Text, out id);
    
            //upit.DataSource = db.dodatna_oprema.Where(x=> x.id_dodatna_oprema == id ).First().vozilo.ToList();

            //upit.DataSource = db.vozilo.Where(x => x.id_vozilo == id).First().dodatna_oprema.ToList();

            dataGridView1.DataSource = db.vozilo.Where(x => x.id_vozilo == id).First().dodatna_oprema.ToList();


           /* upit.DataSource =
                    (from t3 in db.dodatna_oprema
                    from t2 in t3.vozilo.Where(x => x.id_vozilo == id )
                    select{t3.naziv 
                        }).ToList();
                        
            
            
            (from o in db.dodatna_oprema
                         where o.vozilo.Any(x => x.id_vozilo == id )
                         select new
                         {
                             o.naziv,
                             o.cijena,
                         }).ToList();
            
            dodatnaopremaBindingSource.DataSource = upit;
            */
                
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            int id = Convert.ToInt32(txtIdVozilo.Text);

            vozilo vozilo = db.vozilo.Where<vozilo>(x => x.id_vozilo == id ).First<vozilo>();
            db.vozilo.Remove(vozilo);
            db.SaveChanges();

            MessageBox.Show("Vozilo uspješno obrisano");
            System.Threading.Thread.Sleep(700);
            this.Close();

        }

        private void VozilaDetalji_Load(object sender, EventArgs e)
        {
            
        }

        public void getDetails(string i){
            
            
            int b = int.Parse(i);
            this.idVozila = b;

            var vozila = db.vozilo.Where<vozilo>(x => x.id_vozilo == b).First<vozilo>();

            txtIdVozilo.Text = i;
            txtBoja.Text = vozila.boja;
            txtBrSasije.Text = vozila.sasija;
            txtGodinaProizvodnje.Text = Convert.ToString(vozila.godina_proizvodnje);
            dtPickerPrvaRegistracija.Value = (DateTime)vozila.datum_prve_registracije;
            dtPickerNabavka.Value = (DateTime) vozila.datum_nabavke;

            txtIdVozilo.Text = Convert.ToString(vozila.id_vozilo);
            txtRegistracija.Text = vozila.registracija; 
            txtPrometna.Text = vozila.prometna;
            txtServisna.Text = vozila.servisna;
            txtSnaga.Text = Convert.ToString(vozila.snaga_kw);
            txtNosivost.Text = Convert.ToString(vozila.nosivost);
            txtSjedista.Text =  Convert.ToString(vozila.sjedista);
            txtKilometraza.Text = Convert.ToString(vozila.kilometri);

            ucitajDodatnuOpremu();

        }

        private void btnAzurirajVozilo_Click(object sender, EventArgs e)
        {
            //vozilo vozilo = db.vozilo.Where<vozilo>(x => x.id_vozilo == b).First<vozilo>();

            int id = Convert.ToInt32(txtIdVozilo.Text);

            vozilo vozilo = db.vozilo.First(i => i.id_vozilo == id );

            vozilo.sasija = txtBrSasije.Text;
            vozilo.datum_prve_registracije = dtPickerPrvaRegistracija.Value;
            vozilo.boja = txtBoja.Text;
            vozilo.godina_proizvodnje = Convert.ToInt32(txtGodinaProizvodnje.Text);
            vozilo.datum_nabavke = dtPickerNabavka.Value;
            vozilo.snaga_kw = Convert.ToInt32(txtSnaga.Text);
            vozilo.sjedista = Convert.ToInt32(txtSjedista.Text);
            vozilo.nosivost = Convert.ToInt32(txtNosivost.Text);
            vozilo.registracija = txtRegistracija.Text;
            vozilo.prometna = txtPrometna.Text;
            vozilo.servisna = txtServisna.Text;
            vozilo.kilometri = Convert.ToInt32(txtKilometraza.Text);


            db.SaveChanges();
            MessageBox.Show("Vozilo uspješno ažurirano !");


            System.Threading.Thread.Sleep(700);

            this.Close();

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNalog_Click(object sender, EventArgs e)
        {
            frmNalogZaPopravak popravak = new frmNalogZaPopravak();
            popravak.fillForm(txtIdVozilo.Text);
            popravak.Show();
        }

        private void prodajBtn_Click(object sender, EventArgs e)
        {
            frmProdaja prodaja = new frmProdaja(idVozila);
            prodaja.Show();
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            PreglednikSlika.Ucitaj_sliku(txtIdVozilo.Text);
        }

    }
}
