using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finisar.SQLite;

namespace Library
{
    public partial class User
    {
        #region Public Properties

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        #endregion

        #region Get Methods

        public bool CheckIfExist(string korisnickoIme)
        {
            string rez = "";
            using (SQLiteConnection cn = new SQLiteConnection(Helpers.SqLite.DBConnectionString))
            {
                cn.Open();
                using (SQLiteCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.Text;
                    cm.CommandText = String.Format("SELECT Username FROM Users WHERE Username='{0}';", korisnickoIme);
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
            Id = dr.GetInt32("ROWID");
            Username = dr.GetString("Username");
            Password = dr.GetString("Password");
        }

        #endregion

        #region Executes

        private void ExecuteFetch(SQLiteConnection cn, object criteria)
        {
            using (SQLiteCommand cm = cn.CreateCommand())
            {
                cm.CommandText = String.Format("SELECT * FROM Users WHERE Username='{0}'", (string)criteria);
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

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
