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

        private void frmMehanicar_Load(object sender, EventArgs e)
        {

            this.mj = 4; /* MJESECI */
            dohvatiNeupaljenaVozila(mj);
            dohvatiNaloge();
        }

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
        private void dohvatiNeupaljenaVozila(int mj)
        {
            db = new T33_DBEntities();
            DateTime vrijeme = DateTime.Now;
            vrijeme = vrijeme.AddMonths(mj * -1);

            //var vozila = db.vozilo.Where<vozilo>(x => x.zadnje_paljenje == null).ToList<vozilo>();
            /*notifikacijeGrid.DataSource = vozila;*/

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
        public void dohvatiNaloge()
        {
            
            
            /*nalog.DataSource =
                        (from n in db.nalog_za_servis
                         join v in db.vozilo on n.vozilo equals v.id_vozilo
                         join m in db.model_vozila on v.model_vozila equals m.id_model_vozila
                         join k in db.korisnik on n.korisnik equals k.id_korisnik
                         where n.vozilo == v.id_vozilo
                         select new
                         {
                             n.id_nalog_za_servis,
                             n.opis,
                             vozilo = m.naziv,
                             korisnik = k.korisnicko_ime,
                             n.obavljen,
                             n.datum,
                             n.cijena,
                             n.sati_rada
                         }).ToList();*/
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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
