using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOfStrings st = new StackOfStrings();
            Console.WriteLine(st.IsEmpty());
            st.Push("le");
            st.Push("le2");
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Peek());
            st.Push("hi");
            Console.WriteLine(st.IsEmpty());
            Console.ReadKey();
        }
    }
}
