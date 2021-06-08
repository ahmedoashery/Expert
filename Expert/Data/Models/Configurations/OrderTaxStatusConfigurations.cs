using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class OrderTaxStatusConfigurations : EntityTypeConfiguration<OrderTaxStatus>
    {
        public OrderTaxStatusConfigurations()
        {
            ToTable("Order_Tax_Statuses");

            Property(e => e.Tax_status_name)
                .HasMaxLength(50)
                .IsUnicode();

            HasMany(e => e.Orders)
                .WithRequired(e => e.Orders_tax_status)
                .HasForeignKey(e => e.Tax_status_id)
                .WillCascadeOnDelete(false);
        }
    }
}
