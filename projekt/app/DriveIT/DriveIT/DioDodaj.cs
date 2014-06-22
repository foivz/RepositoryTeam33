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
    public partial class DioDodaj : Form
    {
        int id_nalog;
        NaloziDetalji parent;

        /// <summary>
        /// Metoda za dodavanje dijela 
        /// </summary>
        /// <param name="id_nalog"></param>
        /// <param name="parent"></param>
        public DioDodaj(int id_nalog, NaloziDetalji parent)
        {
            InitializeComponent();
            this.id_nalog=id_nalog;
            this.parent = parent;
        }

        /// <summary>
        /// Metoda za dodavanje novog dijela,uzima korisničke unose i sprema ih u objekt koji spremamo u bazu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, EventArgs e)
        {
  
            T33_DBEntities db = new T33_DBEntities();
            dio noviDio = new dio();
            noviDio.kolicina=int.Parse(txtKolicina.Text);
            noviDio.nalog=this.id_nalog;
            noviDio.naziv=txtNaziv.Text;
            noviDio.opis = txtOpis.Text;;
            noviDio.cijena=int.Parse(txtCijena.Text);

            db.dio.Add(noviDio);
            db.SaveChanges();

            this.parent.dohvatiDjelove(this.id_nalog);
            this.parent.podaciONalogu();
            this.Close();

        }

        /// <summary>
        /// Metoda koja zatvara formu na odabir gumba odustani
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
