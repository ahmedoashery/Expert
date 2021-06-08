namespace Expert.Data.Models
{
    using System.Collections.Generic;

    public partial class OrderStatus
    {
        public OrderStatus()
        {
            Orders = new HashSet<Order>();
        }

        public int ID { get; set; }

        public string Status_name { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
