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
    public partial class frmDodatnaOprema : Form
    {
        public frmDodatnaOprema()
        {
            InitializeComponent();
        }

        private void prikaziDodatnuOpremu()
        {
            T33_DBEntities db = new T33_DBEntities();
            var dodatna_oprema = db.dodatna_oprema.ToList<dodatna_oprema>();
            dodatnaopremaBindingSource.DataSource = dodatna_oprema;
        }



        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            prikaziDodatnuOpremu();
        }

        private void frmDodatnaOprema_Load(object sender, EventArgs e)
        {
            prikaziDodatnuOpremu();
        }

       
    }
}
