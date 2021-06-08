using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class InventoryTransactionTypeConfigurations : EntityTypeConfiguration<InventoryTransactionType>
    {
        public InventoryTransactionTypeConfigurations()
        {
            ToTable("Inventory_Transaction_Types");

            Property(e => e.type_name)
             .HasMaxLength(50)
            .IsUnicode();

            HasMany(e => e.inventory_transactions)
            .WithRequired(e => e.Inventory_transaction_types)
            .HasForeignKey(e => e.Transaction_type_id)
            .WillCascadeOnDelete(false);
        }
    }
}
