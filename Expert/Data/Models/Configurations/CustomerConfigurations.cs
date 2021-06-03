using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert.Data.Models.Configurations
{
    public class CustomerConfigurations: EntityTypeConfiguration<Customer>
    {
        public CustomerConfigurations()
        {
            ToTable("Customers");

            HasKey(c => c.ID);

            HasIndex(c => c.Name)
                .IsUnique();

            Property(c => c.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode();

            HasMany(c => c.Orders)
                .WithRequired(o => o.Customer)
                .HasForeignKey(o => o.Customer_id)
                .WillCascadeOnDelete(false);

        }
    }
}
