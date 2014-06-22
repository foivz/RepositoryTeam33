using DriveIT.Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            Lozinka.PasswordChar = '*';
            //progressBar1.Hide();
            progressBar1.Value = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //progressBar1.Show();
            progressBar1.Value = 50;
            Ulaz();
            
        }



        private void Ulaz()
        {
            
            if (ImaInterneta())
            {

                int valjan = Provjera.ProvjeraLogin(txtKorisnickoIme.Text, Lozinka.Text);
                if (valjan == 1 || valjan == 2)
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
            else
                MessageBox.Show("Provjerite internet vezu pa pokušajte ponovo.");
        }

        private bool ImaInterneta()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        

       

        private void Lozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //progressBar1.Show();
                progressBar1.Value = 50;
                Ulaz();
            }
        }
    }
}
