using Expert.Data;
using Expert.Data.Models;
using System.Data.Entity;
using System.Linq;

namespace Expert.Services
{
    public class Authenticate
    {
        protected ExpertContext context;
        public Authenticate()
        {
            context = new ExpertContext();
        }

        public bool Check(string username, string password)
        {
            var foundUser = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (foundUser != null)
            {
                return true;
            }
            return false;
        }
    }
}
