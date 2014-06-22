using DriveIT.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DriveIT.Controler;

namespace DriveIT
{
    /// <summary>
    /// Glavna forma aplikacije koja se pokreće nakon uspješnog logina administratora
    /// sadrži metode koje odgovaraju akcijama korisnika na formi
    /// </summary>
    public partial class frmAplikacija : Form
    {
        T33_DBEntities db = new T33_DBEntities();

        /// <summary>
        /// Konstruktor forme koji sadrži kod za punjenje comboboxa s vrijednostima naziva i id-a parkirališta
        /// </summary>
        public frmAplikacija()
        {
            InitializeComponent();

           
                cbParkiralista.DataSource = db.parking.ToList();
                cbParkiralista.ValueMember = "id_parking";
                cbParkiralista.DisplayMember = "naziv";
                //pictureBox1.Load("./Slike/parking.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            

        }



        /// <summary>
        /// Metoda koja puni datagrid s vrijednostima automobila koji se nalaze na nekom parkiralištu
        /// odabirom vrijednosti u comboboxu se vrijednosti u datagridu ažuriraju
        /// </summary>
        private void prikaziParking() {
            
            //vozilo.parking = Convert.ToInt32(txtParking.SelectedValue);
            int parking ;
            bool park = Int32.TryParse(cbParkiralista.SelectedValue.ToString(),out parking);


            BindingSource upit = new BindingSource();
            upit.DataSource =
                        (from v in db.vozilo
                         join p in db.parking on v.parking equals p.id_parking
                         join t in db.tip_vozila on v.tip_vozila equals t.id_tip_vozila
                         join m in db.model_vozila on v.model_vozila equals m.id_model_vozila
                         where p.id_parking == parking
                         select new
                         {
                             v.id_vozilo,
                             v.sasija,
                             v.datum_prve_registracije,
                             v.datum_nabavke,
                             v.snaga_kw,
                             v.kilometri,
                             tip_vozila = t.naziv,
                             model_vozila = m.naziv,
                         }).ToList();
            voziloBindingSource.DataSource = upit;

        }


        /// <summary>
        /// Metoda za otvaranje forme s detaljima vozila
        /// Kao parametar prima string koji označava id vozila koje je odabrano u datagridu
        /// </summary>
        /// <param name="i"></param>
        private void prikaziDetalje(string i)
        {

            frmVozilaDetalji detalji_vozila = new frmVozilaDetalji();
            detalji_vozila.getDetails(i);
            detalji_vozila.ShowDialog();
        }

        /// <summary>
        ///  Metoda koja otvara formu za prikaz s detaljima dobavljača i CRUD mogućnostima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDobavljaci_Click_1(object sender, EventArgs e)
        {
            frmDobavljaci dobavljaci = new frmDobavljaci();
            dobavljaci.ShowDialog();
        }

        /// <summary>
        /// Metoda koja otvara formu za prikaz kupaca i interesanata s detaljima i CRUD mogućnostima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnKupciIInteresanti_Click(object sender, EventArgs e)
        {
            frmKupci kupci = new frmKupci();
            kupci.ShowDialog();
        }

        /// <summary>
        /// Metoda koja otvara formu za prikaz svih vozila s detaljima i CRUD mogućnostima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnVozila_Click(object sender, EventArgs e)
        {
            frmVozila vozila = new frmVozila();
            vozila.ShowDialog();
        }

        /// <summary>
        /// Metoda koja otvara formu za prikaz ugovora s detaljima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnUgovori_Click(object sender, EventArgs e)
        {
            frmUgovori ugovori = new frmUgovori();
            ugovori.ShowDialog();

        }

        /// <summary>
        /// Metoda koja se poziva prilikom učitavanja glavne forme i poziva metodu koja puni datagrid 
        /// odgovarajućim podacima o vozilu na parkiralištu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAplikacija_Load(object sender, EventArgs e)
        {
            prikaziParking();
            
        }
         
        /// <summary>
        /// Metoda koja se pokreže kada želimo izaći iz aplikacije te zatvara aplikaciju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
            

        }


