using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merged
{
    class HelperMethods
    {
        public static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) > 0;
        }

        public static void Swap<T>(T[] a, int first, int second)
        {
            T FirstElement = a[first];
            T SecondElement = a[second];

            a[first] = SecondElement;
            a[second] = FirstElement;
        }
    }
}
