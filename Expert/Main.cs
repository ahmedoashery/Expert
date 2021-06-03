using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Expert.Properties;
using Expert.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Expert
{
    public partial class Main : RibbonForm
    {
        public Main()
        {
            // Show a splashscreen.
            SplachScreen();

            InitializeComponent();

            //Close the splashscreen
            SplashScreenManager.CloseForm();
            // depends on culture settings
            HandleUIByCulture();
            // authenticated user
            Username.Caption = Settings.Default.AuthenticatedUser;
            // initialize documents instances
            //MainTabbedView.QueryControl += MainTabbedView_QueryControl;
        }

        private void SplachScreen()
        {
            FluentSplashScreenOptions op = new FluentSplashScreenOptions();
            op.Title = "When Only The Best Will Do";
            op.Subtitle = "DevExpress WinForms Controls";
            op.RightFooter = "Starting...";
            op.LeftFooter = "Copyright © 2000 - 2020 Developer Express Inc." + Environment.NewLine + "All Rights reserved.";
            op.LoadingIndicatorType = FluentLoadingIndicatorType.Dots;
            op.OpacityColor = Color.Gray;
            op.Opacity = 130;
            //op.LogoImageOptions.SvgImage = Resources.Logo;

            SplashScreenManager.ShowFluentSplashScreen(
                op,
                parentForm: this,
                useFadeIn: true,
                useFadeOut: true
            );
        }

        private Control RegisterView(string name = null)
        {
            IEnumerable<Type> types = AppDomain.CurrentDomain.GetAssemblies()
                                                             .Where(x => x.GetName().Name.StartsWith("Expert"))
                                                             .SelectMany(x => x.GetTypes());    //target type
            Control view = null;
            foreach (var type in types)
            {
                if (type != null && name != null && type.Name == name)
                {
                    object obj = Activator.CreateInstance(type); // an instance of target type
                    view = (Control)obj;
                    view.Text = view.Name;
                }
            }
            return view;
        }

        private void BarItemNavigation_Click(object sender, ItemClickEventArgs e)
        {
            var linkName = e.Link.Item.Name;
            var viewName = linkName.Substring(0, linkName.Length - 4);
            //MainTabbedView.AddOrActivateDocument(d => d.Caption == viewName, () => RegisterView(viewName) ?? null);   // without deferred loading

            BaseDocument document = MainTabbedView.Documents.Exists(d => d.Caption == viewName) ?
                                            MainTabbedView.Documents.FirstOrDefault(d => d.Caption == viewName) : null;
            if (document == null)
                document = MainTabbedView.AddDocument(viewName, null);
            else
                MainTabbedView.Controller.Activate(document);
        }

        private void MainTabbedView_QueryControl(object sender, QueryControlEventArgs e)
        {
            Control control = RegisterView(e.Document.Caption);
            e.Control = control;
            if (e.Control == null)
                e.Control = new Control();
        }

        private void LanguageChange_ItemClick(object sender, ItemClickEventArgs e)
        {
            var changeMsg = e.Link.Item.Caption == "EN" ?
                                                        "اعادة تشغيل البرنامج لتغيير اللغة ؟"
                                                         : "Restart Application To Change Language ?";

            if (XtraMessageBox.Show(changeMsg, "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                CultureHandler.ChangeCultre(e.Link.Item.Caption);
            }
            return;
        }

        private void HandleUIByCulture()
        {
            var lang = Settings.Default.Language;
            if (lang == "AR")
            {
                RightToLeft = RightToLeft.Yes;
                btnArabicLang.Enabled = false;
                UsernameLabel.Caption = "مستخدم : ";
            }
            if (lang == "EN") btnEnglishLang.Enabled = false;
        }

        private void Logoutbutton_ItemClick(object sender, ItemClickEventArgs e)
        {
            var changeMsg = e.Link.Item.Caption == "EN" ? "Restart Application To Change Language ?" : "اعادة تشغيل البرنامج وتغيير اللغة ؟";
            if (XtraMessageBox.Show(changeMsg, "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Settings.Default.Authenticated = false;
                Settings.Default.AuthenticatedUser = "";
                Settings.Default.Save();
                Application.Restart();
                Environment.Exit(0);
            }
            else
                return;
        }
    }
}