using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSSS.Entitie
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public User() { }

        public User(string name, string login, string pas)
        {
            Name = name;
            Login = login;
            Password = pas;
        }

        public override string ToString()
        {
            return $"Id: {Id} Имя: {Name}";
        }
    }
}
