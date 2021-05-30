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
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<SaleOrder> SalesOrders { get; set; }
        public virtual DbSet<PurchaseOrder> PurchasesOrders { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryConfigurations());
            modelBuilder.Configurations.Add(new ProductConfigurations());
            modelBuilder.Configurations.Add(new SupplierConfigurations());
            modelBuilder.Configurations.Add(new CustomerConfigurations());
            modelBuilder.Configurations.Add(new SaleOrderConfigurations());
            modelBuilder.Configurations.Add(new PurchaseOrderConfigurations());
            modelBuilder.Configurations.Add(new UserConfigurations());

            base.OnModelCreating(modelBuilder);
        }
    }
}
