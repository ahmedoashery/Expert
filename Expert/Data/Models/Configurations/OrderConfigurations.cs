using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert.Data.Models.Configurations
{
    public class OrderConfigurations: EntityTypeConfiguration<Order>
    {
        public OrderConfigurations()
        {
            ToTable("Orders");

            HasKey(o => o.ID);

            Property(o => o.Date)
                .HasColumnType("Datetime");

            HasMany(o => o.Products)
                .WithMany(p => p.Orders)
                .Map(m => {
                    m.ToTable("Order_Products");
                    m.MapLeftKey("Order_id");
                    m.MapRightKey("Product_id");
                });

        }
    }
}
