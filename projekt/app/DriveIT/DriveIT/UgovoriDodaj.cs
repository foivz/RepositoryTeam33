using DriveIT.Controler;
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
            T33_DBEntities db = new T33_DBEntities();
            /*Kupac combobox*/
            
                cbKupac.DataSource = db.kupac.ToList();
                cbKupac.ValueMember = "id_kupac";
                cbKupac.DisplayMember = string.Concat("ime","prezime");

            /*Vozilo combobox*/
           
                cbVozilo.DataSource = db.vozilo.ToList();
                cbVozilo.ValueMember = "id_vozilo";
                cbVozilo.DisplayMember = "sasija";


            /*Dobavljac combobox*/

                cbDobavljac.DataSource = db.dobavljac.ToList();
                cbDobavljac.ValueMember = "id_dobavljac";
                cbDobavljac.DisplayMember = "tvrtka";


        }

        
        private void frmUgovoriDodaj_Load(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNapraviKupoprodajni_Click(object sender, EventArgs e)
        {
            T33_DBEntities db = new T33_DBEntities();
            ugovor ugovor = new ugovor();


            ugovor.kupac = Convert.ToInt32(cbKupac.SelectedValue);
            ugovor.vozilo = Convert.ToInt32(cbVozilo.SelectedValue);
            ugovor.datum = dtPickerDatum.Value;
            ugovor.dobavljac_iddobavljac = Convert.ToInt32(cbDobavljac.SelectedValue);

            db.ugovor.Add(ugovor);



            try
            {
                var vozilo1 = db.vozilo.Where<vozilo>(x => x.id_vozilo == ugovor.vozilo).First<vozilo>();
                var kupac1 = db.kupac.Where<kupac>(x => x.id_kupac == ugovor.kupac).First<kupac>();

                PdfUgovor.KupoprodajniUgovor(vozilo1, kupac1, ugovor);

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
