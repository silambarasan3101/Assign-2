using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class UserAuthenticator
    {
        private List<User> users = new List<User>();

        public void RegisterUser(string username, string password)
        {
            users.Add(new User { Username = username, Password = password });
        }

        public bool Login(string username, string password)
        {
            return users.Exists(u => u.Username == username && u.Password == password);
        }

        public void ResetPassword(string username, string newPassword)
        {
            
            var user = users.Find(u => u.Username == username);
            if (user != null)
            {
                user.Password = newPassword;
            }
        }
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}