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
    public partial class frmVozilaDodaj : Form
    {
        public frmVozilaDodaj()
        {
            InitializeComponent();

            /*Tip vozila combobox*/
            using (T33_DBEntities db = new T33_DBEntities())
            {
                txtTipVozila.DataSource = db.tip_vozila.ToList();
                txtTipVozila.ValueMember = "id_tip_vozila";
                txtTipVozila.DisplayMember = "naziv";
                
            }

            /*Model vozila combobox*/
            using (T33_DBEntities db = new T33_DBEntities())
            {
                txtModel.DataSource = db.model_vozila.ToList();
                txtModel.ValueMember = "id_model_vozila";
                txtModel.DisplayMember = "naziv";
            }


            /*Parking combobox*/
            using (T33_DBEntities db = new T33_DBEntities())
            {
                txtParking.DataSource = db.parking.ToList();
                txtParking.ValueMember = "id_parking";
                txtParking.DisplayMember = "naziv";
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajDobavljac_Click(object sender, EventArgs e)
        {
            T33_DBEntities db = new T33_DBEntities();
            vozilo vozilo = new vozilo();

            vozilo.sasija = txtBrSasije.Text;
            vozilo.datum_prve_registracije = dtPickerPrvaRegistracija.Value;
            vozilo.boja = txtBoja.Text;
            vozilo.godina_proizvodnje = Convert.ToInt32(txtGodinaProizvodnje.Text);
            vozilo.datum_nabavke = dtPickerNabavka.Value;
            vozilo.snaga_kw = Convert.ToInt32(txtSnaga.Text);
            vozilo.sjedista = Convert.ToInt32(txtSjedista.Text);
            vozilo.nosivost = Convert.ToInt32(txtNosivost.Text);
            vozilo.registracija = txtRegistracija.Text;
            vozilo.prometna = txtPrometna.Text;
            vozilo.servisna = txtServisna.Text;
            vozilo.kilometri = Convert.ToInt32(txtKilometraza.Text);

           
            //items.add("")
            vozilo.tip_vozila = Convert.ToInt32(txtTipVozila.SelectedValue);
            vozilo.model_vozila = Convert.ToInt32(txtModel.SelectedValue);
            vozilo.parking = Convert.ToInt32(txtParking.SelectedValue);

            /*MessageBox.Show();*/

            db.vozilo.Add(vozilo);
            
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

        private void frmVozilaDodaj_Load(object sender, EventArgs e)
        {

        }

       

        

       
    }
}
