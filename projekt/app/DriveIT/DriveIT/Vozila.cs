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
        /// <summary>
        /// Varijabla kojom se povezujemo s entity frameworkom
        /// </summary>
        T33_DBEntities db = new T33_DBEntities();

        /// <summary>
        /// Konstruktor klase
        /// </summary>
        public frmVozila()
        {
            InitializeComponent();
        }

       /// <summary>
       /// Metoda koja popunjava datagrid s vozilima iz liste vozila u entity frameworku
       /// </summary>
        private void PrikaziVozila()
        {
            var vozila = db.vozilo.ToList<vozilo>();
            voziloBindingSource.DataSource = vozila;

        }

        /// <summary>
        /// Metoda koja na poziv otvara novu formu s prikazom detalja vozila 
        /// </summary>
        /// <param name="i"></param>
        private void prikaziDetalje(string i) {

            frmVozilaDetalji detalji_vozila = new frmVozilaDetalji();
            detalji_vozila.getDetails(i);
            detalji_vozila.ShowDialog();
        }

       
        /// <summary>
        /// Metoda koja na klik na određeni element datagrida sprema i šalje id odabranog retka 
        /// metodi prikazi detalje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string i = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            prikaziDetalje(i);


        }

        /// <summary>
        /// Metoda koja na učitavanju forme piziva metodu za prikaz vozila
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVozila_Load(object sender, EventArgs e)
        {
            PrikaziVozila();
        }

        /// <summary>
        /// Metoda koja na odabir gumba za izlaz zatvara formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metoda koja na učitavanju forme poziva metodu za priakz vozila
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVozila_Load_1(object sender, EventArgs e)
        {
            PrikaziVozila();
        }

        /// <summary>
        /// Metoda koja na odabir gumba za dodavanje vozila otvara formu za dodavanje novog vozila
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            frmVozilaDodaj novo_vozilo = new frmVozilaDodaj();
            novo_vozilo.ShowDialog();
        }

        /// <summary>
        /// Metoda koja na odabir gumba za osvježavanje poziva metodu za prikaz vozila
        /// Potrebna je zbog dodavanja novog vozila jer se lista vozila ne ažurira automatski
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnoOsvjezi_Click(object sender, EventArgs e)
        {
            PrikaziVozila();
        }

        
        



    }
}
