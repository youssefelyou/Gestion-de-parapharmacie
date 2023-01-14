using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parapharmacie.Class
{
    public class User
    {
        private int id;
        private string fullname;
        private string username;
        private string password;
        private int age;
        private string role;

        public User(int id, string fullname, string username, int age, String password, string role)
        {
            this.id = id;
            this.fullname = fullname;
            this.username = username;
            this.age = age;
            this.password = password;
            this.role = role;
        }

        public User()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Age { get => age; set => age = value; }
        public string Role { get => role; set => role = value; }
    }
}
