using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2._2
{
    class Smartphone : Call, Browse
    {
        private string calls;

        public string Calls
        {
            get { return calls; }
            set 
            {
                if (!IsDigitsOnly(value))
                    Console.WriteLine("Invalid number!");
                else
                    calls = value; 
            }
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private string browses;

        public string Browses
        {
            get { return browses; }
            set 
            {
                if (!(value.Contains("1") || value.Contains("2") || value.Contains("3") || value.Contains("4") || value.Contains("5") || value.Contains("6") || value.Contains("7") || value.Contains("8") || value.Contains("9") || value.Contains("0")))
                    browses = value;
                else
                    Console.WriteLine("Invalid URL!");
            }
        }

        public void Calling()
        {
            if (Calls != null)
                Console.WriteLine($"Calling... {Calls}");
        }
        public void Browsing()
        {
            if (Browses != null)
                Console.WriteLine($"Browsing: {Browses}!");
        }
    }
}
