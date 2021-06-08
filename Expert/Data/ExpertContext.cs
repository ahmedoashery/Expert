using Expert.Data.Models;
using Expert.Data.Models.Configurations;
using System.Data.Entity;

namespace Expert.Data
{
    public class ExpertContext : DbContext
    {
        public ExpertContext() : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<InventoryTransactionType> Inventory_transaction_types { get; set; }
        public virtual DbSet<InventoryTransaction> Inventory_transactions { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<OrderDetail> Order_details { get; set; }
        public virtual DbSet<OrderDetailStatus> Order_details_status { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderStatus> Orders_status { get; set; }
        public virtual DbSet<OrderTaxStatus> Orders_tax_status { get; set; }
        public virtual DbSet<Privilege> Privileges { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<PurchaseOrderDetail> Purchase_order_details { get; set; }
        public virtual DbSet<PurchaseOrderStatus> Purchase_order_status { get; set; }
        public virtual DbSet<PurchaseOrder> Purchase_orders { get; set; }
        public virtual DbSet<SalesReport> Sales_reports { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryConfigurations());
            modelBuilder.Configurations.Add(new CustomerConfigurations());
            modelBuilder.Configurations.Add(new EmployeeConfigurations());
            modelBuilder.Configurations.Add(new InventoryTransactionTypeConfigurations());
            modelBuilder.Configurations.Add(new InventoryTransactionConfigurations());
            modelBuilder.Configurations.Add(new InvoiceConfigurations());
            modelBuilder.Configurations.Add(new OrderDetailConfigurations());
            modelBuilder.Configurations.Add(new OrderDetailStatusConfigurations());
            modelBuilder.Configurations.Add(new OrderConfigurations());
            modelBuilder.Configurations.Add(new OrderStatusConfigurations());
            modelBuilder.Configurations.Add(new OrderTaxStatusConfigurations());
            modelBuilder.Configurations.Add(new PrivilegeConfigurations());
            modelBuilder.Configurations.Add(new ProductConfigurations());
            modelBuilder.Configurations.Add(new PurchaseOrderDetailConfigurations());
            modelBuilder.Configurations.Add(new PurchaseOrderStatusConfigurations());
            modelBuilder.Configurations.Add(new PurchaseOrderConfigurations());
            modelBuilder.Configurations.Add(new SalesReportConfigurations());
            modelBuilder.Configurations.Add(new ShipperConfigurations());
            modelBuilder.Configurations.Add(new MessageConfigurations());
            modelBuilder.Configurations.Add(new SupplierConfigurations());
        }
    }
}
