using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Expert.Data.Models
{
    public class Customer
    {
        public Customer()
        {
            Orders = new ObservableCollection<SaleOrder>();
        }

        public int Customer_id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual ObservableCollection<SaleOrder> Orders { get; set; }
    }
}
