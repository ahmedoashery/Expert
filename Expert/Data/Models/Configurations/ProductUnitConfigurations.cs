using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class ProductUnitConfigurations : EntityTypeConfiguration<ProductUnit>
    {
        public ProductUnitConfigurations()
        {
            ToTable("Product_Units");

            HasIndex(e => e.Name)
                .IsUnique();


            Property(e => e.Name)
            .HasMaxLength(50)
            .IsUnicode();

            Property(e => e.Quantity_per_unit)
            .HasMaxLength(50)
            .IsUnicode();

            HasMany(e => e.Products)
            .WithRequired(e => e.Unit)
            .HasForeignKey(e => e.Unit_id)
            .WillCascadeOnDelete(false);
        }
    }
}
