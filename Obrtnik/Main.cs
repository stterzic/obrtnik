using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraSplashScreen;
using Finisar.SQLite;
using Modules.Editors;

namespace Obrtnik
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            Login();

            InitializeComponent();
        }

        private void Login()
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(false);
            bool egg = false;
            using (Login login = new Login())
            {
                login.ShowDialog();
            }
        }

        public void MainOperator(string ListType, ActionType typ)
        {
            if (!splashScreenManager.IsSplashFormVisible)
            {
                splashScreenManager.ShowWaitForm();
                splashScreenManager.SetWaitFormCaption("Molimo pričekajte");
                splashScreenManager.SetWaitFormDescription("Učitavanje ...");

            }
            //Helpers.Common.spmanager = splashScreenManager;
            switch (ListType)
            {
                //case "dbConnection":
                //    Modules.Tools.DbConnection db = new Modules.Tools.DbConnection();
                //    db.Show();
                //    break;
                default:
                    break;
            }
            if (splashScreenManager.IsSplashFormVisible)
            {
                splashScreenManager.CloseWaitForm();
            }
        }
    }
}
