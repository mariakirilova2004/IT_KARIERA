using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    class zad4_Helpers
    {
        public static bool More(IComparable first, IComparable second)
        {
            return first.CompareTo(second) > 0;
        }

        public static void Swap<T>(T[] collection, int from, int to)
        {
            T FirstElement = collection[from];
            T SecondElement = collection[to];

            collection[from] = SecondElement;
            collection[to] = FirstElement;
        }
    }
}
