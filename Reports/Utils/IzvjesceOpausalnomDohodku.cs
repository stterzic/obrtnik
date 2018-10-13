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
    public class IzvjesceOpausalnomDohodku
    {
        public static XtraReport ShowIzvjesceOpausalnomDohodku()
        {
            Reports.IzvjesceOPausalnomDohodku report = new Reports.IzvjesceOPausalnomDohodku();

            report.xrTNaslovPoSd.Text = "IZVJEŠĆE O PAUŠALNOM DOHOTKU OD SAMOSTALNE DJELATNOSTI I UPLAĆENOM PAUŠALNOM POREZU NA DOHODAK I PRIREZU POREZA NA DOHODAK U "+DateTime.Now.Year+". GODINI";

            Library.Obrt obrt = new Library.Obrt().GetData(null);
            
            report.xrImePrezime.Text = obrt.Vlasnik;
            report.xrOib.Text = obrt.Oib;
            report.xrAdresaPrebivalista.Text = obrt.Adresa;
            report.xrNazivVrstaDjelatnosti.Text = obrt.Djelatnost;

            Library.PrihodiList prihodiPrviKvartal = new Library.PrihodiList().GetData("NadnevakIzdavanjaRacuna BETWEEN '"+DateTime.Now.Year+ "-01-01 00:00:00' AND '" + DateTime.Now.Year + "-03-31 23:59:59'");
            Library.PrihodiList prihodiDrugiKvartal = new Library.PrihodiList().GetData("NadnevakIzdavanjaRacuna BETWEEN '" + DateTime.Now.Year + "-04-01 00:00:00' AND '" + DateTime.Now.Year + "-06-30 23:59:59'");
            Library.PrihodiList prihodiTreciKvartal = new Library.PrihodiList().GetData("NadnevakIzdavanjaRacuna BETWEEN '" + DateTime.Now.Year + "-07-01 00:00:00' AND '" + DateTime.Now.Year + "-09-30 23:59:59'");
            Library.PrihodiList prihodiCetvrtiKvartal = new Library.PrihodiList().GetData("NadnevakIzdavanjaRacuna BETWEEN '" + DateTime.Now.Year + "-10-01 00:00:00' AND '" + DateTime.Now.Year + "-12-31 23:59:59'");
                       
            decimal naplaceniPrimitciPrviKvartal = 0.00M;
            foreach (Library.Prihodi item in prihodiPrviKvartal)
            {
                naplaceniPrimitciPrviKvartal = naplaceniPrimitciPrviKvartal + item.IznosNaplacenVirmanski;
            }
            report.xrVirmanskiNaplacenoPrviKvartal.Text = naplaceniPrimitciPrviKvartal.ToString();
            report.xrUkupnoNaplaceniPrviKvartal.Text = naplaceniPrimitciPrviKvartal.ToString();

            decimal naplaceniPrimitciDrugiKvartal = 0.00M;
            foreach (Library.Prihodi item in prihodiDrugiKvartal)
            {
                naplaceniPrimitciDrugiKvartal = naplaceniPrimitciDrugiKvartal + item.IznosNaplacenVirmanski;
            }
            report.xrVirmanskiNaplacenoDrugiKvartal.Text = naplaceniPrimitciDrugiKvartal.ToString();
            report.xrUkupnoNaplaceniDrugiKvartal.Text = naplaceniPrimitciDrugiKvartal.ToString();

            decimal naplaceniPrimitciTreciKvartal = 0.00M;
            foreach (Library.Prihodi item in prihodiTreciKvartal)
            {
                naplaceniPrimitciTreciKvartal = naplaceniPrimitciTreciKvartal + item.IznosNaplacenVirmanski;
            }
            report.xrVirmanskiNaplacenoTreciKvartal.Text = naplaceniPrimitciTreciKvartal.ToString();
            report.xrUkupnoNaplaceniTreciKvartal.Text = naplaceniPrimitciTreciKvartal.ToString();

            decimal naplaceniPrimitciCetvrtiKvartal = 0.00M;
            foreach (Library.Prihodi item in prihodiCetvrtiKvartal)
            {
                naplaceniPrimitciCetvrtiKvartal = naplaceniPrimitciCetvrtiKvartal + item.IznosNaplacenVirmanski;
            }
            report.xrVirmanskiNaplacenoCetvrtiKvartal.Text = naplaceniPrimitciCetvrtiKvartal.ToString();
            report.xrUkupnoNaplaceniCetvrtiKvartal.Text = naplaceniPrimitciCetvrtiKvartal.ToString();

            decimal ukupnoNaplaceno = naplaceniPrimitciPrviKvartal + naplaceniPrimitciDrugiKvartal + naplaceniPrimitciTreciKvartal + naplaceniPrimitciCetvrtiKvartal;
            report.xrVirmanskiNaplacenoUkupno.Text = naplaceniPrimitciCetvrtiKvartal.ToString();
            report.xrUkupnoNaplaceniUkupno.Text = naplaceniPrimitciCetvrtiKvartal.ToString();

            return report;
        }
    }
}
