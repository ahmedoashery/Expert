namespace Expert.Data.Models
{
    public partial class SalesReport
    {
        public int ID { get; set; }
        public string Group_by { get; set; }

        public string Display { get; set; }

        public string Title { get; set; }

        public string Filter_row_source { get; set; }

        public bool Default { get; set; }
    }
}
