using System;
using System.Windows.Forms;



namespace DPRNIII_U2_A1_MAZM
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
            Application.Run(new FormularioConexionBaseDeDatos());
            //Application.Run(new IngresoProyecto());
        }
    }
}
