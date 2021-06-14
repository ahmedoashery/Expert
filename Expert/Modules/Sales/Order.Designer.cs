
namespace Expert.Modules.Sales
{
    partial class Order
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.IDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Order_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.Shipped_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.Ship_nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Ship_addressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Ship_cityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Ship_state_provinceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Ship_zip_postal_codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Ship_country_regionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Shipping_feeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TaxesTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Payment_typeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Paid_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.Tax_rateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Order_detailsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NotesTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.Customer_idTextEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompany1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirst_name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLast_name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAttachments1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status_idTextEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.orderStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Shipper_idTextEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.shipperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Tax_status_idTextEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.orderTaxStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmployee_id = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForStatus_id = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNotes = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForOrder_date = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCustomer_id = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForShipped_date = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForShipper_id = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForShip_name = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForShip_address = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForShip_city = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForShip_state_province = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForShip_zip_postal_code = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForShip_country_region = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForShipping_fee = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForPayment_type = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPaid_date = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTaxes = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTax_rate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTax_status_id = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForOrder_details = new DevExpress.XtraLayout.LayoutControlItem();
            this.Employee_idTextEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirst_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLast_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAttachments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompany2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirst_name2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLast_name2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAttachments2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTax_status_name = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_dateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shipped_dateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shipped_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ship_nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ship_addressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ship_cityTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ship_state_provinceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ship_zip_postal_codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ship_country_regionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shipping_feeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxesTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Payment_typeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paid_dateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paid_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tax_rateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_detailsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotesTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shipper_idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipperBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tax_status_idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTaxStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployee_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOrder_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomer_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShipped_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShipper_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShip_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShip_address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShip_city)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShip_state_province)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShip_zip_postal_code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShip_country_region)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShipping_fee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPayment_type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPaid_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTaxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTax_rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTax_status_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOrder_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.barManager1.MaxItemId = 1;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar2.Text = "Tools";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "New";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barDockControlTop
            // 
            this.SetBoundPropertyName(this.barDockControlTop, "");
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(828, 29);
            // 
            // barDockControlBottom
            // 
            this.SetBoundPropertyName(this.barDockControlBottom, "");
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 484);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(828, 0);
            // 
            // barDockControlLeft
            // 
            this.SetBoundPropertyName(this.barDockControlLeft, "");
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 455);
            // 
            // barDockControlRight
            // 
            this.SetBoundPropertyName(this.barDockControlRight, "");
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(828, 29);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 455);
            // 
            // dataLayoutControl1
            // 
            this.SetBoundPropertyName(this.dataLayoutControl1, "");
            this.dataLayoutControl1.Controls.Add(this.IDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Order_dateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.Shipped_dateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.Ship_nameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Ship_addressTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Ship_cityTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Ship_state_provinceTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Ship_zip_postal_codeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Ship_country_regionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Shipping_feeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TaxesTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Payment_typeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Paid_dateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.Tax_rateTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Order_detailsGridControl);
            this.dataLayoutControl1.Controls.Add(this.NotesTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Customer_idTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Status_idTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Shipper_idTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Tax_status_idTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Employee_idTextEdit);
            this.dataLayoutControl1.DataSource = this.OrderBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 29);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(828, 455);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // IDTextEdit
            // 
            this.SetBoundPropertyName(this.IDTextEdit, "");
            this.IDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "ID", true));
            this.IDTextEdit.Location = new System.Drawing.Point(131, 42);
            this.IDTextEdit.MenuManager = this.barManager1;
            this.IDTextEdit.Name = "IDTextEdit";
            this.IDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IDTextEdit.Properties.Mask.EditMask = "N0";
            this.IDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IDTextEdit.Size = new System.Drawing.Size(281, 20);
            this.IDTextEdit.StyleController = this.dataLayoutControl1;
            this.IDTextEdit.TabIndex = 4;
            // 
            // OrderBindingSource
            // 
            this.OrderBindingSource.DataSource = typeof(Expert.Data.Models.Order);
            // 
            // Order_dateDateEdit
            // 
            this.SetBoundPropertyName(this.Order_dateDateEdit, "");
            this.Order_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Order_date", true));
            this.Order_dateDateEdit.EditValue = null;
            this.Order_dateDateEdit.Location = new System.Drawing.Point(523, 42);
            this.Order_dateDateEdit.MenuManager = this.barManager1;
            this.Order_dateDateEdit.Name = "Order_dateDateEdit";
            this.Order_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Order_dateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Order_dateDateEdit.Size = new System.Drawing.Size(281, 20);
            this.Order_dateDateEdit.StyleController = this.dataLayoutControl1;
            this.Order_dateDateEdit.TabIndex = 7;
            // 
            // Shipped_dateDateEdit
            // 
            this.SetBoundPropertyName(this.Shipped_dateDateEdit, "");
            this.Shipped_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Shipped_date", true));
            this.Shipped_dateDateEdit.EditValue = null;
            this.Shipped_dateDateEdit.Location = new System.Drawing.Point(131, 219);
            this.Shipped_dateDateEdit.MenuManager = this.barManager1;
            this.Shipped_dateDateEdit.Name = "Shipped_dateDateEdit";
            this.Shipped_dateDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Shipped_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Shipped_dateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Shipped_dateDateEdit.Size = new System.Drawing.Size(673, 20);
            this.Shipped_dateDateEdit.StyleController = this.dataLayoutControl1;
            this.Shipped_dateDateEdit.TabIndex = 8;
            // 
            // Ship_nameTextEdit
            // 
            this.SetBoundPropertyName(this.Ship_nameTextEdit, "");
            this.Ship_nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Ship_name", true));
            this.Ship_nameTextEdit.Location = new System.Drawing.Point(131, 267);
            this.Ship_nameTextEdit.MenuManager = this.barManager1;
            this.Ship_nameTextEdit.Name = "Ship_nameTextEdit";
            this.Ship_nameTextEdit.Size = new System.Drawing.Size(673, 20);
            this.Ship_nameTextEdit.StyleController = this.dataLayoutControl1;
            this.Ship_nameTextEdit.TabIndex = 10;
            // 
            // Ship_addressTextEdit
            // 
            this.SetBoundPropertyName(this.Ship_addressTextEdit, "");
            this.Ship_addressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Ship_address", true));
            this.Ship_addressTextEdit.Location = new System.Drawing.Point(131, 291);
            this.Ship_addressTextEdit.MenuManager = this.barManager1;
            this.Ship_addressTextEdit.Name = "Ship_addressTextEdit";
            this.Ship_addressTextEdit.Size = new System.Drawing.Size(673, 20);
            this.Ship_addressTextEdit.StyleController = this.dataLayoutControl1;
            this.Ship_addressTextEdit.TabIndex = 11;
            // 
            // Ship_cityTextEdit
            // 
            this.SetBoundPropertyName(this.Ship_cityTextEdit, "");
            this.Ship_cityTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Ship_city", true));
            this.Ship_cityTextEdit.Location = new System.Drawing.Point(131, 315);
            this.Ship_cityTextEdit.MenuManager = this.barManager1;
            this.Ship_cityTextEdit.Name = "Ship_cityTextEdit";
            this.Ship_cityTextEdit.Size = new System.Drawing.Size(673, 20);
            this.Ship_cityTextEdit.StyleController = this.dataLayoutControl1;
            this.Ship_cityTextEdit.TabIndex = 12;
            // 
            // Ship_state_provinceTextEdit
            // 
            this.SetBoundPropertyName(this.Ship_state_provinceTextEdit, "");
            this.Ship_state_provinceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Ship_state_province", true));
            this.Ship_state_provinceTextEdit.Location = new System.Drawing.Point(131, 339);
            this.Ship_state_provinceTextEdit.MenuManager = this.barManager1;
            this.Ship_state_provinceTextEdit.Name = "Ship_state_provinceTextEdit";
            this.Ship_state_provinceTextEdit.Size = new System.Drawing.Size(673, 20);
            this.Ship_state_provinceTextEdit.StyleController = this.dataLayoutControl1;
            this.Ship_state_provinceTextEdit.TabIndex = 13;
            // 
            // Ship_zip_postal_codeTextEdit
            // 
            this.SetBoundPropertyName(this.Ship_zip_postal_codeTextEdit, "");
            this.Ship_zip_postal_codeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Ship_zip_postal_code", true));
            this.Ship_zip_postal_codeTextEdit.Location = new System.Drawing.Point(131, 363);
            this.Ship_zip_postal_codeTextEdit.MenuManager = this.barManager1;
            this.Ship_zip_postal_codeTextEdit.Name = "Ship_zip_postal_codeTextEdit";
            this.Ship_zip_postal_codeTextEdit.Size = new System.Drawing.Size(673, 20);
            this.Ship_zip_postal_codeTextEdit.StyleController = this.dataLayoutControl1;
            this.Ship_zip_postal_codeTextEdit.TabIndex = 14;
            // 
            // Ship_country_regionTextEdit
            // 
            this.SetBoundPropertyName(this.Ship_country_regionTextEdit, "");
            this.Ship_country_regionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Ship_country_region", true));
            this.Ship_country_regionTextEdit.Location = new System.Drawing.Point(131, 387);
            this.Ship_country_regionTextEdit.MenuManager = this.barManager1;
            this.Ship_country_regionTextEdit.Name = "Ship_country_regionTextEdit";
            this.Ship_country_regionTextEdit.Size = new System.Drawing.Size(673, 20);
            this.Ship_country_regionTextEdit.StyleController = this.dataLayoutControl1;
            this.Ship_country_regionTextEdit.TabIndex = 15;
            // 
            // Shipping_feeTextEdit
            // 
            this.SetBoundPropertyName(this.Shipping_feeTextEdit, "");
            this.Shipping_feeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Shipping_fee", true));
            this.Shipping_feeTextEdit.Location = new System.Drawing.Point(131, 411);
            this.Shipping_feeTextEdit.MenuManager = this.barManager1;
            this.Shipping_feeTextEdit.Name = "Shipping_feeTextEdit";
            this.Shipping_feeTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Shipping_feeTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Shipping_feeTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Shipping_feeTextEdit.Properties.Mask.EditMask = "G";
            this.Shipping_feeTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Shipping_feeTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Shipping_feeTextEdit.Size = new System.Drawing.Size(673, 20);
            this.Shipping_feeTextEdit.StyleController = this.dataLayoutControl1;
            this.Shipping_feeTextEdit.TabIndex = 16;
            // 
            // TaxesTextEdit
            // 
            this.SetBoundPropertyName(this.TaxesTextEdit, "");
            this.TaxesTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Taxes", true));
            this.TaxesTextEdit.Location = new System.Drawing.Point(131, 267);
            this.TaxesTextEdit.MenuManager = this.barManager1;
            this.TaxesTextEdit.Name = "TaxesTextEdit";
            this.TaxesTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.TaxesTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.TaxesTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TaxesTextEdit.Properties.Mask.EditMask = "G";
            this.TaxesTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TaxesTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TaxesTextEdit.Size = new System.Drawing.Size(673, 20);
            this.TaxesTextEdit.StyleController = this.dataLayoutControl1;
            this.TaxesTextEdit.TabIndex = 17;
            // 
            // Payment_typeTextEdit
            // 
            this.SetBoundPropertyName(this.Payment_typeTextEdit, "");
            this.Payment_typeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Payment_type", true));
            this.Payment_typeTextEdit.Location = new System.Drawing.Point(131, 219);
            this.Payment_typeTextEdit.MenuManager = this.barManager1;
            this.Payment_typeTextEdit.Name = "Payment_typeTextEdit";
            this.Payment_typeTextEdit.Size = new System.Drawing.Size(673, 20);
            this.Payment_typeTextEdit.StyleController = this.dataLayoutControl1;
            this.Payment_typeTextEdit.TabIndex = 18;
            // 
            // Paid_dateDateEdit
            // 
            this.SetBoundPropertyName(this.Paid_dateDateEdit, "");
            this.Paid_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Paid_date", true));
            this.Paid_dateDateEdit.EditValue = null;
            this.Paid_dateDateEdit.Location = new System.Drawing.Point(131, 243);
            this.Paid_dateDateEdit.MenuManager = this.barManager1;
            this.Paid_dateDateEdit.Name = "Paid_dateDateEdit";
            this.Paid_dateDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Paid_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Paid_dateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Paid_dateDateEdit.Size = new System.Drawing.Size(673, 20);
            this.Paid_dateDateEdit.StyleController = this.dataLayoutControl1;
            this.Paid_dateDateEdit.TabIndex = 19;
            // 
            // Tax_rateTextEdit
            // 
            this.SetBoundPropertyName(this.Tax_rateTextEdit, "");
            this.Tax_rateTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Tax_rate", true));
            this.Tax_rateTextEdit.Location = new System.Drawing.Point(131, 291);
            this.Tax_rateTextEdit.MenuManager = this.barManager1;
            this.Tax_rateTextEdit.Name = "Tax_rateTextEdit";
            this.Tax_rateTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Tax_rateTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Tax_rateTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Tax_rateTextEdit.Properties.Mask.EditMask = "F";
            this.Tax_rateTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Tax_rateTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Tax_rateTextEdit.Size = new System.Drawing.Size(673, 20);
            this.Tax_rateTextEdit.StyleController = this.dataLayoutControl1;
            this.Tax_rateTextEdit.TabIndex = 21;
            // 
            // Order_detailsGridControl
            // 
            this.SetBoundPropertyName(this.Order_detailsGridControl, "");
            this.Order_detailsGridControl.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.OrderBindingSource, "Order_details", true));
            this.Order_detailsGridControl.Location = new System.Drawing.Point(24, 219);
            this.Order_detailsGridControl.MainView = this.gridView1;
            this.Order_detailsGridControl.MenuManager = this.barManager1;
            this.Order_detailsGridControl.Name = "Order_detailsGridControl";
            this.Order_detailsGridControl.Size = new System.Drawing.Size(780, 212);
            this.Order_detailsGridControl.TabIndex = 24;
            this.Order_detailsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.Order_detailsGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // NotesTextEdit
            // 
            this.SetBoundPropertyName(this.NotesTextEdit, "");
            this.NotesTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Notes", true));
            this.NotesTextEdit.Location = new System.Drawing.Point(131, 114);
            this.NotesTextEdit.MenuManager = this.barManager1;
            this.NotesTextEdit.Name = "NotesTextEdit";
            this.NotesTextEdit.Size = new System.Drawing.Size(673, 55);
            this.NotesTextEdit.StyleController = this.dataLayoutControl1;
            this.NotesTextEdit.TabIndex = 20;
            // 
            // Customer_idTextEdit
            // 
            this.SetBoundPropertyName(this.Customer_idTextEdit, "");
            this.Customer_idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Customer_id", true));
            this.Customer_idTextEdit.Location = new System.Drawing.Point(131, 66);
            this.Customer_idTextEdit.MenuManager = this.barManager1;
            this.Customer_idTextEdit.Name = "Customer_idTextEdit";
            this.Customer_idTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Customer_idTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Customer_idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Customer_idTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Customer_idTextEdit.Properties.DataSource = this.customerBindingSource;
            this.Customer_idTextEdit.Properties.DisplayMember = "First_name";
            this.Customer_idTextEdit.Properties.NullText = "";
            this.Customer_idTextEdit.Properties.PopupView = this.gridView2;
            this.Customer_idTextEdit.Properties.ValueMember = "ID";
            this.Customer_idTextEdit.Size = new System.Drawing.Size(281, 20);
            this.Customer_idTextEdit.StyleController = this.dataLayoutControl1;
            this.Customer_idTextEdit.TabIndex = 6;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Expert.Data.Models.Customer);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colCompany1,
            this.colFirst_name1,
            this.colLast_name1,
            this.colAttachments1});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 0;
            // 
            // colCompany1
            // 
            this.colCompany1.FieldName = "Company";
            this.colCompany1.Name = "colCompany1";
            this.colCompany1.Visible = true;
            this.colCompany1.VisibleIndex = 1;
            // 
            // colFirst_name1
            // 
            this.colFirst_name1.FieldName = "First_name";
            this.colFirst_name1.Name = "colFirst_name1";
            this.colFirst_name1.Visible = true;
            this.colFirst_name1.VisibleIndex = 2;
            // 
            // colLast_name1
            // 
            this.colLast_name1.FieldName = "Last_name";
            this.colLast_name1.Name = "colLast_name1";
            this.colLast_name1.Visible = true;
            this.colLast_name1.VisibleIndex = 3;
            // 
            // colAttachments1
            // 
            this.colAttachments1.FieldName = "Attachments";
            this.colAttachments1.Name = "colAttachments1";
            this.colAttachments1.Visible = true;
            this.colAttachments1.VisibleIndex = 4;
            // 
            // Status_idTextEdit
            // 
            this.SetBoundPropertyName(this.Status_idTextEdit, "");
            this.Status_idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Status_id", true));
            this.Status_idTextEdit.Location = new System.Drawing.Point(131, 90);
            this.Status_idTextEdit.MenuManager = this.barManager1;
            this.Status_idTextEdit.Name = "Status_idTextEdit";
            this.Status_idTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Status_idTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Status_idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Status_idTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Status_idTextEdit.Properties.DataSource = this.orderStatusBindingSource;
            this.Status_idTextEdit.Properties.DisplayMember = "Status_name";
            this.Status_idTextEdit.Properties.NullText = "";
            this.Status_idTextEdit.Properties.PopupView = this.gridView3;
            this.Status_idTextEdit.Properties.ValueMember = "ID";
            this.Status_idTextEdit.Size = new System.Drawing.Size(673, 20);
            this.Status_idTextEdit.StyleController = this.dataLayoutControl1;
            this.Status_idTextEdit.TabIndex = 23;
            // 
            // orderStatusBindingSource
            // 
            this.orderStatusBindingSource.DataSource = typeof(Expert.Data.Models.OrderStatus);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID2,
            this.colStatus_name});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colID2
            // 
            this.colID2.FieldName = "ID";
            this.colID2.Name = "colID2";
            this.colID2.Visible = true;
            this.colID2.VisibleIndex = 0;
            // 
            // colStatus_name
            // 
            this.colStatus_name.FieldName = "Status_name";
            this.colStatus_name.Name = "colStatus_name";
            this.colStatus_name.Visible = true;
            this.colStatus_name.VisibleIndex = 1;
            // 
            // Shipper_idTextEdit
            // 
            this.SetBoundPropertyName(this.Shipper_idTextEdit, "");
            this.Shipper_idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Shipper_id", true));
            this.Shipper_idTextEdit.Location = new System.Drawing.Point(131, 243);
            this.Shipper_idTextEdit.MenuManager = this.barManager1;
            this.Shipper_idTextEdit.Name = "Shipper_idTextEdit";
            this.Shipper_idTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Shipper_idTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Shipper_idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Shipper_idTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Shipper_idTextEdit.Properties.DataSource = this.shipperBindingSource;
            this.Shipper_idTextEdit.Properties.DisplayMember = "First_name";
            this.Shipper_idTextEdit.Properties.NullText = "";
            this.Shipper_idTextEdit.Properties.PopupView = this.gridView4;
            this.Shipper_idTextEdit.Properties.ValueMember = "ID";
            this.Shipper_idTextEdit.Size = new System.Drawing.Size(673, 20);
            this.Shipper_idTextEdit.StyleController = this.dataLayoutControl1;
            this.Shipper_idTextEdit.TabIndex = 9;
            // 
            // shipperBindingSource
            // 
            this.shipperBindingSource.DataSource = typeof(Expert.Data.Models.Shipper);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID3,
            this.colCompany2,
            this.colFirst_name2,
            this.colLast_name2,
            this.colAttachments2});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // Tax_status_idTextEdit
            // 
            this.SetBoundPropertyName(this.Tax_status_idTextEdit, "");
            this.Tax_status_idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Tax_status_id", true));
            this.Tax_status_idTextEdit.Location = new System.Drawing.Point(131, 315);
            this.Tax_status_idTextEdit.MenuManager = this.barManager1;
            this.Tax_status_idTextEdit.Name = "Tax_status_idTextEdit";
            this.Tax_status_idTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Tax_status_idTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Tax_status_idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Tax_status_idTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Tax_status_idTextEdit.Properties.DataSource = this.orderTaxStatusBindingSource;
            this.Tax_status_idTextEdit.Properties.DisplayMember = "Tax_status_name";
            this.Tax_status_idTextEdit.Properties.NullText = "";
            this.Tax_status_idTextEdit.Properties.PopupView = this.gridView5;
            this.Tax_status_idTextEdit.Properties.ValueMember = "ID";
            this.Tax_status_idTextEdit.Size = new System.Drawing.Size(673, 20);
            this.Tax_status_idTextEdit.StyleController = this.dataLayoutControl1;
            this.Tax_status_idTextEdit.TabIndex = 22;
            // 
            // orderTaxStatusBindingSource
            // 
            this.orderTaxStatusBindingSource.DataSource = typeof(Expert.Data.Models.OrderTaxStatus);
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID4,
            this.colTax_status_name});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Expert.Data.Models.Employee);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(828, 455);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.tabbedControlGroup1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(808, 435);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForID,
            this.ItemForEmployee_id,
            this.ItemForStatus_id,
            this.ItemForNotes,
            this.ItemForOrder_date,
            this.ItemForCustomer_id});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(808, 173);
            this.layoutControlGroup3.Text = "Main Details";
            // 
            // ItemForID
            // 
            this.ItemForID.Control = this.IDTextEdit;
            this.ItemForID.Location = new System.Drawing.Point(0, 0);
            this.ItemForID.Name = "ItemForID";
            this.ItemForID.Size = new System.Drawing.Size(392, 24);
            this.ItemForID.Text = "ID";
            this.ItemForID.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForEmployee_id
            // 
            this.ItemForEmployee_id.Control = this.Employee_idTextEdit;
            this.ItemForEmployee_id.Location = new System.Drawing.Point(392, 24);
            this.ItemForEmployee_id.Name = "ItemForEmployee_id";
            this.ItemForEmployee_id.Size = new System.Drawing.Size(392, 24);
            this.ItemForEmployee_id.Text = "Employee_id";
            this.ItemForEmployee_id.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForStatus_id
            // 
            this.ItemForStatus_id.Control = this.Status_idTextEdit;
            this.ItemForStatus_id.Location = new System.Drawing.Point(0, 48);
            this.ItemForStatus_id.Name = "ItemForStatus_id";
            this.ItemForStatus_id.Size = new System.Drawing.Size(784, 24);
            this.ItemForStatus_id.Text = "Status_id";
            this.ItemForStatus_id.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForNotes
            // 
            this.ItemForNotes.Control = this.NotesTextEdit;
            this.ItemForNotes.Location = new System.Drawing.Point(0, 72);
            this.ItemForNotes.Name = "ItemForNotes";
            this.ItemForNotes.Size = new System.Drawing.Size(784, 59);
            this.ItemForNotes.Text = "Notes";
            this.ItemForNotes.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForOrder_date
            // 
            this.ItemForOrder_date.Control = this.Order_dateDateEdit;
            this.ItemForOrder_date.Location = new System.Drawing.Point(392, 0);
            this.ItemForOrder_date.Name = "ItemForOrder_date";
            this.ItemForOrder_date.Size = new System.Drawing.Size(392, 24);
            this.ItemForOrder_date.Text = "Order_date";
            this.ItemForOrder_date.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForCustomer_id
            // 
            this.ItemForCustomer_id.Control = this.Customer_idTextEdit;
            this.ItemForCustomer_id.Location = new System.Drawing.Point(0, 24);
            this.ItemForCustomer_id.Name = "ItemForCustomer_id";
            this.ItemForCustomer_id.Size = new System.Drawing.Size(392, 24);
            this.ItemForCustomer_id.Text = "Customer_id";
            this.ItemForCustomer_id.TextSize = new System.Drawing.Size(103, 13);
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 173);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup4;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(808, 262);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup4,
            this.layoutControlGroup5,
            this.layoutControlGroup6});
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForShipped_date,
            this.ItemForShipper_id,
            this.ItemForShip_name,
            this.ItemForShip_address,
            this.ItemForShip_city,
            this.ItemForShip_state_province,
            this.ItemForShip_zip_postal_code,
            this.ItemForShip_country_region,
            this.ItemForShipping_fee});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(784, 216);
            this.layoutControlGroup4.Text = "Shipping";
            // 
            // ItemForShipped_date
            // 
            this.ItemForShipped_date.Control = this.Shipped_dateDateEdit;
            this.ItemForShipped_date.Location = new System.Drawing.Point(0, 0);
            this.ItemForShipped_date.Name = "ItemForShipped_date";
            this.ItemForShipped_date.Size = new System.Drawing.Size(784, 24);
            this.ItemForShipped_date.Text = "Shipped_date";
            this.ItemForShipped_date.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForShipper_id
            // 
            this.ItemForShipper_id.Control = this.Shipper_idTextEdit;
            this.ItemForShipper_id.Location = new System.Drawing.Point(0, 24);
            this.ItemForShipper_id.Name = "ItemForShipper_id";
            this.ItemForShipper_id.Size = new System.Drawing.Size(784, 24);
            this.ItemForShipper_id.Text = "Shipper_id";
            this.ItemForShipper_id.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForShip_name
            // 
            this.ItemForShip_name.Control = this.Ship_nameTextEdit;
            this.ItemForShip_name.Location = new System.Drawing.Point(0, 48);
            this.ItemForShip_name.Name = "ItemForShip_name";
            this.ItemForShip_name.Size = new System.Drawing.Size(784, 24);
            this.ItemForShip_name.Text = "Ship_name";
            this.ItemForShip_name.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForShip_address
            // 
            this.ItemForShip_address.Control = this.Ship_addressTextEdit;
            this.ItemForShip_address.Location = new System.Drawing.Point(0, 72);
            this.ItemForShip_address.Name = "ItemForShip_address";
            this.ItemForShip_address.Size = new System.Drawing.Size(784, 24);
            this.ItemForShip_address.Text = "Ship_address";
            this.ItemForShip_address.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForShip_city
            // 
            this.ItemForShip_city.Control = this.Ship_cityTextEdit;
            this.ItemForShip_city.Location = new System.Drawing.Point(0, 96);
            this.ItemForShip_city.Name = "ItemForShip_city";
            this.ItemForShip_city.Size = new System.Drawing.Size(784, 24);
            this.ItemForShip_city.Text = "Ship_city";
            this.ItemForShip_city.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForShip_state_province
            // 
            this.ItemForShip_state_province.Control = this.Ship_state_provinceTextEdit;
            this.ItemForShip_state_province.Location = new System.Drawing.Point(0, 120);
            this.ItemForShip_state_province.Name = "ItemForShip_state_province";
            this.ItemForShip_state_province.Size = new System.Drawing.Size(784, 24);
            this.ItemForShip_state_province.Text = "Ship_state_province";
            this.ItemForShip_state_province.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForShip_zip_postal_code
            // 
            this.ItemForShip_zip_postal_code.Control = this.Ship_zip_postal_codeTextEdit;
            this.ItemForShip_zip_postal_code.Location = new System.Drawing.Point(0, 144);
            this.ItemForShip_zip_postal_code.Name = "ItemForShip_zip_postal_code";
            this.ItemForShip_zip_postal_code.Size = new System.Drawing.Size(784, 24);
            this.ItemForShip_zip_postal_code.Text = "Ship_zip_postal_code";
            this.ItemForShip_zip_postal_code.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForShip_country_region
            // 
            this.ItemForShip_country_region.Control = this.Ship_country_regionTextEdit;
            this.ItemForShip_country_region.Location = new System.Drawing.Point(0, 168);
            this.ItemForShip_country_region.Name = "ItemForShip_country_region";
            this.ItemForShip_country_region.Size = new System.Drawing.Size(784, 24);
            this.ItemForShip_country_region.Text = "Ship_country_region";
            this.ItemForShip_country_region.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForShipping_fee
            // 
            this.ItemForShipping_fee.Control = this.Shipping_feeTextEdit;
            this.ItemForShipping_fee.Location = new System.Drawing.Point(0, 192);
            this.ItemForShipping_fee.Name = "ItemForShipping_fee";
            this.ItemForShipping_fee.Size = new System.Drawing.Size(784, 24);
            this.ItemForShipping_fee.Text = "Shipping_fee";
            this.ItemForShipping_fee.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForPayment_type,
            this.ItemForPaid_date,
            this.ItemForTaxes,
            this.ItemForTax_rate,
            this.ItemForTax_status_id});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(784, 216);
            this.layoutControlGroup5.Text = "Payment & Tax";
            // 
            // ItemForPayment_type
            // 
            this.ItemForPayment_type.Control = this.Payment_typeTextEdit;
            this.ItemForPayment_type.Location = new System.Drawing.Point(0, 0);
            this.ItemForPayment_type.Name = "ItemForPayment_type";
            this.ItemForPayment_type.Size = new System.Drawing.Size(784, 24);
            this.ItemForPayment_type.Text = "Payment_type";
            this.ItemForPayment_type.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForPaid_date
            // 
            this.ItemForPaid_date.Control = this.Paid_dateDateEdit;
            this.ItemForPaid_date.Location = new System.Drawing.Point(0, 24);
            this.ItemForPaid_date.Name = "ItemForPaid_date";
            this.ItemForPaid_date.Size = new System.Drawing.Size(784, 24);
            this.ItemForPaid_date.Text = "Paid_date";
            this.ItemForPaid_date.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForTaxes
            // 
            this.ItemForTaxes.Control = this.TaxesTextEdit;
            this.ItemForTaxes.Location = new System.Drawing.Point(0, 48);
            this.ItemForTaxes.Name = "ItemForTaxes";
            this.ItemForTaxes.Size = new System.Drawing.Size(784, 24);
            this.ItemForTaxes.Text = "Taxes";
            this.ItemForTaxes.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForTax_rate
            // 
            this.ItemForTax_rate.Control = this.Tax_rateTextEdit;
            this.ItemForTax_rate.Location = new System.Drawing.Point(0, 72);
            this.ItemForTax_rate.Name = "ItemForTax_rate";
            this.ItemForTax_rate.Size = new System.Drawing.Size(784, 24);
            this.ItemForTax_rate.Text = "Tax_rate";
            this.ItemForTax_rate.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForTax_status_id
            // 
            this.ItemForTax_status_id.Control = this.Tax_status_idTextEdit;
            this.ItemForTax_status_id.Location = new System.Drawing.Point(0, 96);
            this.ItemForTax_status_id.Name = "ItemForTax_status_id";
            this.ItemForTax_status_id.Size = new System.Drawing.Size(784, 120);
            this.ItemForTax_status_id.Text = "Tax_status_id";
            this.ItemForTax_status_id.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForOrder_details});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(784, 216);
            this.layoutControlGroup6.Text = "Products";
            // 
            // ItemForOrder_details
            // 
            this.ItemForOrder_details.Control = this.Order_detailsGridControl;
            this.ItemForOrder_details.Location = new System.Drawing.Point(0, 0);
            this.ItemForOrder_details.Name = "ItemForOrder_details";
            this.ItemForOrder_details.Size = new System.Drawing.Size(784, 216);
            this.ItemForOrder_details.StartNewLine = true;
            this.ItemForOrder_details.Text = "Order_details";
            this.ItemForOrder_details.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForOrder_details.TextVisible = false;
            // 
            // Employee_idTextEdit
            // 
            this.SetBoundPropertyName(this.Employee_idTextEdit, "");
            this.Employee_idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Employee_id", true));
            this.Employee_idTextEdit.Location = new System.Drawing.Point(523, 66);
            this.Employee_idTextEdit.MenuManager = this.barManager1;
            this.Employee_idTextEdit.Name = "Employee_idTextEdit";
            this.Employee_idTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Employee_idTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Employee_idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Employee_idTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Employee_idTextEdit.Properties.DataSource = this.employeeBindingSource;
            this.Employee_idTextEdit.Properties.DisplayMember = "First_name";
            this.Employee_idTextEdit.Properties.NullText = "";
            this.Employee_idTextEdit.Properties.PopupView = this.searchLookUpEdit1View;
            this.Employee_idTextEdit.Properties.ValueMember = "ID";
            this.Employee_idTextEdit.Size = new System.Drawing.Size(281, 20);
            this.Employee_idTextEdit.StyleController = this.dataLayoutControl1;
            this.Employee_idTextEdit.TabIndex = 5;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCompany,
            this.colFirst_name,
            this.colLast_name,
            this.colAttachments});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colCompany
            // 
            this.colCompany.FieldName = "Company";
            this.colCompany.Name = "colCompany";
            this.colCompany.Visible = true;
            this.colCompany.VisibleIndex = 1;
            // 
            // colFirst_name
            // 
            this.colFirst_name.FieldName = "First_name";
            this.colFirst_name.Name = "colFirst_name";
            this.colFirst_name.Visible = true;
            this.colFirst_name.VisibleIndex = 2;
            // 
            // colLast_name
            // 
            this.colLast_name.FieldName = "Last_name";
            this.colLast_name.Name = "colLast_name";
            this.colLast_name.Visible = true;
            this.colLast_name.VisibleIndex = 3;
            // 
            // colAttachments
            // 
            this.colAttachments.FieldName = "Attachments";
            this.colAttachments.Name = "colAttachments";
            this.colAttachments.Visible = true;
            this.colAttachments.VisibleIndex = 4;
            // 
            // colID3
            // 
            this.colID3.FieldName = "ID";
            this.colID3.Name = "colID3";
            this.colID3.Visible = true;
            this.colID3.VisibleIndex = 0;
            // 
            // colCompany2
            // 
            this.colCompany2.FieldName = "Company";
            this.colCompany2.Name = "colCompany2";
            this.colCompany2.Visible = true;
            this.colCompany2.VisibleIndex = 1;
            // 
            // colFirst_name2
            // 
            this.colFirst_name2.FieldName = "First_name";
            this.colFirst_name2.Name = "colFirst_name2";
            this.colFirst_name2.Visible = true;
            this.colFirst_name2.VisibleIndex = 2;
            // 
            // colLast_name2
            // 
            this.colLast_name2.FieldName = "Last_name";
            this.colLast_name2.Name = "colLast_name2";
            this.colLast_name2.Visible = true;
            this.colLast_name2.VisibleIndex = 3;
            // 
            // colAttachments2
            // 
            this.colAttachments2.FieldName = "Attachments";
            this.colAttachments2.Name = "colAttachments2";
            this.colAttachments2.Visible = true;
            this.colAttachments2.VisibleIndex = 4;
            // 
            // colID4
            // 
            this.colID4.FieldName = "ID";
            this.colID4.Name = "colID4";
            this.colID4.Visible = true;
            this.colID4.VisibleIndex = 0;
            // 
            // colTax_status_name
            // 
            this.colTax_status_name.FieldName = "Tax_status_name";
            this.colTax_status_name.Name = "colTax_status_name";
            this.colTax_status_name.Visible = true;
            this.colTax_status_name.VisibleIndex = 1;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(828, 484);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_dateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shipped_dateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shipped_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ship_nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ship_addressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ship_cityTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ship_state_provinceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ship_zip_postal_codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ship_country_regionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shipping_feeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxesTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Payment_typeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paid_dateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paid_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tax_rateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_detailsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotesTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shipper_idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipperBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tax_status_idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTaxStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployee_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOrder_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomer_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShipped_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShipper_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShip_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShip_address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShip_city)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShip_state_province)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShip_zip_postal_code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShip_country_region)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShipping_fee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPayment_type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPaid_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTaxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTax_rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTax_status_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOrder_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit IDTextEdit;
        private System.Windows.Forms.BindingSource OrderBindingSource;
        private DevExpress.XtraEditors.DateEdit Order_dateDateEdit;
        private DevExpress.XtraEditors.DateEdit Shipped_dateDateEdit;
        private DevExpress.XtraEditors.TextEdit Ship_nameTextEdit;
        private DevExpress.XtraEditors.TextEdit Ship_addressTextEdit;
        private DevExpress.XtraEditors.TextEdit Ship_cityTextEdit;
        private DevExpress.XtraEditors.TextEdit Ship_state_provinceTextEdit;
        private DevExpress.XtraEditors.TextEdit Ship_zip_postal_codeTextEdit;
        private DevExpress.XtraEditors.TextEdit Ship_country_regionTextEdit;
        private DevExpress.XtraEditors.TextEdit Shipping_feeTextEdit;
        private DevExpress.XtraEditors.TextEdit TaxesTextEdit;
        private DevExpress.XtraEditors.TextEdit Payment_typeTextEdit;
        private DevExpress.XtraEditors.DateEdit Paid_dateDateEdit;
        private DevExpress.XtraEditors.TextEdit Tax_rateTextEdit;
        private DevExpress.XtraGrid.GridControl Order_detailsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.MemoEdit NotesTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmployee_id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustomer_id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForOrder_date;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStatus_id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNotes;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControlItem ItemForOrder_details;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem ItemForShipped_date;
        private DevExpress.XtraLayout.LayoutControlItem ItemForShipper_id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForShip_name;
        private DevExpress.XtraLayout.LayoutControlItem ItemForShip_address;
        private DevExpress.XtraLayout.LayoutControlItem ItemForShip_city;
        private DevExpress.XtraLayout.LayoutControlItem ItemForShip_state_province;
        private DevExpress.XtraLayout.LayoutControlItem ItemForShip_zip_postal_code;
        private DevExpress.XtraLayout.LayoutControlItem ItemForShip_country_region;
        private DevExpress.XtraLayout.LayoutControlItem ItemForShipping_fee;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPayment_type;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPaid_date;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTaxes;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTax_rate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTax_status_id;
        private DevExpress.XtraEditors.SearchLookUpEdit Customer_idTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SearchLookUpEdit Status_idTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SearchLookUpEdit Shipper_idTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.SearchLookUpEdit Tax_status_idTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompany1;
        private DevExpress.XtraGrid.Columns.GridColumn colFirst_name1;
        private DevExpress.XtraGrid.Columns.GridColumn colLast_name1;
        private DevExpress.XtraGrid.Columns.GridColumn colAttachments1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.BindingSource orderStatusBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID2;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus_name;
        private System.Windows.Forms.BindingSource shipperBindingSource;
        private System.Windows.Forms.BindingSource orderTaxStatusBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID3;
        private DevExpress.XtraGrid.Columns.GridColumn colCompany2;
        private DevExpress.XtraGrid.Columns.GridColumn colFirst_name2;
        private DevExpress.XtraGrid.Columns.GridColumn colLast_name2;
        private DevExpress.XtraGrid.Columns.GridColumn colAttachments2;
        private DevExpress.XtraGrid.Columns.GridColumn colID4;
        private DevExpress.XtraGrid.Columns.GridColumn colTax_status_name;
        private DevExpress.XtraEditors.SearchLookUpEdit Employee_idTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colFirst_name;
        private DevExpress.XtraGrid.Columns.GridColumn colLast_name;
        private DevExpress.XtraGrid.Columns.GridColumn colAttachments;
    }
}
