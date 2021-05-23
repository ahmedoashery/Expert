using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class CategoryConfigurations : EntityTypeConfiguration<Category>
    {
        public CategoryConfigurations()
        {
            ToTable("Cateogries");

            HasKey(c => c.Category_id);

            HasIndex(c => c.Name)
                .IsUnique();

            Property(c => c.Name)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsUnicode(true);

            Property(c => c.Description)
                .HasColumnType("nvarchar")
                .HasMaxLength(255)
                .IsUnicode(true);

        }
    }
}
