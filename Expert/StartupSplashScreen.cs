using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;

namespace Expert
{
    public partial class StartupSplashScreen : FluentSplashScreen
    {
        public StartupSplashScreen()
        {
            WindowsFormsSettings.LoadApplicationSettings();
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © " + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}