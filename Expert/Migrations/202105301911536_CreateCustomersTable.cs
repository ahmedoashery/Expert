namespace Expert.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCustomersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Name, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "Name" });
            DropTable("dbo.Customers");
        }
    }
}
