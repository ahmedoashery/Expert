using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Expert.Data.Models
{
    public class SaleOrder
    {
        public int Order_id { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

        public int Customer_id { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual ObservableCollection<Product> Products { get; set; }

        public SaleOrder()
        {
            Products = new ObservableCollection<Product>();
        }
    }
}