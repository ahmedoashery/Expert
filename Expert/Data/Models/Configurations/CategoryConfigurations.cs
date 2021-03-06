using System.Data.Entity.ModelConfiguration;

namespace Expert.Data.Models.Configurations
{
    public class CategoryConfigurations : EntityTypeConfiguration<Category>
    {
        public CategoryConfigurations()
        {
            ToTable("Categories");

            HasKey(c => c.ID);

            HasIndex(c => c.Name)
                .IsUnique();

            Property(c => c.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode();

            HasMany(c => c.Products)
                .WithRequired(p => p.Category)
                .HasForeignKey(p => p.Category_id)
                .WillCascadeOnDelete(false);
        }
    }
}
