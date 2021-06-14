using DevExpress.XtraBars;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraGrid.Views.Grid;
using Expert.Data.Services;

namespace Expert.Modules.Sales
{
    public partial class OrdersList : DevExpress.XtraEditors.XtraForm
    {
        public OrdersList()
        {
            InitializeComponent();

            ordersBindingSource.DataSource = DataSources.OrdersBindingList();

            employeeBindingSource.DataSource = DataSources.EmployeesBindingList();

            customerBindingSource.DataSource = DataSources.CustomersBindingList();

            shipperBindingSource.DataSource = DataSources.ShippersBindingList();

            orderTaxStatusBindingSource.DataSource = DataSources.Orders_tax_statusBindingList();

            orderStatusBindingSource.DataSource = DataSources.Orders_statusBindingList();

            orderDetailBindingSource.DataSource = DataSources.OrderDetailsBindingList();

            orderDetailStatusBindingSource.DataSource = DataSources.Order_details_statusBindingList();

            productBindingSource.DataSource = DataSources.ProductsBindingList();

            purchaseOrderBindingSource.DataSource = DataSources.Purchase_ordersBindingList();

            //Assign an instance of CustomEditForm to the GridOptionsEditForm.CustomEditFormLayout property
            //to use the CustomEditForm as an EditForm within the grid
            OrdersListGridView.OptionsBehavior.EditingMode = GridEditingMode.EditForm;
            OrdersListGridView.OptionsEditForm.CustomEditFormLayout = new Order();
        }

        private void BbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            DataSources.dbContext.SaveChanges();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            ordersBindingSource.AddNew();
            OrdersListGridView.ShowPopupEditForm();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            OrdersListGridView.ShowPopupEditForm();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Remove :" + OrdersListGridView.GetSelectedRows().Count() + " Records.?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (var row in OrdersListGridView.GetSelectedRows())
                    return; // Te Be Removed and changed....
                            //OrdersListGridView.SetRowCellValue(row, colDeleted, true);
            }
            return;
        }

        private void OrdersList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DataSources.dbContext.ChangeTracker.HasChanges())
            {
                var ask = MessageBox.Show("Exit without saving changes?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (ask == DialogResult.OK) { e.Cancel = false; }
                if (ask == DialogResult.Cancel) { e.Cancel = true; }
            }
        }

        private void OrdersListGridView_ShowingPopupEditForm(object sender, ShowingPopupEditFormEventArgs e)
        {
            //MessageBox.Show(e.RowHandle.ToString());
        }
    }
}