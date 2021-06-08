using System;
namespace Expert.Data.Models
{

    public partial class PurchaseOrderDetail
    {
        public int ID { get; set; }

        public int Purchase_order_id { get; set; }

        public int? Product_id { get; set; }

        public decimal Quantity { get; set; }

        public decimal Unit_cost { get; set; }

        public DateTime? Date_received { get; set; }

        public bool Posted_to_inventory { get; set; }

        public int? Inventory_id { get; set; }

        public virtual InventoryTransaction Inventory_transactions { get; set; }

        public virtual Product Product { get; set; }

        public virtual PurchaseOrder Purchase_orders { get; set; }
    }
}
