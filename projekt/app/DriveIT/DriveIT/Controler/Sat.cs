using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveIT.Controler
{
    class Sat
    {
        public static string getCurrentTime() {
            string time;

            time = DateTime.Now.ToString("dd/MM/yyyy  H:mm:ss");

             return time;
        }
    }
}
