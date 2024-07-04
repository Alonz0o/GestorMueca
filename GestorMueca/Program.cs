using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtiquetadoBultos
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        private static Mutex mutex = null;
        public static List<string> argumentos = new List<string>();
        public static formPrincipal principal;
        [STAThread]      
        static void Main(string[] args)
        {
            argumentos.AddRange(args);
            const string appName = "GestorMuestras";
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(principal = new formPrincipal());
        }
    }
}
