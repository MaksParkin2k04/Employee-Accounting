using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Accounting.model
{
    public class PersonLogIn
    {

        private Guid id;
        private string firstName;
        private string lastName;
        private string login;
        private string password;
        private string role;

        public PersonLogIn(Guid id, string firstName, string lastName,string login, string password, string role)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Login = login;
            Password = password;
        }

        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public string Login { get; private set; }
        public string Password { get; private set; }

        public string Role { get; private set; }
    }
}
