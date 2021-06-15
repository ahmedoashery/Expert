namespace Expert.Data.Models
{
    using System;

    public partial class SaleOrderDetail
    {
        public int ID { get; set; }

        public int? Order_id { get; set; }

        public int? Product_id { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? Unit_price { get; set; }

        public double? Discount { get; set; }

        public virtual SaleOrder Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
