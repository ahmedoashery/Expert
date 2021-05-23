using System;
using System.Collections.Generic;

namespace Expert.Data.Models
{
    public class PurchaseOrder
    {
        public int Order_id { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

        public int Supplier_id { get; set; }
        public virtual Supplier Supplier { get; set; }

        public virtual IList<Product> Products { get; set; }

        public PurchaseOrder()
        {
            Products = new List<Product>();
        }
    }
}