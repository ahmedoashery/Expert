using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class ProductConfigurations : EntityTypeConfiguration<Product>
    {
        public ProductConfigurations()
        {
            ToTable("Products");


            HasIndex(e => e.Code)
                .IsUnique();

            HasIndex(e => e.Name)
                .IsUnique();

            Property(e => e.Code)
            .HasMaxLength(50)
            .IsUnicode();


            Property(e => e.Name)
            .HasMaxLength(50)
            .IsUnicode();


            Property(e => e.Description)
            .HasMaxLength(200)
            .IsUnicode();

            HasMany(e => e.Sale_order_details)
            .WithRequired(e => e.Product)
            .HasForeignKey(e => e.Product_id)
            .WillCascadeOnDelete(false);


            HasMany(e => e.Purchase_order_details)
            .WithRequired(e => e.Product)
            .HasForeignKey(e => e.Product_id)
            .WillCascadeOnDelete(false);
        }
    }
}
