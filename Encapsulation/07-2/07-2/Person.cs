using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_2
{
    class Person
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string fN, string lN, int a)
        {
            FirstName = fN;
            LastName = lN;
            Age = a;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} is a {Age} years old";
        }
    }
}
