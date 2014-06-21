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
        public frmMehanicar()
        {
            InitializeComponent();
        }

        private void frmMehanicar_Load(object sender, EventArgs e)
        {
             db = new T33_DBEntities();
             DateTime vrijeme = DateTime.Now;
             int mj = 5; /* MJESECI */
             vrijeme = vrijeme.AddMonths(mj*-1);

             //var vozila = db.vozilo.Where<vozilo>(x => x.zadnje_paljenje == null).ToList<vozilo>();
             /*notifikacijeGrid.DataSource = vozila;*/

            db.vozilo.Where<vozilo>(x => x.zadnje_paljenje <= vrijeme).Load();
            if (db.vozilo.Where<vozilo>(x => x.zadnje_paljenje <= vrijeme).Count() > 0)
            {
                bs.DataSource = db.vozilo.Local.ToBindingList();
                notifikacijeGrid.DataSource = bs;


                notifikacijeGrid.Columns["id_vozilo"].Visible = false;
                notifikacijeGrid.Columns["sjedista"].Visible = false;
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
                notifikacijeGrid.Columns[0].Width = (int) (notifikacijeGrid.Size.Width*0.92);
                notifikacijeGrid.Rows[0].Cells[0].Value = "Ne postoji vozilo koje nije paljeno duže od "+mj+" mj";

            }

             
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }
    }
}
