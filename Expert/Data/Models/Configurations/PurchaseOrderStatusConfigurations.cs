using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class PurchaseOrderStatusConfigurations : EntityTypeConfiguration<PurchaseOrderStatus>
    {
        public PurchaseOrderStatusConfigurations()
        {
            ToTable("Purchase_Order_Statuses");

            Property(e => e.Status_name)
                .HasMaxLength(50)
                .IsUnicode();

            HasMany(e => e.Purchase_orders)
                .WithRequired(e => e.Purchase_order_status)
                .HasForeignKey(e => e.Status_id)
                .WillCascadeOnDelete(false);
        }
    }
}
