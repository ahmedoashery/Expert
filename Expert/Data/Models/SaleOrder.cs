using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Expert.Data.Models
{

    public partial class SaleOrder
    {
        public SaleOrder()
        {
            Order_details = new HashSet<SaleOrderDetail>();
        }

        public int ID { get; set; }

        public int? Status_id { get; set; }

        public DateTime? Creation_date { get; set; }

        public int? Employee_id { get; set; }

        public int? Customer_id { get; set; }

        public DateTime? Shipped_date { get; set; }

        public int? Shipper_id { get; set; }

        public string Ship_name { get; set; }

        public string Ship_address { get; set; }

        public string Ship_city { get; set; }

        public string Ship_state_province { get; set; }

        public string Ship_zip_postal_code { get; set; }

        public string Ship_country_region { get; set; }

        public decimal? Shipping_fee { get; set; }

        public decimal? Discount { get; set; }

        public string Payment_type { get; set; }

        public DateTime? Paid_date { get; set; }

        public string Notes { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ICollection<SaleOrderDetail> Order_details { get; set; }

        public virtual SaleOrderStatus Order_status { get; set; }

        public virtual Shipper Shipper { get; set; }
    }
}
