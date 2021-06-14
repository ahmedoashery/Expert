namespace Expert.Data.Models
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

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
