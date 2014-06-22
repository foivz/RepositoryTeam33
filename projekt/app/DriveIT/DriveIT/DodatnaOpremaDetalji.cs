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

namespace DriveIT
{
    public partial class frmDodatnaOpremaDetalji : Form
    {
        T33_DBEntities db = new T33_DBEntities();

        public frmDodatnaOpremaDetalji()
        {
            InitializeComponent();
            /*Combobox dobavljaca*/
            cbDobavljac.DataSource = db.dobavljac.ToList();
            cbDobavljac.ValueMember = "id_dobavljac";
            cbDobavljac.DisplayMember = "tvrtka";
        }

        public void getDetails(string i)
        {
            int b = int.Parse(i);

            dodatna_oprema oprema = db.dodatna_oprema.Where<dodatna_oprema>(x => x.id_dodatna_oprema == b).First<dodatna_oprema>();

            txtId.Text = Convert.ToString(oprema.id_dodatna_oprema);
            cbDobavljac.SelectedValue = oprema.dobavljac_iddobavljac;
            txtNaziv.Text = oprema.naziv;
            txtModel.Text = oprema.model;
            txtBoja.Text = oprema.boja;
            txtKolicina.Text = Convert.ToString(oprema.kolicina);
            txtCijena.Text = Convert.ToString(oprema.cijena);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            dodatna_oprema oprema = db.dodatna_oprema.First(i => i.id_dodatna_oprema == id);
            db.dodatna_oprema.Remove(oprema);
            db.SaveChanges();


            MessageBox.Show("Dodatna oprema je uspješno obrisana");
            System.Threading.Thread.Sleep(700);
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            dodatna_oprema oprema = db.dodatna_oprema.First(i => i.id_dodatna_oprema == id);

            oprema.dobavljac_iddobavljac = (int)cbDobavljac.SelectedValue;
            oprema.naziv = txtNaziv.Text;
            oprema.model = txtModel.Text;
            oprema.boja = txtBoja.Text;
            oprema.kolicina = Convert.ToInt32(txtKolicina.Text);
            oprema.cijena = Convert.ToInt32(txtCijena.Text);

            db.SaveChanges();

            MessageBox.Show("Dobavljaci su  uspješno ažurirani !");
            System.Threading.Thread.Sleep(700);
            this.Close();
        }
    }
}
