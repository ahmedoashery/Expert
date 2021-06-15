using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class PurchaseOrderConfigurations : EntityTypeConfiguration<PurchaseOrder>
    {
        public PurchaseOrderConfigurations()
        {
            ToTable("Purchase_Orders");

            Property(e => e.Payment_method)
                .HasMaxLength(50)
                .IsUnicode();

            Property(e => e.Notes)
                .HasMaxLength(255)
                .IsUnicode();

            HasMany(e => e.Purchase_order_details)
                .WithRequired(e => e.Purchase_orders)
                .HasForeignKey(e => e.Order_id)
                .WillCascadeOnDelete(false);
        }
    }
}
