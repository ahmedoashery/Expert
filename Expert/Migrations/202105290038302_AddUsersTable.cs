namespace Expert.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Userid = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Password = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Userid)
                .Index(t => t.Username, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Username" });
            DropTable("dbo.Users");
        }
    }
}
