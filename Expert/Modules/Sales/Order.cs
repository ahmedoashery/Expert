using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Expert.Data.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expert.Modules.Sales
{
    public partial class Order : EditFormUserControl
    {
        public Order()
        {
            InitializeComponent();

            OrderBindingSource.DataSource = DataSources.OrdersBindingList();
            employeeBindingSource.DataSource = DataSources.EmployeesBindingList();
            customerBindingSource.DataSource = DataSources.CustomersBindingList();
            orderStatusBindingSource.DataSource = DataSources.Orders_statusBindingList();
            shipperBindingSource.DataSource = DataSources.ShippersBindingList();
            orderTaxStatusBindingSource.DataSource = DataSources.Orders_tax_statusBindingList();
            productBindingSource.DataSource = DataSources.ProductsBindingList();
            orderDetailStatusBindingSource.DataSource = DataSources.Order_details_statusBindingList();
            categoryBindingSource.DataSource = DataSources.CategoriesBindingList();
            supplierBindingSource.DataSource = DataSources.SuppliersBindingList();

            SetBoundFieldName(IDTextEdit, "ID");
            SetBoundPropertyName(IDTextEdit, "EditValue");

            SetBoundFieldName(Employee_idTextEdit, "Employee_id");
            SetBoundPropertyName(Employee_idTextEdit, "EditValue");
            Employee_idTextEdit.Properties.DisplayMember = "First_name";
            Employee_idTextEdit.Properties.ValueMember = "ID";

            SetBoundFieldName(Customer_idTextEdit, "Customer_id");
            SetBoundPropertyName(Customer_idTextEdit, "EditValue");
            Customer_idTextEdit.Properties.DisplayMember = "First_name";
            Customer_idTextEdit.Properties.ValueMember = "ID";

            SetBoundFieldName(Order_dateDateEdit, "Order_date");
            SetBoundPropertyName(Order_dateDateEdit, "EditValue");

            SetBoundFieldName(Status_idTextEdit, "Status_id");
            SetBoundPropertyName(Status_idTextEdit, "EditValue");
            Status_idTextEdit.Properties.DisplayMember = "Status_name" ;
            Status_idTextEdit.Properties.ValueMember = "ID";

            SetBoundFieldName(NotesTextEdit, "Notes");
            SetBoundPropertyName(NotesTextEdit, "EditValue");

            SetBoundFieldName(Shipped_dateDateEdit, "Shipped_date");
            SetBoundPropertyName(Shipped_dateDateEdit, "EditValue");

            SetBoundFieldName(Shipper_idTextEdit, "Shipper_id");
            SetBoundPropertyName(Shipper_idTextEdit, "EditValue");
            Shipper_idTextEdit.Properties.DisplayMember = "First_name";
            Shipper_idTextEdit.Properties.ValueMember = "ID";

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

            SetBoundFieldName(TaxesTextEdit, "Taxes");
            SetBoundPropertyName(TaxesTextEdit, "EditValue");

            SetBoundFieldName(Tax_rateTextEdit, "Tax_rate");
            SetBoundPropertyName(Tax_rateTextEdit, "EditValue");

            SetBoundFieldName(Tax_status_idTextEdit, "Tax_status_id");
            SetBoundPropertyName(Tax_status_idTextEdit, "EditValue");
            Tax_status_idTextEdit.Properties.DisplayMember = "Tax_status_name";
            Tax_status_idTextEdit.Properties.ValueMember = "ID";

            SetBoundFieldName(Order_detailsGridControl, "Order_details");
            SetBoundPropertyName(Order_detailsGridControl, "DataSource");

        }
    }
}
