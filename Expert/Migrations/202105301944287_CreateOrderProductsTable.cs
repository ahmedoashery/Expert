namespace Expert.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOrderProductsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Order_Products",
                c => new
                    {
                        Order_id = c.Int(nullable: false),
                        Product_id = c.Int(nullable: false),
                        Quantity = c.Decimal(nullable: false),
                        Price = c.Decimal(nullable: false)
                })
                .PrimaryKey(t => new { t.Order_id, t.Product_id })
                .ForeignKey("dbo.Orders", t => t.Order_id, cascadeDelete: false)
                .ForeignKey("dbo.Products", t => t.Product_id, cascadeDelete: false)
                .Index(t => t.Order_id)
                .Index(t => t.Product_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Order_Products", "Product_id", "dbo.Products");
            DropForeignKey("dbo.Order_Products", "Order_id", "dbo.Orders");
            DropIndex("dbo.Order_Products", new[] { "Product_id" });
            DropIndex("dbo.Order_Products", new[] { "Order_id" });
            DropTable("dbo.Order_Products");
        }
    }
}
