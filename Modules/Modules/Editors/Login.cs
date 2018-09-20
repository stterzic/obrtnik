using Finisar.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace Modules.Editors
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;
            SQLiteDataReader sqlite_datareader;

            sqlite_conn = new SQLiteConnection("Data Source=ObrtnikDatabase.db;Version=3;New=True;Compress=True;");
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "CREATE TABLE Users (Id INTEGER PRIMARY KEY AUTOINCREMENT, Username varchar(100), Password varchar(100));";
            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = "INSERT INTO test (Username, Password) VALUES ('"+txtUsername+"', '"+txtPassword+"');";
        }
    }
}
