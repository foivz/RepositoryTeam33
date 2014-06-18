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
    public partial class frmModeliVozilaDodaj : Form
    {
        public frmModeliVozilaDodaj()
        {
            InitializeComponent();

            using (T33_DBEntities db = new T33_DBEntities())
            {
                cbMarka.DataSource = db.marka_vozila.ToList();
                cbMarka.ValueMember = "id_marka_vozila";
                cbMarka.DisplayMember = "naziv";

            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajModelVozila_Click(object sender, EventArgs e)
        {
            T33_DBEntities db = new T33_DBEntities();
            model_vozila model = new model_vozila();

            model.naziv = txtNaziv.Text;
            model.marka_vozila = Convert.ToInt32(cbMarka.SelectedValue);

            db.model_vozila.Add(model);
            
            try
            {
    
                db.SaveChanges();

                MessageBox.Show("Uspješno je dodan model vozila !");
                System.Threading.Thread.Sleep(700);
                this.Close();


            }
            catch {

                MessageBox.Show("Pogreška pri dodavanju novog modela !");
                System.Threading.Thread.Sleep(700);
                this.Close();
            }
        }
    }
}
