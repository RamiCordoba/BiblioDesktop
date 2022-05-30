using BiblioDesktop.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioDesktop
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(DespliegueControladoDeErroresOtroshilos);

            Application.ThreadException += new ThreadExceptionEventHandler(DespliegueControladoDeErroresHiloPrincipal);
            Application.Run(new FrmInicio());
        }

        private static void DespliegueControladoDeErroresOtroshilos(object sender, UnhandledExceptionEventArgs args)
        {
            Exception exepcion = (Exception)args.ExceptionObject;

            // MessageBox.Show($"Ha ocurrido un error:{e.Message}{System.Environment.NewLine}Origen del error:{e.Source}");
            var frmError = new FrmError(exepcion);
            frmError.ShowDialog();
        }

        private static void DespliegueControladoDeErroresHiloPrincipal(object sender, ThreadExceptionEventArgs e)
        {

            //MessageBox.Show($"Ha ocurrido un error:{e.Exception.Message}{System.Environment.NewLine}Origen del error:{e.Exception.Source}");
            var frmError = new FrmError(e.Exception);
            frmError.ShowDialog();
        }
    }
}
