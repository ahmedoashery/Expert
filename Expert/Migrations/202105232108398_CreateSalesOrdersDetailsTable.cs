namespace Expert.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CreateSalesOrdersDetailsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sales_Orders_Details",
                c => new
                {
                    Order_id = c.Int(nullable: false),
                    Product_id = c.Int(nullable: false),
                    Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Price = c.Decimal(nullable: false, precision: 18, scale: 2)
                })
                .PrimaryKey(t => new { t.Order_id, t.Product_id })
                .ForeignKey("dbo.Sales_Orders", t => t.Order_id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_id, cascadeDelete: true)
                .Index(t => t.Order_id)
                .Index(t => t.Product_id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Sales_Orders_Details", "Product_id", "dbo.Products");
            DropForeignKey("dbo.Sales_Orders_Details", "Order_id", "dbo.Sales_Orders");
            DropIndex("dbo.Sales_Orders_Details", new[] { "Product_id" });
            DropIndex("dbo.Sales_Orders_Details", new[] { "Order_id" });
            DropTable("dbo.Sales_Orders_Details");
        }
    }
}
