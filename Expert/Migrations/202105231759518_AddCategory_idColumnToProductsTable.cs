namespace Expert.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddCategory_idColumnToProductsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Category_id", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "Category_id");
            AddForeignKey("dbo.Products", "Category_id", "dbo.Cateogries", "Category_id");
        }

        public override void Down()
        {
            DropForeignKey("dbo.Products", "Category_id", "dbo.Cateogries");
            DropIndex("dbo.Products", new[] { "Category_id" });
            DropColumn("dbo.Products", "Category_id");
        }
    }
}
