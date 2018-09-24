using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Finisar.SQLite;
using Modules.Editors;

namespace Obrtnik
{
    public enum ActionType
    {
        List
    }

    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            Login();
            InitializeComponent();
            if (Library.Helpers.Common.User == null)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void Login()
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(false);
            using (Login login = new Login())
            {
                login.ShowDialog();
            }
        }

        public void MainOperator(string ListType)
        {
            if (!splashScreenManager.IsSplashFormVisible)
            {
                splashScreenManager.ShowWaitForm();
                splashScreenManager.SetWaitFormCaption("Molimo pričekajte");
                splashScreenManager.SetWaitFormDescription("Učitavanje ...");

            }

            switch (ListType)
            {
                case "Obrt":
                    Modules.Editors.ObrtPodaci obrtPodaci = new Modules.Editors.ObrtPodaci();
                    obrtPodaci.Show();
                    break;
                case "RacuniPrihod":
                    Modules.Prihodi_Lista prihodiLista = new Modules.Prihodi_Lista();
                    ShowForm(ListType, prihodiLista, "Lista prihoda");
                    break;
                case "Proizvodi":
                    Modules.Proizvodi_Lista proizvodiLista = new Modules.Proizvodi_Lista();
                    ShowForm(ListType, proizvodiLista, "Lista proizvoda");
                    break;
                case "Usluge":
                    Modules.Usluge_Lista uslugeLista = new Modules.Usluge_Lista();
                    ShowForm(ListType, uslugeLista, "Lista usluga");
                    break;
                case "MjerneJedinice":
                    Modules.MjerneJedinice_Lista mjerneJediniceLista = new Modules.MjerneJedinice_Lista();
                    ShowForm(ListType, mjerneJediniceLista, "Lista mjernih jedinica");
                    break;
                default:
                    break;
            }
            if (splashScreenManager.IsSplashFormVisible)
            {
                splashScreenManager.CloseWaitForm();
            }
        }

        private bool SetActiveTab(string FormTag)
        {
            var item = GetActiveTab(FormTag);
            if (item != null)
            {
                xtraTabbedMdiManager1.SelectedPage = item;
                return true;
            }
            return false;
        }

        private DevExpress.XtraTabbedMdi.XtraMdiTabPage GetActiveTab(string FormTag)
        {
            foreach (DevExpress.XtraTabbedMdi.XtraMdiTabPage item in xtraTabbedMdiManager1.Pages)
            {
                if (item.MdiChild.Tag is string[])
                {
                    if (((string[])item.MdiChild.Tag)[0].ToUpper() == FormTag.ToUpper())
                    {
                        return item;
                    }
                }
            }
            return null;
        }
        void newForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void ShowForm(string FormTag, Control cnt, string caption)
        {
            if (SetActiveTab(FormTag)) return;
            XtraForm newForm = new XtraForm() { Text = caption };
            newForm.FormClosing += newForm_FormClosing;
            newForm.Controls.Add(cnt);
            newForm.Width = cnt.Width;
            newForm.Height = cnt.Height;
            cnt.Dock = DockStyle.Fill;
            cnt.Visible = true;
            if (this.IsMdiContainer)
                newForm.MdiParent = this;
            newForm.Tag = new string[] { FormTag };
            newForm.Show();
            newForm.Visible = true;
        }

        private void btnObrt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MainOperator("Obrt");
        }

        private void btnRacuniPrihod_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MainOperator("RacuniPrihod");
        }

        private void btnProizvod_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MainOperator("Proizvodi");
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MainOperator("Usluge");
        }

        private void btnMjerneJedinice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MainOperator("MjerneJedinice");
        }
    }
}
