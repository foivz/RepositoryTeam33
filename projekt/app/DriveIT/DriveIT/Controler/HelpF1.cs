using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveIT.Controler
{
    /// <summary>
    /// Klasa koja otvara korisničku dokumentaciju na odabir opcije help ili pritiskom na f1
    /// </summary>
    class HelpF1
    {
        /// <summary>
        /// metoda koja poziva korisnikov zadani web preglednik i otvara stranicu s dokumentacijom
        /// </summary>
        public static void getHelp(){

            System.Diagnostics.Process.Start("http://arka.foi.hr/~lpredova/driveIT/CUDNOVATE_ZGODE_SEGRTA_HLAPICA.pdf");
        }

    }
}
