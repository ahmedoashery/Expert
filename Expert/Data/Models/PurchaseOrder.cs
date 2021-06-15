namespace Expert.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            Purchase_order_details = new HashSet<PurchaseOrderDetail>();
        }

        public int ID { get; set; }

        public int? Status_id { get; set; }

        public DateTime? Creation_date { get; set; }

        public int? Supplier_id { get; set; }

        public int? Employee_id { get; set; }

        public decimal? Shipping_fee { get; set; }

        public DateTime? Payment_date { get; set; }

        public decimal? Payment_amount { get; set; }

        public decimal? Discount { get; set; }

        public string Payment_method { get; set; }

        public string Notes { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ICollection<PurchaseOrderDetail> Purchase_order_details { get; set; }

        public virtual PurchaseOrderStatus Purchase_order_status { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
