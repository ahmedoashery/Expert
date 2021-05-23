namespace Expert.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddCategoriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cateogries",
                c => new
                {
                    Category_id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                    Description = c.String(maxLength: 255, storeType: "nvarchar"),
                })
                .PrimaryKey(t => t.Category_id)
                .Index(t => t.Name, unique: true);

        }

        public override void Down()
        {
            DropIndex("dbo.Cateogries", new[] { "Name" });
            DropTable("dbo.Cateogries");
        }
    }
}
