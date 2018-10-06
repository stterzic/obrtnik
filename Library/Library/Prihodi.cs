using Finisar.SQLite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public DateTime DospijecePlacanja { get; set; }
        public string UslugaIliProizvod { get; set; }
        public string JedinicaMjere { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public int Rabat { get; set; }
        public decimal Iznos { get; set; }
        public string Napomena { get; set; }
        public decimal IznosNaplacenGotovinom { get; set; }
        public decimal IznosNaplacenVirmanski { get; set; }
        public int BrojIzvodaUplatnice { get; set; }
        public DateTime NadnevakDatumUplate { get; set; }

        #endregion


        #region GetData

        public Prihodi GetData(object criteria)
        {
            using (SQLiteConnection cn = new SQLiteConnection(Helpers.SqLite.DBConnectionString))
            {
                cn.Open();
                ExecuteFetch(cn, criteria);
                cn.Close();
            }
            return this;
        }

        public int GetMaxId()
        {
            int rez = 0;
            using (SQLiteConnection cn = new SQLiteConnection(Helpers.SqLite.DBConnectionString))
            {
                cn.Open();
                using (SQLiteCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.Text;
                    cm.CommandText = String.Format("SELECT MAX(Id) FROM Racuni;");
                    object res = cm.ExecuteScalar();
                    if (res != null && !(res is DBNull))
                        rez = Convert.ToInt32(res);
                }
                cn.Close();
            }
            return rez;
        }

        public void GetDataReader(Helpers.SafeDataReader dr)
        {
            Id = dr.GetInt32("Id");
            KupacNaziv = dr.GetString("KupacNaziv");
            Adresa = dr.GetString("Adresa");
            Mjesto = dr.GetString("Mjesto");
            OibKupca = dr.GetString("OibKupca");
            NadnevakIzdavanjaRacuna = dr.GetDateTime("NadnevakIzdavanjaRacuna");
            DatumPredvideneIsporuke = dr.GetDateTime("DatumPredvideneIsporuke");
            VrijemeIzrade = dr.GetDateTime("VrijemeIzrade");
            DospijecePlacanja = dr.GetDateTime("DospijecePlacanja");
            Napomena = dr.GetString("Napomena");
            IznosNaplacenGotovinom = dr.GetDecimal("IznosNaplacenGotovinom");
            IznosNaplacenVirmanski = dr.GetDecimal("IznosNaplacenVirmanski");
            BrojIzvodaUplatnice = dr.GetInt32("BrojIzvodaUplatnice");
            NadnevakDatumUplate = dr.GetDateTime("NadnevakDatumUplate");
        }

        #endregion

        #region Executes

        public void InsertData()
        {
            using (SQLiteConnection cn = new SQLiteConnection(Helpers.SqLite.DBConnectionString))
            {
                cn.Open();
                ExecuteInsert(cn);
                cn.Close();
            }
        }

        public void UpdateData()
        {
            using (SQLiteConnection cn = new SQLiteConnection(Helpers.SqLite.DBConnectionString))
            {
                cn.Open();
                ExecuteUpdate(cn);
                cn.Close();
            }
        }

        public void DeleteData(object criteria)
        {
            using (SQLiteConnection cn = new SQLiteConnection(Helpers.SqLite.DBConnectionString))
            {
                cn.Open();
                ExecuteDelete(cn, criteria);
                cn.Close();
            }
        }

        private void ExecuteFetch(SQLiteConnection cn, object criteria)
        {
            using (SQLiteCommand cm = cn.CreateCommand())
            {
                cm.CommandText = String.Format("SELECT * FROM Racuni WHERE Id={0}", (int)criteria);
                cm.CommandType = CommandType.Text;
                using (Helpers.SafeDataReader dr = new Helpers.SafeDataReader(cm.ExecuteReader()))
                {
                    while (dr.Read())
                    {
                        GetDataReader(dr);
                    }
                }
            }
        }

        private void ExecuteInsert(SQLiteConnection cn)
        {
            using (SQLiteCommand cm = cn.CreateCommand())
            {
                cm.CommandType = CommandType.Text;
                cm.CommandText = @"INSERT INTO Racuni (
								KupacNaziv, 
								Adresa, 
								Mjesto,
                                OibKupca,
                                NadnevakIzdavanjaRacuna,
                                DatumPredvideneIsporuke,
                                VrijemeIzrade,
                                DospijecePlacanja,
                                Napomena,
                                IznosNaplacenGotovinom,
                                IznosNaplacenVirmanski,
                                BrojIzvodaUplatnice,
                                NadnevakDatumUplate
							) VALUES (
								@KupacNaziv, 
								@Adresa, 
								@Mjesto,
                                @OibKupca,
                                @NadnevakIzdavanjaRacuna,
                                @DatumPredvideneIsporuke,
                                @VrijemeIzrade,
                                @DospijecePlacanja,
                                @Napomena,
                                @IznosNaplacenGotovinom,
                                @IznosNaplacenVirmanski,
                                @BrojIzvodaUplatnice,
                                @NadnevakDatumUplate
							);";

                AddParameters(cm);
                cm.Prepare();
                cm.ExecuteNonQuery();
            }
        }

        private void ExecuteUpdate(SQLiteConnection cn)
        {
            using (SQLiteCommand cm = cn.CreateCommand())
            {
                cm.CommandType = CommandType.Text;
                cm.CommandText = @"UPDATE Racuni SET
								KupacNaziv=@KupacNaziv, 
								Adresa=@Adresa, 
								Mjesto=@Mjesto,
                                OibKupca=@OibKupca,
                                NadnevakIzdavanjaRacuna=@NadnevakIzdavanjaRacuna,
                                DatumPredvideneIsporuke=@DatumPredvideneIsporuke,
                                VrijemeIzrade=@VrijemeIzrade,
                                DospijecePlacanja=@DospijecePlacanja,
                                Napomena=@Napomena,
                                IznosNaplacenGotovinom=@IznosNaplacenGotovinom,
                                IznosNaplacenVirmanski=@IznosNaplacenVirmanski,
                                BrojIzvodaUplatnice=@BrojIzvodaUplatnice,
                                NadnevakDatumUplate=@NadnevakDatumUplate WHERE Id=@Id;";

                AddParameters(cm);
                cm.Prepare();
                cm.ExecuteNonQuery();
            }
        }

        private void ExecuteDelete(SQLiteConnection cn, object criteria)
        {
            using (SQLiteCommand cm = cn.CreateCommand())
            {
                cm.CommandType = CommandType.Text;
                cm.CommandText = string.Format(@"DELETE FROM Racuni WHERE Id={0};", (int)criteria);

                AddParameters(cm);
                cm.Prepare();
                cm.ExecuteNonQuery();
            }
        }

        private void AddParameters(SQLiteCommand cm)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@Id", DbType.Int32, 512);
            cm.Parameters["@Id"].Value = Id;

            cm.Parameters.Add("@KupacNaziv", DbType.String, 512);
            cm.Parameters["@KupacNaziv"].Value = KupacNaziv;

            cm.Parameters.Add("@Adresa", DbType.String, 512);
            cm.Parameters["@Adresa"].Value = Adresa;

            cm.Parameters.Add("@Mjesto", DbType.String, 512);
            cm.Parameters["@Mjesto"].Value = Mjesto;

            cm.Parameters.Add("@OibKupca", DbType.String, 512);
            cm.Parameters["@OibKupca"].Value = OibKupca;

            cm.Parameters.Add("@NadnevakIzdavanjaRacuna", DbType.DateTime, 512);
            cm.Parameters["@NadnevakIzdavanjaRacuna"].Value = NadnevakIzdavanjaRacuna;

            cm.Parameters.Add("@DatumPredvideneIsporuke", DbType.DateTime, 512);
            cm.Parameters["@DatumPredvideneIsporuke"].Value = DatumPredvideneIsporuke;

            cm.Parameters.Add("@VrijemeIzrade", DbType.DateTime, 512);
            cm.Parameters["@VrijemeIzrade"].Value = VrijemeIzrade;

            cm.Parameters.Add("@DospijecePlacanja", DbType.DateTime, 512);
            cm.Parameters["@DospijecePlacanja"].Value = DospijecePlacanja;

            cm.Parameters.Add("@Napomena", DbType.String, 512);
            cm.Parameters["@Napomena"].Value = Napomena;

            cm.Parameters.Add("@IznosNaplacenGotovinom", DbType.Decimal, 512);
            cm.Parameters["@IznosNaplacenGotovinom"].Value = IznosNaplacenGotovinom;

            cm.Parameters.Add("@IznosNaplacenVirmanski", DbType.Decimal, 512);
            cm.Parameters["@IznosNaplacenVirmanski"].Value = IznosNaplacenVirmanski;

            cm.Parameters.Add("@BrojIzvodaUplatnice", DbType.Int32, 512);
            cm.Parameters["@BrojIzvodaUplatnice"].Value = BrojIzvodaUplatnice;

            cm.Parameters.Add("@NadnevakDatumUplate", DbType.DateTime, 512);
            cm.Parameters["@NadnevakDatumUplate"].Value = NadnevakDatumUplate;
        }

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public partial class PrihodiList : CollectionBase
    {
        public Prihodi this[int idx]
        {
            get
            {
                return (Prihodi)this.InnerList[idx];
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {

            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public PrihodiList GetData(object criteria)
        {
            using (SQLiteConnection cn = new SQLiteConnection(Helpers.SqLite.DBConnectionString))
            {
                cn.Open();
                ExecuteFetch(cn, criteria);
                cn.Close();
            }
            return this;
        }

        void List_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(e.PropertyName);
        }

        private void ExecuteFetch(SQLiteConnection cn, object criteria)
        {
            using (SQLiteCommand cm = cn.CreateCommand())
            {

                cm.CommandType = CommandType.Text;
                cm.CommandText = "SELECT * FROM Racuni";
                if (criteria != null)
                {
                    cm.CommandText += " WHERE " + criteria;
                }

                using (Helpers.SafeDataReader dr = new Helpers.SafeDataReader(cm.ExecuteReader()))
                {
                    InnerList.Clear();
                    while (dr.Read())
                    {
                        Prihodi item = new Prihodi();
                        item.GetDataReader(dr);
                        InnerList.Add(item);
                        item.PropertyChanged += new PropertyChangedEventHandler(List_PropertyChanged);
                    }

                    dr.NextResult();
                }
            }
        }
    }
}
