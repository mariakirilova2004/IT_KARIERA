using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selected
{
    public class SelectionSort
    {
        public static void Sort<T>(T[] a) where T : IComparable
        {
            int currentIndex = 0;
            T currentElement = a[0];
            int minIndex = 0;
            T minElemnt = a[0];
            while(currentIndex < a.Length)
            {
                currentElement = a[currentIndex];
                minElemnt =currentElement;
                for (int i = currentIndex; i < a.Length; i++)
                {
                    if (HelperMethods.Less(a[i], a[minIndex]))
                    {
                        minIndex = i;
                        minElemnt = a[minIndex];
                    }
                }
                HelperMethods.Swap(a, minIndex, currentIndex);
                currentIndex++;
                minIndex = currentIndex;
            }
        }
    }
}
