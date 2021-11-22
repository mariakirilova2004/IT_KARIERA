using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    public class ListT<T> where T:IComparable
    {
        public List<T> list;
        public ListT()
        {
            list = new List<T>();
        }
        public void Add(T element)
        {
            list.Add(element);
        }

        public T Remove(int index)
        {
            T rt = list[index];
            list.RemoveAt(index);
            return rt;
        }

        public bool Contains(T element)
        {
            if (list.Contains(element)) return true;
            else return false;
        }

        public void Swap(int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }

        public int CountGreaterThan(T element)
        {
                int br = 0;
                foreach (var item in list)
                {
                    if (item.CompareTo(element) > 0) br++;
                }
                return br;
        }

        public T Max()
        {
            return list.Max();
        }

        public T Min()
        {
            return list.Min();
        }


        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach (var item in list)
            {
                if(item.CompareTo(list.Last()) != 0)
                {
                    str.Append($"{item}");
                    str.Append(Environment.NewLine);
                }
                else str.Append($"{item}");
            }
            return str.ToString();
        }
    }
}
