namespace Expert.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnCategoryIDToProductsTAble : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Category_id", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "Category_id");
            AddForeignKey("dbo.Products", "Category_id", "dbo.Categories", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Category_id", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Category_id" });
            DropColumn("dbo.Products", "Category_id");
        }
    }
}
