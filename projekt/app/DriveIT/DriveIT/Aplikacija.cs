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

        private void btnDobavljaci_Click(object sender, EventArgs e)
        {
            frmDobavljaci dobavljaci = new frmDobavljaci();
            dobavljaci.Show();
        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            frmVozila vozila = new frmVozila();
            vozila.Show();

        }

        private void btnKupci_Click(object sender, EventArgs e)
        {
            frmKupci kupci = new frmKupci();
            kupci.Show();

        }

        private void btnUgovori_Click(object sender, EventArgs e)
        {
            frmUgovori ugovori = new frmUgovori();
            ugovori.Show();
        }
    }
}
