using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_1
{
    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set 
            {
                if (value.Length < 3) throw new ArgumentException("The name can't be less that 3 symbols.");
                name = value; 
            }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set 
            {
                if (value < 1) throw new ArgumentException("The age çan't be less than 1 year.");
                age = value;
            }
        }
    }
}
