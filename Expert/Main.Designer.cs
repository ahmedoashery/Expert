
namespace Expert
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.StockViewLink = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.DataRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.StockRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.MainDockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.mainAccordionGroup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.employeesAccordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.customersAccordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.MainTabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.MainDocumentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.MainMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.ReportsRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.SettingsRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.CustomersRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.CustomersViewLink = new DevExpress.XtraBars.BarButtonItem();
            this.SuppliersViewLink = new DevExpress.XtraBars.BarButtonItem();
            this.SalesReportsViewLink = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PurchasesReportsViewLink = new DevExpress.XtraBars.BarButtonItem();
            this.CustomersandSuppliersReportsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.CustomersReportsViewLink = new DevExpress.XtraBars.BarButtonItem();
            this.SuppliersReportsViewLink = new DevExpress.XtraBars.BarButtonItem();
            this.StockTransactionsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.SalesOrderViewLink = new DevExpress.XtraBars.BarButtonItem();
            this.PurchaseOrdersViewLink = new DevExpress.XtraBars.BarButtonItem();
            this.SalesReturnsViewLink = new DevExpress.XtraBars.BarButtonItem();
            this.PurchasesReturnsViewLink = new DevExpress.XtraBars.BarButtonItem();
            this.CustoermsAndSuppliersTransactionsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.CustomerPayViewLink = new DevExpress.XtraBars.BarButtonItem();
            this.SupplierPayViewLink = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDockManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDocumentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ApplicationButtonDropDownControl = this.MainMenu;
            this.ribbonControl.CaptionBarItemLinks.Add(this.skinDropDownButtonItem1);
            this.ribbonControl.CaptionBarItemLinks.Add(this.skinPaletteDropDownButtonItem1);
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.StockViewLink,
            this.skinDropDownButtonItem1,
            this.skinPaletteDropDownButtonItem1,
            this.CustomersViewLink,
            this.SuppliersViewLink,
            this.SalesReportsViewLink,
            this.PurchasesReportsViewLink,
            this.CustomersReportsViewLink,
            this.SuppliersReportsViewLink,
            this.SalesOrderViewLink,
            this.PurchaseOrdersViewLink,
            this.SalesReturnsViewLink,
            this.PurchasesReturnsViewLink,
            this.CustomerPayViewLink,
            this.SupplierPayViewLink});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 72;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage,
            this.DataRibbonPage,
            this.ReportsRibbonPage,
            this.SettingsRibbonPage});
            this.ribbonControl.Size = new System.Drawing.Size(790, 143);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // StockViewLink
            // 
            this.StockViewLink.Caption = "Stock";
            this.StockViewLink.Id = 49;
            this.StockViewLink.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("InventoryViewLink.ImageOptions.Image")));
            this.StockViewLink.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("InventoryViewLink.ImageOptions.LargeImage")));
            this.StockViewLink.Name = "StockViewLink";
            this.StockViewLink.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarItemNavigation_Click);
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.StockTransactionsRibbonPageGroup,
            this.CustoermsAndSuppliersTransactionsRibbonPageGroup});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "Main";
            // 
            // DataRibbonPage
            // 
            this.DataRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.StockRibbonPageGroup,
            this.CustomersRibbonPageGroup});
            this.DataRibbonPage.Name = "DataRibbonPage";
            this.DataRibbonPage.Text = "Data";
            // 
            // StockRibbonPageGroup
            // 
            this.StockRibbonPageGroup.ItemLinks.Add(this.StockViewLink);
            this.StockRibbonPageGroup.Name = "StockRibbonPageGroup";
            this.StockRibbonPageGroup.Text = "Stock";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 568);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(790, 31);
            // 
            // MainDockManager
            // 
            this.MainDockManager.Form = this;
            this.MainDockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // mainAccordionGroup
            // 
            this.mainAccordionGroup.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.employeesAccordionControlElement,
            this.customersAccordionControlElement});
            this.mainAccordionGroup.Expanded = true;
            this.mainAccordionGroup.HeaderVisible = false;
            this.mainAccordionGroup.Name = "mainAccordionGroup";
            this.mainAccordionGroup.Text = "mainGroup";
            // 
            // employeesAccordionControlElement
            // 
            this.employeesAccordionControlElement.Name = "employeesAccordionControlElement";
            this.employeesAccordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.employeesAccordionControlElement.Text = "Employees";
            // 
            // customersAccordionControlElement
            // 
            this.customersAccordionControlElement.Name = "customersAccordionControlElement";
            this.customersAccordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.customersAccordionControlElement.Text = "Customers";
            // 
            // MainDocumentManager
            // 
            this.MainDocumentManager.ContainerControl = this;
            this.MainDocumentManager.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.MainDocumentManager.View = this.MainTabbedView;
            this.MainDocumentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.MainTabbedView});
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 53;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // skinPaletteDropDownButtonItem1
            // 
            this.skinPaletteDropDownButtonItem1.Enabled = false;
            this.skinPaletteDropDownButtonItem1.Id = 54;
            this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // MainMenu
            // 
            this.MainMenu.ItemLinks.Add(this.StockViewLink);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Ribbon = this.ribbonControl;
            // 
            // ReportsRibbonPage
            // 
            this.ReportsRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.CustomersandSuppliersReportsRibbonPageGroup});
            this.ReportsRibbonPage.Name = "ReportsRibbonPage";
            this.ReportsRibbonPage.Text = "Reports";
            // 
            // SettingsRibbonPage
            // 
            this.SettingsRibbonPage.Name = "SettingsRibbonPage";
            this.SettingsRibbonPage.Text = "Settings";
            // 
            // CustomersRibbonPageGroup
            // 
            this.CustomersRibbonPageGroup.ItemLinks.Add(this.CustomersViewLink);
            this.CustomersRibbonPageGroup.ItemLinks.Add(this.SuppliersViewLink);
            this.CustomersRibbonPageGroup.Name = "CustomersRibbonPageGroup";
            this.CustomersRibbonPageGroup.Text = "Customers and Suppliers";
            // 
            // CustomersViewLink
            // 
            this.CustomersViewLink.Caption = "Customers";
            this.CustomersViewLink.Id = 60;
            this.CustomersViewLink.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("CustomersViewLink.ImageOptions.SvgImage")));
            this.CustomersViewLink.Name = "CustomersViewLink";
            // 
            // SuppliersViewLink
            // 
            this.SuppliersViewLink.Caption = "Suppliers";
            this.SuppliersViewLink.Id = 61;
            this.SuppliersViewLink.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SuppliersViewLink.ImageOptions.SvgImage")));
            this.SuppliersViewLink.Name = "SuppliersViewLink";
            // 
            // SalesReportsViewLink
            // 
            this.SalesReportsViewLink.Caption = "Sales";
            this.SalesReportsViewLink.Id = 62;
            this.SalesReportsViewLink.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SalesReportsViewLink.ImageOptions.Image")));
            this.SalesReportsViewLink.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("SalesReportsViewLink.ImageOptions.LargeImage")));
            this.SalesReportsViewLink.Name = "SalesReportsViewLink";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.SalesReportsViewLink);
            this.ribbonPageGroup1.ItemLinks.Add(this.PurchasesReportsViewLink);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Sales andPurchases";
            // 
            // PurchasesReportsViewLink
            // 
            this.PurchasesReportsViewLink.Caption = "Purchases";
            this.PurchasesReportsViewLink.Id = 63;
            this.PurchasesReportsViewLink.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PurchasesReportsViewLink.ImageOptions.Image")));
            this.PurchasesReportsViewLink.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("PurchasesReportsViewLink.ImageOptions.LargeImage")));
            this.PurchasesReportsViewLink.Name = "PurchasesReportsViewLink";
            // 
            // CustomersandSuppliersReportsRibbonPageGroup
            // 
            this.CustomersandSuppliersReportsRibbonPageGroup.ItemLinks.Add(this.CustomersReportsViewLink);
            this.CustomersandSuppliersReportsRibbonPageGroup.ItemLinks.Add(this.SuppliersReportsViewLink);
            this.CustomersandSuppliersReportsRibbonPageGroup.Name = "CustomersandSuppliersReportsRibbonPageGroup";
            this.CustomersandSuppliersReportsRibbonPageGroup.Text = "Customers and Suppliers";
            // 
            // CustomersReportsViewLink
            // 
            this.CustomersReportsViewLink.Caption = "Customers";
            this.CustomersReportsViewLink.Id = 64;
            this.CustomersReportsViewLink.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CustomersReportsViewLink.ImageOptions.Image")));
            this.CustomersReportsViewLink.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("CustomersReportsViewLink.ImageOptions.LargeImage")));
            this.CustomersReportsViewLink.Name = "CustomersReportsViewLink";
            // 
            // SuppliersReportsViewLink
            // 
            this.SuppliersReportsViewLink.Caption = "Suppliers";
            this.SuppliersReportsViewLink.Id = 65;
            this.SuppliersReportsViewLink.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SuppliersReportsViewLink.ImageOptions.Image")));
            this.SuppliersReportsViewLink.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("SuppliersReportsViewLink.ImageOptions.LargeImage")));
            this.SuppliersReportsViewLink.Name = "SuppliersReportsViewLink";
            // 
            // StockTransactionsRibbonPageGroup
            // 
            this.StockTransactionsRibbonPageGroup.ItemLinks.Add(this.SalesOrderViewLink);
            this.StockTransactionsRibbonPageGroup.ItemLinks.Add(this.PurchaseOrdersViewLink);
            this.StockTransactionsRibbonPageGroup.ItemLinks.Add(this.SalesReturnsViewLink);
            this.StockTransactionsRibbonPageGroup.ItemLinks.Add(this.PurchasesReturnsViewLink);
            this.StockTransactionsRibbonPageGroup.Name = "StockTransactionsRibbonPageGroup";
            this.StockTransactionsRibbonPageGroup.Text = "Stock";
            // 
            // SalesOrderViewLink
            // 
            this.SalesOrderViewLink.Caption = "Sales Order";
            this.SalesOrderViewLink.Id = 66;
            this.SalesOrderViewLink.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("StockTransactionsViewLink.ImageOptions.Image")));
            this.SalesOrderViewLink.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("StockTransactionsViewLink.ImageOptions.LargeImage")));
            this.SalesOrderViewLink.Name = "SalesOrderViewLink";
            // 
            // PurchaseOrdersViewLink
            // 
            this.PurchaseOrdersViewLink.Caption = "Purchase Order";
            this.PurchaseOrdersViewLink.Id = 67;
            this.PurchaseOrdersViewLink.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.PurchaseOrdersViewLink.Name = "PurchaseOrdersViewLink";
            // 
            // SalesReturnsViewLink
            // 
            this.SalesReturnsViewLink.Caption = "Sales Returns";
            this.SalesReturnsViewLink.Id = 68;
            this.SalesReturnsViewLink.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SalesBackOrderViewLink.ImageOptions.SvgImage")));
            this.SalesReturnsViewLink.Name = "SalesReturnsViewLink";
            // 
            // PurchasesReturnsViewLink
            // 
            this.PurchasesReturnsViewLink.Caption = "Purchases Returns";
            this.PurchasesReturnsViewLink.Id = 69;
            this.PurchasesReturnsViewLink.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("PurchasesReturnsViewLink.ImageOptions.SvgImage")));
            this.PurchasesReturnsViewLink.Name = "PurchasesReturnsViewLink";
            // 
            // CustoermsAndSuppliersTransactionsRibbonPageGroup
            // 
            this.CustoermsAndSuppliersTransactionsRibbonPageGroup.ItemLinks.Add(this.CustomerPayViewLink);
            this.CustoermsAndSuppliersTransactionsRibbonPageGroup.ItemLinks.Add(this.SuppliersReportsViewLink);
            this.CustoermsAndSuppliersTransactionsRibbonPageGroup.Name = "CustoermsAndSuppliersTransactionsRibbonPageGroup";
            this.CustoermsAndSuppliersTransactionsRibbonPageGroup.Text = "Customers and Suppliers";
            // 
            // CustomerPayViewLink
            // 
            this.CustomerPayViewLink.Caption = "Customer Pay";
            this.CustomerPayViewLink.Id = 70;
            this.CustomerPayViewLink.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("CustomerPayViewLink.ImageOptions.SvgImage")));
            this.CustomerPayViewLink.Name = "CustomerPayViewLink";
            // 
            // SupplierPayViewLink
            // 
            this.SupplierPayViewLink.Caption = "Supplier Pay";
            this.SupplierPayViewLink.Id = 71;
            this.SupplierPayViewLink.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SupplierPayViewLink.ImageOptions.SvgImage")));
            this.SupplierPayViewLink.Name = "SupplierPayViewLink";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 599);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "Main";
            this.Ribbon = this.ribbonControl;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StatusBar = this.ribbonStatusBar;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDockManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDocumentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Docking.DockManager MainDockManager;
        private DevExpress.XtraBars.Navigation.AccordionControlElement employeesAccordionControlElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement customersAccordionControlElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mainAccordionGroup;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView MainTabbedView;
        private DevExpress.XtraBars.Docking2010.DocumentManager MainDocumentManager;
        private DevExpress.XtraBars.BarButtonItem StockViewLink;
        private DevExpress.XtraBars.Ribbon.RibbonPage DataRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup StockRibbonPageGroup;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu MainMenu;
        private DevExpress.XtraBars.Ribbon.RibbonPage ReportsRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPage SettingsRibbonPage;
        private DevExpress.XtraBars.BarButtonItem CustomersViewLink;
        private DevExpress.XtraBars.BarButtonItem SuppliersViewLink;
        private DevExpress.XtraBars.BarButtonItem SalesReportsViewLink;
        private DevExpress.XtraBars.BarButtonItem PurchasesReportsViewLink;
        private DevExpress.XtraBars.BarButtonItem CustomersReportsViewLink;
        private DevExpress.XtraBars.BarButtonItem SuppliersReportsViewLink;
        private DevExpress.XtraBars.BarButtonItem SalesOrderViewLink;
        private DevExpress.XtraBars.BarButtonItem PurchaseOrdersViewLink;
        private DevExpress.XtraBars.BarButtonItem SalesReturnsViewLink;
        private DevExpress.XtraBars.BarButtonItem PurchasesReturnsViewLink;
        private DevExpress.XtraBars.BarButtonItem CustomerPayViewLink;
        private DevExpress.XtraBars.BarButtonItem SupplierPayViewLink;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup StockTransactionsRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup CustoermsAndSuppliersTransactionsRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup CustomersRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup CustomersandSuppliersReportsRibbonPageGroup;
    }
}