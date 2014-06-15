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
    public partial class frmKupciDodaj : Form
    {
        public frmKupciDodaj()
        {
            InitializeComponent();
        }

        private void frmKupciDodaj_Load(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajKupca_Click(object sender, EventArgs e)
        {

            T33_DBEntities db = new T33_DBEntities();
            kupac kupac = new kupac();

            kupac.tip_kupca = Convert.ToInt32(txtTipKupca.Text);
            kupac.ime = txtTipKupca.Text;
            kupac.prezime = txtPrezime.Text;
            kupac.tvrtka = txtTvrtka.Text;
            kupac.adresa = txtAdresa.Text;
            kupac.email = txtEmail.Text;
            kupac.telefon = txtTelefon.Text;
            kupac.faks = txtFaks.Text;

            db.kupac.Add(kupac);
            MessageBox.Show(txtTipKupca.Text);
            try

            {

                db.SaveChanges();
                this.Close();


            }
            catch (DbEntityValidationException dbEx)
            {
                MessageBox.Show("Greška !");
                foreach (var validaitonErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validaitonErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error:{1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }

            }





        }

        

        
    }
}
