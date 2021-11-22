using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakciq
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee emp1 = new FullTimeEmployee(1, "Pesho", "ul.Dunav", "Manager", "HR");
            emp1.Show();
            emp1.CalculateSalary(3);
            emp1.GetDepartment();
            FullTimeEmployee emp2 = new FullTimeEmployee(2, "Gosho", "ul.Dunav", "Researching", "RND");
            emp2.Show();
            emp2.CalculateSalary(3);
            emp2.GetDepartment();
            Console.ReadKey();
        }
    }
}
