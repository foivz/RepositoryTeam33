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
    public partial class PreglednikSlika : Form
    {
        public PreglednikSlika()
        {
            InitializeComponent();
        }

        public static void Ucitaj_sliku(string id_vozila)
        {
            PreglednikSlika preglednik = new PreglednikSlika();
            preglednik.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            string url = "./Slike/" + id_vozila + "_1.jpg";
            preglednik.pictureBox1.Load(url);
            preglednik.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string[] putanja = pictureBox1.ImageLocation.Split('_');

            string nova_putanja;
            int broj;
            Int32.TryParse(putanja[1][0].ToString(), out broj);
            broj++;
            char znak;
            Char.TryParse(broj.ToString(), out znak);
            nova_putanja = putanja[0] + "_" + broj.ToString() + ".jpg";
            try
            {
                pictureBox1.Load(nova_putanja);
            }
            catch
            {
                MessageBox.Show("Nema više slika");
                broj--;
                nova_putanja = putanja[0] + "_" + broj.ToString() + ".jpg";
                pictureBox1.Load(nova_putanja);
                
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string[] putanja = pictureBox1.ImageLocation.Split('_');

            string nova_putanja;

            if (putanja[1][0] != '1' || putanja[1][1] != '.')
            {
                int broj;
                Int32.TryParse(putanja[1][0].ToString(), out broj);
                broj--;
                char znak;
                Char.TryParse(broj.ToString(), out znak);
                nova_putanja = putanja[0] + "_" + broj.ToString() + ".jpg";
                pictureBox1.Load(nova_putanja);
            }


        }


    }
}
