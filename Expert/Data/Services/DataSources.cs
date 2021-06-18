using Expert.Data.Models;
using System.ComponentModel;
using System.Data.Entity;

namespace Expert.Data.Services
{
    public class DataSources
    {
        // Instantiate a new DBContext
        public static ExpertContext dbContext = new ExpertContext();

        public static BindingList<SaleOrder> OrdersBindingList()
        {
            dbContext.SaleOrders.LoadAsync();
            // Bind data to control when loading complete
            return dbContext.SaleOrders.Local.ToBindingList();
        }

        public static BindingList<Employee> EmployeesBindingList()
        {
            var data = new BindingList<Employee>();
            dbContext.Employees.LoadAsync();
            // Bind data to control when loading complete
            return dbContext.Employees.Local.ToBindingList();
        }

        public static BindingList<Customer> CustomersBindingList()
        {
            dbContext.Customers.LoadAsync();
            // Bind data to control when loading complete
            return dbContext.Customers.Local.ToBindingList();
        }

        public static BindingList<SaleOrderDetail> OrderDetailsBindingList()
        {
            dbContext.Sale_order_details.LoadAsync();
            return dbContext.Sale_order_details.Local.ToBindingList();
        }

        public static BindingList<Shipper> ShippersBindingList()
        {
            dbContext.Shippers.LoadAsync();
            // Bind data to control when loading complete
            return dbContext.Shippers.Local.ToBindingList();
        }

        public static BindingList<SaleOrderStatus> Orders_statusBindingList()
        {
            dbContext.Sale_orders_status.LoadAsync();
            // Bind data to control when loading complete
            return dbContext.Sale_orders_status.Local.ToBindingList();
        }

        public static BindingList<Product> ProductsBindingList()
        {
            dbContext.Products.LoadAsync();
            // Bind data to control when loading complete
            return dbContext.Products.Local.ToBindingList();
        }

        public static BindingList<PurchaseOrder> Purchase_ordersBindingList()
        {
            dbContext.Purchase_orders.LoadAsync();
            // Bind data to control when loading complete
            return dbContext.Purchase_orders.Local.ToBindingList();
        }

        public static BindingList<Category> CategoriesBindingList()
        {
            dbContext.Categories.LoadAsync();
            // Bind data to control when loading complete
            return dbContext.Categories.Local.ToBindingList();
        }

        public static BindingList<Supplier> SuppliersBindingList()
        {
            dbContext.Suppliers.LoadAsync();
            // Bind data to control when loading complete
            return dbContext.Suppliers.Local.ToBindingList();
        }

    }
}
