namespace Expert.Data.Models
{
    using System;

    public partial class Invoice
    {
        public int ID { get; set; }
        public int? Order_id { get; set; }
        public DateTime Invoice_date { get; set; }
        public DateTime? Due_date { get; set; }
        public decimal? Tax { get; set; }
        public decimal? Shipping { get; set; }
        public decimal? Amount_due { get; set; }
        public virtual Order Order { get; set; }
    }
}
