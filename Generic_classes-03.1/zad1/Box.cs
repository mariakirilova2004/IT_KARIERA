using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Box<T>
    {
        List<T> data;
        private int count;

        public int Count
        {
            get { return count; }
            private set { count = value; }
        }

        public Box()
        {
            data = new List<T>();
        }
        public void Add(T element)
        {
            data.Add(element);
            Count++;
        }
        public string Remove()
        {
            string last = data.Last().ToString();
            data.RemoveAt(Count - 1);
            Count--;
            return last;
        }

    }
}
