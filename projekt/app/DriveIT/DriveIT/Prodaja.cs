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
    public partial class frmProdaja : Form
    {
        int marza = 24;
        public frmProdaja(int id)
        {
            InitializeComponent();
            loadData(id);
        }

        private void frmProdaja_Load(object sender, EventArgs e)
        {
            
        }
        private void loadData(int id)
        {
            T33_DBEntities db = new T33_DBEntities();
            var vozila = db.vozilo.Where<vozilo>(x => x.id_vozilo == id).First<vozilo>();
            var cijena = db.cijena.Where<cijena>(x => x.vozilo == id).FirstOrDefault();
            
            DateTime datumNabave = (DateTime)vozila.datum_nabavke;
            
            int starostDani=(DateTime.Today-datumNabave).Days;
            float starostMj= starostDani/30;

            option1txt.Text = datumNabave.ToLongDateString();
            if(starostMj>0)
                option2txt.Text = starostMj +" mj";
            else
                option2txt.Text = starostDani + " dan/a";

            if (cijena == null)
                option3txt.Text = "Nabavna cijena nije unesena";
            else
                option3txt.Text = izracunCijeneVozila(starostMj, (float)cijena.nabavna_sa_pdv).ToString();

            
        }
        public double izracunCijeneVozila(float starostMj, float cijenaVozila)
        {
            if ((int)starostMj > marza) marza = 0;
            else
                marza -= (int)starostMj;
            double cijena = (float)marza * 0.01 * cijenaVozila;
            return cijena;
        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
