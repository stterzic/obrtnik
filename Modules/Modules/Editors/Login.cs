using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;
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
                        
            try
            {
                sqlite_conn = new SQLiteConnection("Data Source=ObrtnikDatabase.db;Version=3;New=false;Compress=True;");
                sqlite_conn.Open();
                Library.Helpers.SqLite.DBConnectionString = "Data Source=ObrtnikDatabase.db;Version=3;New=false;Compress=True;";
                Library.User user = new Library.User();
                if (!user.CheckIfExist(txtUsername.Text))
                {
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    //Unos novoga Korisnika
                    sqlite_cmd.CommandText = "INSERT INTO Users (Username, Password) VALUES ('" + txtUsername.Text + "', '" + txtPassword.Text + "');";
                    sqlite_cmd.ExecuteNonQuery();
                }
                else
                {
                    user.GetData(txtUsername.Text);
                    Library.Helpers.Common.User = user;
                    XtraMessageBox.Show("Korisnik sa tim imenom već postoji, logiramo se s njime!", "Greška", MessageBoxButtons.OK);
                }
                sqlite_conn.Close();
                this.Close();
            }
            catch (Exception)
            {
                sqlite_conn = new SQLiteConnection("Data Source=ObrtnikDatabase.db;Version=3;New=True;Compress=True;");
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();

                //Kreiranje tablica
                //Tablica korisnika
                sqlite_cmd.CommandText = "CREATE TABLE Users (Username varchar(100), Password varchar(100));";
                sqlite_cmd.ExecuteNonQuery();

                //Tablica o obrtu
                sqlite_cmd.CommandText = "CREATE TABLE Obrt (NazivObrta varchar(100), Vlasnik varchar(100)," +
                    "Adresa varchar(100),OIB varchar(100),IBAN varchar(100),Banka varchar(100),Djelatnost varchar(512), Logo BLOB);";
                sqlite_cmd.ExecuteNonQuery();

                //Tablica usluga
                sqlite_cmd.CommandText = "CREATE TABLE Usluge (Naziv varchar(512));";
                sqlite_cmd.ExecuteNonQuery();

                //Tablica Proizvoda
                sqlite_cmd.CommandText = "CREATE TABLE Proizvodi (Naziv varchar(512));";
                sqlite_cmd.ExecuteNonQuery();

                //Tablica jedinica mjere
                sqlite_cmd.CommandText = "CREATE TABLE JedinicaMjere (Naziv varchar(512));";
                sqlite_cmd.ExecuteNonQuery();

                //Tablica Zakoni
                sqlite_cmd.CommandText = "CREATE TABLE Zakoni (Naziv varchar(512), Napomena varchar(512));";
                sqlite_cmd.ExecuteNonQuery();
                
                //Popunjavanje tablica
                //Popunjavanje tablice sa korisnikom
                sqlite_cmd.CommandText = "INSERT INTO Users (Username, Password) VALUES ('" + txtUsername.Text + "', '" + txtPassword.Text + "');";
                sqlite_cmd.ExecuteNonQuery();


                //Popunjavanje tablice sa mjernim jedinicama
                sqlite_cmd.CommandText = "INSERT INTO JedinicaMjere (Naziv) VALUES ('kg');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO JedinicaMjere (Naziv) VALUES ('kom');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO JedinicaMjere (Naziv) VALUES ('l');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO JedinicaMjere (Naziv) VALUES ('sat');";
                sqlite_cmd.ExecuteNonQuery();

                //Popunjavanje tablice sa zakonima
                sqlite_cmd.CommandText = "INSERT INTO Zakoni (Username, Password) VALUES ('Usluge za domaće klijente', 'Oslobođeno PDV-a temeljem članka 90. Zakona o PDV-u');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO Zakoni (Username, Password) VALUES ('Usluge za inozemne klijente', 'Oslobođeno PDV-a temeljem članka 17.točka 1 Zakona o PDV-u - reverse charge');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO Zakoni (Username, Password) VALUES ('Roba za domaće klijente', 'Oslobođeno PDV-a temeljem članka 90. Zakona o PDV-u');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO Zakoni (Username, Password) VALUES ('Roba za inozemne klijente', 'Oslobođeno PDV-a temeljem članka 90. Zakona o PDV-u');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_conn.Close();

                //Auto login
                Library.User user = new Library.User();
                if (user.CheckIfExist(txtUsername.Text))
                {
                    user.GetData(txtUsername.Text);
                    Library.Helpers.Common.User = user;
                }
                this.Close();
            }
            

            
        }
    }
}
