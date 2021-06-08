namespace Expert.Data.Models
{
    using System.Collections.Generic;

    public partial class OrderDetailStatus
    {
        public OrderDetailStatus()
        {
            Order_details = new HashSet<OrderDetail>();
        }

        public int ID { get; set; }

        public string Status_name { get; set; }

        public virtual ICollection<OrderDetail> Order_details { get; set; }
    }
}
