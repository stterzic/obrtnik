using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Reflection;
using System.Deployment.Application;

namespace Obrtnik
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool ok;
            var m = new System.Threading.Mutex(true, Assembly.GetExecutingAssembly().ManifestModule.Name, out ok);
            if (!ok)
            {
                if (!ApplicationDeployment.IsNetworkDeployed)
                {
                    MessageBox.Show("Program je već pokrenut !!", Application.ProductVersion);
                }
                else
                {
                    MessageBox.Show("Program je već pokrenut !!", ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString());

                }
                return;
            }
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(SplashScreen));
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("hr");

            DevExpress.XtraEditors.Repository.RepositoryItem.EditValueChangedFiringDelay = 3000;
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            Application.Run(new Main());
            

        }
    }
}