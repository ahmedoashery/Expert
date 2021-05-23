namespace Expert.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSuppliersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Supplier_id = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 50, storeType: "nvarchar"),
                        Name = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Supplier_id)
                .Index(t => t.Name, unique: true);
            
            AddColumn("dbo.Products", "Supplier_id", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "Supplier_id");
            AddForeignKey("dbo.Products", "Supplier_id", "dbo.Suppliers", "Supplier_id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Supplier_id", "dbo.Suppliers");
            DropIndex("dbo.Suppliers", new[] { "Name" });
            DropIndex("dbo.Products", new[] { "Supplier_id" });
            DropColumn("dbo.Products", "Supplier_id");
            DropTable("dbo.Suppliers");
        }
    }
}
