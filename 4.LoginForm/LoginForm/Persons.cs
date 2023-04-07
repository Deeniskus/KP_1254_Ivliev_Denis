using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    public class Persons
    {
        public string login;
        public string password;
        public string name;
        public int age;
        public Persons()
        {

        }

        public Persons(string login, string password, string name, int age)
        {
            this.login = login;
            this.password = password;
            this.name = name;
            this.age = age;
        }
    }
}
