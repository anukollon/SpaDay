using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime TimeJoined { get; set; }

        public User()
        {
            TimeJoined = DateTime.Now;
        }

        public User(string username, string email, string password):this()
        {
            Console.WriteLine("Inside constructor");
            Username = username;
            Email = email;
            Password = password;
        }

    }
}
