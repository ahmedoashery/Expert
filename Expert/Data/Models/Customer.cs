using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert.Data.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ObservableCollection<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new ObservableCollection<Order>();
        }
    }
}
