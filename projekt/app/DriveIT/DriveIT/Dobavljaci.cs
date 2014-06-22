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
       
        /// <summary>
        /// Metoda za popunjavanje datagrida s podacima dobavljača
        /// </summary>
        private void PrikaziDobavljace()
        {
            T33_DBEntities db = new T33_DBEntities();
            var dobavljaci = db.dobavljac.ToList<dobavljac>();
            dobavljacBindingSource.DataSource = dobavljaci;
           
        }

        /// <summary>
        /// Metoda koja poziva formu s detaljima dobavljača i šalje joj id trenutnog dobavljača
        /// </summary>
        /// <param name="i"></param>
        private void prikaziDetalje(string i)
        {

            frmDobavljaciDetalji detalji_dobavljac = new frmDobavljaciDetalji();
            detalji_dobavljac.getDetails(i);
            detalji_dobavljac.ShowDialog();
        }

        /*Konstruktor*/
        public frmDobavljaci()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda koja zatvara formu na odabir gumba za odustajanje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metoda koja sadrži poziv metode za popunjanje datagrida s dobavljačima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDobavljaci_Load(object sender, EventArgs e)
        {
            PrikaziDobavljace();
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metoda koja poziva formu za dodavanje novog dobavljača
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajDobavljaca_Click(object sender, EventArgs e)
        {
            /*otvaranje nove forme za dodavanje dobavljaca*/
            frmDobavljaciDodaj novi_dobavljac = new frmDobavljaciDodaj();
            novi_dobavljac.ShowDialog();

        }

       /// <summary>
       /// Metoda za osvježavanje liste dobavljača nakon dodavanja novog dobavljača
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            PrikaziDobavljace();
        }

        /// <summary>
        /// Metoda koja nakon klika na određeni element na listu dobavljača proslijeđuje metodi za prikaz detalja 
        /// koja poziva formu za prikaz detalja.
        /// Hvata korisnički id na početku retka kao string i proslijeđuje ga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string i = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            prikaziDetalje(i);
        }

        
       
    }
}
