namespace Expert.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class MakeCodeColumnInSuppliersTableUnique : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Suppliers", "Code", unique: true);
        }

        public override void Down()
        {
            DropIndex("dbo.Suppliers", new[] { "Code" });
        }
    }
}
