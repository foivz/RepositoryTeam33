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

        /// <summary>
        /// Metoda koja kreira kupoprodajni ugovor te generira pdf iz njih.
        /// Na temelju zadanih parametara vozilo,kupac i ugovor popunjava template ugovora
        /// </summary>
        /// <param name="vozilo"></param>
        /// <param name="kupac"></param>
        /// <param name="ugovor"></param>
        public static void KupoprodajniUgovor(vozilo vozilo, kupac kupac, ugovor ugovor)
        {

            string FONT = "c:/windows/fonts/arial.ttf";
            BaseFont bf = BaseFont.CreateFont(FONT, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font f = new Font(bf, 12, Font.NORMAL);



            Tvrtka tvrtka = new Tvrtka();

            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string[] polje = userName.Split('\\');
            userName = polje[1];

            string FolderMjesto = @"C:/Users/" + userName + "/DriveIT/KupciUgovori";

            bool isExists = System.IO.Directory.Exists(FolderMjesto);
            if (!isExists)
                System.IO.Directory.CreateDirectory(FolderMjesto);

            

            Document dokument = new Document(iTextSharp.text.PageSize.A4);
            string parameter = FolderMjesto+"/Ugovor_" + ugovor.id_ugovor.ToString() + "_" + kupac.tvrtka.ToString() + "_" + kupac.ime.ToString() + ".pdf";
            PdfWriter wri = PdfWriter.GetInstance(dokument, new FileStream(parameter, FileMode.Create));

            dokument.Open();

            Paragraph prodavatelj = new Paragraph("PRODAVATELJ:  " + tvrtka.imeTvrtke + ",  " + tvrtka.adresa + "\n", f);
            prodavatelj.Font.IsBold();
            dokument.Add(prodavatelj);

            Paragraph oKupcu = new Paragraph("KUPAC:  " + kupac.ime.ToString() + " " + kupac.prezime.ToString() + " " + kupac.tvrtka.ToString() + ",  " + kupac.adresa.ToString() + "\nZaključili su u " + tvrtka.adresa + ",  " + ugovor.datum.ToShortDateString() + " godine ovaj:\n", f);
            oKupcu.Font.IsBold();
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
            PdfPCell celija17 = new PdfPCell(new Phrase(vozilo.model_vozila1.marka_vozila1.drzava.ToString()));
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
            PdfPCell celija23 = new PdfPCell(new Phrase(vozilo.datum_prve_registracije.Value.ToShortDateString()));
            tablica1.AddCell(celija23);

            PdfPCell celija24 = new PdfPCell(new Phrase("Snaga motora u kW"));
            tablica1.AddCell(celija24);
            PdfPCell celija25 = new PdfPCell(new Phrase(vozilo.snaga_kw.ToString()));
            tablica1.AddCell(celija25);

            PdfPCell celija26 = new PdfPCell(new Phrase("Nosivost"));
            tablica1.AddCell(celija26);
            PdfPCell celija27 = new PdfPCell(new Phrase(vozilo.nosivost.ToString()));
            tablica1.AddCell(celija27);


            dokument.Add(tablica1);

            Paragraph cijena = new Paragraph("2. Prodajna cijena ugovorena je u uznosu od " + vozilo.cijena.prodajna_sa_pdv.ToString() + " kn\nOd toga je poreza na dodatnu vrijednost (PDV): " + vozilo.cijena.porez.ToString() + " kn\n");
            //Paragraph cijena = new Paragraph("2. Prodajna cijena ugovorena je u uznosu od " + "12545" + " kn\nOd toga je poreza na dodatnu vrijednost (PDV): " + "2500" + " kn\n");
            dokument.Add(cijena);

            Paragraph ostatak = new Paragraph("3. Prodavatelj jamči da je vozilo njegovo vlasništvo, a kupac nakon što je pregledao vozilo nema prigovora u svezi kvalitete i prodajne cijene.\n\n4. Porez i ostale troškove snosi KUPAC\n\n5. Prodavatelj i kupac prihvaćaju prava i obveze ovog ugovora, a za slučaj spora nadležan je sud u Ljubuškom.\n6.Napomena..................................................................................................\n\n", f);
            dokument.Add(ostatak);


            Paragraph primjerci = new Paragraph("Prije potpisivanja ugovora isprintajte tri primjerka ovog ugovora.\nNakon toga kupac i prodavatelj potpisat će vlastoručno svaki list posebno\n\n", f);
            dokument.Add(primjerci);

            Paragraph crtice = new Paragraph(".....................................................                                       ...............................................\n");
            dokument.Add(crtice);
            Paragraph ispodCrtica = new Paragraph("                           prodavatelj                                                                                                                                   kupac\n\n");
            ispodCrtica.Font.Size = 8;
            dokument.Add(ispodCrtica);

            Paragraph potvrdaNaslov = new Paragraph("------------------------------------------------------------------------------POTVRDA");
            potvrdaNaslov.Font.Size = 20;
            dokument.Add(potvrdaNaslov);

            Paragraph potvrdaNaslov2 = new Paragraph(" da je kupac od prodavatelja na mjestu  " + tvrtka.adresa + ", datuma " + DateTime.Now.ToShortDateString() + " preuzeo :");
            potvrdaNaslov2.Font.IsBold();
            dokument.Add(potvrdaNaslov2);

            Paragraph stvari = new Paragraph("Tri ključa,      Tablice \"ako ostaju na vozilu\",     Prometna dozvola,   Kupoprodajni ugovor,   Knjižica vozila", f);
            dokument.Add(stvari);
            dokument.Add(crtice);
            dokument.Add(ispodCrtica);

            dokument.Close();



        }
        /// <summary>
        /// Metoda koja kreira kupoprodajni ugovor od dobavljača te generira pdf iz njih.
        /// Na temelju zadanih parametara vozilo,kupac i ugovor popunjava template ugovora
        /// </summary>
        /// <param name="vozilo"></param>
        /// <param name="dobavljac"></param>
        /// <param name="ugovor"></param>
        public static void KupoprodajniUgovorOdDobavljaca(vozilo vozilo, dobavljac dobavljac, ugovor ugovor)
        {

            string FONT = "c:/windows/fonts/arial.ttf";
            BaseFont bf = BaseFont.CreateFont(FONT, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font f = new Font(bf, 12, Font.NORMAL);



            Tvrtka tvrtka = new Tvrtka();



            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            string[] polje = userName.Split('\\');
            userName = polje[1];

            string FolderMjesto = @"C:/Users/" + userName + "/DriveIT/DobavljaciUgovori";

            bool isExists = System.IO.Directory.Exists(FolderMjesto);
            if (!isExists)
                System.IO.Directory.CreateDirectory(FolderMjesto);

            Document dokument = new Document(iTextSharp.text.PageSize.A4);
            string parameter = FolderMjesto+"/Ugovor_" + ugovor.id_ugovor.ToString() + "_" + dobavljac.tvrtka.ToString() + "_" + dobavljac.ime.ToString() + ".pdf";
            PdfWriter wri = PdfWriter.GetInstance(dokument, new FileStream(parameter, FileMode.Create));

            dokument.Open();

            Paragraph prodavatelj = new Paragraph("PRODAVATELJ:  " + dobavljac.ime.ToString() + "  " + dobavljac.prezime.ToString() + "  " + dobavljac.tvrtka.ToString() + ",  " + dobavljac.adresa.ToString() + "\n", f);
            //Paragraph prodavatelj = new Paragraph("PRODAVATELJ:  " + tvrtka.imeTvrtke + ",  " + tvrtka.adresa + "\n");
            prodavatelj.Font.IsBold();
            dokument.Add(prodavatelj);


            Paragraph oKupcu = new Paragraph("KUPAC:  " + tvrtka.imeTvrtke + " " + tvrtka.adresa + "\nZaključili su u " + tvrtka.adresa + ",  " + ugovor.datum.ToShortDateString() + " godine ovaj:\n", f);
            oKupcu.Font.IsBold();
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
            PdfPCell celija17 = new PdfPCell(new Phrase(vozilo.model_vozila1.marka_vozila1.drzava.ToString()));
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
            PdfPCell celija23 = new PdfPCell(new Phrase(vozilo.datum_prve_registracije.Value.ToShortDateString()));
            tablica1.AddCell(celija23);

            PdfPCell celija24 = new PdfPCell(new Phrase("Snaga motora u kW"));
            tablica1.AddCell(celija24);
            PdfPCell celija25 = new PdfPCell(new Phrase(vozilo.snaga_kw.ToString()));
            tablica1.AddCell(celija25);

            PdfPCell celija26 = new PdfPCell(new Phrase("Nosivost"));
            tablica1.AddCell(celija26);
            PdfPCell celija27 = new PdfPCell(new Phrase(vozilo.nosivost.ToString()));
            tablica1.AddCell(celija27);


            dokument.Add(tablica1);

            Paragraph cijena = new Paragraph("2. Prodajna cijena ugovorena je u uznosu od " + vozilo.cijena.prodajna_sa_pdv.ToString() + " kn\nOd toga je poreza na dodatnu vrijednost (PDV): " + vozilo.cijena.porez.ToString()+" kn\n");
            //Paragraph cijena = new Paragraph("2. Prodajna cijena ugovorena je u uznosu od " + "12545" + " kn\nOd toga je poreza na dodatnu vrijednost (PDV): " + "2500" + " kn\n");
            dokument.Add(cijena);

            Paragraph ostatak = new Paragraph("3. Prodavatelj jamči da je vozilo njegovo vlasništvo, a kupac nakon što je pregledao vozilo nema prigovora u svezi kvalitete i prodajne cijene.\n\n4. Porez i ostale troškove snosi KUPAC\n\n5. Prodavatelj i kupac prihvaćaju prava i obveze ovog ugovora, a za slučaj spora nadležan je sud u Ljubuškom.\n6.Napomena..................................................................................................\n\n", f);
            dokument.Add(ostatak);


            Paragraph primjerci = new Paragraph("Prije potpisivanja ugovora isprintajte tri primjerka ovog ugovora.\nNakon toga kupac i prodavatelj potpisat će vlastoručno svaki list posebno\n\n", f);
            dokument.Add(primjerci);

            Paragraph crtice = new Paragraph(".....................................................                                       ...............................................\n");
            dokument.Add(crtice);
            Paragraph ispodCrtica = new Paragraph("                           prodavatelj                                                                                                                                   kupac\n\n");
            ispodCrtica.Font.Size = 8;
            dokument.Add(ispodCrtica);

            Paragraph potvrdaNaslov = new Paragraph("------------------------------------------------------------------------------POTVRDA");
            potvrdaNaslov.Font.Size = 20;
            dokument.Add(potvrdaNaslov);

            Paragraph potvrdaNaslov2 = new Paragraph(" da je kupac od prodavatelja na mjestu  " + tvrtka.adresa + ", datuma " + DateTime.Now.ToShortDateString() + " preuzeo :");
            potvrdaNaslov2.Font.IsBold();
            dokument.Add(potvrdaNaslov2);

            Paragraph stvari = new Paragraph("Tri ključa,      Tablice \"ako ostaju na vozilu\",     Prometna dozvola,   Kupoprodajni ugovor,   Knjižica vozila", f);
            dokument.Add(stvari);
            dokument.Add(crtice);
            dokument.Add(ispodCrtica);

            dokument.Close();



        }


        /// <summary>
        /// Metoda koja kreira predračun te popunjava template na temelju parametara koje prima.
        /// Kao parametre prima vozilo i kupca koji kupuje vozilo
        /// </summary>
        /// <param name="vozilo"></param>
        /// <param name="kupac"></param>
        public static void KreirajPredracun(vozilo vozilo, kupac kupac)
        {
            string FONT = "c:/windows/fonts/arial.ttf";
            BaseFont bf = BaseFont.CreateFont(FONT, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font f = new Font(bf, 12, Font.NORMAL);



            Tvrtka tvrtka = new Tvrtka();

            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            string[] polje = userName.Split('\\');
            userName = polje[1];

            string FolderMjesto = @"C:/Users/" + userName + "/DriveIT/Racuni";

            bool isExists = System.IO.Directory.Exists(FolderMjesto);
            if (!isExists)
                System.IO.Directory.CreateDirectory(FolderMjesto);

            Document dokument = new Document(iTextSharp.text.PageSize.A4);
            string parameter = FolderMjesto+"/Racun_" + vozilo.id_vozilo.ToString() + "_" + kupac.tvrtka.ToString() + "_" + kupac.ime.ToString() + ".pdf";
            PdfWriter wri = PdfWriter.GetInstance(dokument, new FileStream(parameter, FileMode.Create));

            dokument.Open();

            Paragraph opisTvrtke = new Paragraph(tvrtka.imeTvrtke + "\n" + tvrtka.adresa + "\n" + tvrtka.telefon + "\n" + tvrtka.faks + "\n" + tvrtka.email, f);
            dokument.Add(opisTvrtke);

            Paragraph oKupcu = new Paragraph(kupac.ime.ToString() + " " + kupac.prezime.ToString() + " " + kupac.tvrtka.ToString() + "\n" + kupac.adresa.ToString() + "\n" + kupac.telefon.ToString() + "\n" + kupac.faks.ToString() + "\n" + kupac.email.ToString() + "\n", f);
            oKupcu.Alignment = Element.ALIGN_RIGHT;
            dokument.Add(oKupcu);


            Paragraph naslov = new Paragraph("RAČUN  " + vozilo.id_vozilo.ToString() + "\n", f);
            naslov.Font.Size = 20;
            naslov.Alignment = Element.ALIGN_CENTER;
            dokument.Add(naslov);

            Paragraph datum = new Paragraph(DateTime.Now.ToString("dd.MM.yyyy. HH:mm:ss"));
            dokument.Add(datum);

            PdfPTable tablica1 = new PdfPTable(3);
            float[] widths = new float[] { 1f, 10f, 2f };
            tablica1.SetWidths(widths);

            tablica1.TotalWidth = 520f;

            tablica1.LockedWidth = true;
            tablica1.HorizontalAlignment = 0;
            tablica1.SpacingBefore = 20f;
            tablica1.SpacingAfter = 30f;

            PdfPCell celija1 = new PdfPCell(new Phrase("ID"));
            tablica1.AddCell(celija1);
            PdfPCell celija2 = new PdfPCell(new Phrase("Opis"));
            tablica1.AddCell(celija2);
            PdfPCell celija3 = new PdfPCell(new Phrase("Iznos"));
            tablica1.AddCell(celija3);

            PdfPCell celija4 = new PdfPCell(new Phrase(vozilo.id_vozilo.ToString()));
            tablica1.AddCell(celija4);
            PdfPCell celija5 = new PdfPCell(new Phrase(vozilo.model_vozila1.marka_vozila1.naziv.ToString() + "  " + vozilo.model_vozila1.naziv.ToString() + " " + vozilo.godina_proizvodnje.ToString()));
            tablica1.AddCell(celija5);
            PdfPCell celija6 = new PdfPCell(new Phrase(vozilo.cijena.prodajna_sa_pdv.ToString()));
            tablica1.AddCell(celija6);

            PdfPCell celija7 = new PdfPCell(new Phrase(""));
            tablica1.AddCell(celija7);
            PdfPCell celija8 = new PdfPCell(new Phrase("Iznos poreza:"));
            tablica1.AddCell(celija8);
            PdfPCell celija9 = new PdfPCell(new Phrase(vozilo.cijena.porez.ToString()));
            tablica1.AddCell(celija9);

            dokument.Add(tablica1);

            Paragraph crtice = new Paragraph("\n\n\n\n\n             .....................................................                                   ...............................................\n");
            dokument.Add(crtice);
            Paragraph ispodCrtica = new Paragraph("                                             prodavatelj                                                                                                                      kupac\n\n");
            ispodCrtica.Font.Size = 8;
            dokument.Add(ispodCrtica);



            dokument.Close();


        }
    }
}
