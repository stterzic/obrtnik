using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Utils
{
    public class Racun
    {
        public static XtraReport ShowRacun(int id)
        {
            Reports.Racun report = new Reports.Racun();

            Library.Prihodi prihodi = new Library.Prihodi().GetData(id);

            Library.Obrt obrt = new Library.Obrt().GetData(null);

            report.xrLogo.Image = ByteToImage(obrt.Logo);
            report.xrRacunBroj.Text = prihodi.Id.ToString();
            report.xrNazivKupca.Text = prihodi.KupacNaziv;
            report.xrAdresa.Text = prihodi.Adresa;
            report.xrMjesto.Text = prihodi.Mjesto;
            report.xrOib.Text = prihodi.OibKupca;

            report.xrMjestoDatumVrijeme.Text = prihodi.Mjesto + ", " + prihodi.NadnevakIzdavanjaRacuna.ToString();

            report.xrDospjecePlacanja.Text = prihodi.DospijecePlacanja.ToString();
            report.xrDatumIsporuke.Text = prihodi.DatumPredvideneIsporuke.ToString();

            Library.UslugaProizvodList items = new Library.UslugaProizvodList().GetData("RacunId=" + id);

            report.DataSource = items;
            report.xrTrgovackiNazivUslugeProizvodi.DataBindings.Add("Text", items, "UslugaIliProizvod");
            report.xrJedinicaMjere.DataBindings.Add("Text", items, "JedinicaMjere");
            report.xrKolicina.DataBindings.Add("Text", items, "Kolicina");
            report.xrCijena.DataBindings.Add("Text", items + " kn", "Cijena");
            report.xrIznos.DataBindings.Add("Text", items + " kn", "Iznos");
            report.xrRabat.DataBindings.Add("Text", items + " %", "Rabat");

            double ukupno = 0;
            foreach(Library.UslugaProizvod item in items)
            {
                ukupno = ukupno + item.Iznos;
            }
            report.xrUkIznos.Text = ukupno.ToString()+" kn";
            report.xrUkRabat.Text = "0.00 kn";
            report.xrUkOsnovica.Text = ukupno.ToString() + " kn";
            report.xrUkPdv.Text = "0.00 kn";
            report.xrUkupno.Text = ukupno.ToString() + " kn";

            report.xrZakon.Text = prihodi.Napomena;
            report.xrRacunIspostavio.Text = obrt.Vlasnik;
            report.xrNacinPlacanja.Text = "Transakcijski račun";
            report.xrPozivNaBroj.Text = "1";

            report.xrVlasnikOibZiroRacunIbanBanka.Text = obrt.Vlasnik + ", " + obrt.Oib + ", Žiro račun " + obrt.Iban + " otvoren u " + obrt.Banka;

            return report;
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
    }
}
