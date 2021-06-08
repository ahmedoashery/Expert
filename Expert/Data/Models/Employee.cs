namespace Expert.Data.Models
{
    using System.Collections.Generic;

    public partial class Employee
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
            Purchase_orders = new HashSet<PurchaseOrder>();
            Privileges = new HashSet<Privilege>();
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
        public string Notes { get; set; }
        public byte[] Attachments { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PurchaseOrder> Purchase_orders { get; set; }
        public virtual ICollection<Privilege> Privileges { get; set; }
    }
}
