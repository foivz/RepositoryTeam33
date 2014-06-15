﻿using DriveIT.Database;
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
    public partial class frmKupci : Form
    {


        private void prikaziKupce() {

            T33_DBEntities db = new T33_DBEntities();
            var kupci = db.kupac.ToList<kupac>();
            kupacBindingSource.DataSource = kupci;
        
        }



        public frmKupci()
        {
            InitializeComponent();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKupci_Load(object sender, EventArgs e) {

            prikaziKupce();

         
         }

        private void btnDodajNovogKupca_Click(object sender, EventArgs e)
        {
            frmKupciDodaj novi_kupac = new frmKupciDodaj();
            novi_kupac.ShowDialog();
        }
        

    }
}
