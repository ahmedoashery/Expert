using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    class SalesOrderConfigurations : EntityTypeConfiguration<SalesOrder>
    {
        public SalesOrderConfigurations()
        {
            ToTable("Sales_Orders");

            HasKey(o => o.Order_id);

            Property(o => o.Date)
                .HasColumnType("datetime")
                .IsRequired();

            Property(o => o.Notes)
                .HasColumnType("nvarchar")
                .HasMaxLength(255)
                .IsUnicode(true);
        }
    }
}
