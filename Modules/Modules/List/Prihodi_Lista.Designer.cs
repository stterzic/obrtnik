namespace Modules
{
    partial class Prihodi_Lista
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKupacNaziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMjesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOibKupca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNadnevak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumIsporuke = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVrijemeIzrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDospijecePlacanja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUslugaProizvod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJedinicaMjere = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKolicina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCijena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRabat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNapomena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGotovina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVirman = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrojUplatnice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumUplate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPoSd = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Hint = "New";
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Hint = "Delete";
            this.gridControl1.EmbeddedNavigator.TextStringFormat = "";
            this.gridControl1.EmbeddedNavigator.UseWaitCursor = false;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1253, 681);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.UseWaitCursor = false;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKupacNaziv,
            this.colAdresa,
            this.colMjesto,
            this.colOibKupca,
            this.colNadnevak,
            this.colDatumIsporuke,
            this.colVrijemeIzrade,
            this.colDospijecePlacanja,
            this.colUslugaProizvod,
            this.colJedinicaMjere,
            this.colKolicina,
            this.colCijena,
            this.colRabat,
            this.colIznos,
            this.colNapomena,
            this.colGotovina,
            this.colVirman,
            this.colBrojUplatnice,
            this.colDatumUplate,
            this.colPoSd});
            this.gridView1.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView1.OptionsDetail.SmartDetailHeight = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowPreview = true;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Lista prihoda";
            // 
            // colKupacNaziv
            // 
            this.colKupacNaziv.Caption = "Kupac naziv";
            this.colKupacNaziv.Name = "colKupacNaziv";
            this.colKupacNaziv.Visible = true;
            this.colKupacNaziv.VisibleIndex = 0;
            // 
            // colAdresa
            // 
            this.colAdresa.Caption = "Adresa";
            this.colAdresa.Name = "colAdresa";
            this.colAdresa.Visible = true;
            this.colAdresa.VisibleIndex = 1;
            // 
            // colMjesto
            // 
            this.colMjesto.Caption = "Mjesto";
            this.colMjesto.Name = "colMjesto";
            this.colMjesto.Visible = true;
            this.colMjesto.VisibleIndex = 2;
            // 
            // colOibKupca
            // 
            this.colOibKupca.Caption = "OIB kupca";
            this.colOibKupca.Name = "colOibKupca";
            this.colOibKupca.Visible = true;
            this.colOibKupca.VisibleIndex = 3;
            // 
            // colNadnevak
            // 
            this.colNadnevak.Caption = "Nadnevak\n(datum izdavanja računa)";
            this.colNadnevak.Name = "colNadnevak";
            this.colNadnevak.Visible = true;
            this.colNadnevak.VisibleIndex = 4;
            // 
            // colDatumIsporuke
            // 
            this.colDatumIsporuke.Caption = "Datum predviđene isporuke";
            this.colDatumIsporuke.Name = "colDatumIsporuke";
            this.colDatumIsporuke.Visible = true;
            this.colDatumIsporuke.VisibleIndex = 5;
            // 
            // colVrijemeIzrade
            // 
            this.colVrijemeIzrade.Caption = "Vrijeme izrade";
            this.colVrijemeIzrade.Name = "colVrijemeIzrade";
            this.colVrijemeIzrade.Visible = true;
            this.colVrijemeIzrade.VisibleIndex = 6;
            // 
            // colDospijecePlacanja
            // 
            this.colDospijecePlacanja.Caption = "Dospijeće plaćanja";
            this.colDospijecePlacanja.Name = "colDospijecePlacanja";
            this.colDospijecePlacanja.Visible = true;
            this.colDospijecePlacanja.VisibleIndex = 7;
            // 
            // colUslugaProizvod
            // 
            this.colUslugaProizvod.Caption = "Usluga ili proizvod";
            this.colUslugaProizvod.Name = "colUslugaProizvod";
            this.colUslugaProizvod.Visible = true;
            this.colUslugaProizvod.VisibleIndex = 8;
            // 
            // colJedinicaMjere
            // 
            this.colJedinicaMjere.Caption = "Jedinica mjere";
            this.colJedinicaMjere.Name = "colJedinicaMjere";
            this.colJedinicaMjere.Visible = true;
            this.colJedinicaMjere.VisibleIndex = 9;
            // 
            // colKolicina
            // 
            this.colKolicina.Caption = "Količina";
            this.colKolicina.Name = "colKolicina";
            this.colKolicina.Visible = true;
            this.colKolicina.VisibleIndex = 10;
            // 
            // colCijena
            // 
            this.colCijena.Caption = "Cijena";
            this.colCijena.Name = "colCijena";
            this.colCijena.Visible = true;
            this.colCijena.VisibleIndex = 11;
            // 
            // colRabat
            // 
            this.colRabat.Caption = "Rabat";
            this.colRabat.Name = "colRabat";
            this.colRabat.Visible = true;
            this.colRabat.VisibleIndex = 12;
            // 
            // colIznos
            // 
            this.colIznos.Caption = "Iznos";
            this.colIznos.Name = "colIznos";
            this.colIznos.Visible = true;
            this.colIznos.VisibleIndex = 13;
            // 
            // colNapomena
            // 
            this.colNapomena.Caption = "Napomena";
            this.colNapomena.Name = "colNapomena";
            this.colNapomena.Visible = true;
            this.colNapomena.VisibleIndex = 14;
            // 
            // colGotovina
            // 
            this.colGotovina.Caption = "Iznos naplaćen\n  GOTOVINOM\n";
            this.colGotovina.Name = "colGotovina";
            this.colGotovina.Visible = true;
            this.colGotovina.VisibleIndex = 15;
            // 
            // colVirman
            // 
            this.colVirman.Caption = "Iznos naplaćen \nVIRMANSKI \npreko računa";
            this.colVirman.Name = "colVirman";
            this.colVirman.Visible = true;
            this.colVirman.VisibleIndex = 16;
            // 
            // colBrojUplatnice
            // 
            this.colBrojUplatnice.Caption = "Broj\n izvoda uplatnice";
            this.colBrojUplatnice.Name = "colBrojUplatnice";
            this.colBrojUplatnice.Visible = true;
            this.colBrojUplatnice.VisibleIndex = 17;
            // 
            // colDatumUplate
            // 
            this.colDatumUplate.Caption = "Nadnevak\ndatum uplate";
            this.colDatumUplate.Name = "colDatumUplate";
            this.colDatumUplate.Visible = true;
            this.colDatumUplate.VisibleIndex = 18;
            // 
            // colPoSd
            // 
            this.colPoSd.Caption = "PO-SD VIRMANSKI\n(ZA KPR)";
            this.colPoSd.Name = "colPoSd";
            this.colPoSd.Visible = true;
            this.colPoSd.VisibleIndex = 19;
            // 
            // Prihodi_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "Prihodi_Lista";
            this.Size = new System.Drawing.Size(1253, 681);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colKupacNaziv;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresa;
        private DevExpress.XtraGrid.Columns.GridColumn colMjesto;
        private DevExpress.XtraGrid.Columns.GridColumn colOibKupca;
        private DevExpress.XtraGrid.Columns.GridColumn colNadnevak;
        private DevExpress.XtraGrid.Columns.GridColumn colDatumIsporuke;
        private DevExpress.XtraGrid.Columns.GridColumn colVrijemeIzrade;
        private DevExpress.XtraGrid.Columns.GridColumn colDospijecePlacanja;
        private DevExpress.XtraGrid.Columns.GridColumn colUslugaProizvod;
        private DevExpress.XtraGrid.Columns.GridColumn colJedinicaMjere;
        private DevExpress.XtraGrid.Columns.GridColumn colKolicina;
        private DevExpress.XtraGrid.Columns.GridColumn colCijena;
        private DevExpress.XtraGrid.Columns.GridColumn colRabat;
        private DevExpress.XtraGrid.Columns.GridColumn colIznos;
        private DevExpress.XtraGrid.Columns.GridColumn colNapomena;
        private DevExpress.XtraGrid.Columns.GridColumn colGotovina;
        private DevExpress.XtraGrid.Columns.GridColumn colVirman;
        private DevExpress.XtraGrid.Columns.GridColumn colBrojUplatnice;
        private DevExpress.XtraGrid.Columns.GridColumn colDatumUplate;
        private DevExpress.XtraGrid.Columns.GridColumn colPoSd;
    }
}
