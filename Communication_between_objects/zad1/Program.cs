using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispatcher dis = new Dispatcher();
            Handler hand = new Handler();
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "End") break;
                dis.Name = name;
                hand.OnDispatcherNameChange(dis,new NameChangeEventArgs(dis.Name));
            }
            Console.ReadKey(); 
        }
    }
}
