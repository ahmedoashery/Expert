using System;

namespace Expert.Data.Models
{
    public class SalesOrder
    {
        public int Order_id { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

        public int Customer_id { get; set; }
        public virtual Customer Customer { get; set; }
    }
}