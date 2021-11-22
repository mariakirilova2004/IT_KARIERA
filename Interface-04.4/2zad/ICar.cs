using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2zad
{
    interface ICar
    {
        string Model { get; set; }
        string Color { get; set; }

        string Start();
        string Stop();
    }
}
