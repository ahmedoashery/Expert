using DevExpress.XtraEditors;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Expert.Services
{
    public class CultureHandler
    {
        CultureInfo culture;
        public CultureHandler()
        {

        }

        public void ApplyCulture()
        {
            // Create a new object, representing the German culture.
            culture = CultureInfo.CreateSpecificCulture(Properties.Settings.Default.Language);

            // The following line provides localization for the application's user interface. 
            Thread.CurrentThread.CurrentUICulture = culture;
            // The following line provides localization for data formats. 
            Thread.CurrentThread.CurrentCulture = culture;

            // Set this culture as the default culture for all threads in this application. 
            // Note: The following properties are supported in the .NET Framework 4.5+
            //CultureInfo.DefaultThreadCurrentCulture = culture;
            //CultureInfo.DefaultThreadCurrentUICulture = culture;
        }


        public static void ChangeCultre(string culture)
        {
            Properties.Settings.Default.Language = culture;
            Properties.Settings.Default.Save();
            Application.Restart();
            Environment.Exit(0);

        }
    }
}
