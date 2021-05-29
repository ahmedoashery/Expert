using Expert.Data;
using Expert.Data.Models;
using System.Data.Entity;

namespace Expert.Services
{
    public class Authenticate
    {
        protected User _user;
        protected ExpertContext context;
        public Authenticate(User user)
        {
            _user = user;
            context = new ExpertContext();
        }

        private bool Check(string username, string password) 
        {
            return true;
        }
    }
}
