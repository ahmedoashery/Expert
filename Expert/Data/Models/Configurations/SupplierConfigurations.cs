using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class SupplierConfigurations: EntityTypeConfiguration<Supplier>
    {
        public SupplierConfigurations()
        {
            ToTable("Suppliers");

            HasKey(s => s.Supplier_id);

            HasIndex(s => s.Name)
                .IsUnique();

            Property(s => s.Code)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsUnicode(true);

            Property(s => s.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode(true);

            HasMany(s => s.Products)
                .WithRequired(p => p.Supplier)
                .HasForeignKey(p => p.Supplier_id)
                .WillCascadeOnDelete(false);
        }
    }
}
