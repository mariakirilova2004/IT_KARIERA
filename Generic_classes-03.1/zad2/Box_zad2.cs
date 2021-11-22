using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    public class Box_zad2<T>
    {
        public T data { get; set; }
        public Box_zad2(T data)
        {
            this.data = data;
        }
        public override string ToString()
        {
            return $"{data.GetType().FullName}: {data}";
        }
    }
}
