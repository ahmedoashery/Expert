using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Expert.Data.Models
{
    public partial class Product
    {
        public Product()
        {
            Sale_order_details = new HashSet<SaleOrderDetail>();
            Purchase_order_details = new HashSet<PurchaseOrderDetail>();
        }

        public int ID { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal? Cost { get; set; }

        public decimal? Price { get; set; }

        public int? Quantity_in_stock { get; set; }

        public bool Active { get; set; }

        public int? Category_id { get; set; }

        public virtual Category Category { get; set; }

        public int? Unit_id { get; set; }

        public virtual ProductUnit Unit { get; set; }

        public int? Supplier_id { get; set; }

        public virtual Supplier Supplier { get; set; }

        public byte[] Attachments { get; set; }

        public virtual ICollection<SaleOrderDetail> Sale_order_details { get; set; }

        public virtual ICollection<PurchaseOrderDetail> Purchase_order_details { get; set; }
    }
}
