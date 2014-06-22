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
    public partial class frmNalogZaPopravak : Form
    {
        public frmNalogZaPopravak()
        {
            InitializeComponent();
            /*Korisnik combobox*/
            using (T33_DBEntities db = new T33_DBEntities())
            {
                cbKorisnik.DataSource = db.korisnik.ToList();
                cbKorisnik.ValueMember = "id_korisnik";
                cbKorisnik.DisplayMember = "korisnicko_ime";
            }


        }

        public void fillForm(string i){
            
            txtVozilo.Text = i; ;
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKreirajNalog_Click(object sender, EventArgs e)
        {

            T33_DBEntities db = new T33_DBEntities();
            nalog_za_servis nalogServis = new nalog_za_servis();

            nalogServis.vozilo = Convert.ToInt32(txtVozilo.Text);
            nalogServis.korisnik = Convert.ToInt32(cbKorisnik.SelectedValue);
            nalogServis.opis = txtOpis.Text;

            db.nalog_za_servis.Add(nalogServis);

            try
            {
                db.SaveChanges();

                MessageBox.Show("Nalog je uspješno kreiran ! ");
                System.Threading.Thread.Sleep(700);
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
