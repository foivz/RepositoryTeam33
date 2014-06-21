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
    public partial class frmDodatnaOpremaDodaj : Form
    {
        T33_DBEntities db = new T33_DBEntities();

        public frmDodatnaOpremaDodaj()
        {
            InitializeComponent();
            /*Combobox dobavljaca*/
            cbDobavljac.DataSource = db.dobavljac.ToList();
            cbDobavljac.ValueMember = "id_dobavljac";
            cbDobavljac.DisplayMember = "tvrtka";

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajDodatnuOpremu_Click(object sender, EventArgs e)
        {
            dodatna_oprema dodatna = new dodatna_oprema();

            dodatna.dobavljac_iddobavljac = Convert.ToInt32(cbDobavljac.SelectedValue);
            dodatna.naziv = txtNaziv.Text;
            dodatna.model = txtModel.Text;
            dodatna.boja = txtBoja.Text;
            dodatna.kolicina = Convert.ToInt32(txtKolicina.Text);
            dodatna.cijena = Convert.ToInt32(txtCijena.Text);
            dodatna.raspoloživo = null;

            db.dodatna_oprema.Add(dodatna);

            try
            {
                db.SaveChanges();

                MessageBox.Show("Dodatna oprema uspješno ažurirana");
                System.Threading.Thread.Sleep(700);
                this.Close();

            }
            catch {
                MessageBox.Show("Greška pri dodavanju dodatne opreme");
            }
        }
    }
}
