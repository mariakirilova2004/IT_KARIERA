using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    public static class Sorter
    {
        public static ListT<T> Sort<T>(ListT<T> data) where T:IComparable
        {
            data.list.Sort();
            return data;
        }
    }
}
