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
using DriveIT.Controler;

namespace DriveIT
{
    public partial class frmProdaja : Form
    {

        T33_DBEntities db = new T33_DBEntities();
        static int identifikator;
        int marza = 24;
        public frmProdaja(int id)
        {
            InitializeComponent();
            loadData(id);

             using (T33_DBEntities db = new T33_DBEntities())
            {
                metroComboBox1.DataSource = db.kupac.ToList();
                metroComboBox1.ValueMember = "id_kupac";
                metroComboBox1.DisplayMember = "email";
            }
        }


        /// <summary>
        /// Metoda koja poziva metodu iz kontrolera za konačni izračun cijene vozila na temelju parametara
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProdaja_Load(object sender, EventArgs e)
        {
            /*Prijedlog cijene vozila*/
            vozilo vozilo = db.vozilo.First(i => i.id_vozilo == identifikator);
            KonacnaCijena cijena = new KonacnaCijena();

            vozilo = cijena.Izracun(vozilo);
            option3txt.Text = Convert.ToString(vozilo.cijena.prodajna_sa_pdv);
            
        }

        /// <summary>
        /// Metoda za učitavanje podataka o cijeni vozila
        /// </summary>
        /// <param name="id"></param>
        private void loadData(int id)
        {

            var vozila = db.vozilo.Where<vozilo>(x => x.id_vozilo == id).First<vozilo>();


            KonacnaCijena cijena = new KonacnaCijena();


            vozila = cijena.Izracun(vozila);

            DateTime datumNabave = (DateTime)vozila.datum_nabavke;

            int starostDani = (DateTime.Today - datumNabave).Days;


            option1txt.Text = datumNabave.ToLongDateString();

            option2txt.Text = starostDani + " dan/a";

            if (cijena == null)
                option3txt.Text = "Nabavna cijena nije unesena";
            else
                option3txt.Text = vozila.cijena.prodajna_sa_pdv.ToString();


        }
        
        /// <summary>
        /// Metoda za zatvaranje forme Prodaje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metoda koja nam služi kao getter i u property klase spremamo id vozila koje se prodaje
        /// </summary>
        /// <param name="id"></param>
        public void getId(int id) {
            identifikator = id;
        }


        /// <summary>
        /// Metoda koja se pokreće na odabit gumba za prodaju vozila
        /// Spremamo unesene vrijednosti u objekt i generiramo pdf 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButton1_Click(object sender, EventArgs e)
        {
            vozilo vozilo = db.vozilo.First(i => i.id_vozilo == identifikator);
           
            vozilo.parking = 5;
            decimal vrijednost;
            decimal.TryParse(option3txt.Text, out vrijednost);
            vozilo.cijena.prodajna_sa_pdv = vrijednost;

            int id_kupca;
            Int32.TryParse(metroComboBox1.SelectedValue.ToString(), out id_kupca);
            kupac kupac = db.kupac.First(i => i.id_kupac == id_kupca);
            ugovor prodajni = new ugovor();
            prodajni.datum = DateTime.Now;
            prodajni.vozilo = vozilo.id_vozilo;
            prodajni.kupac = kupac.id_kupac;
            db.ugovor.Add(prodajni);
            db.SaveChanges();
            PdfUgovor.KupoprodajniUgovor(vozilo, kupac, prodajni);
            PdfUgovor.KreirajPredracun(vozilo, kupac);

            db.SaveChanges();
            MessageBox.Show("Vozilo uspješno prodano i generanirani kupo-prodajni ugovor i račun na standardnoj lokaciji !");

            System.Threading.Thread.Sleep(700);

            this.Close();
        }
    }
}

