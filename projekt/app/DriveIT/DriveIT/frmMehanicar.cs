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
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            MessageBox.Show("Ako nije izbacilo grešku, Spremljeno");
           
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
    }
}
