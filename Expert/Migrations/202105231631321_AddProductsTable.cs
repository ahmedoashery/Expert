namespace Expert.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddProductsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                {
                    Product_id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                    Description = c.String(maxLength: 255, storeType: "nvarchar"),
                    QuantityInStock = c.Decimal(precision: 18, scale: 2, defaultValue: 0),
                    Price = c.Decimal(precision: 18, scale: 2, defaultValue: 0),
                })
                .PrimaryKey(t => t.Product_id)
                .Index(t => t.Name, unique: true);

        }

        public override void Down()
        {
            DropIndex("dbo.Products", new[] { "Name" });
            DropTable("dbo.Products");
        }
    }
}
