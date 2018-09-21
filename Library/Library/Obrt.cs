using Finisar.SQLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public partial class Obrt
    {
        #region Public Properties

        public int Id { get; set; }
        public string NazivObrta { get; set; }
        public string Vlasnik { get; set; }
        public string Adresa { get; set; }
        public string Oib { get; set; }
        public string Iban { get; set; }
        public string Banka { get; set; }
        public string Djelatnost { get; set; }
        public byte[] Logo = new byte[] { };

        #endregion
        
        #region GetData

        public void GetData(object criteria)
        {
            using (SQLiteConnection cn = new SQLiteConnection(Helpers.SqLite.DBConnectionString))
            {
                cn.Open();
                ExecuteFetch(cn, criteria);
                cn.Close();
            }
        }

        public void GetDataReader(Helpers.SafeDataReader dr)
        {
            Id = dr.GetInt32("Id");
            NazivObrta = dr.GetString("NazivObrta");
            Vlasnik = dr.GetString("Vlasnik");
            Adresa = dr.GetString("Adresa");
            Oib = dr.GetString("Oib");
            Iban = dr.GetString("Iban");
            Banka = dr.GetString("Banka");
            Djelatnost = dr.GetString("Djelatnost");
            Logo = (byte[])dr["Logo"];
        }

        #endregion

        #region Execute

        public void InsertData()
        {
            using (SQLiteConnection cn = new SQLiteConnection(Helpers.SqLite.DBConnectionString))
            {
                cn.Open();
                ExecuteInsert(cn);
                cn.Close();
            }
        }

        private void ExecuteFetch(SQLiteConnection cn, object criteria)
        {
            using (SQLiteCommand cm = cn.CreateCommand())
            {
                cm.CommandText = String.Format("SELECT * FROM Obrt WHERE Id=1", (int)criteria);
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
                cm.CommandText = @"INSERT INTO Obrt (
								NazivObrta,
                                Vlasnik,
                                Adresa,
                                Oib,
                                Iban,
                                Banka,
                                Djelatnost,
                                Logo
							) VALUES (
								@NazivObrta,
                                @Vlasnik,
                                @Adresa,
                                @Oib,
                                @Iban,
                                @Banka,
                                @Djelatnost,
                                @Logo
							);";

                AddParameters(cm);
                cm.Prepare();
                cm.ExecuteNonQuery();
            }
        }

        #endregion


        private void AddParameters(SQLiteCommand cm)
        {
            cm.Parameters.Add("@Id", DbType.Int32, Id);
            cm.Parameters["@Id"].Value = Id;

            cm.Parameters.Add("@NazivObrta", DbType.String, NazivObrta.Length);
            cm.Parameters["@NazivObrta"].Value = NazivObrta;

            cm.Parameters.Add("@Vlasnik", DbType.String, Vlasnik.Length);
            cm.Parameters["@Vlasnik"].Value = Vlasnik;

            cm.Parameters.Add("@Adresa", DbType.String, Adresa.Length);
            cm.Parameters["@Adresa"].Value = Adresa;

            cm.Parameters.Add("@Oib", DbType.String, Oib.Length);
            cm.Parameters["@Oib"].Value = Oib;

            cm.Parameters.Add("@Iban", DbType.String, Iban.Length);
            cm.Parameters["@Iban"].Value = Iban;

            cm.Parameters.Add("@Banka", DbType.String, Banka.Length);
            cm.Parameters["@Banka"].Value = Banka;

            cm.Parameters.Add("@Djelatnost", DbType.String, Djelatnost.Length);
            cm.Parameters["@Djelatnost"].Value = Djelatnost;

            cm.Parameters.Add("@Logo", DbType.Binary, Logo.Length);
            cm.Parameters["@Logo"].Value = File.ReadAllBytes(Logo.ToString());
        }
    }
}
