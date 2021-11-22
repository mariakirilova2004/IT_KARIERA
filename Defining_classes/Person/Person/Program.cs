using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Maria", 16, new BankAccount(270.45m));

            person1.PersonalAccounts.Add(new BankAccount(2.45m));

            person1.IntroduceYourself();
            person1.GetBalance();

            Console.ReadKey();
        }
    }
}
