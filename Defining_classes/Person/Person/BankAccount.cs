using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class BankAccount
    {
        public decimal Balance { get; set; }

        public BankAccount(decimal balance)
        {
            Balance = balance;              
        }
    }
}
