using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    class SaleOrderConfigurations : EntityTypeConfiguration<SaleOrder>
    {
        public SaleOrderConfigurations()
        {
            ToTable("Sales_Orders");

            HasKey(o => o.Order_id);

            Property(o => o.Date)
                .HasColumnType("datetime")
                .IsRequired();

            Property(o => o.Notes)
                .HasColumnType("nvarchar")
                .HasMaxLength(255)
                .IsUnicode(true);

            HasMany(o => o.Products)
                .WithMany(p => p.SalesOrders)
                .Map(m =>
                {
                    m.ToTable("Sales_Orders_Details");
                    m.MapLeftKey("Order_id");
                    m.MapRightKey("Product_id");
                });
        }
    }
}
