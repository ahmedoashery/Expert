using System;
namespace Expert.Data.Models
{

    public partial class PurchaseOrderDetail
    {
        public int? ID { get; set; }

        public int? Order_id { get; set; }

        public int? Product_id { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? Unit_cost { get; set; }

        public double? Discount { get; set; }

        public virtual Product Product { get; set; }

        public virtual PurchaseOrder Purchase_orders { get; set; }
    }
}
