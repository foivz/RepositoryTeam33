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
    public partial class NaloziDetalji : Form
    {
        private BindingSource dijelovi = new BindingSource();
        int id_naloga;
        T33_DBEntities db = new T33_DBEntities();
        int ukupnaCijena=0;
        frmMehanicar formaMehanicar;

        public NaloziDetalji(int id_naloga, frmMehanicar formaMehanicar)
        {
            InitializeComponent();
            this.id_naloga = id_naloga;
            this.formaMehanicar=formaMehanicar;
        }
        public void dohvatiDjelove(int id_naloga)
        {

            db.dio.Where<dio>(x => x.nalog == id_naloga).Load();
            var dioLista= db.dio.Where<dio>(x => x.nalog == id_naloga).ToList();
            if (db.dio.Where<dio>(x => x.nalog == id_naloga).Count() > 0)
            {
                dijelovi.DataSource = db.dio.Local.ToBindingList();
                djeloviGrid.DataSource = dijelovi;
                djeloviGrid.Columns["id_dio"].Visible = false;
                djeloviGrid.Columns["nalog"].Visible = false;
                djeloviGrid.Columns["nalog_za_servis"].Visible = false;
                foreach (dio row in dioLista)
                {
                    this.ukupnaCijena += (int) row.cijena;
                }
            }
            else
            {
                djeloviGrid.AllowUserToAddRows = true;
                djeloviGrid.Columns.Add("status", "Status");
                djeloviGrid.Columns[0].Width = (int)(djeloviGrid.Size.Width * 0.92);
                djeloviGrid.Rows[0].Cells[0].Value = "Ne postoje djelovi";

            }
        }

        private void NaloziDetalji_Load(object sender, EventArgs e)
        {
            dohvatiDjelove(id_naloga);
            podaciONalogu();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            DioDodaj dodajNovi = new DioDodaj(this.id_naloga, this);
            dodajNovi.Show();
            dohvatiDjelove(this.id_naloga);

        }
        public void podaciONalogu()
        {
            var nalog = db.nalog_za_servis.Where<nalog_za_servis>(x => x.id_nalog_za_servis == this.id_naloga).FirstOrDefault();
            txtOpis.Text = nalog.opis;
            txtVozilo.Text = nalog.vozilo1.registracija + "("+nalog.vozilo1.model_vozila1.naziv+")";
            txtSati.Text = nalog.sati_rada.ToString();
            txtCijena.Text = ukupnaCijena.ToString();

            if((int)nalog.obavljen==0 || nalog.obavljen==null)
                comboxObavljeno.SelectedIndex = 0 ;
            else
                comboxObavljeno.SelectedIndex = 1;

            nalog.cijena = ukupnaCijena;
            db.SaveChanges();

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            var nalog = db.nalog_za_servis.Where<nalog_za_servis>(x => x.id_nalog_za_servis == this.id_naloga).FirstOrDefault();
            if (txtSati.Text==null) 
                nalog.sati_rada = 0;
            else
                nalog.sati_rada = int.Parse(txtSati.Text);
            if (comboxObavljeno.SelectedIndex == 1)
                nalog.obavljen = 1;
            else
                nalog.obavljen = 0;

            nalog.cijena = ukupnaCijena;
            db.SaveChanges();
            this.formaMehanicar.dohvatiNaloge();
            
        }

        private void NaloziDetalji_Leave(object sender, EventArgs e)
        {
            this.formaMehanicar.dohvatiNaloge();
        }



    }
}
