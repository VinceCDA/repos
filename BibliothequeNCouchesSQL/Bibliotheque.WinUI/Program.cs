using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using Bibliotheque.DAL;

namespace Bibliotheque.WinUI
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            CultureInfo c = System.Globalization.CultureInfo.GetCultureInfo("en-001");
           
            Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en-001");
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-001");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DB.DbConnectionString = Properties.Settings.Default.BibliothequeConnectString;
            Application.Run(new FrmMain());
        }
    }
}
