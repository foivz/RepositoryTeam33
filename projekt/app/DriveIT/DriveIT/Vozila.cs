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
       
        public void PrikaziVozila() {

            lblTest.Text = "test";


            T33_DBEntities2 db = new T33_DBEntities2();

            //BindingList<vozilo> listaVozila = null;

            



            //var vozila = db.vozilo.Where<vozilo>(x => x.id_vozilo == 2).First<vozilo>();

            //var vozila = db.vozilo.Where<vozilo>;
            var vozila = db.vozilo.ToList<vozilo>();


            voziloBindingSource1.DataSource = vozila;
        }


        public frmVozila()
        {
            InitializeComponent();

            /*var db = new T33_DBEntities2();

            var voz = db.vozilo.ToList<vozilo>();

            var jedno = voz.First<vozilo>();

            MessageBox.Show(jedno.boja);*/

        }

        private void frmVozila_Load(object sender, EventArgs e)
        {
            PrikaziVozila();
        }
    }
}
