using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class UserAuthenticator
    {
        private Dictionary<string, string> userDatabase; // Simulating a simple in-memory user database

        public UserAuthenticator()
        {
            userDatabase = new Dictionary<string, string>();
        }

        public bool RegisterUser(string username, string password)
        {
            if (!userDatabase.ContainsKey(username))
            {
                userDatabase[username] = password;
                return true;
            }
            return false; // User already exists
        }

        public bool LoginUser(string username, string password)
        {
            if (userDatabase.TryGetValue(username, out string storedPassword))
            {
                return password == storedPassword;
            }
            return false; // User not found
        }

        public bool ChangePassword(string username, string newPassword)
        {
            if (userDatabase.ContainsKey(username))
            {
                userDatabase[username] = newPassword;
                return true;
            }
            return false; // User not found
        }
    }
}
