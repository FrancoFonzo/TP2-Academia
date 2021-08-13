using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    static class Program
    {
        static internal readonly Main MainUI = new Main();
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
                Application.Run(MainUI);
            }
        }
    }
}
