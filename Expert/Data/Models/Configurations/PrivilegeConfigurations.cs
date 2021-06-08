using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class PrivilegeConfigurations : EntityTypeConfiguration<Privilege>
    {
        public PrivilegeConfigurations()
        {
            ToTable("Privileges");

            Property(e => e.Privilege_name)
                .HasMaxLength(50)
                .IsUnicode();
        }
    }
}
