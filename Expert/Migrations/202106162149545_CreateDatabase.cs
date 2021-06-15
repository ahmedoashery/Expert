namespace Expert.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            // Character-Set & Collation = 'utf8mb4'
            Sql("ALTER SCHEMA Expert_Data DEFAULT CHARACTER SET utf8mb4 DEFAULT COLLATE utf8mb4_unicode_ci");


            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Description = c.String(unicode: false),
                        Picture = c.Binary(),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 50, storeType: "nvarchar"),
                        Name = c.String(maxLength: 50, storeType: "nvarchar"),
                        Description = c.String(maxLength: 200, storeType: "nvarchar"),
                        Cost = c.Decimal(precision: 18, scale: 2),
                        Price = c.Decimal(precision: 18, scale: 2),
                        Quantity_in_stock = c.Int(),
                        Active = c.Boolean(nullable: false),
                        Category_id = c.Int(nullable: false),
                        Unit_id = c.Int(nullable: false),
                        Supplier_id = c.Int(nullable: false),
                        Attachments = c.Binary(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_id)
                .ForeignKey("dbo.Product_Units", t => t.Unit_id)
                .ForeignKey("dbo.Categories", t => t.Category_id)
                .Index(t => t.Code, unique: true)
                .Index(t => t.Name, unique: true)
                .Index(t => t.Category_id)
                .Index(t => t.Unit_id)
                .Index(t => t.Supplier_id);
            
            CreateTable(
                "dbo.Purchase_Order_Details",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Order_id = c.Int(nullable: false),
                        Product_id = c.Int(nullable: false),
                        Quantity = c.Decimal(precision: 18, scale: 2),
                        Unit_cost = c.Decimal(precision: 18, scale: 2),
                        Discount = c.Double(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Purchase_Orders", t => t.Order_id)
                .ForeignKey("dbo.Products", t => t.Product_id)
                .Index(t => t.Order_id)
                .Index(t => t.Product_id);
            
            CreateTable(
                "dbo.Purchase_Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Status_id = c.Int(nullable: false),
                        Creation_date = c.DateTime(precision: 0),
                        Supplier_id = c.Int(nullable: false),
                        Employee_id = c.Int(nullable: false),
                        Shipping_fee = c.Decimal(precision: 18, scale: 2),
                        Payment_date = c.DateTime(precision: 0),
                        Payment_amount = c.Decimal(precision: 18, scale: 2),
                        Discount = c.Decimal(precision: 18, scale: 2),
                        Payment_method = c.String(maxLength: 50, storeType: "nvarchar"),
                        Notes = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employees", t => t.Employee_id)
                .ForeignKey("dbo.Purchase_Order_Statuses", t => t.Status_id)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_id)
                .Index(t => t.Status_id)
                .Index(t => t.Supplier_id)
                .Index(t => t.Employee_id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Company = c.String(maxLength: 50, storeType: "nvarchar"),
                        First_name = c.String(maxLength: 50, storeType: "nvarchar"),
                        Last_name = c.String(maxLength: 50, storeType: "nvarchar"),
                        Email_address = c.String(maxLength: 200, storeType: "nvarchar"),
                        Job_title = c.String(maxLength: 50, storeType: "nvarchar"),
                        Business_phone = c.String(maxLength: 50, storeType: "nvarchar"),
                        Home_phone = c.String(maxLength: 50, storeType: "nvarchar"),
                        Mobile_phone = c.String(maxLength: 50, storeType: "nvarchar"),
                        Fax_number = c.String(maxLength: 50, storeType: "nvarchar"),
                        Address = c.String(maxLength: 50, storeType: "nvarchar"),
                        City = c.String(maxLength: 50, storeType: "nvarchar"),
                        State_province = c.String(maxLength: 50, storeType: "nvarchar"),
                        Zip_postal_code = c.String(maxLength: 50, storeType: "nvarchar"),
                        Country_region = c.String(maxLength: 50, storeType: "nvarchar"),
                        Web_page = c.String(maxLength: 200, storeType: "nvarchar"),
                        Notes = c.String(maxLength: 255, storeType: "nvarchar"),
                        Attachments = c.Binary(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Privileges",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Privilege_name = c.String(maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sale_Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Status_id = c.Int(nullable: false),
                        Creation_date = c.DateTime(precision: 0),
                        Employee_id = c.Int(nullable: false),
                        Customer_id = c.Int(nullable: false),
                        Shipped_date = c.DateTime(precision: 0),
                        Shipper_id = c.Int(nullable: false),
                        Ship_name = c.String(maxLength: 50, storeType: "nvarchar"),
                        Ship_address = c.String(maxLength: 200, storeType: "nvarchar"),
                        Ship_city = c.String(maxLength: 50, storeType: "nvarchar"),
                        Ship_state_province = c.String(maxLength: 50, storeType: "nvarchar"),
                        Ship_zip_postal_code = c.String(maxLength: 50, storeType: "nvarchar"),
                        Ship_country_region = c.String(maxLength: 50, storeType: "nvarchar"),
                        Shipping_fee = c.Decimal(precision: 18, scale: 2),
                        Discount = c.Decimal(precision: 18, scale: 2),
                        Payment_type = c.String(maxLength: 50, storeType: "nvarchar"),
                        Paid_date = c.DateTime(precision: 0),
                        Notes = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.Customer_id)
                .ForeignKey("dbo.Sale_Order_Statuses", t => t.Status_id)
                .ForeignKey("dbo.Shippers", t => t.Shipper_id)
                .ForeignKey("dbo.Employees", t => t.Employee_id)
                .Index(t => t.Status_id)
                .Index(t => t.Employee_id)
                .Index(t => t.Customer_id)
                .Index(t => t.Shipper_id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Company = c.String(maxLength: 50, storeType: "nvarchar"),
                        First_name = c.String(maxLength: 50, storeType: "nvarchar"),
                        Last_name = c.String(maxLength: 50, storeType: "nvarchar"),
                        Email_address = c.String(maxLength: 200, storeType: "nvarchar"),
                        Job_title = c.String(maxLength: 50, storeType: "nvarchar"),
                        Business_phone = c.String(maxLength: 50, storeType: "nvarchar"),
                        Home_phone = c.String(maxLength: 50, storeType: "nvarchar"),
                        Mobile_phone = c.String(maxLength: 50, storeType: "nvarchar"),
                        Fax_number = c.String(maxLength: 50, storeType: "nvarchar"),
                        Address = c.String(maxLength: 50, storeType: "nvarchar"),
                        City = c.String(maxLength: 50, storeType: "nvarchar"),
                        State_province = c.String(maxLength: 50, storeType: "nvarchar"),
                        Zip_postal_code = c.String(maxLength: 50, storeType: "nvarchar"),
                        Country_region = c.String(maxLength: 50, storeType: "nvarchar"),
                        Web_page = c.String(maxLength: 200, storeType: "nvarchar"),
                        Attachments = c.Binary(),
                        Notes = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sale_Order_Details",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Order_id = c.Int(nullable: false),
                        Product_id = c.Int(nullable: false),
                        Quantity = c.Decimal(precision: 18, scale: 2),
                        Unit_price = c.Decimal(precision: 18, scale: 2),
                        Discount = c.Double(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Sale_Orders", t => t.Order_id)
                .ForeignKey("dbo.Products", t => t.Product_id)
                .Index(t => t.Order_id)
                .Index(t => t.Product_id);
            
            CreateTable(
                "dbo.Sale_Order_Statuses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Status_name = c.String(maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Shippers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Company = c.String(maxLength: 50, storeType: "nvarchar"),
                        First_name = c.String(maxLength: 50, storeType: "nvarchar"),
                        Last_name = c.String(maxLength: 50, storeType: "nvarchar"),
                        Email_address = c.String(maxLength: 200, storeType: "nvarchar"),
                        Job_title = c.String(maxLength: 50, storeType: "nvarchar"),
                        Business_phone = c.String(maxLength: 50, storeType: "nvarchar"),
                        Home_phone = c.String(maxLength: 50, storeType: "nvarchar"),
                        Mobile_phone = c.String(maxLength: 50, storeType: "nvarchar"),
                        Fax_number = c.String(maxLength: 50, storeType: "nvarchar"),
                        Address = c.String(maxLength: 50, storeType: "nvarchar"),
                        City = c.String(maxLength: 50, storeType: "nvarchar"),
                        State_province = c.String(maxLength: 50, storeType: "nvarchar"),
                        Zip_postal_code = c.String(maxLength: 50, storeType: "nvarchar"),
                        Country_region = c.String(maxLength: 50, storeType: "nvarchar"),
                        Web_page = c.String(maxLength: 200, storeType: "nvarchar"),
                        Attachments = c.Binary(),
                        Notes = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Purchase_Order_Statuses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Status_name = c.String(maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Company = c.String(maxLength: 50, storeType: "nvarchar"),
                        First_name = c.String(maxLength: 50, storeType: "nvarchar"),
                        Last_name = c.String(maxLength: 50, storeType: "nvarchar"),
                        Email_address = c.String(maxLength: 200, storeType: "nvarchar"),
                        Job_title = c.String(maxLength: 50, storeType: "nvarchar"),
                        Business_phone = c.String(maxLength: 50, storeType: "nvarchar"),
                        Home_phone = c.String(maxLength: 50, storeType: "nvarchar"),
                        Mobile_phone = c.String(maxLength: 50, storeType: "nvarchar"),
                        Fax_number = c.String(maxLength: 50, storeType: "nvarchar"),
                        Address = c.String(maxLength: 50, storeType: "nvarchar"),
                        City = c.String(maxLength: 50, storeType: "nvarchar"),
                        State_province = c.String(maxLength: 50, storeType: "nvarchar"),
                        Zip_postal_code = c.String(maxLength: 50, storeType: "nvarchar"),
                        Country_region = c.String(maxLength: 50, storeType: "nvarchar"),
                        Web_page = c.String(maxLength: 200, storeType: "nvarchar"),
                        Attachments = c.Binary(),
                        Notes = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Product_Units",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50, storeType: "nvarchar"),
                        Quantity_per_unit = c.String(maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        String_data = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.employee_privileges",
                c => new
                    {
                        Employee_ID = c.Int(nullable: false),
                        Privilege_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Employee_ID, t.Privilege_ID })
                .ForeignKey("dbo.Employees", t => t.Employee_ID, cascadeDelete: true)
                .ForeignKey("dbo.Privileges", t => t.Privilege_ID, cascadeDelete: true)
                .Index(t => t.Employee_ID)
                .Index(t => t.Privilege_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Category_id", "dbo.Categories");
            DropForeignKey("dbo.Products", "Unit_id", "dbo.Product_Units");
            DropForeignKey("dbo.Sale_Order_Details", "Product_id", "dbo.Products");
            DropForeignKey("dbo.Purchase_Order_Details", "Product_id", "dbo.Products");
            DropForeignKey("dbo.Purchase_Orders", "Supplier_id", "dbo.Suppliers");
            DropForeignKey("dbo.Products", "Supplier_id", "dbo.Suppliers");
            DropForeignKey("dbo.Purchase_Orders", "Status_id", "dbo.Purchase_Order_Statuses");
            DropForeignKey("dbo.Purchase_Order_Details", "Order_id", "dbo.Purchase_Orders");
            DropForeignKey("dbo.Sale_Orders", "Employee_id", "dbo.Employees");
            DropForeignKey("dbo.Sale_Orders", "Shipper_id", "dbo.Shippers");
            DropForeignKey("dbo.Sale_Orders", "Status_id", "dbo.Sale_Order_Statuses");
            DropForeignKey("dbo.Sale_Order_Details", "Order_id", "dbo.Sale_Orders");
            DropForeignKey("dbo.Sale_Orders", "Customer_id", "dbo.Customers");
            DropForeignKey("dbo.Purchase_Orders", "Employee_id", "dbo.Employees");
            DropForeignKey("dbo.employee_privileges", "Privilege_ID", "dbo.Privileges");
            DropForeignKey("dbo.employee_privileges", "Employee_ID", "dbo.Employees");
            DropIndex("dbo.employee_privileges", new[] { "Privilege_ID" });
            DropIndex("dbo.employee_privileges", new[] { "Employee_ID" });
            DropIndex("dbo.Product_Units", new[] { "Name" });
            DropIndex("dbo.Sale_Order_Details", new[] { "Product_id" });
            DropIndex("dbo.Sale_Order_Details", new[] { "Order_id" });
            DropIndex("dbo.Sale_Orders", new[] { "Shipper_id" });
            DropIndex("dbo.Sale_Orders", new[] { "Customer_id" });
            DropIndex("dbo.Sale_Orders", new[] { "Employee_id" });
            DropIndex("dbo.Sale_Orders", new[] { "Status_id" });
            DropIndex("dbo.Purchase_Orders", new[] { "Employee_id" });
            DropIndex("dbo.Purchase_Orders", new[] { "Supplier_id" });
            DropIndex("dbo.Purchase_Orders", new[] { "Status_id" });
            DropIndex("dbo.Purchase_Order_Details", new[] { "Product_id" });
            DropIndex("dbo.Purchase_Order_Details", new[] { "Order_id" });
            DropIndex("dbo.Products", new[] { "Supplier_id" });
            DropIndex("dbo.Products", new[] { "Unit_id" });
            DropIndex("dbo.Products", new[] { "Category_id" });
            DropIndex("dbo.Products", new[] { "Name" });
            DropIndex("dbo.Products", new[] { "Code" });
            DropIndex("dbo.Categories", new[] { "Name" });
            DropTable("dbo.employee_privileges");
            DropTable("dbo.Messages");
            DropTable("dbo.Product_Units");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Purchase_Order_Statuses");
            DropTable("dbo.Shippers");
            DropTable("dbo.Sale_Order_Statuses");
            DropTable("dbo.Sale_Order_Details");
            DropTable("dbo.Customers");
            DropTable("dbo.Sale_Orders");
            DropTable("dbo.Privileges");
            DropTable("dbo.Employees");
            DropTable("dbo.Purchase_Orders");
            DropTable("dbo.Purchase_Order_Details");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
