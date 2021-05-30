using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Expert.Data.Models
{
    public class Category
    {
        public Category()
        {
            Products = new ObservableCollection<Product>();
        }

        public int Category_id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ObservableCollection<Product> Products { get; set; }
    }
}
