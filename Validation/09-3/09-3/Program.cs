using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            //PEOPLE INPUT

            List<Person> people = new List<Person>();

            string[] input = Console.ReadLine().Split(';').ToArray();
            string[] names = new string[input.Length];
            decimal[] money = new decimal[input.Length];
            int i = 0;
            int j = 0;
            foreach (var item in input)
            { 
                string[] item2 = item.Split('=').ToArray();
                names[i] = item2[0];
                money[i] = decimal.Parse(item2[1]);
                i++;
            }

            for (j = 0; j < i; j++)
            {
                people.Add(new Person(names[j], money[j]));
            }

            //PRODUCTS INPUT


            List<Product> products = new List<Product>();

            string[] input1 = Console.ReadLine().Split(';').ToArray();
            if(input1.Length != 1)input1 = input1.Take(input1.Length - 1).ToArray();
            string[] namespr = new string[input.Length];
            decimal[] prices = new decimal[input.Length];
            i = 0;
            j = 0;

            foreach (var item in input1)
            {
                string[] item2 = item.Split('=').ToArray();
                namespr[j] = item2[0];
                prices[j] = decimal.Parse(item2[1]);
                j++;
            }

            for (i = 0; i < j; i++)
            {
                products.Add(new Product(namespr[i], prices[i]));
            }

            //BUYING

            while(true)
            {
                input = Console.ReadLine().Split().ToArray();
                if (input[0] == "END") break;
                foreach (var item in people)
                {
                    if(item.Name == input[0])
                    {
                        foreach (var itempr in products)
                        {
                            if(itempr.Namepr == input[1])
                            {
                                item.Buy(itempr);
                            }
                        }
                    }

                }
            }

            // OUTPUT

            foreach (var item in people)
            {
                if(item.products.Count == 0)
                {
                    Console.WriteLine($"{item.Name} - Nothing bought");
                }
                else
                {
                    List<string> prnm = new List<string>();
                    foreach (var item1 in item.products)
                    {
                        prnm.Add(item1.Namepr);
                    }
                    Console.WriteLine($"{item.Name} - {String.Join(", ", prnm)}");
                }
            }
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
