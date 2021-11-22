using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_1
{
    class Person
    {
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<BankAccount> accounts;

        public void IntroduceYourself()
        {
            Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
        }

        public void GetBalance()
        {
            Console.WriteLine($"{accounts.Sum(x => x.Balance)}");
        }
    }
}
