namespace Expert.Migrations
{
    using Expert.Data;
    using MySql.Data.EntityFramework;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ExpertContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySqlMigrationSqlGenerator());
        }

        protected override void Seed(ExpertContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //context.Categories.AddOrUpdate(new Data.Models.Category { ID = 1, Name = "Category 1" });
            //context.Categories.AddOrUpdate(new Data.Models.Category { ID = 2, Name = "Category 2" });
            //context.Categories.AddOrUpdate(new Data.Models.Category { ID = 3, Name = "Category 3" });
            //context.Categories.AddOrUpdate(new Data.Models.Category { ID = 4, Name = "Category 4" });
            //context.Categories.AddOrUpdate(new Data.Models.Category { ID = 5, Name = "Category 5" });

            //context.Suppliers.AddOrUpdate(new Data.Models.Supplier { ID = 1, Name = "Supplier 1" });

            //context.Customers.AddOrUpdate(new Data.Models.Customer { ID = 1, Name = "Customer 1" });

            //context.Products.AddOrUpdate(new Data.Models.Product { ID = 1, Name = "Product 1", Category_id = 1, Supplier_id = 1 });
            //context.Products.AddOrUpdate(new Data.Models.Product { ID = 2, Name = "Product 2", Category_id = 1, Supplier_id = 1 });
            //context.Products.AddOrUpdate(new Data.Models.Product { ID = 3, Name = "Product 3", Category_id = 4, Supplier_id = 1 });
            //context.Products.AddOrUpdate(new Data.Models.Product { ID = 4, Name = "Product 4", Category_id = 2, Supplier_id = 1 });
            //context.Products.AddOrUpdate(new Data.Models.Product { ID = 5, Name = "Product 5", Category_id = 2, Supplier_id = 1 });
            //context.Products.AddOrUpdate(new Data.Models.Product { ID = 6, Name = "Product 6", Category_id = 3, Supplier_id = 1 });
            //context.Products.AddOrUpdate(new Data.Models.Product { ID = 7, Name = "Product 7", Category_id = 3, Supplier_id = 1 });
            //context.Products.AddOrUpdate(new Data.Models.Product { ID = 8, Name = "Product 8", Category_id = 4, Supplier_id = 1 });
            //context.Products.AddOrUpdate(new Data.Models.Product { ID = 9, Name = "Product 9", Category_id = 5, Supplier_id = 1 });
            //context.Products.AddOrUpdate(new Data.Models.Product { ID = 10, Name = "Product 10", Category_id = 5, Supplier_id = 1 });

            //var salt = BCrypt.Net.BCrypt.GenerateSalt();
            //var hashed = BCrypt.Net.BCrypt.HashPassword("1234", salt, true, BCrypt.Net.HashType.SHA384);
            //context.Users.AddOrUpdate(new Data.Models.User { ID = 1, Username = "admin", Password = hashed });
            //context.Users.AddOrUpdate(new Data.Models.User { ID = 2, Username = "user", Password = hashed });

            //context.Orders.AddOrUpdate(new Data.Models.Order { ID = 1, Date = DateTime.Now, Customer_id = 1, User_id = 1 });

            //context.SaveChanges();
        }
    }
}
