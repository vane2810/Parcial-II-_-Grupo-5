using System;
using Parcial_II___Grupo_5.PL;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_II___Grupo_5
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmEmpleados());
            Application.Run(new frmSalas());
            Application.Run(new frmFunciones());
            Application.Run(new frmCartelera());
            Application.Run(new frmSnacks());

        }
    }
}
