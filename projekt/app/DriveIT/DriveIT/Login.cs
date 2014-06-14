using DriveIT.Controler;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
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
            bool valjan = Provjera.ProvjeraLogin(txtKorisnickoIme.Text, Lozinka.Text);
            if (valjan == true)
            {
                
                this.Close();

            }
            else
            {
                MessageBox.Show("Neuispravni podaci pri prijavi");
            }

        }
    }
}
