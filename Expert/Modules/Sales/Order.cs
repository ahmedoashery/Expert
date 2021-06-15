using DevExpress.XtraGrid.Views.Grid;
using Expert.Data.Services;

namespace Expert.Modules.Sales
{
    public partial class Order : EditFormUserControl
    {
        public Order()
        {
            InitializeComponent();

            RightToLeft = Properties.Settings.Default.RightToLeft;

            saleOrderBindingSource.DataSource = DataSources.OrdersBindingList();
            employeeBindingSource.DataSource = DataSources.EmployeesBindingList();
            customerBindingSource.DataSource = DataSources.CustomersBindingList();
            sale_orders_statusBindingSource.DataSource = DataSources.Orders_statusBindingList();
            shipperBindingSource.DataSource = DataSources.ShippersBindingList();
            productBindingSource.DataSource = DataSources.ProductsBindingList();
            //categoryBindingSource.DataSource = DataSources.CategoriesBindingList();
            //supplierBindingSource.DataSource = DataSources.SuppliersBindingList();

            SetBoundFieldName(IDTextEdit, "ID");
            SetBoundPropertyName(IDTextEdit, "EditValue");

            SetBoundFieldName(Employee_idSearchLookUpEdit, "Employee_id");
            SetBoundPropertyName(Employee_idSearchLookUpEdit, "EditValue");
            Employee_idSearchLookUpEdit.Properties.DisplayMember = "First_name";
            Employee_idSearchLookUpEdit.Properties.ValueMember = "ID";

            SetBoundFieldName(Customer_idSearchLookUpEdit, "Customer_id");
            SetBoundPropertyName(Customer_idSearchLookUpEdit, "EditValue");
            Customer_idSearchLookUpEdit.Properties.DisplayMember = "First_name";
            Customer_idSearchLookUpEdit.Properties.ValueMember = "ID";

            SetBoundFieldName(Creation_dateDateEdit, "Creation_date");
            SetBoundPropertyName(Creation_dateDateEdit, "EditValue");

            SetBoundFieldName(Status_idSearchLookUpEdit, "Status_id");
            SetBoundPropertyName(Status_idSearchLookUpEdit, "EditValue");
            Status_idSearchLookUpEdit.Properties.DisplayMember = "Status_name";
            Status_idSearchLookUpEdit.Properties.ValueMember = "ID";

            SetBoundFieldName(NotesTextEdit, "Notes");
            SetBoundPropertyName(NotesTextEdit, "EditValue");

            SetBoundFieldName(Shipped_dateDateEdit, "Shipped_date");
            SetBoundPropertyName(Shipped_dateDateEdit, "EditValue");

            SetBoundFieldName(Shipper_idSearchLookUpEdit, "Shipper_id");
            SetBoundPropertyName(Shipper_idSearchLookUpEdit, "EditValue");
            Shipper_idSearchLookUpEdit.Properties.DisplayMember = "First_name";
            Shipper_idSearchLookUpEdit.Properties.ValueMember = "ID";

            SetBoundFieldName(Ship_nameTextEdit, "Ship_name");
            SetBoundPropertyName(Ship_nameTextEdit, "EditValue");

            SetBoundFieldName(Ship_addressTextEdit, "Ship_address");
            SetBoundPropertyName(Ship_addressTextEdit, "EditValue");

            SetBoundFieldName(Ship_cityTextEdit, "Ship_city");
            SetBoundPropertyName(Ship_cityTextEdit, "EditValue");

            SetBoundFieldName(Ship_state_provinceTextEdit, "Ship_state_province");
            SetBoundPropertyName(Ship_state_provinceTextEdit, "EditValue");

            SetBoundFieldName(Ship_zip_postal_codeTextEdit, "Ship_zip_postal_code");
            SetBoundPropertyName(Ship_zip_postal_codeTextEdit, "EditValue");

            SetBoundFieldName(Ship_country_regionTextEdit, "Ship_country_region");
            SetBoundPropertyName(Ship_country_regionTextEdit, "EditValue");

            SetBoundFieldName(Shipping_feeTextEdit, "Shipping_fee");
            SetBoundPropertyName(Shipping_feeTextEdit, "EditValue");

            SetBoundFieldName(Payment_typeTextEdit, "Payment_type");
            SetBoundPropertyName(Payment_typeTextEdit, "EditValue");

            SetBoundFieldName(Paid_dateDateEdit, "Paid_date");
            SetBoundPropertyName(Paid_dateDateEdit, "EditValue");

            SetBoundFieldName(DiscountTextEdit, "Discount");
            SetBoundPropertyName(DiscountTextEdit, "EditValue");

            SetBoundFieldName(Order_detailsGridControl, "Order_details");
            SetBoundPropertyName(Order_detailsGridControl, "DataSource");
        }
    }
}
