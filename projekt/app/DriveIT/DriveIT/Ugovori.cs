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
    public partial class frmUgovori : Form
    {
        private void PrikaziUgovore()
        {
            T33_DBEntities db = new T33_DBEntities();
            var ugovori = db.ugovor.ToList<ugovor>();
            ugovorBindingSource.DataSource = ugovori;
        }

        public frmUgovori()
        {
            InitializeComponent();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUgovori_Load(object sender, EventArgs e)
        {
            PrikaziUgovore();
        }
    }
}
