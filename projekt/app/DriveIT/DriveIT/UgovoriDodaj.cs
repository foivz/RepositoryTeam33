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
    public partial class frmUgovoriDodaj : Form
    {
        public frmUgovoriDodaj()
        {
            InitializeComponent();
        }

        private void btnDodajDobavljac_Click(object sender, EventArgs e)
        {
            T33_DBEntities db = new T33_DBEntities();
            ugovor ugovor = new ugovor();
            

            ugovor.kupac = Convert.ToInt32(txtKupac.Text);
            ugovor.vozilo = Convert.ToInt32(txtVozilo.Text);
            ugovor.datum = dtPickerDatum.Value;
            ugovor.dobavljac_iddobavljac = Convert.ToInt32(txtDobavljac.Text);

            db.ugovor.Add(ugovor);            

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

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
