using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class SaleOrderStatusConfigurations : EntityTypeConfiguration<SaleOrderStatus>
    {
        public SaleOrderStatusConfigurations()
        {
            ToTable("Sale_Order_Statuses");

            Property(e => e.Status_name)
                .HasMaxLength(50)
                .IsUnicode();

            HasMany(e => e.Orders)
                .WithRequired(e => e.Order_status)
                .HasForeignKey(e => e.Status_id)
                .WillCascadeOnDelete(false);
        }
    }
}
