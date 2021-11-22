﻿using System;
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
            List<string> list = Console.ReadLine().Split().ToList();
            Action<string> act = element => Console.WriteLine(element);
            foreach (var item in list)
            {
                act(item);
            }
            Console.ReadKey();
        }
    }
}
