namespace Expert.Data.Models
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SaleOrderStatus
    {
        public SaleOrderStatus()
        {
            Orders = new HashSet<SaleOrder>();
        }

        public int ID { get; set; }

        public string Status_name { get; set; }

        public virtual ICollection<SaleOrder> Orders { get; set; }
    }
}
