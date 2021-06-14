namespace Expert.Data.Models
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class InventoryTransactionType
    {
        public InventoryTransactionType()
        {
            inventory_transactions = new HashSet<InventoryTransaction>();
        }

        public int ID { get; set; }
        public string type_name { get; set; }
        public virtual ICollection<InventoryTransaction> inventory_transactions { get; set; }
    }
}
