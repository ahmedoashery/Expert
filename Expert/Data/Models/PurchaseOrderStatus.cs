namespace Expert.Data.Models
{
    using System.Collections.Generic;

    public partial class PurchaseOrderStatus
    {
        public PurchaseOrderStatus()
        {
            Purchase_orders = new HashSet<PurchaseOrder>();
        }

        public int ID { get; set; }

        public string Status { get; set; }

        public virtual ICollection<PurchaseOrder> Purchase_orders { get; set; }
    }
}
