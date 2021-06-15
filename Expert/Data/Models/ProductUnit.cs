using System.Collections.Generic;

namespace Expert.Data.Models
{
    public partial class ProductUnit
    {
        public ProductUnit()
        {
            Products = new HashSet<Product>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public string Quantity_per_unit { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
