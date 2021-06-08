using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class OrderStatusConfigurations : EntityTypeConfiguration<OrderStatus>
    {
        public OrderStatusConfigurations()
        {
            ToTable("Order_Statuses");

            Property(e => e.Status_name)
                .HasMaxLength(50)
                .IsUnicode();

            HasMany(e => e.Orders)
                .WithRequired(e => e.Orders_status)
                .HasForeignKey(e => e.Status_id)
                .WillCascadeOnDelete(false);
        }
    }
}
