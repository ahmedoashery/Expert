using Expert.Data;

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
            var hashed = BCrypt.Net.BCrypt.HashPassword(password);
            var foundUsername = new { };
            //foundUsername= context.Users.FirstOrDefault(u => u.Username == username);

            if (foundUsername != null && BCrypt.Net.BCrypt.Verify(password, hashed))
                return true;
            else
                return false;
        }
    }
}
