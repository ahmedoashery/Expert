using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class SalesReportConfigurations : EntityTypeConfiguration<SalesReport>
    {
        public SalesReportConfigurations()
        {
            ToTable("Sales_Reports");

            Property(e => e.Group_by)
                .IsUnicode();

            Property(e => e.Display)
                .IsUnicode();

            Property(e => e.Title)
                .IsUnicode();

            Property(e => e.Filter_row_source)
                .IsUnicode();
        }
    }
}
