using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public List<BankAccount> PersonalAccounts { get; set; }
        public void IntroduceYourself()
        {
            Console.WriteLine($"Hi, I'm {name} and I'm {age} years old.");
        }

        public Person()
        {
            PersonalAccounts = new List<BankAccount>();
        }
        public Person(string name, int age) : this()
        {
            this.name = name;
            this.age = age;
        }
        public Person(string name, int age, BankAccount account) : this(name, age)
        {
            PersonalAccounts.Add(account);
        }
        public void GetBalance()
        {
            decimal sum = PersonalAccounts.Select(x => x.Balance).Sum();
            Console.WriteLine($"{name} has ${sum} in their bank account");
        }
    }
}
