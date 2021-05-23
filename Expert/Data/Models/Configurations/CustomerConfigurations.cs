using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    class CustomerConfigurations : EntityTypeConfiguration<Customer>
    {
        public CustomerConfigurations()
        {
            ToTable("Customers");

            HasKey(c => c.Customer_id);

            HasIndex(s => s.Name)
                .IsUnique();

            HasIndex(s => s.Code)
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

            HasMany(c => c.Orders)
                .WithRequired(o => o.Customer)
                .HasForeignKey(o => o. Customer_id)
                .WillCascadeOnDelete(false);
        }
    }
}
