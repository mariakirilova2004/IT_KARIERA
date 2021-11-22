using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();
            firstPerson.Name = "Gosho";
            firstPerson.Age = 15;
            firstPerson.IntroduceYourself();

            BankAccount acc1 = new BankAccount(1);
            acc1.Deposit(5);
            acc1.Withdraw(1);

            BankAccount acc2 = new BankAccount(2);
            acc2.Deposit(7);
            acc2.Withdraw(4);

            BankAccount acc3 = new BankAccount(3);
            acc3.Deposit(20);
            acc3.Withdraw(10);

            firstPerson.accounts = new List<BankAccount>();
            firstPerson.accounts.Add(acc1);
            firstPerson.accounts.Add(acc2);
            firstPerson.accounts.Add(acc3);

            firstPerson.GetBalance();

            Console.ReadKey();
        }
    }
}
