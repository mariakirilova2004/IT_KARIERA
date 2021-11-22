using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Employee[] emp = new Employee[N]; 
            for (int i = 0; i < N; i++)
            {
                string[] input = new string[6];
                input = Console.ReadLine().Split().ToArray();
                var exists4 = input.ElementAtOrDefault(4) == null;
                var exists5 = input.ElementAtOrDefault(5) == null;
                if (exists4 ) input[4] = "0";
                if (exists5) input[5] = "0";
                emp[i] = new Employee();
                emp[i].Name = input[0];
                emp[i].Salary = decimal.Parse(input[1]);
                emp[i].Position = input[2];
                emp[i].Department = input[3];
                if (input[4].Contains('@'))
                {
                    emp[i].Email = input[4];
                    if (input[5] == "0") emp[i].Age = -1;
                    else emp[i].Age = int.Parse(input[5]);
                }               
                else
                {
                    emp[i].Email = "n/a";
                    if (input[4] == "0") emp[i].Age = -1;
                    else emp[i].Age = int.Parse(input[4]);
                }
                
            }
            Console.ReadKey();
        }
    }
}
