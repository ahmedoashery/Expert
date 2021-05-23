using Expert.Data.Models;
using Expert.Data.Models.Configurations;
using System.Data.Entity;

namespace Expert.Data
{
    public class ExpertContext : DbContext
    {
        public ExpertContext() : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryConfigurations());

            base.OnModelCreating(modelBuilder);
        }
    }
}
