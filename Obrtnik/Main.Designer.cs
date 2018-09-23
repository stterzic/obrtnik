namespace Obrtnik
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnProizvod = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnRacuniPrihod = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnObrt = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupBaza = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageKnjizica = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageSifarnik = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupProizvod = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Obrtnik.WaitForm), true, true);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnProizvod,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.btnRacuniPrihod,
            this.barButtonItem5,
            this.btnObrt,
            this.barButtonItem6});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPageKnjizica,
            this.ribbonPageSifarnik});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1206, 143);
            // 
            // btnProizvod
            // 
            this.btnProizvod.Caption = "Proizvodi";
            this.btnProizvod.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProizvod.Glyph")));
            this.btnProizvod.Id = 1;
            this.btnProizvod.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnProizvod.LargeGlyph")));
            this.btnProizvod.Name = "btnProizvod";
            this.btnProizvod.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProizvod_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Usluge";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "PO-SD";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "KPR";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnRacuniPrihod
            // 
            this.btnRacuniPrihod.Caption = "Prikaz računa";
            this.btnRacuniPrihod.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRacuniPrihod.Glyph")));
            this.btnRacuniPrihod.Id = 5;
            this.btnRacuniPrihod.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRacuniPrihod.LargeGlyph")));
            this.btnRacuniPrihod.Name = "btnRacuniPrihod";
            this.btnRacuniPrihod.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRacuniPrihod_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Id = 7;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btnObrt
            // 
            this.btnObrt.Caption = "Osnovni podaci o obrtu";
            this.btnObrt.Glyph = ((System.Drawing.Image)(resources.GetObject("btnObrt.Glyph")));
            this.btnObrt.Id = 8;
            this.btnObrt.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnObrt.LargeGlyph")));
            this.btnObrt.Name = "btnObrt";
            this.btnObrt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnObrt_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 9;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroupBaza});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Osnovni podaci";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnObrt);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            // 
            // ribbonPageGroupBaza
            // 
            this.ribbonPageGroupBaza.ItemLinks.Add(this.btnRacuniPrihod);
            this.ribbonPageGroupBaza.Name = "ribbonPageGroupBaza";
            this.ribbonPageGroupBaza.ShowCaptionButton = false;
            // 
            // ribbonPageKnjizica
            // 
            this.ribbonPageKnjizica.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup3});
            this.ribbonPageKnjizica.Name = "ribbonPageKnjizica";
            this.ribbonPageKnjizica.Text = "Knjižica";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowMinimize = false;
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Ukupni izvještaj";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowMinimize = false;
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Podjela po kvartalima";
            // 
            // ribbonPageSifarnik
            // 
            this.ribbonPageSifarnik.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupProizvod,
            this.ribbonPageGroup2});
            this.ribbonPageSifarnik.Name = "ribbonPageSifarnik";
            this.ribbonPageSifarnik.Text = "Šifarnik";
            // 
            // ribbonPageGroupProizvod
            // 
            this.ribbonPageGroupProizvod.AllowMinimize = false;
            this.ribbonPageGroupProizvod.AllowTextClipping = false;
            this.ribbonPageGroupProizvod.ItemLinks.Add(this.btnProizvod);
            this.ribbonPageGroupProizvod.Name = "ribbonPageGroupProizvod";
            this.ribbonPageGroupProizvod.ShowCaptionButton = false;
            this.ribbonPageGroupProizvod.Text = "Proizvodi";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowMinimize = false;
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Usluge";
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Main
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 664);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageKnjizica;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageSifarnik;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupProizvod;
        private DevExpress.XtraBars.BarButtonItem btnProizvod;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnRacuniPrihod;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupBaza;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraBars.BarButtonItem btnObrt;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

