using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Expert.Data.Models
{

    public partial class Order
    {
        public Order()
        {
            Inventory_transactions = new HashSet<InventoryTransaction>();
            Invoices = new HashSet<Invoice>();
            Order_details = new HashSet<OrderDetail>();
        }

        public int ID { get; set; }
        public int? Employee_id { get; set; }
        public int? Customer_id { get; set; }
        public DateTime Order_date { get; set; }
        public DateTime? Shipped_date { get; set; }
        public int? Shipper_id { get; set; }
        public string Ship_name { get; set; }
        public string Ship_address { get; set; }
        public string Ship_city { get; set; }
        public string Ship_state_province { get; set; }
        public string Ship_zip_postal_code { get; set; }
        public string Ship_country_region { get; set; }
        public decimal? Shipping_fee { get; set; }
        public decimal? Taxes { get; set; }
        public string Payment_type { get; set; }
        public DateTime? Paid_date { get; set; }
        public string Notes { get; set; }
        public double? Tax_rate { get; set; }
        public int? Tax_status_id { get; set; }
        public int? Status_id { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<InventoryTransaction> Inventory_transactions { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<OrderDetail> Order_details { get; set; }
        public virtual OrderStatus Orders_status { get; set; }
        public virtual OrderTaxStatus Orders_tax_status { get; set; }
        public virtual Shipper Shipper { get; set; }
    }
}
