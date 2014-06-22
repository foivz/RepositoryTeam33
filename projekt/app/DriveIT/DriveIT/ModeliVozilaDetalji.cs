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
    public partial class frmModeliVozilaDetalji : Form
    {
        T33_DBEntities db = new T33_DBEntities();

        public frmModeliVozilaDetalji()
        {
            InitializeComponent();

            cbMarka.DataSource = db.marka_vozila.ToList();
            cbMarka.ValueMember = "id_marka_vozila";
            cbMarka.DisplayMember = "naziv";

        }

        private void frmModeliVozilaDetalji_Load(object sender, EventArgs e)
        {

        }

        public void getDetails(string i)
        {

            int b = int.Parse(i);
            var model = db.model_vozila.Where<model_vozila>(x => x.id_model_vozila == b).First<model_vozila>();

            txtSifra.Text = Convert.ToString(model.id_model_vozila);
            txtNaziv.Text = model.naziv;
            cbMarka.SelectedValue = model.id_model_vozila;
            cbMarka.SelectedValue = Convert.ToString(model.naziv);
            
            //TODO ovo rijesiti
            //cbMarka.SelectedText = 


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
           



        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObrisi_Click_1(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txtSifra.Text);
            model_vozila model = db.model_vozila.First(i => i.id_model_vozila == id);

            db.model_vozila.Remove(model);
            db.SaveChanges();

            MessageBox.Show("Model vozila uspješno obrisan");
            System.Threading.Thread.Sleep(700);
            this.Close();
        }

        private void btnAzuriraj_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtSifra.Text);
            model_vozila model = db.model_vozila.First(i => i.id_model_vozila == id);

            model.marka_vozila = Convert.ToInt32(cbMarka.SelectedValue);
            model.naziv = txtNaziv.Text;

            db.SaveChanges();
            MessageBox.Show("Model vozila uspješno ažuriran !");
            System.Threading.Thread.Sleep(700);
            this.Close();
        }

       

    }
}
