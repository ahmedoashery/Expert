namespace Expert.Data.Models
{
    using System;

    public partial class OrderDetail
    {
        public int ID { get; set; }
        public int Order_id { get; set; }
        public int? Product_id { get; set; }
        public decimal Quantity { get; set; }
        public decimal? Unit_price { get; set; }
        public double Discount { get; set; }
        public int? Status_id { get; set; }
        public DateTime? Date_allocated { get; set; }
        public int? Purchase_order_id { get; set; }
        public int? Inventory_id { get; set; }
        public virtual OrderDetailStatus Order_details_status { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
