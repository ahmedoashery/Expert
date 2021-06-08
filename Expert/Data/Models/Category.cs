using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Expert.Data.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ObservableCollection<Product> Products { get; set; }

        public Category()
        {
            Products = new ObservableCollection<Product>();
        }
    }
}
