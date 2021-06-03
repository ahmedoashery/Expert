using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert.Data.Models
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }

        public int Customer_id { get; set; }
        public Customer Customer { get; set; }

        public virtual ObservableCollection<Product> Products { get; set; }

        public Order()
        {
            Products = new ObservableCollection<Product>();
        }
    }
}
