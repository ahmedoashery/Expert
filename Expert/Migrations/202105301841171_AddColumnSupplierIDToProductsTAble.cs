namespace Expert.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnSupplierIDToProductsTAble : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Supplier_id", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "Supplier_id");
            AddForeignKey("dbo.Products", "Supplier_id", "dbo.Suppliers", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Supplier_id", "dbo.Suppliers");
            DropIndex("dbo.Products", new[] { "Supplier_id" });
            DropColumn("dbo.Products", "Supplier_id");
        }
    }
}
