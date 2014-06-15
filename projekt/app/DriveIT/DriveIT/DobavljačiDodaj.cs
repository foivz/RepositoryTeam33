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
    public partial class frmDobavljaciDodaj : Form
    {
        public frmDobavljaciDodaj()
        {
            InitializeComponent();
        }

        private void DobavljačiDodaj_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajDobavljac_Click(object sender, EventArgs e)
        {

            T33_DBEntities db = new T33_DBEntities();
            dobavljac dobavljac = new dobavljac();

            dobavljac.ime = txtIme.Text;
            dobavljac.prezime = txtPrezime.Text;
            dobavljac.tvrtka = txtTvrtka.Text;
            dobavljac.adresa = txtAdresa.Text;
            dobavljac.email = txtEmail.Text;
            dobavljac.telefon = txtTelefon.Text;
            dobavljac.faks = txtFaks.Text;

            db.dobavljac.Add(dobavljac);
            MessageBox.Show(txtIme.Text);
            try {
 
            db.SaveChanges();
            this.Close();
            
            
            }
            catch(DbEntityValidationException dbEx){
                MessageBox.Show("Greška !");
                foreach (var validaitonErrors in dbEx.EntityValidationErrors) {
                    foreach (var validationError in validaitonErrors.ValidationErrors) {
                        Trace.TraceInformation("Property: {0} Error:{1}",validationError.PropertyName,validationError.ErrorMessage);
                    }
                }
            
            }

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
  
    }
}
