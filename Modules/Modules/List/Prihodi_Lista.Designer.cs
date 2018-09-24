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
            this.components = new System.ComponentModel.Container();
            this.PrihodiListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKupacNaziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMjesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOibKupca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNadnevakIzdavanjaRacuna = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumPredvideneIsporuke = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVrijemeIzrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDospijecePlacanja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUslugaIliProizvod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJedinicaMjere = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKolicina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCijena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRabat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNapomena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznosNaplacenGotovinom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznosNaplacenVirmanski = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrojIzvodaUplatnice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNadnevakDatumUplate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PrihodiListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // PrihodiListBindingSource
            // 
            this.PrihodiListBindingSource.DataSource = typeof(Library.PrihodiList);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKupacNaziv,
            this.colAdresa,
            this.colMjesto,
            this.colOibKupca,
            this.colNadnevakIzdavanjaRacuna,
            this.colDatumPredvideneIsporuke,
            this.colVrijemeIzrade,
            this.colDospijecePlacanja,
            this.colUslugaIliProizvod,
            this.colJedinicaMjere,
            this.colKolicina,
            this.colCijena,
            this.colRabat,
            this.colIznos,
            this.colNapomena,
            this.colIznosNaplacenGotovinom,
            this.colIznosNaplacenVirmanski,
            this.colBrojIzvodaUplatnice,
            this.colNadnevakDatumUplate});
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
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gridControl1.DataSource = this.PrihodiListBindingSource;
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
            this.gridControl1.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControl1_EmbeddedNavigator_ButtonClick);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1253, 681);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            this.gridControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseMove);
            // 
            // colId
            // 
            this.colId.Caption = "Broj računa";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colKupacNaziv
            // 
            this.colKupacNaziv.FieldName = "KupacNaziv";
            this.colKupacNaziv.Name = "colKupacNaziv";
            this.colKupacNaziv.OptionsColumn.AllowEdit = false;
            this.colKupacNaziv.Visible = true;
            this.colKupacNaziv.VisibleIndex = 1;
            this.colKupacNaziv.Width = 78;
            // 
            // colAdresa
            // 
            this.colAdresa.FieldName = "Adresa";
            this.colAdresa.Name = "colAdresa";
            this.colAdresa.OptionsColumn.AllowEdit = false;
            this.colAdresa.Visible = true;
            this.colAdresa.VisibleIndex = 2;
            // 
            // colMjesto
            // 
            this.colMjesto.FieldName = "Mjesto";
            this.colMjesto.Name = "colMjesto";
            this.colMjesto.OptionsColumn.AllowEdit = false;
            this.colMjesto.Visible = true;
            this.colMjesto.VisibleIndex = 3;
            // 
            // colOibKupca
            // 
            this.colOibKupca.FieldName = "OibKupca";
            this.colOibKupca.Name = "colOibKupca";
            this.colOibKupca.OptionsColumn.AllowEdit = false;
            this.colOibKupca.Visible = true;
            this.colOibKupca.VisibleIndex = 4;
            // 
            // colNadnevakIzdavanjaRacuna
            // 
            this.colNadnevakIzdavanjaRacuna.FieldName = "NadnevakIzdavanjaRacuna";
            this.colNadnevakIzdavanjaRacuna.Name = "colNadnevakIzdavanjaRacuna";
            this.colNadnevakIzdavanjaRacuna.OptionsColumn.AllowEdit = false;
            this.colNadnevakIzdavanjaRacuna.Visible = true;
            this.colNadnevakIzdavanjaRacuna.VisibleIndex = 5;
            this.colNadnevakIzdavanjaRacuna.Width = 158;
            // 
            // colDatumPredvideneIsporuke
            // 
            this.colDatumPredvideneIsporuke.FieldName = "DatumPredvideneIsporuke";
            this.colDatumPredvideneIsporuke.Name = "colDatumPredvideneIsporuke";
            this.colDatumPredvideneIsporuke.OptionsColumn.AllowEdit = false;
            this.colDatumPredvideneIsporuke.Visible = true;
            this.colDatumPredvideneIsporuke.VisibleIndex = 6;
            this.colDatumPredvideneIsporuke.Width = 153;
            // 
            // colVrijemeIzrade
            // 
            this.colVrijemeIzrade.FieldName = "VrijemeIzrade";
            this.colVrijemeIzrade.Name = "colVrijemeIzrade";
            this.colVrijemeIzrade.OptionsColumn.AllowEdit = false;
            this.colVrijemeIzrade.Visible = true;
            this.colVrijemeIzrade.VisibleIndex = 7;
            this.colVrijemeIzrade.Width = 89;
            // 
            // colDospijecePlacanja
            // 
            this.colDospijecePlacanja.FieldName = "DospijecePlacanja";
            this.colDospijecePlacanja.Name = "colDospijecePlacanja";
            this.colDospijecePlacanja.OptionsColumn.AllowEdit = false;
            this.colDospijecePlacanja.Visible = true;
            this.colDospijecePlacanja.VisibleIndex = 8;
            this.colDospijecePlacanja.Width = 109;
            // 
            // colUslugaIliProizvod
            // 
            this.colUslugaIliProizvod.FieldName = "UslugaIliProizvod";
            this.colUslugaIliProizvod.Name = "colUslugaIliProizvod";
            this.colUslugaIliProizvod.OptionsColumn.AllowEdit = false;
            this.colUslugaIliProizvod.Visible = true;
            this.colUslugaIliProizvod.VisibleIndex = 9;
            this.colUslugaIliProizvod.Width = 107;
            // 
            // colJedinicaMjere
            // 
            this.colJedinicaMjere.FieldName = "JedinicaMjere";
            this.colJedinicaMjere.Name = "colJedinicaMjere";
            this.colJedinicaMjere.OptionsColumn.AllowEdit = false;
            this.colJedinicaMjere.Visible = true;
            this.colJedinicaMjere.VisibleIndex = 10;
            this.colJedinicaMjere.Width = 88;
            // 
            // colKolicina
            // 
            this.colKolicina.FieldName = "Kolicina";
            this.colKolicina.Name = "colKolicina";
            this.colKolicina.OptionsColumn.AllowEdit = false;
            this.colKolicina.Visible = true;
            this.colKolicina.VisibleIndex = 11;
            // 
            // colCijena
            // 
            this.colCijena.FieldName = "Cijena";
            this.colCijena.Name = "colCijena";
            this.colCijena.OptionsColumn.AllowEdit = false;
            this.colCijena.Visible = true;
            this.colCijena.VisibleIndex = 12;
            // 
            // colRabat
            // 
            this.colRabat.FieldName = "Rabat";
            this.colRabat.Name = "colRabat";
            this.colRabat.OptionsColumn.AllowEdit = false;
            this.colRabat.Visible = true;
            this.colRabat.VisibleIndex = 13;
            // 
            // colIznos
            // 
            this.colIznos.FieldName = "Iznos";
            this.colIznos.Name = "colIznos";
            this.colIznos.OptionsColumn.AllowEdit = false;
            this.colIznos.Visible = true;
            this.colIznos.VisibleIndex = 14;
            // 
            // colNapomena
            // 
            this.colNapomena.FieldName = "Napomena";
            this.colNapomena.Name = "colNapomena";
            this.colNapomena.OptionsColumn.AllowEdit = false;
            this.colNapomena.Visible = true;
            this.colNapomena.VisibleIndex = 15;
            // 
            // colIznosNaplacenGotovinom
            // 
            this.colIznosNaplacenGotovinom.FieldName = "IznosNaplacenGotovinom";
            this.colIznosNaplacenGotovinom.Name = "colIznosNaplacenGotovinom";
            this.colIznosNaplacenGotovinom.OptionsColumn.AllowEdit = false;
            this.colIznosNaplacenGotovinom.Visible = true;
            this.colIznosNaplacenGotovinom.VisibleIndex = 16;
            this.colIznosNaplacenGotovinom.Width = 147;
            // 
            // colIznosNaplacenVirmanski
            // 
            this.colIznosNaplacenVirmanski.FieldName = "IznosNaplacenVirmanski";
            this.colIznosNaplacenVirmanski.Name = "colIznosNaplacenVirmanski";
            this.colIznosNaplacenVirmanski.OptionsColumn.AllowEdit = false;
            this.colIznosNaplacenVirmanski.Visible = true;
            this.colIznosNaplacenVirmanski.VisibleIndex = 17;
            this.colIznosNaplacenVirmanski.Width = 140;
            // 
            // colBrojIzvodaUplatnice
            // 
            this.colBrojIzvodaUplatnice.FieldName = "BrojIzvodaUplatnice";
            this.colBrojIzvodaUplatnice.Name = "colBrojIzvodaUplatnice";
            this.colBrojIzvodaUplatnice.OptionsColumn.AllowEdit = false;
            this.colBrojIzvodaUplatnice.Visible = true;
            this.colBrojIzvodaUplatnice.VisibleIndex = 18;
            this.colBrojIzvodaUplatnice.Width = 122;
            // 
            // colNadnevakDatumUplate
            // 
            this.colNadnevakDatumUplate.FieldName = "NadnevakDatumUplate";
            this.colNadnevakDatumUplate.Name = "colNadnevakDatumUplate";
            this.colNadnevakDatumUplate.OptionsColumn.AllowEdit = false;
            this.colNadnevakDatumUplate.Visible = true;
            this.colNadnevakDatumUplate.VisibleIndex = 19;
            this.colNadnevakDatumUplate.Width = 136;
            // 
            // Prihodi_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "Prihodi_Lista";
            this.Size = new System.Drawing.Size(1253, 681);
            ((System.ComponentModel.ISupportInitialize)(this.PrihodiListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource PrihodiListBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colKupacNaziv;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresa;
        private DevExpress.XtraGrid.Columns.GridColumn colMjesto;
        private DevExpress.XtraGrid.Columns.GridColumn colOibKupca;
        private DevExpress.XtraGrid.Columns.GridColumn colNadnevakIzdavanjaRacuna;
        private DevExpress.XtraGrid.Columns.GridColumn colDatumPredvideneIsporuke;
        private DevExpress.XtraGrid.Columns.GridColumn colVrijemeIzrade;
        private DevExpress.XtraGrid.Columns.GridColumn colDospijecePlacanja;
        private DevExpress.XtraGrid.Columns.GridColumn colUslugaIliProizvod;
        private DevExpress.XtraGrid.Columns.GridColumn colJedinicaMjere;
        private DevExpress.XtraGrid.Columns.GridColumn colKolicina;
        private DevExpress.XtraGrid.Columns.GridColumn colCijena;
        private DevExpress.XtraGrid.Columns.GridColumn colRabat;
        private DevExpress.XtraGrid.Columns.GridColumn colIznos;
        private DevExpress.XtraGrid.Columns.GridColumn colNapomena;
        private DevExpress.XtraGrid.Columns.GridColumn colIznosNaplacenGotovinom;
        private DevExpress.XtraGrid.Columns.GridColumn colIznosNaplacenVirmanski;
        private DevExpress.XtraGrid.Columns.GridColumn colBrojIzvodaUplatnice;
        private DevExpress.XtraGrid.Columns.GridColumn colNadnevakDatumUplate;
        private DevExpress.XtraGrid.GridControl gridControl1;
    }
}
