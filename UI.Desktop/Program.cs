using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    static class Program
    {
        static internal Main MainUI;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                MainUI = new Main(login.UsuarioActual);
                Application.Run(MainUI);
            }
        }
    }
}
