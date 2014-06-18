using DriveIT.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriveIT
{
    public partial class frmMarkeVozilaDodaj : Form
    {
        public frmMarkeVozilaDodaj()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajParking_Click(object sender, EventArgs e)
        {
            T33_DBEntities db = new T33_DBEntities();
            marka_vozila marka = new marka_vozila();

            marka.naziv = txtNaziv.Text;
            marka.drzava = txtDrzava.Text;
          

            db.marka_vozila.Add(marka);

            try
            {

                db.SaveChanges();
                MessageBox.Show("Marka vozila je uspješno dodana!");
                System.Threading.Thread.Sleep(700);


                this.Close();


            }
            catch 
            {
                MessageBox.Show("Greška !");

            }
        }
    }
}
