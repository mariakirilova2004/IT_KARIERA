using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class StackOfStrings
    {
        private List<string> data = new List<string>();
        public void Push(string element)
        { this.data.Add(element); }
        public string Pop()
        {
            var element = this.data.Last();
            this.data.Remove(element);
            return element;
        }
        public string Peek()
        {
            var element = this.data.First();
            return element;
        }
        public string IsEmpty()
        {
            if (this.data.Count == null || this.data.Count == 0) return "Yes";
            else return "No";
        }
    }
}
