namespace Expert.Data.Models
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Shipper
    {
        public Shipper()
        {
            Sale_orders = new HashSet<SaleOrder>();
        }

        public int ID { get; set; }
        public string Company { get; set; }

        public string First_name { get; set; }

        public string Last_name { get; set; }

        public string Email_address { get; set; }

        public string Job_title { get; set; }

        public string Business_phone { get; set; }

        public string Home_phone { get; set; }

        public string Mobile_phone { get; set; }

        public string Fax_number { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State_province { get; set; }

        public string Zip_postal_code { get; set; }

        public string Country_region { get; set; }

        public string Web_page { get; set; }

        public byte[] Attachments { get; set; }

        public string Notes { get; set; }

        public virtual ICollection<SaleOrder> Sale_orders { get; set; }
    }
}
