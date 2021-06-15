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
        public virtual DbSet<SaleOrderDetail> Sale_order_details { get; set; }
        public virtual DbSet<SaleOrder> SaleOrders { get; set; }
        public virtual DbSet<SaleOrderStatus> Sale_orders_status { get; set; }
        public virtual DbSet<Privilege> Privileges { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<PurchaseOrderDetail> Purchase_order_details { get; set; }
        public virtual DbSet<PurchaseOrderStatus> Purchase_order_status { get; set; }
        public virtual DbSet<PurchaseOrder> Purchase_orders { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<ProductUnit> ProductUnits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryConfigurations());
            modelBuilder.Configurations.Add(new CustomerConfigurations());
            modelBuilder.Configurations.Add(new EmployeeConfigurations());
            modelBuilder.Configurations.Add(new SaleOrderDetailConfigurations());
            modelBuilder.Configurations.Add(new SaleOrderConfigurations());
            modelBuilder.Configurations.Add(new SaleOrderStatusConfigurations());
            modelBuilder.Configurations.Add(new PrivilegeConfigurations());
            modelBuilder.Configurations.Add(new ProductConfigurations());
            modelBuilder.Configurations.Add(new PurchaseOrderDetailConfigurations());
            modelBuilder.Configurations.Add(new PurchaseOrderStatusConfigurations());
            modelBuilder.Configurations.Add(new PurchaseOrderConfigurations());
            modelBuilder.Configurations.Add(new ShipperConfigurations());
            modelBuilder.Configurations.Add(new MessageConfigurations());
            modelBuilder.Configurations.Add(new SupplierConfigurations());
            modelBuilder.Configurations.Add(new ProductUnitConfigurations());
        }
    }
}
