using System.Collections.Generic;

namespace Expert.Data.Models
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }

        public int Category_id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual IList<Product> Products { get; set; }
    }
}
