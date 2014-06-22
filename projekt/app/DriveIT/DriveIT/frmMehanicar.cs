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
using System.Data.Entity;

namespace DriveIT
{
    public partial class frmMehanicar : Form
    {
        private BindingSource bs = new BindingSource();
        private BindingSource nalog = new BindingSource();
        T33_DBEntities db;
        int mj;

        public frmMehanicar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda koja pri paljenju vozila 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMehanicar_Load(object sender, EventArgs e)
        {

            this.mj = 4; /* MJESECI */
            dohvatiNeupaljenaVozila(mj);
            dohvatiNaloge();
        }

        /// <summary>
        /// Metoda koja sprema podatke o promjenama koje je napravio mehaničar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                db.SaveChanges();
                MessageBox.Show("Spremljeno");
            }
            catch 
            {

                MessageBox.Show("Greška");
            }
            
            
           
        }

        /// <summary>
        /// Metoda koja simulira paljenje automobila i javlja poruku o paljenju vozilas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upaliBtn_Click(object sender, EventArgs e)
        {
            //DataRow row = (notifikacijeGrid.SelectedRows[0].DataBoundItem as DataRowView).Row;
            foreach (DataGridViewRow row in notifikacijeGrid.SelectedRows)
            {
                vozilo selektiranoVozilo = row.DataBoundItem as vozilo;
                selektiranoVozilo.zadnje_paljenje = DateTime.Now.Date;
                db.SaveChanges();
                dohvatiNeupaljenaVozila(mj);
                MessageBox.Show("Upalili ste vozilo registracije: "+selektiranoVozilo.registracija, "Poruka o paljenju vozila");
            }

        }


        /// <summary>
        /// Metoda koja dohvaća vozila koja nisu upaljena određeni period vremena i na temelju provjere
        /// podiže notifikaciju mehaničaru da vozilo nije paljeno
        /// </summary>
        /// <param name="mj"></param>
        private void dohvatiNeupaljenaVozila(int mj)
        {
            db = new T33_DBEntities();
            DateTime vrijeme = DateTime.Now;
            vrijeme = vrijeme.AddMonths(mj * -1);

            db.vozilo.Where<vozilo>(x => x.zadnje_paljenje <= vrijeme).Load();
            if (db.vozilo.Where<vozilo>(x => x.zadnje_paljenje <= vrijeme).Count() > 0)
            {
                bs.DataSource = db.vozilo.Local.ToBindingList();
                notifikacijeGrid.DataSource = bs;


                notifikacijeGrid.Columns["id_vozilo"].Visible = false;
                notifikacijeGrid.Columns["sjedista"].Visible = false;
                notifikacijeGrid.Columns["ugovor"].Visible = false;
                notifikacijeGrid.Columns["nosivost"].Visible = false;
                notifikacijeGrid.Columns["prometna"].Visible = false;
                notifikacijeGrid.Columns["tip_vozila"].Visible = false;
                notifikacijeGrid.Columns["tip_vozila1"].Visible = false;
                notifikacijeGrid.Columns["model_vozila"].Visible = false;
                notifikacijeGrid.Columns["model_vozila1"].Visible = false;
                notifikacijeGrid.Columns["parking"].Visible = false;
                notifikacijeGrid.Columns["parking1"].Visible = false;
                notifikacijeGrid.Columns["cijena"].Visible = false;
            }
            else
            {
                //notifikacijeGrid.Visible = false;
                notifikacijeGrid.AllowUserToAddRows = true;
                notifikacijeGrid.Columns.Add("status", "Status");
                //notifikacijeGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                notifikacijeGrid.Columns[0].Width = (int)(notifikacijeGrid.Size.Width * 0.92);
                notifikacijeGrid.Rows[0].Cells[0].Value = "Ne postoji vozilo koje nije paljeno duže od " + mj + " mj";

            }
        }

        /// <summary>
        /// Metoda koja dohvaća sve naloge i sprema ih u datagrid 
        /// </summary>
        public void dohvatiNaloge()
        {
     
            db = new T33_DBEntities();
            db.nalog_za_servis.Where<nalog_za_servis>(x => x.korisnik1.id_korisnik >=0).Load();
            nalog.DataSource = db.nalog_za_servis.Local.ToBindingList();
            nalogGrid.DataSource = nalog;
            nalogGrid.Columns["id_nalog_za_servis"].Visible = false;
            nalogGrid.Columns["korisnik"].Visible = false;
            nalogGrid.Columns["cijena"].Visible = false;
            nalogGrid.Columns["sati_rada"].Visible = false;
            nalogGrid.Columns["korisnik1"].Visible = false;
            nalogGrid.Columns["vozilo1"].Visible = false;
            nalogGrid.Columns["dio"].Visible = false;
            nalogGrid.Columns["opis"].Width = (int)(nalogGrid.Size.Width * 0.42);
        }

        /// <summary>
        /// Metoda koja na odabir gumba za otvaranje naloga izabire određeni nalog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void otvoriNalogBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in nalogGrid.SelectedRows)
            {
                nalog_za_servis selektiraniNalog = row.DataBoundItem as nalog_za_servis;
                NaloziDetalji Detalji = new NaloziDetalji(selektiraniNalog.id_nalog_za_servis, this);
                Detalji.Show();
                //selektiraniNalog.id_nalog_za_servis;
            }
        }

        /// <summary>
        /// Metoda koja zatvara aplikaciju za mehaničara
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Metoda koja pita mehaničara da li je siguran da želi ugasiti aplikaciju
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

    }
}
