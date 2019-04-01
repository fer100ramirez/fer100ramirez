using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActividadeU3.vista;

namespace ActividadeU3
{
    static class Program
    {
        public static FormaCampeonato formaCampeonato = null;
        public static FormaJornada formaJornada = null;
        public static Main main = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            main = new Main();
            formaCampeonato = new FormaCampeonato();
            formaJornada = new FormaJornada();
            Application.Run(new Main());
        }
    }
}
