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
    public class UslugaProizvod
    {
        #region Properties

        public int Id { get; set; }
        public string UslugaIliProizvod { get; set; }
        public string JedinicaMjere { get; set; }
        public int Kolicina { get; set; }
        public double Cijena { get; set; }
        public double Iznos { get; set; }
        public int Rabat { get; set; }
        public int RacunId { get; set; }

        #endregion

        #region GetData

        public UslugaProizvod GetData(object criteria)
        {
            using (SQLiteConnection cn = new SQLiteConnection(Helpers.SqLite.DBConnectionString))
            {
                cn.Open();
                ExecuteFetch(cn, criteria);
                cn.Close();
            }
            return this;
        }

        public void GetDataReader(Helpers.SafeDataReader dr)
        {
            Id = dr.GetInt32("Id");
            UslugaIliProizvod = dr.GetString("UslugaIliProizvod");
            JedinicaMjere = dr.GetString("JedinicaMjere");
            Kolicina= dr.GetInt32("Kolicina");
            Cijena = dr.GetDouble("Cijena");
            Iznos = dr.GetDouble("Iznos");
            Rabat = dr.GetInt32("Rabat");
            RacunId = dr.GetInt32("RacunId");
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
                cm.CommandText = String.Format("SELECT * FROM UslugaProizvod WHERE Id={0}", (int)criteria);
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
                cm.CommandText = @"INSERT INTO UslugaProizvod (
								UslugaIliProizvod,
                                JedinicaMjere,
								Kolicina,
								Cijena,
								Iznos,
								Rabat,
                                RacunId
							) VALUES (
								@UslugaIliProizvod,
                                @JedinicaMjere,
								@Kolicina,
								@Cijena,
								@Iznos,
								@Rabat,
                                @RacunId
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
                cm.CommandText = @"UPDATE UslugaProizvod SET
								UslugaIliProizvod=@UslugaIliProizvod,
                                JedinicaMjere=@JedinicaMjere,
								Kolicina=@Kolicina,
								Cijena=@Cijena,
								Iznos=@Iznos,
								Rabat=@Rabat,
                                RacunId=@RacunId WHERE Id=@Id;";

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
                cm.CommandText = string.Format(@"DELETE FROM UslugaProizvod WHERE Id={0};", (int)criteria);

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

            cm.Parameters.Add("@UslugaIliProizvod", DbType.String, 512);
            cm.Parameters["@UslugaIliProizvod"].Value = UslugaIliProizvod;

            cm.Parameters.Add("@JedinicaMjere", DbType.String, 512);
            cm.Parameters["@JedinicaMjere"].Value = JedinicaMjere;

            cm.Parameters.Add("@Kolicina", DbType.Int32, 512);
            cm.Parameters["@Kolicina"].Value = Kolicina;

            cm.Parameters.Add("@Cijena", DbType.Double, 512);
            cm.Parameters["@Cijena"].Value = Cijena;

            cm.Parameters.Add("@Iznos", DbType.Double, 512);
            cm.Parameters["@Iznos"].Value = Iznos;

            cm.Parameters.Add("@Rabat", DbType.Int32, 512);
            cm.Parameters["@Rabat"].Value = Rabat;

            cm.Parameters.Add("@RacunId", DbType.Int32, 512);
            cm.Parameters["@RacunId"].Value = RacunId;
        }

#endregion

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public partial class UslugaProizvodList : CollectionBase
    {
        public UslugaProizvod this[int idx]
        {
            get
            {
                return (UslugaProizvod)this.InnerList[idx];
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {

            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public UslugaProizvodList GetData(object criteria)
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
                cm.CommandText = "SELECT * FROM UslugaProizvod";
                if (criteria != null)
                {
                    cm.CommandText += " WHERE " + criteria;
                }

                using (Helpers.SafeDataReader dr = new Helpers.SafeDataReader(cm.ExecuteReader()))
                {
                    InnerList.Clear();
                    while (dr.Read())
                    {
                        UslugaProizvod item = new UslugaProizvod();
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
