using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    class ProductConfigurations : EntityTypeConfiguration<Product>
    {
        public ProductConfigurations()
        {
            ToTable("Products");

            HasKey(p => p.Product_id);
            HasIndex(p => p.Name)
                .IsUnique();

            Property(p => p.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode(true);

            Property(p => p.Description)
                .HasColumnType("nvarchar")
                .HasMaxLength(255)
                .IsUnicode(true);

            Property(p => p.QuantityInStock)
                .HasColumnType("decimal")
                .HasPrecision(18, 2)
                .IsOptional();

            Property(p => p.Price)
                .HasColumnType("decimal")
                .HasPrecision(18, 2)
                .IsOptional();
        }
    }
}
