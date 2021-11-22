using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    class BubbleSort
    {
        public static void Sort<T>(T[] a) where T: IComparable
        {
            T Current;
            T Next;
            for (int j = 0; j < a.Length; j++)
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    Current = a[i];
                    Next = a[i + 1];
                    if (HelperMethods.Less(Current, Next))
                    {
                        HelperMethods.Swap(a, i, i + 1);
                    }
                }
            }
        }
    }
}
