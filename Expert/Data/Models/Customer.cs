using System.Collections.Generic;

namespace Expert.Data.Models
{
    public class Customer
    {
        public Customer()
        {
            Orders = new List<SalesOrder>();
        }

        public int Customer_id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual IList<SalesOrder> Orders { get; set; }
    }
}
