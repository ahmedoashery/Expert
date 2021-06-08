namespace Expert.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CreateExpertDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER SCHEMA Expert DEFAULT CHARACTER SET utf8mb4 DEFAULT COLLATE utf8mb4_unicode_ci");
        }

        public override void Down()
        {
        }
    }
}