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
using DriveIT.Controler;
using WinSCP;

namespace DriveIT
{
    public partial class frmVozilaDodaj : Form
    {
        T33_DBEntities db = new T33_DBEntities();

        string oznaka;

        /// <summary>
        /// Konstruktor forme koji sadrži kod za popunjavanje comboboxova prilikom inicijalizacije forme
        /// </summary>
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

       

        
        /// <summary>
        /// Metoda koja vraća vozilo kojem broj šasije odgovara zadnje unesenom vozilu
        /// vraća objekt vozila koji je zadnji unesen
        /// </summary>
        /// <returns></returns>
        private vozilo vratiZadnjeUneseno()
        {
            string broj_sasije = txtBrSasije.Text;
            vozilo zadnje_vozilo = db.vozilo.Where<vozilo>(x => x.sasija == broj_sasije).First<vozilo>();
            //var vozila = db.vozilo.Where<vozilo>(x => x.id_vozilo == 2).First<vozilo>();
            return zadnje_vozilo;

        }

        /// <summary>
        /// Metoda koja sprema cijene u tablicu cijena za odgovarajuće vozilo
        /// </summary>
        private void spremiCijene()
        {

            vozilo vozilo_uneseno = vratiZadnjeUneseno();
            cijena cijena_vozila = new cijena();

            //MessageBox.Show(Convert.ToString(vozilo_uneseno.id_vozilo));

            cijena_vozila.vozilo = vozilo_uneseno.id_vozilo;
            cijena_vozila.nabavna_bez_pdv = Convert.ToDecimal(txtCijena.Text)/1.25m;
            cijena_vozila.nabavna_sa_pdv = Convert.ToDecimal(txtCijena.Text);
            cijena_vozila.popravci_ekterni = 0;
            cijena_vozila.porez = 0;
            cijena_vozila.popravci_interni = 0;
            cijena_vozila.datum_izracuna = DateTime.Now.Date;
            cijena_vozila.tip_poreza_nabavna = 1;
            cijena_vozila.tip_poreza_prodajna = 1;


            db.cijena.Add(cijena_vozila);
            db.SaveChanges();

        }

        /// <summary>
        /// Metoda koja za dodavanje vozila kreira ugovor na vozilu
        /// </summary>
        private void spremiUgovore()
        {
            vozilo vozilo_uneseno = vratiZadnjeUneseno();
            ugovor ugovor_prvi_kupoprodajni = new ugovor();

            ugovor_prvi_kupoprodajni.vozilo = vozilo_uneseno.id_vozilo;
            ugovor_prvi_kupoprodajni.kupac = null;
            ugovor_prvi_kupoprodajni.datum = DateTime.Now.Date;
            ugovor_prvi_kupoprodajni.dobavljac_iddobavljac = Convert.ToInt32(cbDobavljac.SelectedValue);

            dobavljac Dobavljac = db.dobavljac.First(i => i.id_dobavljac == ugovor_prvi_kupoprodajni.dobavljac_iddobavljac);


            db.ugovor.Add(ugovor_prvi_kupoprodajni);
            db.SaveChanges();

            PdfUgovor.KupoprodajniUgovorOdDobavljaca(vozilo_uneseno, Dobavljac, ugovor_prvi_kupoprodajni);

            

            

        }


        private void frmVozilaDodaj_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Metoda koja omogućava upload slike/a vozila
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Odaberite slike vozila";
            openFileDialog1.ShowDialog();

            //saveFileDialog1.InitialDirectory = @"C:\Program Files\DriveIT\Slike\";
            //saveFileDialog1.Filter = "JPEG files (*.jpg)|*.jpeg|PNG files (*.png)|*.png";

        }


        /// <summary>
        /// Metoda koja služi za spremanje slika vozila u direktorij na disku kojeg kreira ukoliko ne postoji
        /// ili koristi postojeći ako postoji
        /// </summary>
        /// 

        private void SpremiSlikeArka()
        {
            vozilo vozilo_uneseno = vratiZadnjeUneseno();
            this.oznaka = vozilo_uneseno.id_vozilo.ToString();

            int brojac = 1;

            SessionOptions sessionOptions = new SessionOptions
            {
                Protocol = Protocol.Sftp,
                HostName = "arka.foi.hr",
                UserName = "mboras",
                Password = "BJRGybmH",

                GiveUpSecurityAndAcceptAnySshHostKey = true

            };
            if (openFileDialog1.FileNames.Length != 0)
            {


                using (Session session = new Session())
                {
                    // Connect

                    session.Open(sessionOptions);

                    // Upload files
                    TransferOptions transferOptions = new TransferOptions();
                    transferOptions.TransferMode = TransferMode.Binary;


                    foreach (String file in openFileDialog1.FileNames)
                    {
                        String[] fileNameArray = file.Split('\\');

                        Environment.CurrentDirectory = file.Substring(0,(file.Length-fileNameArray[fileNameArray.Length-1].Length));

                        System.IO.File.Move(fileNameArray[fileNameArray.Length - 1], oznaka + "_" + brojac+".jpg");
                        fileNameArray[fileNameArray.Length - 1] = oznaka + "_" + brojac+".jpg";

                        TransferOperationResult transferResult;


                        string newFilePath = String.Join("\\",fileNameArray);
                        transferResult = session.PutFiles(newFilePath, "/home/is2011/m/mboras/public_html/piprojekt/", false, transferOptions);

                        // Throw on any error
                        transferResult.Check();
                        foreach (TransferEventArgs transfer in transferResult.Transfers)
                        {
                            Console.WriteLine("Upload of {0} succeeded", transfer.FileName);
                        }
                        brojac++;
                    }

              
                }
            }
        }
        private void SpremiSlike()
        {
            vozilo vozilo_uneseno = vratiZadnjeUneseno();
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            string[] polje = userName.Split('\\');
            userName = polje[1];

            string FolderMjesto = @"C:/Users/" + userName + "/DriveIT/Slike";

            bool isExists = System.IO.Directory.Exists(FolderMjesto);
            if (!isExists)
                System.IO.Directory.CreateDirectory(FolderMjesto);

            int brojac = 1;


            if (openFileDialog1.FileNames.Length!= 0)
            {
                foreach (String file in openFileDialog1.FileNames)
                {

                    Image loadedImage = Image.FromFile(file);

                    var bitovi = File.ReadAllBytes(file);
                    File.WriteAllBytes(FolderMjesto+"/" + vozilo_uneseno.id_vozilo + "_" + brojac.ToString() + ".jpg", bitovi);
                    //File.WriteAllBytes("./Slike/" + "111" + "_" + brojac.ToString() + ".jpg", bitovi);

                    

                    brojac++;


                    //await file.CopyAsync( @"C:\Program Files\DriveIT\Slike\");

                }
            }
        }

        /// <summary>
        /// Metoda koja poziva metodu za spremanje označenih slika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButton2_Click(object sender, EventArgs e)
        {
            SpremiSlike();
        }


        /// <summary>
        /// Metoda koja služi da dodavanje novog vozila,
        /// koristi korisnički unešene vrijednosti ili javlja grešku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajVozilo_Click(object sender, EventArgs e)
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
               // spremiUgovore();
                db.SaveChanges();

                SpremiSlikeArka();


                MessageBox.Show("Vozilo je uspješno dodano !");
                System.Threading.Thread.Sleep(700);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Greška pri unosu vozila!");
                this.Close();
            }
        }

        /// <summary>
        /// Metoda za zatvaranje forme na odabir gumba za zatvaranje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
