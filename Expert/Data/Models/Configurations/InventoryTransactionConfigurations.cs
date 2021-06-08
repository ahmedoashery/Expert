using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class InventoryTransactionConfigurations : EntityTypeConfiguration<InventoryTransaction>
    {
        public InventoryTransactionConfigurations()
        {
            ToTable("Inventory_Transactions");
            Property(e => e.Comments)
                .HasMaxLength(200)
                .IsUnicode();

            HasMany(e => e.Purchase_order_details)
                .WithRequired(e => e.Inventory_transactions)
                .HasForeignKey(e => e.Inventory_id)
                .WillCascadeOnDelete(false);
        }
    }
}
