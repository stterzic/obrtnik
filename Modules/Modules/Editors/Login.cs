using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;
using Finisar.SQLite;
using Microsoft.Win32;
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
            try
            {
                string username = Registry.GetValue(@"HKEY_CURRENT_USER\Obrtnik Username", "Obrtnik Username", "NULL").ToString();
                string password = Registry.GetValue(@"HKEY_CURRENT_USER\Obrtnik Password", "Obrtnik Password", "NULL").ToString();
                txtUsername.Text = username;
                txtPassword.Text = password;
            }
            catch (Exception)
            { }
            
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
                    user.GetData(txtUsername.Text);
                    Library.Helpers.Common.User = user;
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
                sqlite_cmd.CommandText = "CREATE TABLE Users (Id INTEGER PRIMARY KEY, Username VARCHAR(100), Password VARCHAR(100));";
                sqlite_cmd.ExecuteNonQuery();

                //Tablica o obrtu
                sqlite_cmd.CommandText = "CREATE TABLE Obrt (Id INTEGER PRIMARY KEY,NazivObrta VARCHAR(100), Vlasnik VARCHAR(100)," +
                    "Adresa VARCHAR(100),OIB VARCHAR(100),IBAN VARCHAR(100),Banka VARCHAR(100),Djelatnost VARCHAR(512), Logo BLOB);";
                sqlite_cmd.ExecuteNonQuery();

                //Tablica usluga
                sqlite_cmd.CommandText = "CREATE TABLE Usluge (Id INTEGER PRIMARY KEY, Naziv VARCHAR(512));";
                sqlite_cmd.ExecuteNonQuery();

                //Tablica Proizvoda
                sqlite_cmd.CommandText = "CREATE TABLE Proizvodi (Id INTEGER PRIMARY KEY, Naziv VARCHAR(512));";
                sqlite_cmd.ExecuteNonQuery();

                //Tablica jedinica mjere
                sqlite_cmd.CommandText = "CREATE TABLE JedinicaMjere (Id INTEGER PRIMARY KEY, Naziv VARCHAR(512));";
                sqlite_cmd.ExecuteNonQuery();

                //Tablica Zakoni
                sqlite_cmd.CommandText = "CREATE TABLE Zakoni (Id INTEGER PRIMARY KEY, Naziv VARCHAR(512), Napomena VARCHAR(512));";
                sqlite_cmd.ExecuteNonQuery();

                //Tablica racun
                sqlite_cmd.CommandText = "CREATE TABLE Racuni (Id INTEGER PRIMARY KEY, KupacNaziv VARCHAR(512), Adresa VARCHAR(512)," +
                    "Mjesto VARCHAR(512), OibKupca VARCHAR(512), NadnevakIzdavanjaRacuna DATETIME, DatumPredvideneIsporuke DATETIME," +
                    "VrijemeIzrade DATETIME, DospijecePlacanja DATETIME, Napomena VARCHAR(512), IznosNaplacenGotovinom DECIMAL(10,2)," +
                    "IznosNaplacenVirmanski DECIMAL(10,2), BrojIzvodaUplatnice INTEGER, NadnevakDatumUplate DATETIME);";
                sqlite_cmd.ExecuteNonQuery();

                //Tablica uslugaProizvod
                sqlite_cmd.CommandText = "CREATE TABLE UslugaProizvod (Id INTEGER PRIMARY KEY, UslugaIliProizvod VARCHAR(512), JedinicaMjere VARCHAR(512)," +
                    "Kolicina INTEGER, Cijena DECIMAL(10,2), Iznos DECIMAL(10,2), Rabat INTEGER, RacunId INTEGER);";
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
                sqlite_cmd.CommandText = "INSERT INTO Zakoni (Naziv, Napomena) VALUES ('Usluge za domaće klijente', 'Oslobođeno PDV-a temeljem članka 90. Zakona o PDV-u');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO Zakoni (Naziv, Napomena) VALUES ('Usluge za inozemne klijente', 'Oslobođeno PDV-a temeljem članka 17.točka 1 Zakona o PDV-u - reverse charge');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO Zakoni (Naziv, Napomena) VALUES ('Roba za domaće klijente', 'Oslobođeno PDV-a temeljem članka 90. Zakona o PDV-u');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "INSERT INTO Zakoni (Naziv, Napomena) VALUES ('Roba za inozemne klijente', 'Oslobođeno PDV-a temeljem članka 90. Zakona o PDV-u');";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_conn.Close();

                Library.Helpers.SqLite.DBConnectionString = "Data Source=ObrtnikDatabase.db;Version=3;New=false;Compress=True;";

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            try
            {
                sqlite_conn = new SQLiteConnection("Data Source=ObrtnikDatabase.db;Version=3;New=false;Compress=True;");
                sqlite_conn.Open();
                Library.Helpers.SqLite.DBConnectionString = "Data Source=ObrtnikDatabase.db;Version=3;New=false;Compress=True;";
                sqlite_conn.Close();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Baza nije kreirana, molimo kreirajte bazu i usera!", "Greška", MessageBoxButtons.OK);
                return;
            }

            Library.User user = new Library.User();
            if (user.CheckIfExist(txtUsername.Text))
            {                
                user.GetData(txtUsername.Text);
                Library.Helpers.Common.User = user;

                Microsoft.Win32.RegistryKey username;
                username = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Obrtnik Username");
                username.SetValue("Obrtnik Username", txtUsername.Text);
                username.Close();

                Microsoft.Win32.RegistryKey password;
                password = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Obrtnik Password");
                password.SetValue("Obrtnik Password", txtPassword.Text);
                password.Close();

                this.Close();
            }
            else
            {                
                XtraMessageBox.Show("Korisnik sa tim podacima nije pronađen!", "Greška", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
