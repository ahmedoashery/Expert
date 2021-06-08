using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class OrderConfigurations : EntityTypeConfiguration<Order>
    {
        public OrderConfigurations()
        {
            ToTable("Orders");


            Property(e => e.Ship_name)
               .HasMaxLength(50)
            .IsUnicode();


            Property(e => e.Ship_address)
                .HasMaxLength(200)
            .IsUnicode();


            Property(e => e.Ship_city)
                .HasMaxLength(50)
            .IsUnicode();


            Property(e => e.Ship_state_province)
                .HasMaxLength(50)
            .IsUnicode();


            Property(e => e.Ship_zip_postal_code)
                .HasMaxLength(50)
            .IsUnicode();


            Property(e => e.Ship_country_region)
                .HasMaxLength(50)
            .IsUnicode();


            Property(e => e.Payment_type)
                .HasMaxLength(50)
            .IsUnicode();


            Property(e => e.Notes)
                .HasMaxLength(255)
            .IsUnicode();


            HasMany(e => e.Inventory_transactions)
            .WithRequired(e => e.Order)
            .HasForeignKey(e => e.Customer_order_id)
            .WillCascadeOnDelete(false);


            HasMany(e => e.Invoices)
            .WithRequired(e => e.Order)
            .HasForeignKey(e => e.Order_id)
            .WillCascadeOnDelete(false);


            HasMany(e => e.Order_details)
            .WithRequired(e => e.Order)
            .HasForeignKey(e => e.Order_id)
            .WillCascadeOnDelete(false);
        }
    }
}
