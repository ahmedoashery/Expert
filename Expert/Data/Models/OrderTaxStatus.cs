namespace Expert.Data.Models
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class OrderTaxStatus
    {
        public OrderTaxStatus()
        {
            Orders = new HashSet<Order>();
        }

        public int ID { get; set; }

        public string Tax_status_name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
