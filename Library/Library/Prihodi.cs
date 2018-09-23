using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public partial class Prihodi
    {
        #region Public Properties

        public int Id { get; set; }
        public string KupacNaziv { get; set; }
        public string Adresa { get; set; }
        public string Mjesto { get; set; }
        public string OibKupca { get; set; }
        public DateTime NadnevakIzdavanjaRacuna { get; set; }
        public DateTime DatumPredvideneIsporuke { get; set; }
        public DateTime VrijemeIzrade { get; set; }
        public DateTime DospijećePlacanja { get; set; }
        public string UslugaIliProizvod { get; set; }
        public string JedinicaMjere { get; set; }
        public int Kolicina { get; set; }
        public string Cijena { get; set; }
        public decimal Rabat { get; set; }
        public decimal Iznos { get; set; }
        public string Napomena { get; set; }
        public decimal IznosNaplacenGotovinom { get; set; }
        public decimal IznosNaplacenVirmanski { get; set; }
        public int BrojIzvodaUplatnice { get; set; }
        public DateTime NadnevakDatumUplate { get; set; }

        #endregion
    }
}
