using Expert.Data.Models;

namespace Expert.Services
{
    public class Authenticate
    {
        private string username1;
        private string Username { get => username1; set => username1 = value; }

        private string password1;
        private string Password { get => password1; set => password1 = value; }

        public Authenticate(User user)
        {

        }
    }
}
