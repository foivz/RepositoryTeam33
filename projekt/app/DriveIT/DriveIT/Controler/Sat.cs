using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveIT.Controler
{

    /// <summary>
    /// Klasa koja služi za dobivanje vremena i zapis u sat
    /// </summary>
    class Sat
    {
        /// <summary>
        /// metoda koja na poziv vraća trenutno vrijeme u obliku dan/mjesec/godina sat/minut/sekunda
        /// </summary>
        /// <returns>string time</returns>
        public static string getCurrentTime() {
            string time;

            time = DateTime.Now.ToString("dd/MM/yyyy  H:mm:ss");

             return time;
        }
    }
}
