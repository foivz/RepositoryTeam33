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
            
        }
         

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
            

        }



        private void parkiralištaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParkiralista parkiralista = new frmParkiralista();
            parkiralista.Show();

        }

        private void modeliVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModeliVozila modeli = new frmModeliVozila();
            modeli.Show();
        }

        private void markeVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarkeVozila marke = new frmMarkeVozila();
            marke.Show();

        }

        private void vrstaVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVrsteVozila vrste = new frmVrsteVozila();
            vrste.Show();

        }

        private void dodatnaOpremaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodatnaOprema dodatnaOprema = new frmDodatnaOprema();
            dodatnaOprema.Show();
        }

        private void dijeloviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDijeloviServis dijelovi = new frmDijeloviServis();
            dijelovi.Show();
        }

        private void tim33NOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutUs about = new frmAboutUs();
            about.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Jeste li sigurni za želite izaći?", "Zatvaranje", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default: Application.Exit();
                    break;
            }

        }

        private void metroButtnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
