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
    public partial class frmVozila : Form
    {

        private void PrikaziVozila() {

            BindingList<vozilo> listaVozila = null;
            using (var db = new T33_DBEntities2()) {
                listaVozila = new BindingList<vozilo>(db.vozilo.ToList<vozilo>());
            }
            voziloBindingSource1.DataSource = listaVozila;
        }


        public frmVozila()
        {
            InitializeComponent();
        }

        private void frmVozila_Load(object sender, EventArgs e)
        {
            PrikaziVozila();
        }
    }
}
