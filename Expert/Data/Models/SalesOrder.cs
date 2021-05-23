using System;
using System.Collections.Generic;

namespace Expert.Data.Models
{
    public class SalesOrder
    {
        public int Order_id { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

        public int Customer_id { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual IList<Product> Products { get; set; }

        public SalesOrder()
        {
            Products = new List<Product>();
        }
    }
}