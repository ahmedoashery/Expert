using System;
using System.Collections.Generic;

namespace Expert.Data.Models
{

    public partial class InventoryTransaction
    {
        public InventoryTransaction()
        {
            Purchase_order_details = new HashSet<PurchaseOrderDetail>();
        }

        public int ID { get; set; }
        public int Transaction_type_id { get; set; }
        public DateTime Transaction_created_date { get; set; }
        public DateTime Transaction_modified_date { get; set; }
        public int Product_id { get; set; }
        public int Quantity { get; set; }
        public int? Purchase_order_id { get; set; }
        public int? Customer_order_id { get; set; }
        public string Comments { get; set; }
        public virtual InventoryTransactionType Inventory_transaction_types { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual PurchaseOrder Purchase_orders { get; set; }
        public virtual ICollection<PurchaseOrderDetail> Purchase_order_details { get; set; }
    }
}
