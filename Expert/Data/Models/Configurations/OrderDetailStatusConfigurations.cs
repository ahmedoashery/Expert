using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class OrderDetailStatusConfigurations : EntityTypeConfiguration<OrderDetailStatus>
    {
        public OrderDetailStatusConfigurations()
        {
            ToTable("Order_Detail_Statuses");

            Property(e => e.Status_name)
                .HasMaxLength(50)
                .IsUnicode();


            HasMany(e => e.Order_details)
                .WithRequired(e => e.Order_details_status)
                .HasForeignKey(e => e.Status_id)
                .WillCascadeOnDelete(false);
        }
    }
}
