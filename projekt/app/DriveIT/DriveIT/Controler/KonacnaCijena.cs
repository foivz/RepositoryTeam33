using DriveIT.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveIT.Controler
{
    class KonacnaCijena
    {
        public static vozilo Izracun(vozilo vozilo)
        {

            int razilka = ((DateTime.Now.Year - vozilo.datum_nabavke.Value.Year) * 12) + DateTime.Now.Year - vozilo.datum_nabavke.Value.Month;

            int marza = 24 - razilka;
            if (marza < 0) marza = 0;


            vozilo.cijena.prodajna_sa_pdv = (decimal)vozilo.cijena.nabavna_sa_pdv * (decimal)marza;
            int djeljitelj = 1 + vozilo.cijena.tip_poreza1.postotak;
            vozilo.cijena.porez = vozilo.cijena.prodajna_sa_pdv / (1 + djeljitelj);
            vozilo.cijena.marza = marza;

            return vozilo;
        }

    }
}
