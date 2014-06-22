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
    public partial class frmParkiralistaDodaj : Form
    {
        public frmParkiralistaDodaj()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajParkiraliste_Click(object sender, EventArgs e)
        {
            T33_DBEntities db = new T33_DBEntities();
            parking parkiraliste = new parking();

            parkiraliste.naziv = txtNaziv.Text;
            parkiraliste.kapacitet = Convert.ToInt32(txtKapacitet.Text);

            db.parking.Add(parkiraliste);

            try
            {

                db.SaveChanges();
                MessageBox.Show("Parkiralište je uspješno dodano !");
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
