using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Expert
{
    public partial class Main : RibbonForm
    {
        readonly List<Control> views = new List<Control>();
        public Main()
        {
            InitializeComponent();
        }

        private void RegisterView(string name = null)
        {
            Type type = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).First(x => x.Name == name); //target type
            Activator.CreateInstance(type);
            object o = Activator.CreateInstance(type); // an instance of target type
            Control view = (Control)o;
            view.Text = o.GetType().Name;

            if (MainTabbedView.Documents.Exists(d => d.Control.Name == view.Name) == false)
            {
                MainTabbedView.AddDocument(view);
            }

            views.Add(view);
        }

        private void BarItemNavigation_Click(object sender, ItemClickEventArgs e)
        {
            var linkName = e.Link.Item.Name;

            if (views.Count == 0 || views.Exists(v => v.Name == linkName) == false)
            {
                var viewName = linkName.Substring(0, linkName.Length - 4);
                RegisterView(viewName);
            }

            foreach (var view in views)
            {
                if ((view.Name + "Link") == linkName) MainTabbedView.ActivateDocument(view);
            }
        }
    }
}