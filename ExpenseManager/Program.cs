using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManager
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

            var loginForm = new LoginForm();
            Application.Run(loginForm);

            if (loginForm.DialogResult != DialogResult.OK)
            {
                return;
            }

            var mainWindow = new MainWindow(loginForm.CurrentUser);
            Application.Run(mainWindow);
            if (mainWindow.DialogResult == DialogResult.Cancel)
            {
                Application.Restart();
            }
        }
    }
}
