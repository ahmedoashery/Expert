using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class OrderDetailConfigurations : EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailConfigurations()
        {
            ToTable("Order_Details");


        }
    }
}
