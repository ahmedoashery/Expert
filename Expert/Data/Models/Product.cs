namespace Expert.Data.Models
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Product
    {
        public Product()
        {
            Inventory_transactions = new HashSet<InventoryTransaction>();
            Order_details = new HashSet<OrderDetail>();
            Purchase_order_details = new HashSet<PurchaseOrderDetail>();
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

        public virtual ICollection<InventoryTransaction> Inventory_transactions { get; set; }

        public virtual ICollection<OrderDetail> Order_details { get; set; }

        public virtual ICollection<PurchaseOrderDetail> Purchase_order_details { get; set; }
    }
}
