using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    public class ListT<T>
    {
        public List<T> list;
        public ListT(List<T> list)
        {
            this.list = list;
        }
        public List<T> Swap(int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
            return list;
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach (var item in list)
            {
                str.Append($"{item.GetType().FullName}: {item}");
                str.Append(Environment.NewLine);
            }
            return str.ToString();
        }
    }
}
