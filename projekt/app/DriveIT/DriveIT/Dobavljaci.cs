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
    public partial class frmDobavljaci : Form
    {

        private void PrikaziDobavljace() { 
        BindingList<dobavljac> listaDobavljaca= null;
        using (var db = new T33_DBEntities2()) {
            listaDobavljaca = new BindingList<dobavljac>(db.dobavljac.ToList());
        }

        dobavljacBindingSource.DataSource = listaDobavljaca;

        }


        public frmDobavljaci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmDobavljaci_Load(object sender, EventArgs e)
        {
            PrikaziDobavljace();
            
        }
    }
}
