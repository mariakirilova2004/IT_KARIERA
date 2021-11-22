using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class BinarySearch
    {
        public static int IndexOf(int[] arr, int key)
        {
            int start = 0;
            int end = arr.Length - 1;
            int length = arr.Length;
            int mid = length / 2 - 1;
            while(length > 0)
            {
                if(arr[mid] == key)
                {
                    return mid;
                }
                else if(arr[mid] > key)
                {
                    end = mid;
                }
                else if (arr[mid] < key)
                {
                    start = mid;
                }
                length = end - start;
                mid = start + length / 2;
            }
            return -1;
        }
    }
}
