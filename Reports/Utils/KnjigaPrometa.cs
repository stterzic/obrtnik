using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Utils
{
    public class KnjigaPrometa
    {
        public static XtraReport ShowKnjigaPrometa()
        {
            Reports.KnjigaPrometa report = new Reports.KnjigaPrometa();

            Library.Obrt obrt = new Library.Obrt().GetData(null);

            report.xrNazivDjelatnosti.Text = obrt.Djelatnost;
            report.xrImePrezimePoduzetnika.Text = obrt.Vlasnik;
            report.xrAdresaPrebivalistaBoravista.Text = obrt.Adresa;
            report.xrOibPoduzetnika.Text = obrt.Oib;
            report.xrPodaciOPoslovnojJediniciNaziv.Text = obrt.NazivObrta;
            report.xrPodaciOPoslovnojJediniciAdresa.Text = obrt.Adresa;
            
            Library.PrihodiList prihodi = new Library.PrihodiList().GetData(null);
            report.DataSource = prihodi;
            report.xrNadnevak.DataBindings.Add("Text", prihodi, "NadnevakIzdavanjaRacuna");
            report.xrBrojIspravePrometa.DataBindings.Add("Text", prihodi, "BrojIzvodaUplatnice");
            report.xrOpisIspravaOPrimicima.DataBindings.Add("Text", prihodi, "Id");
            report.xrIznosNaplacenUGotovini.DataBindings.Add("Text", prihodi, "IznosNaplacenGotovinom");
            report.xrIznosNaplacenVirmanski.DataBindings.Add("Text", prihodi, "IznosNaplacenVirmanski");
            report.xrIznosUkupno.DataBindings.Add("Text", prihodi, "Ukupno");

            decimal ukupnoVirmanski = 0;
            foreach(Library.Prihodi item in prihodi)
            {
                ukupnoVirmanski = ukupnoVirmanski + item.IznosNaplacenVirmanski;
            }

            decimal ukupnoGotovinom = 0;
            foreach (Library.Prihodi item in prihodi)
            {
                ukupnoGotovinom = ukupnoGotovinom + item.IznosNaplacenGotovinom;
            }

            report.xrUkupnoGotovina.Text = ukupnoGotovinom.ToString();
            report.xrUkupnoVirmanski.Text = ukupnoVirmanski.ToString();

            report.xrUkupno.Text = (ukupnoGotovinom + ukupnoVirmanski).ToString();

            return report;
        }
    }
}
