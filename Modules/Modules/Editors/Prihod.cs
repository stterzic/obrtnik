using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
        int maxId;
        Library.Prihodi Header = new Library.Prihodi();

        public Prihod()
        {
            InitializeComponent();
            LoadData();
            maxId = new Library.Prihodi().GetMaxId();
            txtRacunBroj.Text = (maxId+1).ToString();
        }

        public void LoadData()
        {            
            MjerneJediniceListBindingSource.DataSource = new Library.MjerneJediniceList().GetData(null);
            zakoniListBindingSource.DataSource = new Library.ZakoniList().GetData(null);
            uslugeListBindingSource.DataSource = new Library.UslugeList().GetData(null);
        }

        public Prihod(int id)
        {
            InitializeComponent();
            LoadData(id);
        }
        public void LoadData(int id)
        {
            Header = new Library.Prihodi().GetData(id);
            PrihodiBindingSource.DataSource = Header;
            txtRacunBroj.Text = id.ToString();
            uslugaProizvodListBindingSource.DataSource = new Library.UslugaProizvodList().GetData("RacunId=" + id);
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Library.Prihodi prihodi = new Library.Prihodi();
            try
            {
                prihodi.Adresa = txtAdresa.Text;
                prihodi.BrojIzvodaUplatnice = Convert.ToInt32(txtBrojIzvodaUputnice.Text);
                prihodi.DatumPredvideneIsporuke = Convert.ToDateTime(dateEditDatumPredvidjeneIsporuke.Text);
                prihodi.DospijecePlacanja = Convert.ToDateTime(dateEditDospjecePlacanja.Text);
                if(txtGotovina.Text!="")
                prihodi.IznosNaplacenGotovinom = Convert.ToDecimal(txtGotovina.Text);
                if (txtVirmanski.Text != "")
                    prihodi.IznosNaplacenVirmanski = Convert.ToDecimal(txtVirmanski.Text);
                prihodi.KupacNaziv = txtKupacNaziv.Text;
                prihodi.Mjesto = txtMjesto.Text;
                prihodi.NadnevakDatumUplate = Convert.ToDateTime(dateEditNadnevakUplate.Text);
                prihodi.NadnevakIzdavanjaRacuna = Convert.ToDateTime(dateEditNadnevak.Text);
                prihodi.Napomena = lookUpEditNapomena.Text;
                prihodi.OibKupca = txtOibKupca.Text;
                prihodi.VrijemeIzrade = Convert.ToDateTime(dateEditVrijemeIzrade.Text);
                if (new Library.Prihodi().GetMaxId()== Convert.ToInt32(txtRacunBroj.Text))
                {
                    prihodi.Id = Convert.ToInt32(txtRacunBroj.Text);
                    prihodi.UpdateData();
                }
                else
                    prihodi.InsertData();

                Library.UslugaProizvod uslugaProizvod = new Library.UslugaProizvod();
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    uslugaProizvod = new Library.UslugaProizvod();

                    int rowHandle = gridView2.GetVisibleRowHandle(i);

                    string cijena = gridView2.GetRowCellDisplayText(rowHandle, "Cijena");
                    uslugaProizvod.Cijena = Convert.ToDouble(cijena);

                    string iznos = gridView2.GetRowCellDisplayText(rowHandle, "Iznos");
                    uslugaProizvod.Iznos = Convert.ToDouble(iznos);

                    string jedinicaMjere = gridView2.GetRowCellDisplayText(rowHandle, "JedinicaMjere");
                    uslugaProizvod.JedinicaMjere = jedinicaMjere;

                    string kolicina = gridView2.GetRowCellDisplayText(rowHandle, "Kolicina");
                    uslugaProizvod.Kolicina = Convert.ToInt32(kolicina);

                    string rabat = gridView2.GetRowCellDisplayText(rowHandle, "Rabat");
                    uslugaProizvod.Rabat = Convert.ToInt32(rabat);

                    string uslugaIliProizvod = gridView2.GetRowCellDisplayText(rowHandle, "UslugaIliProizvod");
                    uslugaProizvod.UslugaIliProizvod = uslugaIliProizvod;

                    string id = gridView2.GetRowCellDisplayText(rowHandle, "Id");
                    if (id != "0")
                    {
                        uslugaProizvod.UslugaIliProizvod = id;
                        uslugaProizvod.RacunId = Convert.ToInt32(txtRacunBroj.Text);

                        uslugaProizvod.UpdateData();
                    }
                    else
                    {
                        uslugaProizvod.RacunId = Convert.ToInt32(txtRacunBroj.Text);
                        uslugaProizvod.InsertData();
                    }
                }
                Header = prihodi;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Greška:" + ex, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void gridControl1_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                
            }
            else if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (txtRacunBroj.Text != "")
                {
                    int iFocus = gridView2.FocusedRowHandle;
                    if (iFocus < 0) return;
                    int id = (int)gridView2.GetFocusedRowCellValue("Id");
                    if (MessageBox.Show("Dali ste sigurni za brisanje označenog zapisa?", "Upozorenje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Library.MjerneJedinice item = new Library.MjerneJedinice();
                        item.DeleteData(id);
                    }
                }
            }
        }

        private void gridView2_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int kolicina = (int)gridView2.GetFocusedRowCellValue("Kolicina");
            double cijena = (double)gridView2.GetFocusedRowCellValue("Cijena");
            int rabat = (int)gridView2.GetFocusedRowCellValue("Rabat");

            double ukupno = kolicina * cijena;
            double postotak = (double)rabat/100;
            ukupno = ukupno * postotak;

            double iznos = kolicina * cijena - ukupno;

            gridView2.SetFocusedRowCellValue("Iznos", iznos);

        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            XtraReport tempReport = Reports.Utils.Racun.ShowRacun(Header.Id);
            tempReport.ShowRibbonPreviewDialog();
        }
    }
}
