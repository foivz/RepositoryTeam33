using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveIT.Controler
{
    class ProvjeraUnos
    {
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
