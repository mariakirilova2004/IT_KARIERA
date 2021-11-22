﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class zad3_SelectionSort
    {
        public static void Sort<T>(T[] a) where T : IComparable
        {
            int currentIndex = 0;
            T currentElement = a[0];
            int maxIndex = 0;
            T maxElemnt = a[0];
            while (currentIndex < a.Length)
            {
                currentElement = a[currentIndex];
                maxElemnt = currentElement;
                for (int i = currentIndex; i < a.Length; i++)
                {
                    if (zad3_Helpers.More(a[i], a[maxIndex]))
                    {
                        maxIndex = i;
                        maxElemnt = a[maxIndex];
                    }
                }
                zad3_Helpers.Swap(a, maxIndex, currentIndex);
                currentIndex++;
                maxIndex = currentIndex;
            }
        }
    }
}
