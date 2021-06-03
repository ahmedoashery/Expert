using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert.Data.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Category_id { get; set; }
        public Category Category { get; set; }

        public int Supplier_id { get; set; }
        public Supplier Supplier { get; set; }

        public virtual ObservableCollection<Order> Orders { get; set; }

        public Product()
        {
            Orders = new ObservableCollection<Order>();
        }
    }
}
