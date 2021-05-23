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
                .HasMaxLength(50)
                .HasColumnType("nvarchar")
                .IsUnicode(true);

        }
    }
}
