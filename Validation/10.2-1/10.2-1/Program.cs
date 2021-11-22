using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza p1 = new Pizza();
            Dough d1 = new Dough();
            List<Topping> t1 = new List<Topping>();
            int control = 0;
            while(true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0] == "Pizza")
                {
                    try
                    {
                        p1 = new Pizza(input[1], int.Parse(input[2]));
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                        control++;
                        break;
                    }
                }
                if (input[0] == "END") break;
                else
                {
                    if (input[0] == "Dough")
                    {
                        try
                        {
                            d1 = new Dough(input[1].ToLower(), input[2].ToLower(), double.Parse(input[3]));
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                            control++;
                            break;
                        }
                    }

                    if (input[0] == "Topping")
                    {
                        try
                        {
                            Topping t = new Topping(input[1].ToLower(), double.Parse(input[2]));
                            t1.Add(t);
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                            control++;
                            break;
                        }                       
                    }

                }
            }

            p1.dough = d1;
            p1.toppings = t1;

            if(control == 0) Console.WriteLine($"{p1.Name} - {p1.Calories:0.00} Calories.");

            //if (doughs.Count != 0)
            //{
            //    foreach (var dough in doughs)
            //    {
            //        Console.WriteLine($"{dough.Caloriesd:0.00}");
            //    }
            //}
            //if (toppings.Count != 0)
            //{
            //    foreach (var topping in toppings)
            //    {
            //        Console.WriteLine($"{topping.Caloriest:0.00}");
            //    }
            //}
            Console.ReadKey();
        }
    }
}
