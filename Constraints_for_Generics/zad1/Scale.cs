using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Scale<T> where T:IComparable
    {
        public T left { get; set; }
        public T right { get; set; }
        public Scale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }
        public T getHeavier()
        {
            if (left.CompareTo(right) > 0) return left;
            else if (right.CompareTo(left) > 0) return right;
            else return default(T);
        }
    }
}
