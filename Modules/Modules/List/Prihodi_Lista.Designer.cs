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
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKupacNaziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMjesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOibKupca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNadnevakIzdavanjaRacuna = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumPredvideneIsporuke = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVrijemeIzrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDospijecePlacanja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNapomena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznosNaplacenGotovinom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIznosNaplacenVirmanski = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrojIzvodaUplatnice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNadnevakDatumUplate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnKpr = new DevExpress.XtraBars.BarButtonItem();
            this.btnPoSd = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.PrihodiListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
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
            // colNapomena
            // 
            this.colNapomena.FieldName = "Napomena";
            this.colNapomena.Name = "colNapomena";
            this.colNapomena.OptionsColumn.AllowEdit = false;
            this.colNapomena.Visible = true;
            this.colNapomena.VisibleIndex = 9;
            // 
            // colIznosNaplacenGotovinom
            // 
            this.colIznosNaplacenGotovinom.FieldName = "IznosNaplacenGotovinom";
            this.colIznosNaplacenGotovinom.Name = "colIznosNaplacenGotovinom";
            this.colIznosNaplacenGotovinom.OptionsColumn.AllowEdit = false;
            this.colIznosNaplacenGotovinom.Visible = true;
            this.colIznosNaplacenGotovinom.VisibleIndex = 10;
            this.colIznosNaplacenGotovinom.Width = 147;
            // 
            // colIznosNaplacenVirmanski
            // 
            this.colIznosNaplacenVirmanski.FieldName = "IznosNaplacenVirmanski";
            this.colIznosNaplacenVirmanski.Name = "colIznosNaplacenVirmanski";
            this.colIznosNaplacenVirmanski.OptionsColumn.AllowEdit = false;
            this.colIznosNaplacenVirmanski.Visible = true;
            this.colIznosNaplacenVirmanski.VisibleIndex = 11;
            this.colIznosNaplacenVirmanski.Width = 140;
            // 
            // colBrojIzvodaUplatnice
            // 
            this.colBrojIzvodaUplatnice.FieldName = "BrojIzvodaUplatnice";
            this.colBrojIzvodaUplatnice.Name = "colBrojIzvodaUplatnice";
            this.colBrojIzvodaUplatnice.OptionsColumn.AllowEdit = false;
            this.colBrojIzvodaUplatnice.Visible = true;
            this.colBrojIzvodaUplatnice.VisibleIndex = 12;
            this.colBrojIzvodaUplatnice.Width = 122;
            // 
            // colNadnevakDatumUplate
            // 
            this.colNadnevakDatumUplate.FieldName = "NadnevakDatumUplate";
            this.colNadnevakDatumUplate.Name = "colNadnevakDatumUplate";
            this.colNadnevakDatumUplate.OptionsColumn.AllowEdit = false;
            this.colNadnevakDatumUplate.Visible = true;
            this.colNadnevakDatumUplate.VisibleIndex = 13;
            this.colNadnevakDatumUplate.Width = 136;
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
            this.gridControl1.Location = new System.Drawing.Point(0, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1253, 661);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            this.gridControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseMove);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnKpr,
            this.btnPoSd});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnKpr, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPoSd, true)});
            this.bar2.OptionsBar.DisableClose = true;
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1253, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 681);
            this.barDockControlBottom.Size = new System.Drawing.Size(1253, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 661);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1253, 20);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 661);
            // 
            // btnKpr
            // 
            this.btnKpr.Caption = "Obrazac KPR";
            this.btnKpr.Id = 0;
            this.btnKpr.Name = "btnKpr";
            this.btnKpr.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKpr_ItemClick);
            // 
            // btnPoSd
            // 
            this.btnPoSd.Caption = "Obrazac PO-SD";
            this.btnPoSd.Id = 1;
            this.btnPoSd.Name = "btnPoSd";
            this.btnPoSd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPoSd_ItemClick);
            // 
            // Prihodi_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Prihodi_Lista";
            this.Size = new System.Drawing.Size(1253, 681);
            ((System.ComponentModel.ISupportInitialize)(this.PrihodiListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DevExpress.XtraGrid.Columns.GridColumn colNapomena;
        private DevExpress.XtraGrid.Columns.GridColumn colIznosNaplacenGotovinom;
        private DevExpress.XtraGrid.Columns.GridColumn colIznosNaplacenVirmanski;
        private DevExpress.XtraGrid.Columns.GridColumn colBrojIzvodaUplatnice;
        private DevExpress.XtraGrid.Columns.GridColumn colNadnevakDatumUplate;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnKpr;
        private DevExpress.XtraBars.BarButtonItem btnPoSd;
    }
}
