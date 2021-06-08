using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class PurchaseOrderDetailConfigurations : EntityTypeConfiguration<PurchaseOrderDetail>
    {
        public PurchaseOrderDetailConfigurations()
        {
            ToTable("Purchase_Order_Details");

        }
    }
}
