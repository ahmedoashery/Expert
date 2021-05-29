using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    class UserConfigurations: EntityTypeConfiguration<User>
    {
        public UserConfigurations()
        {
            ToTable("Users");

            HasKey(u => u.Userid);

            HasIndex(u => u.Username)
                .IsUnique();

            Property(u => u.Username)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode(true);
        }
    }
}
