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
    public partial class Proizvodi
    {
        #region Public Properties

        public int Id { get; set; }
        public string Naziv { get; set; }

        #endregion

        public bool CheckIfExist(string naziv)
        {
            string rez = "";
            using (SQLiteConnection cn = new SQLiteConnection(Helpers.SqLite.DBConnectionString))
            {
                cn.Open();
                using (SQLiteCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.Text;
                    cm.CommandText = String.Format("SELECT Id FROM Proizvodi WHERE Naziv='{0}';", naziv);
                    object res = cm.ExecuteScalar();
                    if (res != null && !(res is DBNull))
                        rez = cm.ExecuteScalar().ToString();
                }
                cn.Close();
            }
            if (rez != "")
                return true;
            else
                return false;
        }

        #region GetData

        public Proizvodi GetData(object criteria)
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
            Naziv = dr.GetString("Naziv");
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
                cm.CommandText = String.Format("SELECT * FROM Proizvodi WHERE Id='{0}'", (string)criteria);
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
                cm.CommandText = @"INSERT INTO Proizvodi (
								Naziv
							) VALUES (
								@Naziv
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
                cm.CommandText = @"UPDATE Proizvodi SET
								Naziv@Naziv WHERE Id=@Id;";

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
                cm.CommandText = string.Format(@"DELETE FROM Proizvodi WHERE Id={0};", (int)criteria);

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

            cm.Parameters.Add("@Naziv", DbType.String, 512);
            cm.Parameters["@Naziv"].Value = Naziv;
        }

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public partial class ProizvodiList : CollectionBase
    {
        public Proizvodi this[int idx]
        {
            get
            {
                return (Proizvodi)this.InnerList[idx];
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {

            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public ProizvodiList GetData(object criteria)
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
                cm.CommandText = "SELECT * FROM Proizvodi";
                if (criteria != null)
                {
                    cm.CommandText += " WHERE " + criteria;
                }

                using (Helpers.SafeDataReader dr = new Helpers.SafeDataReader(cm.ExecuteReader()))
                {
                    InnerList.Clear();
                    while (dr.Read())
                    {
                        Proizvodi item = new Proizvodi();
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
