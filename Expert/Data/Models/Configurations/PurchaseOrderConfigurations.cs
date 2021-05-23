using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    class PurchaseOrderConfigurations : EntityTypeConfiguration<PurchaseOrder>
    {
        public PurchaseOrderConfigurations()
        {
            ToTable("Purchases_Orders");

            HasKey(o => o.Order_id);

            Property(o => o.Date)
                .HasColumnType("datetime")
                .IsRequired();

            Property(o => o.Notes)
                .HasColumnType("nvarchar")
                .HasMaxLength(255)
                .IsUnicode(true);

            HasMany(o => o.Products)
                .WithMany(p => p.PurchasesOrders)
                .Map(m =>
                {
                    m.ToTable("Purchases_Orders_Details");
                    m.MapLeftKey("Order_id");
                    m.MapRightKey("Product_id");
                });
        }
    }
}
