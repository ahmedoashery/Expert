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
    }
}
