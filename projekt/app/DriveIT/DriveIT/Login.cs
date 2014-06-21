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

        private void frmDriveIT_Load(object sender, EventArgs e)
        {
         
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int valjan = Provjera.ProvjeraLogin(txtKorisnickoIme.Text, Lozinka.Text);
            if (valjan == 1 ||valjan==2)
            {
                
                

                frmAplikacija app = new frmAplikacija();
                app.Show();
                
                this.Hide();
                

            }
            else if (valjan == 3)
            {
                
                

                frmMehanicar app = new frmMehanicar();
                app.Show();
                
                this.Hide();

            }

            else
            {
                MessageBox.Show("Neuispravni podaci pri prijavi");
            }

        }
    }
}
