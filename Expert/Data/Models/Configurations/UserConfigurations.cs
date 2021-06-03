using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert.Data.Models.Configurations
{
    public class UserConfigurations : EntityTypeConfiguration<User>
    {
        public UserConfigurations()
        {
            ToTable("Users");

            HasKey(u => u.ID);

            HasIndex(u => u.Username)
                .IsUnique();

            Property(u => u.Username)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode();

            Property(u => u.Password)
                .HasColumnType("nvarchar")
                .HasMaxLength(200)
                .IsRequired()
                .IsUnicode();

            
        }
    }
}
