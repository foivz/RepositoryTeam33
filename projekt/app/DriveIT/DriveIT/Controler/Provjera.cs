using DriveIT.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveIT.Controler
{
    class Provjera
    {
        public static bool ProvjeraLogin(string korIme,string lozinka)
        {
            using (T33_DBEntities db = new T33_DBEntities()) 
            {
                var korisnici = db.korisnik.ToList<korisnik>();
                foreach (korisnik kor in korisnici){
                    if(kor.korisnicko_ime==korIme)
                        if(kor.lozinka==lozinka)
                            return true;
                }

                }

            return false;
        }

    }
}
