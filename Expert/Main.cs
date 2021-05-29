using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using Expert.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Expert
{
    public partial class Main : RibbonForm
    {
        public Main()
        {
            InitializeComponent();
            //HandleUIByLanguage();
            MainTabbedView.QueryControl += MainTabbedView_QueryControl;
        }

        private Control RegisterView(string name = null)
        {
            if (name == null) return null;
            Type type = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).FirstOrDefault(x => x.Name == name); //target type
            if (type == null) return null;
            object obj = Activator.CreateInstance(type); // an instance of target type
            Control view = (Control)obj;
            view.Text = view.Name;
            return view;
        }

        private void BarItemNavigation_Click(object sender, ItemClickEventArgs e)
        {
            var linkName = e.Link.Item.Name;
            var viewName = linkName.Substring(0, linkName.Length - 4);
            //MainTabbedView.AddOrActivateDocument(d => d.Caption == viewName, () => RegisterView(viewName));   // withou deferred loading

            BaseDocument document = MainTabbedView.Documents.Exists(d => d.Caption == viewName) ?
                                            MainTabbedView.Documents.FirstOrDefault(d => d.Caption == viewName) : null;
            if (document == null)
                document = MainTabbedView.AddDocument(viewName, null);
            
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
                                                        "اعادة تشغيل البرنامج وتغيير اللغة ؟"
                                                         : "Restart Application To Change Language ?";

            if (XtraMessageBox.Show(changeMsg, "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                CultureHandler.ChangeCultre(e.Link.Item.Caption);
            }
            return;
        }

        private void HandleUIByLanguage()
        {
            var lang = Properties.Settings.Default.Language;
            if (lang == "AR") {
                RightToLeft = RightToLeft.Yes;
                btnArabicLang.Enabled = false; 
            }
            if (lang == "EN") btnEnglishLang.Enabled = false;
        }
    }
}