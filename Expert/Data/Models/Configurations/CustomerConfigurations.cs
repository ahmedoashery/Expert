using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class CustomerConfigurations : EntityTypeConfiguration<Customer>
    {
        public CustomerConfigurations()
        {
            ToTable("Customers");

            Property(e => e.Company)
            .HasMaxLength(50)
            .IsUnicode();

            Property(e => e.Last_name)
            .HasMaxLength(50)
            .IsUnicode();

            Property(e => e.First_name)
            .HasMaxLength(50)
            .IsUnicode();

            Property(e => e.Email_address)
            .HasMaxLength(200)
            .IsUnicode();

            Property(e => e.Job_title)
            .HasMaxLength(50)
            .IsUnicode();

            Property(e => e.Business_phone)
            .HasMaxLength(50)
            .IsUnicode();

            Property(e => e.Home_phone)
            .HasMaxLength(50)
            .IsUnicode();

            Property(e => e.Mobile_phone)
            .HasMaxLength(50)
            .IsUnicode();

            Property(e => e.Fax_number)
            .HasMaxLength(50)
            .IsUnicode();

            Property(e => e.Address)
            .HasMaxLength(50)
            .IsUnicode();

            Property(e => e.City)
            .HasMaxLength(50)
            .IsUnicode();

            Property(e => e.State_province)
            .HasMaxLength(50)
            .IsUnicode();

            Property(e => e.Zip_postal_code)
            .HasMaxLength(50)
            .IsUnicode();

            Property(e => e.Country_region)
            .HasMaxLength(50)
            .IsUnicode();

            Property(e => e.Web_page)
            .HasMaxLength(200)
            .IsUnicode();

            Property(e => e.Notes)
            .HasMaxLength(255)
            .IsUnicode();

            HasMany(e => e.Orders)
            .WithRequired(e => e.Customer)
            .HasForeignKey(e => e.Customer_id)
            .WillCascadeOnDelete(false);
        }
    }
}
