using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class MessageConfigurations : EntityTypeConfiguration<Message>
    {
        public MessageConfigurations()
        {
            ToTable("Messages");

            Property(e => e.String_data)
                .IsUnicode();
        }
    }
}
