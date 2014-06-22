using DriveIT.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveIT.Controler
{
    /// <summary>
    /// Klasa koja računa cijenu vozila kojeg joj proslijedimo
    /// </summary>
    class KonacnaCijena
    {
        /// <summary>
        /// Metoda u kojoj se računaju cijene vozila s porezima,maržama.
        /// Bazira se na datašnjem datumu te ovisno o stajanju na skladištu računa maržu
        /// </summary>
        /// <param name="vozilo"></param>
        /// <returns>vozilo s unesenim izračunatim vrijednostima cijene</returns>


        public  vozilo Izracun(vozilo vozilo)
        {

            int razilka = ((DateTime.Now.Year - vozilo.datum_nabavke.Value.Year) * 12) + DateTime.Now.Year - vozilo.datum_nabavke.Value.Month;

            int marza = 24 - razilka;
            //if (marza < 0) marza = 0;


            vozilo.cijena.prodajna_sa_pdv = (decimal)vozilo.cijena.nabavna_sa_pdv * 1.20m;
            int djeljitelj = 1 + vozilo.cijena.tip_poreza1.postotak;
            vozilo.cijena.porez = vozilo.cijena.prodajna_sa_pdv / (1 + djeljitelj);
            vozilo.cijena.marza = marza;

            return vozilo;
        }

    }
}
