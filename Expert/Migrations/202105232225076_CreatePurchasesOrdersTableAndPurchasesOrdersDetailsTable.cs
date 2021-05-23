namespace Expert.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePurchasesOrdersTableAndPurchasesOrdersDetailsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Purchases_Orders",
                c => new
                    {
                        Order_id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false, precision: 0),
                        Notes = c.String(maxLength: 255, storeType: "nvarchar"),
                        Supplier_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Order_id)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_id, cascadeDelete: true)
                .Index(t => t.Supplier_id);
            
            CreateTable(
                "dbo.Purchases_Orders_Details",
                c => new
                    {
                        Order_id = c.Int(nullable: false),
                        Product_id = c.Int(nullable: false),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2)
                })
                .PrimaryKey(t => new { t.Order_id, t.Product_id })
                .ForeignKey("dbo.Purchases_Orders", t => t.Order_id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_id, cascadeDelete: true)
                .Index(t => t.Order_id)
                .Index(t => t.Product_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchases_Orders", "Supplier_id", "dbo.Suppliers");
            DropForeignKey("dbo.Purchases_Orders_Details", "Product_id", "dbo.Products");
            DropForeignKey("dbo.Purchases_Orders_Details", "Order_id", "dbo.Purchases_Orders");
            DropIndex("dbo.Purchases_Orders_Details", new[] { "Product_id" });
            DropIndex("dbo.Purchases_Orders_Details", new[] { "Order_id" });
            DropIndex("dbo.Purchases_Orders", new[] { "Supplier_id" });
            DropTable("dbo.Purchases_Orders_Details");
            DropTable("dbo.Purchases_Orders");
        }
    }
}
