using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert.Data.Models.Configurations
{
    public class SupplierConfigurations: EntityTypeConfiguration<Supplier>
    {
        public SupplierConfigurations()
        {
            ToTable("Suppliers");

            HasKey(s => s.ID);

            HasIndex(s=> s.Name)
                .IsUnique();

            Property(s => s.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode();

            HasMany(s => s.Products)
                .WithRequired(p => p.Supplier)
                .HasForeignKey(p => p.Supplier_id)
                .WillCascadeOnDelete(false);
        }
    }
}
