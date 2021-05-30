using DevExpress.Utils;
using Expert.Data;
using Expert.Data.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Expert.Modules.Customers
{
    public partial class CustomersListView : DevExpress.XtraEditors.XtraUserControl
    {
        //ExpertContext context;
        public CustomersListView()
        {
            InitializeComponent();
            //context = new ExpertContext();
            //BindingSource source = new BindingSource();
            //List<Customer> customers;
            //context.Customers.Load();
            //customers = context.Customers.Local.ToList();
            //source.DataSource = customers;
            //dataLayoutControl1.AllowGeneratingCollectionProperties = DefaultBoolean.True;
            //dataLayoutControl1.DataSource = source;
            //dataLayoutControl1.RetrieveFields();
            //dataLayoutControl1.BestFit();

        }
    }
}