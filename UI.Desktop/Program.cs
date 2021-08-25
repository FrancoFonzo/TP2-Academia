using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    static class Program
    {
        internal static Main MainUI;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (new Login().ShowDialog() == DialogResult.OK)
            {
                MainUI = new Main();
                Application.Run(MainUI);
            }
        }
    }
}
