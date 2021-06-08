namespace Expert.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
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
                        Standard_cost = c.Decimal(precision: 18, scale: 2),
                        List_price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Reorder_level = c.Int(),
                        Target_level = c.Int(),
                        Quantity_per_unit = c.String(maxLength: 50, storeType: "nvarchar"),
                        Discontinued = c.Boolean(nullable: false),
                        Minimum_reorder_quantity = c.Int(),
                        Category_id = c.Int(nullable: false),
                        Supplier_id = c.Int(nullable: false),
                        Attachments = c.Binary(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_id)
                .ForeignKey("dbo.Categories", t => t.Category_id)
                .Index(t => t.Code, unique: true)
                .Index(t => t.Name, unique: true)
                .Index(t => t.Category_id)
                .Index(t => t.Supplier_id);
            
            CreateTable(
                "dbo.Inventory_Transactions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Transaction_type_id = c.Int(nullable: false),
                        Transaction_created_date = c.DateTime(nullable: false, precision: 0),
                        Transaction_modified_date = c.DateTime(nullable: false, precision: 0),
                        Product_id = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Purchase_order_id = c.Int(nullable: false),
                        Customer_order_id = c.Int(nullable: false),
                        Comments = c.String(maxLength: 200, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Inventory_Transaction_Types", t => t.Transaction_type_id)
                .ForeignKey("dbo.Purchase_Orders", t => t.Purchase_order_id)
                .ForeignKey("dbo.Orders", t => t.Customer_order_id)
                .ForeignKey("dbo.Products", t => t.Product_id)
                .Index(t => t.Transaction_type_id)
                .Index(t => t.Product_id)
                .Index(t => t.Purchase_order_id)
                .Index(t => t.Customer_order_id);
            
            CreateTable(
                "dbo.Inventory_Transaction_Types",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        type_name = c.String(maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Employee_id = c.Int(nullable: false),
                        Customer_id = c.Int(nullable: false),
                        Order_date = c.DateTime(nullable: false, precision: 0),
                        Shipped_date = c.DateTime(precision: 0),
                        Shipper_id = c.Int(nullable: false),
                        Ship_name = c.String(maxLength: 50, storeType: "nvarchar"),
                        Ship_address = c.String(maxLength: 200, storeType: "nvarchar"),
                        Ship_city = c.String(maxLength: 50, storeType: "nvarchar"),
                        Ship_state_province = c.String(maxLength: 50, storeType: "nvarchar"),
                        Ship_zip_postal_code = c.String(maxLength: 50, storeType: "nvarchar"),
                        Ship_country_region = c.String(maxLength: 50, storeType: "nvarchar"),
                        Shipping_fee = c.Decimal(precision: 18, scale: 2),
                        Taxes = c.Decimal(precision: 18, scale: 2),
                        Payment_type = c.String(maxLength: 50, storeType: "nvarchar"),
                        Paid_date = c.DateTime(precision: 0),
                        Notes = c.String(maxLength: 255, storeType: "nvarchar"),
                        Tax_rate = c.Double(),
                        Tax_status_id = c.Int(nullable: false),
                        Status_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.Customer_id)
                .ForeignKey("dbo.Employees", t => t.Employee_id)
                .ForeignKey("dbo.Order_Statuses", t => t.Status_id)
                .ForeignKey("dbo.Order_Tax_Statuses", t => t.Tax_status_id)
                .ForeignKey("dbo.Shippers", t => t.Shipper_id)
                .Index(t => t.Employee_id)
                .Index(t => t.Customer_id)
                .Index(t => t.Shipper_id)
                .Index(t => t.Tax_status_id)
                .Index(t => t.Status_id);
            
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
                        Notes = c.String(maxLength: 255, storeType: "nvarchar"),
                        Attachments = c.Binary(),
                    })
                .PrimaryKey(t => t.ID);
            
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
                "dbo.Purchase_Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Supplier_id = c.Int(nullable: false),
                        Created_by = c.Int(nullable: false),
                        Submitted_date = c.DateTime(precision: 0),
                        Creation_date = c.DateTime(nullable: false, precision: 0),
                        Status_id = c.Int(nullable: false),
                        Expected_date = c.DateTime(precision: 0),
                        Shipping_fee = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Taxes = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Payment_date = c.DateTime(precision: 0),
                        Payment_amount = c.Decimal(precision: 18, scale: 2),
                        Payment_method = c.String(maxLength: 50, storeType: "nvarchar"),
                        Notes = c.String(maxLength: 255, storeType: "nvarchar"),
                        Approved_by = c.Int(),
                        Approved_date = c.DateTime(precision: 0),
                        Submitted_by = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Purchase_Order_Statuses", t => t.Status_id)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_id)
                .ForeignKey("dbo.Employees", t => t.Created_by)
                .Index(t => t.Supplier_id)
                .Index(t => t.Created_by)
                .Index(t => t.Status_id);
            
            CreateTable(
                "dbo.Purchase_Order_Details",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Purchase_order_id = c.Int(nullable: false),
                        Product_id = c.Int(nullable: false),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Unit_cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date_received = c.DateTime(precision: 0),
                        Posted_to_inventory = c.Boolean(nullable: false),
                        Inventory_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Purchase_Orders", t => t.Purchase_order_id)
                .ForeignKey("dbo.Inventory_Transactions", t => t.Inventory_id)
                .ForeignKey("dbo.Products", t => t.Product_id)
                .Index(t => t.Purchase_order_id)
                .Index(t => t.Product_id)
                .Index(t => t.Inventory_id);
            
            CreateTable(
                "dbo.Purchase_Order_Statuses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Status = c.String(maxLength: 50, storeType: "nvarchar"),
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
                        Notes = c.String(maxLength: 255, storeType: "nvarchar"),
                        Attachments = c.Binary(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Order_id = c.Int(nullable: false),
                        Invoice_date = c.DateTime(nullable: false, precision: 0),
                        Due_date = c.DateTime(precision: 0),
                        Tax = c.Decimal(precision: 18, scale: 2),
                        Shipping = c.Decimal(precision: 18, scale: 2),
                        Amount_due = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Orders", t => t.Order_id)
                .Index(t => t.Order_id);
            
            CreateTable(
                "dbo.Order_Details",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Order_id = c.Int(nullable: false),
                        Product_id = c.Int(nullable: false),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Unit_price = c.Decimal(precision: 18, scale: 2),
                        Discount = c.Double(nullable: false),
                        Status_id = c.Int(nullable: false),
                        Date_allocated = c.DateTime(precision: 0),
                        Purchase_order_id = c.Int(),
                        Inventory_id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Order_Detail_Statuses", t => t.Status_id)
                .ForeignKey("dbo.Orders", t => t.Order_id)
                .ForeignKey("dbo.Products", t => t.Product_id)
                .Index(t => t.Order_id)
                .Index(t => t.Product_id)
                .Index(t => t.Status_id);
            
            CreateTable(
                "dbo.Order_Detail_Statuses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Status_name = c.String(maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Order_Statuses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Status_name = c.String(maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Order_Tax_Statuses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Tax_status_name = c.String(maxLength: 50, storeType: "nvarchar"),
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
                        Notes = c.String(maxLength: 255, storeType: "nvarchar"),
                        Attachments = c.Binary(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        String_data = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sales_Reports",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Group_by = c.String(unicode: false),
                        Display = c.String(unicode: false),
                        Title = c.String(unicode: false),
                        Filter_row_source = c.String(unicode: false),
                        Default = c.Boolean(nullable: false),
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
            DropForeignKey("dbo.Purchase_Order_Details", "Product_id", "dbo.Products");
            DropForeignKey("dbo.Order_Details", "Product_id", "dbo.Products");
            DropForeignKey("dbo.Inventory_Transactions", "Product_id", "dbo.Products");
            DropForeignKey("dbo.Purchase_Order_Details", "Inventory_id", "dbo.Inventory_Transactions");
            DropForeignKey("dbo.Orders", "Shipper_id", "dbo.Shippers");
            DropForeignKey("dbo.Orders", "Tax_status_id", "dbo.Order_Tax_Statuses");
            DropForeignKey("dbo.Orders", "Status_id", "dbo.Order_Statuses");
            DropForeignKey("dbo.Order_Details", "Order_id", "dbo.Orders");
            DropForeignKey("dbo.Order_Details", "Status_id", "dbo.Order_Detail_Statuses");
            DropForeignKey("dbo.Invoices", "Order_id", "dbo.Orders");
            DropForeignKey("dbo.Inventory_Transactions", "Customer_order_id", "dbo.Orders");
            DropForeignKey("dbo.Purchase_Orders", "Created_by", "dbo.Employees");
            DropForeignKey("dbo.Purchase_Orders", "Supplier_id", "dbo.Suppliers");
            DropForeignKey("dbo.Products", "Supplier_id", "dbo.Suppliers");
            DropForeignKey("dbo.Purchase_Orders", "Status_id", "dbo.Purchase_Order_Statuses");
            DropForeignKey("dbo.Purchase_Order_Details", "Purchase_order_id", "dbo.Purchase_Orders");
            DropForeignKey("dbo.Inventory_Transactions", "Purchase_order_id", "dbo.Purchase_Orders");
            DropForeignKey("dbo.employee_privileges", "Privilege_ID", "dbo.Privileges");
            DropForeignKey("dbo.employee_privileges", "Employee_ID", "dbo.Employees");
            DropForeignKey("dbo.Orders", "Employee_id", "dbo.Employees");
            DropForeignKey("dbo.Orders", "Customer_id", "dbo.Customers");
            DropForeignKey("dbo.Inventory_Transactions", "Transaction_type_id", "dbo.Inventory_Transaction_Types");
            DropIndex("dbo.employee_privileges", new[] { "Privilege_ID" });
            DropIndex("dbo.employee_privileges", new[] { "Employee_ID" });
            DropIndex("dbo.Order_Details", new[] { "Status_id" });
            DropIndex("dbo.Order_Details", new[] { "Product_id" });
            DropIndex("dbo.Order_Details", new[] { "Order_id" });
            DropIndex("dbo.Invoices", new[] { "Order_id" });
            DropIndex("dbo.Purchase_Order_Details", new[] { "Inventory_id" });
            DropIndex("dbo.Purchase_Order_Details", new[] { "Product_id" });
            DropIndex("dbo.Purchase_Order_Details", new[] { "Purchase_order_id" });
            DropIndex("dbo.Purchase_Orders", new[] { "Status_id" });
            DropIndex("dbo.Purchase_Orders", new[] { "Created_by" });
            DropIndex("dbo.Purchase_Orders", new[] { "Supplier_id" });
            DropIndex("dbo.Orders", new[] { "Status_id" });
            DropIndex("dbo.Orders", new[] { "Tax_status_id" });
            DropIndex("dbo.Orders", new[] { "Shipper_id" });
            DropIndex("dbo.Orders", new[] { "Customer_id" });
            DropIndex("dbo.Orders", new[] { "Employee_id" });
            DropIndex("dbo.Inventory_Transactions", new[] { "Customer_order_id" });
            DropIndex("dbo.Inventory_Transactions", new[] { "Purchase_order_id" });
            DropIndex("dbo.Inventory_Transactions", new[] { "Product_id" });
            DropIndex("dbo.Inventory_Transactions", new[] { "Transaction_type_id" });
            DropIndex("dbo.Products", new[] { "Supplier_id" });
            DropIndex("dbo.Products", new[] { "Category_id" });
            DropIndex("dbo.Products", new[] { "Name" });
            DropIndex("dbo.Products", new[] { "Code" });
            DropIndex("dbo.Categories", new[] { "Name" });
            DropTable("dbo.employee_privileges");
            DropTable("dbo.Sales_Reports");
            DropTable("dbo.Messages");
            DropTable("dbo.Shippers");
            DropTable("dbo.Order_Tax_Statuses");
            DropTable("dbo.Order_Statuses");
            DropTable("dbo.Order_Detail_Statuses");
            DropTable("dbo.Order_Details");
            DropTable("dbo.Invoices");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Purchase_Order_Statuses");
            DropTable("dbo.Purchase_Order_Details");
            DropTable("dbo.Purchase_Orders");
            DropTable("dbo.Privileges");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
            DropTable("dbo.Inventory_Transaction_Types");
            DropTable("dbo.Inventory_Transactions");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
