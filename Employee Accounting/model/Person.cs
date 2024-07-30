using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Accounting.model
{
    public class Person
    {

        private Guid id;
        private string firstName;
        private string lastName;
        private int age;
        private string email;
        private string phone;


        public Person(Guid id, string firstName, string lastName, int age, string email, string phone)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
            Phone = phone;
            
            
        }

        public Guid Id { get; private set; }

        public string FirstName { get; private set; }
            
        public string LastName { get; private set; }

        public int Age { get; private set; }

        public string Email { get; private set; }

        public string Phone { get; private set; }


    }
}
