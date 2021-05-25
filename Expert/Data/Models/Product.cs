using System.Collections.Generic;

namespace Expert.Data.Models
{
    public class Product
    {
        public int Product_id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal QuantityInStock { get; set; }
        public decimal Price { get; set; }

        public int Category_id { get; set; }
        public Category Category { get; set; }

        public int Supplier_id { get; set; }
        public Supplier Supplier { get; set; }

        public virtual IList<SaleOrder> SalesOrders { get; set; }
        public virtual IList<PurchaseOrder> PurchasesOrders { get; set; }

        public Product()
        {
            SalesOrders = new List<SaleOrder>();
            PurchasesOrders = new List<PurchaseOrder>();
        }
    }
}
