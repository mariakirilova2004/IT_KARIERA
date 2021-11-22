using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merged
{
    public class MergeSort<T> where T : IComparable
    {
        private static T[] aux;
        public static void Sort(T[] arr)
        {
        
        }
        private static void Merge(T[] arr, int lo, int mid, int hi)
        {
            if(HelperMethods.Less(arr[mid], arr[mid + 1]))
            {
                return;
            }
            for (int i = lo; i < hi + 1; i++)
            {
                aux[i] = arr[i];
            }
            int i = lo;
            int j = mid + 1;
            for (int k = lo; k <= hi; k++)
            {
                if()
                {
                    arr[k] = aux[j++];
                }
            }
        }
    }
}
