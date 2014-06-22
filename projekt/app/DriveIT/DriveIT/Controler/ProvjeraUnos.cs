using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveIT.Controler
{

    /// <summary>
    /// [TODO]
    /// Klasa koja validira podatke koje je korisnik unio u neku od textboxova forme
    /// </summary>
    class ProvjeraUnos
    {
        /// <summary>
        /// Metoda koja provjerava da li string koji smo mu proslijedili sadrži velika ili mala slova
        /// Ukoliko sadrži mala vraćamo true a u suprotnom false
        /// </summary>
        /// <param name="unos"></param>
        /// <returns></returns>
        public static bool ProvjeraVelicineSlova(string unos)
        {

            if (unos[0] != Char.ToLower(unos[0]) && unos.Substring(1).ToLower()!=unos.Substring(1))
            {
                return true;
            }
            else
                return false;
            }

    }
}