        /// <summary>
        /// Metoda koja otvara formu za prikaz kataloga parkirališta s CRUD mogućnostima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void parkiralištaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParkiralista parkiralista = new frmParkiralista();
            parkiralista.Show();

        }

        /// <summary>
        /// Metoda koja otvara formu za prikaz kataloga modela vozila s CRUD mogućnostima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modeliVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModeliVozila modeli = new frmModeliVozila();
            modeli.Show();
        }

        /// <summary>
        /// Metoda koja otvara formu za prikaz kataloga modela vozila s CRUD mogućnostima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void markeVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarkeVozila marke = new frmMarkeVozila();
            marke.Show();

        }

        /// <summary>
        /// Metoda koja otvara formu za prikaz kataloga vrsta vozila s CRUD mogućnostima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vrstaVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVrsteVozila vrste = new frmVrsteVozila();
            vrste.Show();

        }

        /// <summary>
        /// Metoda koja otvara formu za prikaz kataloga dodatne opreme s CRUD mogućnostima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dodatnaOpremaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodatnaOprema dodatnaOprema = new frmDodatnaOprema();
            dodatnaOprema.Show();
        }

        /// <summary>
        /// [TODO]
        /// Metoda koja otvara formu za prikaz kataloga dijelova za popravam s CRUD mogućnostima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dijeloviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDijeloviServis dijelovi = new frmDijeloviServis();
            dijelovi.Show();
        }

        /// <summary>
        /// Metoda koja otvara formu s detaljima o autorima aplikacije
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tim33NOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutUs about = new frmAboutUs();
            about.Show();
        }

        /// <summary>
        /// Metoda koja se pokreće kad je aktivirana neka od opcija za izlaz iz aplikacije
        /// Korisniku nudi odabir ukoliko stvarno želi izaći iz aplikacije ukoliko je možda slučajno odabrao
        /// opciju izlaza iz aplikacije
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (e.CloseReason == CloseReason.UserClosing) Application.Exit();
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {

                switch (MessageBox.Show(this, "Jeste li sigurni za želite izaći?", "Zatvaranje", MessageBoxButtons.YesNo))
                {
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default: Application.Exit();
                        break;
                }
            }

        }

        /// <summary>
        /// Metoda za izlaz iz aplikacije koja gasi aplikaciju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButtnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Metoda koja otvara formu za prikaz kataloga naloga s mogućnošću pregledavanja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroBtnNalozi_Click(object sender, EventArgs e)
        {
            frmNalozi nalozi = new frmNalozi();
            nalozi.Show();
        }


        /// <summary>
        /// Metoda koja se pokreće prilikom promjene odabira parkirališta u comboboxu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbParkiralista_SelectedValueChanged(object sender, EventArgs e)
        {
            prikaziParking();
        }

        /// <summary>
        /// Metoda koja prilikom klika na neku vrijednosti iz datagrida šalje metodi za prikaz detalja id 
        /// trenutno odabranog retka,odnosno vraća njegov prvi element - id samog automobila
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string i = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            prikaziDetalje(i);
        }

        /// <summary>
        /// Metoda koja na odabir opcije za help otvara online PDF dokument s korisničkom dokumentacijom aplikacije
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpF1.getHelp();
        }


        /// <summary>
        /// Timer koji otkucava za vrijeme rada aplikacije svaku 1 sekundu i poziva statičku metodu
        /// iz kontrolera koja vraća trenutno vrijeme u obliku stringa
        /// zapisuje rezultat, u label koji glumi sat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void satTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = Sat.getCurrentTime();
        }

        /// <summary>
        /// Metoda koja pritiskom tipke f1 na tipkovnici poziva statičku metodu koja otvara pdf korisničke dokumentacije
        /// u korisnikovom web pregledniku
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
                if (keyData == Keys.F1)
                {
                    HelpF1.getHelp();
                    return true;   
                }
                return base.ProcessCmdKey(ref msg, keyData);
            }

      
    }
}
