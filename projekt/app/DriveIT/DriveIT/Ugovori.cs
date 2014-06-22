﻿using DriveIT.Database;
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


        /// <summary>
        /// Metoda koja sadrži upit i prikazuje sve ugovore s detaljima
        /// </summary>
        private void PrikaziUgovore()
        {

            BindingSource upit = new BindingSource();
            upit.DataSource =
                        (from u in db.ugovor
                         join d in db.dobavljac on u.dobavljac_iddobavljac equals d.id_dobavljac
                         join v in db.vozilo on u.vozilo equals v.id_vozilo      
                         join m in db.model_vozila on v.model_vozila equals m.id_model_vozila
                         join a in db.marka_vozila on m.id_model_vozila equals a.id_marka_vozila
                         join k in db.kupac on u.kupac equals k.id_kupac
                         select new
                         {
                             u.id_ugovor,
                             kupac = k.ime + " " + k.prezime,
                             vozilo = a.naziv+ " " + m.naziv, 
                             u.datum,
                            dobavljac_iddobavljac = d.tvrtka,
                         }).ToList();

            ugovorBindingSource.DataSource = upit;
        }


        /// <summary>
        /// Metoda koja otvara detalje pojedinog ugovora i zove metode koje proslijeđuju id formi dijetetu
        /// </summary>
        /// <param name="i"></param>
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

        /// <summary>
        /// Metoda za zatvaranje forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Metoda koja pri učitavanju forme poziva metodu za prikaz ugovora 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUgovori_Load(object sender, EventArgs e)
        {
            PrikaziUgovore();

        }

        /// <summary>
        /// Metoda koja na odabir gumba za dodavanje ugovora otvara formu za dodavanje ugovora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajUgovor_Click(object sender, EventArgs e)
        {
            frmUgovoriDodaj novi_ugovor = new frmUgovoriDodaj();
            novi_ugovor.ShowDialog();
        }

        /// <summary>
        /// Metoda koja osvježava prikaz ugovora u datagridu pozivajući metodu za prikaz ugovora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            PrikaziUgovore();
        }

        /// <summary>
        /// Metoda koja na klik na neku od ćelija datagrida šalje metodi za prikaz detalja id trenutno odabranog retka kao string
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
