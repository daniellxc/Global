using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CONCEPTI_FACTORING.VIEW.Cenarios.Cadastro;
using CONCEPTI_FACTORING.VIEW.Cenarios;

namespace CONCEPTI_FACTORING.VIEW
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
            Application.Run(new FPrincipal());
        }
    }
}
