using Expert.Data.Models;
using System;
using System.ComponentModel;
using System.Data.Entity;

namespace Expert.Data.Services
{
    public class DataSources
    {
        // Instantiate a new DBContext
        public static ExpertContext dbContext = new ExpertContext();

        public static BindingList<Order> OrdersBindingList()
        {
            dbContext.Orders.LoadAsync();
            // Bind data to control when loading complete
            return dbContext.Orders.Local.ToBindingList();
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

        public static BindingList<OrderDetail> OrderDetailsBindingList()
        {
            dbContext.Order_details.LoadAsync();
            return dbContext.Order_details.Local.ToBindingList();
        }

        public static BindingList<Shipper> ShippersBindingList()
        {
            dbContext.Shippers.LoadAsync();
            // Bind data to control when loading complete
            return dbContext.Shippers.Local.ToBindingList();
        }

        public static BindingList<OrderTaxStatus> Orders_tax_statusBindingList()
        {
            dbContext.Orders_tax_status.LoadAsync();
            // Bind data to control when loading complete
            return dbContext.Orders_tax_status.Local.ToBindingList();
        }

        public static BindingList<OrderStatus> Orders_statusBindingList()
        {
            dbContext.Orders_status.LoadAsync();
            // Bind data to control when loading complete
            return dbContext.Orders_status.Local.ToBindingList();
        }

        public static BindingList<OrderDetailStatus> Order_details_statusBindingList()
        {
            dbContext.Order_details_status.LoadAsync();
            // Bind data to control when loading complete
            return dbContext.Order_details_status.Local.ToBindingList();
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


    }
}
