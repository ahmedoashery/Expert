using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class SaleOrderDetailConfigurations : EntityTypeConfiguration<SaleOrderDetail>
    {
        public SaleOrderDetailConfigurations()
        {
            ToTable("Sale_Order_Details");


        }
    }
}
