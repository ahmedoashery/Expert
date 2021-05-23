using System.Collections.Generic;

namespace Expert.Data.Models
{
    public class Customer
    {
        public Customer()
        {
            Orders = new List<SaleOrder>();
        }

        public int Customer_id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual IList<SaleOrder> Orders { get; set; }
    }
}
