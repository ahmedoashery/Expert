using Expert.Core;
using System;
using System.Windows.Forms;

namespace Expert
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // set application culture for ui and data.
            CultureHandler culture = new CultureHandler();
            culture.ApplyCulture();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // check authentication
            var isAuthenticated = Properties.Settings.Default.Authenticated;
            if (!isAuthenticated)
                Application.Run(new Login());
            else
                Application.Run(new Main());
        }
    }
}
