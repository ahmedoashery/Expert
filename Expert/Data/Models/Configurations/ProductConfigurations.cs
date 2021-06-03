using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert.Data.Models.Configurations
{
    public class ProductConfigurations: EntityTypeConfiguration<Product>
    {
        public ProductConfigurations()
        {
            ToTable("Products");

            HasKey(p => p.ID);

            HasIndex(p => p.Name)
                .IsUnique();
            Property(p => p.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode();
        }
    }
}
