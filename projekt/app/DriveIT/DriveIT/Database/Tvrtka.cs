using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveIT.Database
{
    /// <summary>
    /// Klasa koja sadrži opće podatke o tvrtci koja koristi aplikaciju odnosno je vlasnik aplikacije
    /// Koristimo je prilikom kreiranja računa i izvještaja u PDF-u
    /// </summary>

    class Tvrtka
    {
        public string imeTvrtke { get; set; }
        public string adresa { get; set; }
        public string telefon { get; set; }
        public string faks { get; set; }
        public string email { get; set; }

        public Tvrtka()
        {
            this.imeTvrtke = "Auto Salon KRAMAR d.o.o.";
            this.adresa = "Mostarska vrata b.b. 88320 Ljubuški, BiH";
            this.telefon = "+387 39 830 000";
            this.faks = "+387 39 830 001";
            this.email = "info@askramar.com ";
        }


    }

}
