using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class EmployeeConfigurations : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfigurations()
        {
            ToTable("Employees");

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
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.Employee_id)
                .WillCascadeOnDelete(false);


            HasMany(e => e.Purchase_orders)
            .WithRequired(e => e.Employee)
            .HasForeignKey(e => e.Created_by)
            .WillCascadeOnDelete(false);


            HasMany(e => e.Privileges)
            .WithMany(e => e.Employees)
            .Map(m => m.ToTable("employee_privileges"));
        }
    }
}
