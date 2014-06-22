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

        /// <summary>
        /// Metoda za učitavanje dodatne opreme preko slabog entiteta,sadrži implementaciju upita M:N
        /// </summary>
        private void ucitajDodatnuOpremu() {

            BindingSource upit = new BindingSource();

            int id;
            bool park = Int32.TryParse(txtIdVozilo.Text, out id);
            dataGridView1.DataSource = db.vozilo.Where(x => x.id_vozilo == id).First().dodatna_oprema.ToList();


        }

        private void VozilaDetalji_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Metoda koja učitava detalje o pojedinom vozilu na temelju stringa koji primi odnosno id-a
        /// Radi upit koji vraća objekt koji odgovara odabarnom elementu te popunjava textboxove vrijednostima
        /// </summary>
        /// <param name="i"></param>
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


        /// <summary>
        /// Metoda koja poziva formu za prodaju vozila te poziva metodu pomoću koje toj formi proslijeđuje id vozila
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prodajBtn_Click(object sender, EventArgs e)
        {
            frmProdaja prodaja = new frmProdaja(idVozila);

            int id = Convert.ToInt32(txtIdVozilo.Text);

            prodaja.getId(id);
            prodaja.Show();
            
        }


        /// <summary>
        /// Metoda koja otvara formu za učitavanje slika, odnosno objekt preglednik slika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButton1_Click(object sender, EventArgs e)
        {

            PreglednikSlika.Ucitaj_sliku(txtIdVozilo.Text);
        }

        /// <summary>
        /// Metoda koja poziva metodu za dodavanje nove dodatne opreme za pojedini automobil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajOpremu_Click(object sender, EventArgs e)
        {
            frmDodajOpremuAutomobilu oprema = new frmDodajOpremuAutomobilu();
            oprema.getId(idVozila);
            oprema.Show();
        }


        /// <summary>
        /// Metoda koja pretražuje objekte u entity-u i traži onu s odgovrajućim id-em
        /// nakon toga briše objekt i sprema ga u bazu,odnosno briše ili javlja grešku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisiVozilo_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdVozilo.Text);

            vozilo vozilo = db.vozilo.Where<vozilo>(x => x.id_vozilo == id).First<vozilo>();
            db.vozilo.Remove(vozilo);
            db.SaveChanges();

            MessageBox.Show("Vozilo uspješno obrisano");
            System.Threading.Thread.Sleep(700);
            this.Close();
        }


        /// <summary>
        /// Metoda koja zatvara formu detalja o vozilu na odabir gumba odustani
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Metoda koja pretražuje objekte u entity frameworku te nalazi objekt s odgovarajućim id-em
        /// popunjava vrijednosti u objektu s vrijednostima iz textboxova 
        /// Nakon popunjavanja vrijednosti ih sprema u bazu ili javlja grešku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAzurirajVozilo_Click(object sender, EventArgs e)
        {
            //vozilo vozilo = db.vozilo.Where<vozilo>(x => x.id_vozilo == b).First<vozilo>();

            int id = Convert.ToInt32(txtIdVozilo.Text);

            vozilo vozilo = db.vozilo.First(i => i.id_vozilo == id);

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

        /// <summary>
        /// Metoda koja otvara formu za izradu novog naloga za popravak
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNalog_Click(object sender, EventArgs e)
        {
            frmNalogZaPopravak popravak = new frmNalogZaPopravak();
            popravak.fillForm(txtIdVozilo.Text);
            popravak.Show();
        }

    }
}
