namespace Expert.Data.Models
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Privilege
    {
        public Privilege()
        {
            Employees = new HashSet<Employee>();
        }

        public int ID { get; set; }

        public string Privilege_name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
