using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAcademy
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static NLog.Logger Log = NLog.LogManager.GetCurrentClassLogger();
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Veiws.Main());
        }
    }
}
