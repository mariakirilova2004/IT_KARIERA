using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_1
{
    class Person
    {
        string firstName;
        string lastName;
        int Age;
        double Salary;

        public Person(string fName, string lName, int age, double salary)
        {
            firstName = fName;
            lastName = lName;
            Age = age;
            Salary = salary;
        }
        public void IncreseSalary(double percent)
        {
            if (Age < 30)
            {
                percent /= 2;
            }
            percent = percent / 100;
            Salary = Salary + (Salary * percent);
        }

        public override string ToString()
        {
            return $"{firstName} {lastName} get {Salary:0.00} leva";
        }
    }
}
