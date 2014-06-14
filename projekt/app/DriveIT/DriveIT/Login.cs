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
    public partial class frmDriveIT : Form
    {
        public frmDriveIT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAplikacija app = new frmAplikacija();
            app.Show();

        }

        private void lblKorisnickoIme_Click(object sender, EventArgs e)
        {

        }

        private void lblLozinka_Click(object sender, EventArgs e)
        {

        }

        private void frmDriveIT_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmAplikacija frm = new frmAplikacija();
            frm.ShowDialog();
           

        }
    }
}
