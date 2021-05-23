namespace Expert.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerTableAndSalesOrdersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Customer_id = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 50, storeType: "nvarchar"),
                        Name = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Customer_id)
                .Index(t => t.Code, unique: true)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Sales_Orders",
                c => new
                    {
                        Order_id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false, precision: 0),
                        Notes = c.String(maxLength: 255, storeType: "nvarchar"),
                        Customer_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Order_id)
                .ForeignKey("dbo.Customers", t => t.Customer_id)
                .Index(t => t.Customer_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales_Orders", "Customer_id", "dbo.Customers");
            DropIndex("dbo.Sales_Orders", new[] { "Customer_id" });
            DropIndex("dbo.Customers", new[] { "Name" });
            DropIndex("dbo.Customers", new[] { "Code" });
            DropTable("dbo.Sales_Orders");
            DropTable("dbo.Customers");
        }
    }
}
