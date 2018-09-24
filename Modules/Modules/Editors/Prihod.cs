using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modules.Editors
{
    public partial class Prihod : Form
    {
        public Prihod()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            Dictionary<string, string> collection = new Dictionary<string, string>();
            foreach (Library.Usluge item in new Library.UslugeList().GetData(null))
            {
                collection.Add(item.Naziv,"Usluge");
            }
            foreach (Library.Proizvodi item in new Library.ProizvodiList().GetData(null))
            {
                collection.Add(item.Naziv,"Proizvodi");
            }

            lookUpEditUslugaProizvod.Properties.DataSource = collection;
        }

        public Prihod(int id)
        {
            InitializeComponent();
            LoadData(id);
        }
        public void LoadData(int id)
        {
            PrihodiBindingSource.DataSource = new Library.Prihodi().GetData(id);
            txtRacunBroj.Text = id.ToString();
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {            
            Library.Prihodi prihodi = new Library.Prihodi();
            prihodi.Adresa = txtAdresa.Text;
            prihodi.BrojIzvodaUplatnice = Convert.ToInt32(txtBrojIzvodaUputnice.Text);
            prihodi.Cijena = Convert.ToDecimal(txtCijena.Text);
            prihodi.DatumPredvideneIsporuke = Convert.ToDateTime(dateEditDatumPredvidjeneIsporuke.Text);
            prihodi.DospijecePlacanja = Convert.ToDateTime(dateEditDospjecePlacanja.Text);
            prihodi.Iznos = Convert.ToDecimal(txtIznos.Text);
            prihodi.IznosNaplacenGotovinom = Convert.ToDecimal(txtGotovina.Text);
            prihodi.IznosNaplacenVirmanski = Convert.ToDecimal(txtVirmanski.Text);
            prihodi.JedinicaMjere = lookUpEditJedinicaMjere.Text;
            prihodi.Kolicina = Convert.ToInt32(txtKolicina.Text);
            prihodi.KupacNaziv = txtKupacNaziv.Text;
            prihodi.Mjesto = txtMjesto.Text;
            prihodi.NadnevakDatumUplate = Convert.ToDateTime(dateEditNadnevakUplate.Text);
            prihodi.NadnevakIzdavanjaRacuna = Convert.ToDateTime(dateEditNadnevak.Text);
            prihodi.Napomena = lookUpEditNapomena.Text;
            prihodi.OibKupca = txtOibKupca.Text;
            prihodi.Rabat = Convert.ToInt32(txtRabat.Text);
            prihodi.UslugaIliProizvod = lookUpEditUslugaProizvod.Text;
            prihodi.VrijemeIzrade = Convert.ToDateTime(dateEditVrijemeIzrade.Text);
            if (txtRacunBroj.Text != "")
            {
                prihodi.Id= Convert.ToInt32(txtRacunBroj.Text);
                prihodi.UpdateData();
            }
            else
                prihodi.InsertData();
        }
    }
}
