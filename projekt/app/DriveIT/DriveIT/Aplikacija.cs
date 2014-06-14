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
    public partial class frmAplikacija : Form
    {
        public frmAplikacija()
        {
            InitializeComponent();
        }

    
        private void btnDobavljaci_Click_1(object sender, EventArgs e)
        {
            frmDobavljaci dobavljaci = new frmDobavljaci();
            dobavljaci.ShowDialog();
        }

        private void btnKupciIInteresanti_Click(object sender, EventArgs e)
        {
            frmKupci kupci = new frmKupci();
            kupci.ShowDialog();
        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            frmVozila vozila = new frmVozila();
            vozila.ShowDialog();
        }

        private void btnUgovori_Click(object sender, EventArgs e)
        {
            frmUgovori ugovori = new frmUgovori();
            ugovori.ShowDialog();

        }

        private void frmAplikacija_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

      
    }
}
