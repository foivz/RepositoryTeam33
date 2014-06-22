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
    public partial class frmAplikacija : Form
    {
        T33_DBEntities db = new T33_DBEntities();

        public frmAplikacija()
        {
            InitializeComponent();

           
                cbParkiralista.DataSource = db.parking.ToList();
                cbParkiralista.ValueMember = "id_parking";
                cbParkiralista.DisplayMember = "naziv";
            

        }


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



        private void prikaziDetalje(string i)
        {

            frmVozilaDetalji detalji_vozila = new frmVozilaDetalji();
            detalji_vozila.getDetails(i);
            detalji_vozila.ShowDialog();
        }

    
        private void btnDobavljaci_Click_1(object sender, EventArgs e)
        {
            frmDobavljaci dobavljaci = new frmDobavljaci();
            dobavljaci.ShowDialog();
        }

        private void btnKupciIInteresanti_Click(object sender, EventArgs e)
        {
            frmKupci kupci = new frmKupci();
            kupci.ShowDialog();
        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            frmVozila vozila = new frmVozila();
            vozila.ShowDialog();
        }

        private void btnUgovori_Click(object sender, EventArgs e)
        {
            frmUgovori ugovori = new frmUgovori();
            ugovori.ShowDialog();

        }

        
        private void frmAplikacija_Load(object sender, EventArgs e)
        {
            prikaziParking();
            
        }
         

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
            

        }



        private void parkiralištaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParkiralista parkiralista = new frmParkiralista();
            parkiralista.Show();

        }

        private void modeliVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModeliVozila modeli = new frmModeliVozila();
            modeli.Show();
        }

        private void markeVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarkeVozila marke = new frmMarkeVozila();
            marke.Show();

        }

        private void vrstaVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVrsteVozila vrste = new frmVrsteVozila();
            vrste.Show();

        }

        private void dodatnaOpremaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodatnaOprema dodatnaOprema = new frmDodatnaOprema();
            dodatnaOprema.Show();
        }

        private void dijeloviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDijeloviServis dijelovi = new frmDijeloviServis();
            dijelovi.Show();
        }

        private void tim33NOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutUs about = new frmAboutUs();
            about.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Jeste li sigurni za želite izaći?", "Zatvaranje", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default: Application.Exit();
                    break;
            }

        }

        private void metroButtnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroBtnNalozi_Click(object sender, EventArgs e)
        {
            frmNalozi nalozi = new frmNalozi();
            nalozi.Show();
        }

        private void cbParkiralista_SelectedValueChanged(object sender, EventArgs e)
        {
            prikaziParking();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string i = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            prikaziDetalje(i);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            frmHelp help = new frmHelp();
            help.Show();*/
            //System.Diagnostics.Process.Start("C:/Users/Toplomjer/Documents/RepositoryTeam33/projekt/app/DriveIT/DriveIT/Help/CUDNOVATE_ZGODE_SEGRTA_HLAPICA.pdf");
            //System.Diagnostics.Process.Start("../Help/CUDNOVATE_ZGODE_SEGRTA_HLAPICA.pdf");
            
            //Zasada ovako radi pa ...
            //System.Diagnostics.Process.Start("http://os-gorican.skole.hr/upload/os-gorican/images/static3/721/File/CUDNOVATE_ZGODE_SEGRTA_HLAPICA.pdf");

        }

        private void satTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = Sat.getCurrentTime();
        }

      
    }
}
