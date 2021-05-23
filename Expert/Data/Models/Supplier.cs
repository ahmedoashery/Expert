using System.Collections.Generic;

namespace Expert.Data.Models
{
    public class Supplier
    {
        public Supplier()
        {
            Products = new List<Product>();
        }

        public int Supplier_id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual IList<Product> Products { get; set; }
    }
}
