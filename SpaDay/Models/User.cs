using System;
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

        public User(string u, string e, string p): this()
        {
            Username = u;
            Email = e;
            Password = p;
        }

    }
}
