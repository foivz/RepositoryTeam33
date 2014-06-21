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
using System.IO;

namespace DriveIT
{
    public partial class frmVozilaDodaj : Form
    {
        T33_DBEntities db = new T33_DBEntities();

        public frmVozilaDodaj()
        {
            InitializeComponent();

            /*Tip vozila combobox*/
            
            
                txtTipVozila.DataSource = db.tip_vozila.ToList();
                txtTipVozila.ValueMember = "id_tip_vozila";
                txtTipVozila.DisplayMember = "naziv";
           
            /*Model vozila combobox*/
            
                txtModel.DataSource = db.model_vozila.ToList();
                txtModel.ValueMember = "id_model_vozila";
                txtModel.DisplayMember = "naziv";

            /*Parking combobox*/        
                txtParking.DataSource = db.parking.ToList();
                txtParking.ValueMember = "id_parking";
                txtParking.DisplayMember = "naziv";

            /*Dobavljači combobox*/
                cbDobavljac.DataSource = db.dobavljac.ToList();
                cbDobavljac.ValueMember = "id_dobavljac";
                cbDobavljac.DisplayMember = "tvrtka"; 

            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajDobavljac_Click(object sender, EventArgs e)
        {
            
            vozilo vozilo = new vozilo();

            /*Dodavanje u tablicu vozila*/
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
            vozilo.tip_vozila = Convert.ToInt32(txtTipVozila.SelectedValue);
            vozilo.model_vozila = Convert.ToInt32(txtModel.SelectedValue);
            vozilo.parking = Convert.ToInt32(txtParking.SelectedValue);

            
           try
            {
                 db.vozilo.Add(vozilo);
                 db.SaveChanges();   
                 
                 spremiCijene();
                 spremiUgovore();
                 db.SaveChanges();

                MessageBox.Show("Vozilo je uspješno dodano !");
                System.Threading.Thread.Sleep(700);
                this.Close();
            }
            catch {
                MessageBox.Show("Greška pri unosu vozila!");
                this.Close();
            }
        }

        private  vozilo vratiZadnjeUneseno(){
            string broj_sasije = txtBrSasije.Text;
            vozilo zadnje_vozilo = db.vozilo.Where<vozilo>(x => x.sasija == broj_sasije).First<vozilo>();
            //var vozila = db.vozilo.Where<vozilo>(x => x.id_vozilo == 2).First<vozilo>();
            return zadnje_vozilo;
            
        }

           
        private void spremiCijene(){

                vozilo vozilo_uneseno = vratiZadnjeUneseno() ;
                cijena cijena_vozila = new cijena();

                MessageBox.Show(Convert.ToString(vozilo_uneseno.id_vozilo));

                cijena_vozila.vozilo = vozilo_uneseno.id_vozilo;
                cijena_vozila.nabavna_bez_pdv = Convert.ToDecimal(txtCijena.Text);
                cijena_vozila.nabavna_sa_pdv = 0;
                cijena_vozila.popravci_ekterni = 0;
                cijena_vozila.porez = 0;
                cijena_vozila.popravci_interni = 0;
                cijena_vozila.datum_izracuna = DateTime.Now.Date;
                cijena_vozila.tip_poreza_nabavna = 1;
                cijena_vozila.tip_poreza_prodajna = 1;
                
                
                db.cijena.Add(cijena_vozila);
                db.SaveChanges();
                
        }


        private void spremiUgovore(){
                vozilo vozilo_uneseno = vratiZadnjeUneseno();
                ugovor ugovor_prvi_kupoprodajni = new ugovor();

                ugovor_prvi_kupoprodajni.vozilo = vozilo_uneseno.id_vozilo;
                ugovor_prvi_kupoprodajni.kupac = null;
                ugovor_prvi_kupoprodajni.datum = DateTime.Now.Date;
                ugovor_prvi_kupoprodajni.dobavljac_iddobavljac = Convert.ToInt32(cbDobavljac.SelectedValue);

                db.ugovor.Add(ugovor_prvi_kupoprodajni);
                db.SaveChanges();
                
        }


        private void frmVozilaDodaj_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Odaberite slike vozila";
            string mapa = @"C:\Program Files\DriveIT\Slike\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                  foreach (String file in openFileDialog1.FileNames)
                  {
                      
                      Image loadedImage = Image.FromFile(file);

                      var bitovi = File.ReadAllBytes(file);
                      File.WriteAllBytes(@"C:\Program Files\DriveIT\Slike\bla.jpg", bitovi);
                     
                      //await file.CopyAsync( @"C:\Program Files\DriveIT\Slike\");

                  }
            }
            
            
            //saveFileDialog1.InitialDirectory = @"C:\Program Files\DriveIT\Slike\";
            //saveFileDialog1.Filter = "JPEG files (*.jpg)|*.jpeg|PNG files (*.png)|*.png";
            

            

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Spremljene slike");
        }
    }
}
