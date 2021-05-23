using System.Data.Entity;

namespace Expert.Data
{
    public class ExpertContext : DbContext
    {
        public ExpertContext() : base("name=DefaultConnection")
        {
        }
    }
}
