using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DriveIT.Database;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace DriveIT.Controler
{
    class PdfUgovor
    {
         public static void KupoprodajniUgovor(vozilo vozilo, kupac kupac, ugovor ugovor){

            Tvrtka tvrtka = new Tvrtka();

            bool isExists = System.IO.Directory.Exists("./Ugovori");
            if(!isExists)
                System.IO.Directory.CreateDirectory("./Ugovori");

            Document dokument = new Document(iTextSharp.text.PageSize.A4);
            string parameter = "Ugovori/Ugovor_" + ugovor.id_ugovor.ToString() + "_" + kupac.tvrtka.ToString() + "_" + kupac.ime.ToString() + ".pdf";
            PdfWriter wri = PdfWriter.GetInstance(dokument, new FileStream(parameter, FileMode.Create));
            dokument.Open();
            
            Paragraph prodavatelj = new Paragraph("PRODAVATELJ  "+tvrtka.imeTvrtke+",  "+tvrtka.adresa+"\n");
            dokument.Add(prodavatelj);

            Paragraph oKupcu = new Paragraph("KUPAC  " + kupac.ime.ToString() + " " + kupac.prezime.ToString() + " " + kupac.tvrtka.ToString() + ",  " + kupac.adresa.ToString() + "\nZakljucili su u "+tvrtka.adresa+ ",  " + ugovor.datum.ToString() + " godine ovaj:\n");
            dokument.Add(oKupcu);
            
            Paragraph naslov = new Paragraph("UGOVOR O KUPOPRODAJI MOTORNOG VOZILA\n");
            naslov.Font.Size = 20;
            naslov.Alignment = Element.ALIGN_CENTER;
            dokument.Add(naslov);

            Paragraph oVozilu = new Paragraph("\n1.Prodavatelj prodaje a kupac kupuje motorno vozilo:\n");
            dokument.Add(oVozilu);

            PdfPTable tablica1 = new PdfPTable(6);

            tablica1.TotalWidth = 520f;

            tablica1.LockedWidth = true;
            tablica1.HorizontalAlignment = 0;
            tablica1.SpacingBefore = 20f;
            tablica1.SpacingAfter = 30f;

            PdfPCell celija1 = new PdfPCell(new Phrase("Registracijaska oznaka")); 
            tablica1.AddCell(celija1);

            PdfPCell celija2 = new PdfPCell(new Phrase(vozilo.registracija.ToString()));
            tablica1.AddCell(celija2);

            PdfPCell celija3 = new PdfPCell(new Phrase("Vrsta vozila"));
            tablica1.AddCell(celija3);

            PdfPCell celija4 = new PdfPCell(new Phrase(vozilo.tip_vozila1.naziv.ToString()));
            tablica1.AddCell(celija4);

            PdfPCell celija5 = new PdfPCell(new Phrase("Marka vozila"));
            tablica1.AddCell(celija5);

            PdfPCell celija6 = new PdfPCell(new Phrase(vozilo.model_vozila1.marka_vozila1.naziv.ToString()));
            tablica1.AddCell(celija6);

            PdfPCell celija7 = new PdfPCell(new Phrase("Tip vozila"));
            tablica1.AddCell(celija7);
            PdfPCell celija8 = new PdfPCell(new Phrase(vozilo.tip_vozila1.podtip.ToString()));
            tablica1.AddCell(celija8);
            PdfPCell celija9 = new PdfPCell(new Phrase("Model vozila"));
            tablica1.AddCell(celija9);
            PdfPCell celija10 = new PdfPCell(new Phrase(vozilo.model_vozila1.naziv.ToString()));
            tablica1.AddCell(celija10);
            PdfPCell celija11 = new PdfPCell(new Phrase("Boja vozila"));
            tablica1.AddCell(celija11);
            PdfPCell celija12 = new PdfPCell(new Phrase(vozilo.boja.ToString()));
            tablica1.AddCell(celija12);
            PdfPCell celija13 = new PdfPCell(new Phrase("Broj sasije"));
            tablica1.AddCell(celija13);
            PdfPCell celija14 = new PdfPCell(new Phrase(vozilo.sasija.ToString()));
            celija14.Colspan = 3;
            tablica1.AddCell(celija14);
            

            PdfPCell celija15 = new PdfPCell(new Phrase("Oblik karoserije"));
            tablica1.AddCell(celija15);
            PdfPCell celija28 = new PdfPCell(new Phrase(vozilo.tip_vozila1.naziv.ToString()));
            tablica1.AddCell(celija28);

            PdfPCell celija16 = new PdfPCell(new Phrase("Država proizvodnje"));
            tablica1.AddCell(celija16);
            PdfPCell celija17= new PdfPCell(new Phrase(vozilo.model_vozila1.marka_vozila1.drzava.ToString()));
            tablica1.AddCell(celija17);
            
            PdfPCell celija18 = new PdfPCell(new Phrase("Godina proizvodnje"));
            tablica1.AddCell(celija18);
            PdfPCell celija19 = new PdfPCell(new Phrase(vozilo.godina_proizvodnje.ToString()));
            tablica1.AddCell(celija19);
            
            PdfPCell celija20 = new PdfPCell(new Phrase("Osnovna namjena"));
            tablica1.AddCell(celija20);
            PdfPCell celija21 = new PdfPCell(new Phrase("Transport"));
            tablica1.AddCell(celija21);
            
            PdfPCell celija22 = new PdfPCell(new Phrase("Datum prve registracije"));
            tablica1.AddCell(celija22);
            PdfPCell celija23 = new PdfPCell(new Phrase(vozilo.datum_prve_registracije.ToString()));
            tablica1.AddCell(celija23);

            PdfPCell celija24 = new PdfPCell(new Phrase("Snaga motora u kW"));
            tablica1.AddCell(celija24);
            PdfPCell celija25 = new PdfPCell(new Phrase(vozilo.snaga_kw.ToString()));
            tablica1.AddCell(celija25);

            PdfPCell celija26 = new PdfPCell(new Phrase("Nosivost"));
            tablica1.AddCell(celija26);
            PdfPCell celija27 = new PdfPCell(new Phrase(vozilo.nosivost.ToString()));
            tablica1.AddCell(celija27);
           
            /*
            PdfPCell celija28 = new PdfPCell(new Phrase("Registracijaska oznaka"));
            tablica1.AddCell(celija28);
            PdfPCell celija29 = new PdfPCell(new Phrase("Registracijaska oznaka"));
            tablica1.AddCell(celija29);
            PdfPCell celija30 = new PdfPCell(new Phrase("Registracijaska oznaka"));
            tablica1.AddCell(celija30);
            PdfPCell celija31 = new PdfPCell(new Phrase("Registracijaska oznaka"));
            tablica1.AddCell(celija31);
            PdfPCell celija32 = new PdfPCell(new Phrase("Registracijaska oznaka"));
            tablica1.AddCell(celija32);
            PdfPCell celija33 = new PdfPCell(new Phrase("Registracijaska oznaka"));
            tablica1.AddCell(celija33);
            PdfPCell celija34 = new PdfPCell(new Phrase("Registracijaska oznaka"));
            tablica1.AddCell(celija34);
            PdfPCell celija35 = new PdfPCell(new Phrase("Registracijaska oznaka"));
            tablica1.AddCell(celija35);
            PdfPCell celija36 = new PdfPCell(new Phrase("Registracijaska oznaka"));
            tablica1.AddCell(celija36);
            */
            dokument.Add(tablica1);

            //Paragraph cijena = new Paragraph("2. Prodajna cijena ugovorena je u uznosu od " + vozilo.cijena.prodajna_sa_pdv.ToString() + " kn\nOd toga je poreza na dodatnu vrijednost (PDV): " + vozilo.cijena.porez.ToString()+" kn\n");
            Paragraph cijena = new Paragraph("2. Prodajna cijena ugovorena je u uznosu od " + "12545" + " kn\nOd toga je poreza na dodatnu vrijednost (PDV): " + "2500" + " kn\n");
            dokument.Add(cijena);

            Paragraph ostatak = new Paragraph("3. Prodavatelj jam!i da je vozilo njegovo vlasništvo, a kupac nakon što je pregledao vozilo nema prigovora u svezi kvalitete i prodajne cijene.\n\n4. Porez i ostale troškove snosi KUPAC\n\n5. Prodavatelj i kupac prihvaćaju prava i obveze ovog ugovora, a za slučaj spora nadležan je sud u Ljubuškom\n6.Napomena..................................................................................................\n\n");
            dokument.Add(ostatak);

            Paragraph primjerci = new Paragraph("Prije potpisivanja ugovora isprintajte tri primjerka ovog ugovora.\nNakon toga kupac i prodavatelj potpisat će vlastoručno svaki list posebno\n\n");
            dokument.Add(primjerci);

            Paragraph crtice = new Paragraph("...........................................     ..........................................\n");
            Paragraph ispodCrtica = new Paragraph("            prodavatelj                                     kupac\n\n\n\n"); 
            ispodCrtica.Font.Size = 8;
            dokument.Add(ispodCrtica);

            dokument.Close();
            

            
        }
    }
}
