namespace Expert.Data.Models
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Product
    {
        public Product()
        {
            Inventory_transactions = new ObservableCollection<InventoryTransaction>();
            Order_details = new ObservableCollection<OrderDetail>();
            Purchase_order_details = new ObservableCollection<PurchaseOrderDetail>();
        }

        public int ID { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal? Standard_cost { get; set; }

        public decimal List_price { get; set; }

        public int? Reorder_level { get; set; }

        public int? Target_level { get; set; }

        public string Quantity_per_unit { get; set; }

        public bool Discontinued { get; set; }

        public int? Minimum_reorder_quantity { get; set; }

        public int Category_id { get; set; }

        public virtual Category Category { get; set; }

        public int Supplier_id { get; set; }

        public virtual Supplier Supplier { get; set; }

        public byte[] Attachments { get; set; }

        public virtual ObservableCollection<InventoryTransaction> Inventory_transactions { get; set; }

        public virtual ObservableCollection<OrderDetail> Order_details { get; set; }

        public virtual ObservableCollection<PurchaseOrderDetail> Purchase_order_details { get; set; }
    }
}
