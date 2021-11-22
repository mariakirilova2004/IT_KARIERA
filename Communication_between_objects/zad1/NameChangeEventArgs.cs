using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    public class NameChangeEventArgs:EventArgs
    {
        public string Name { get; private set; }

        public NameChangeEventArgs(string name)
        {
            Name = name;
        }
    }
}
