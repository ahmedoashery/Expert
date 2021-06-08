using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class InvoiceConfigurations : EntityTypeConfiguration<Invoice>
    {
        public InvoiceConfigurations()
        {
            ToTable("Invoices");
        }
    }
}
