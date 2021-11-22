using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    public class Handler
    {
        public void OnDispatcherNameChange(object sender, NameChangeEventArgs args)
        {
            Dispatcher dis = new Dispatcher();
            dis.NameChange += OnDispatcherNameChange;
            Console.WriteLine($"Dispatcher’s name changed to {args.Name}");
        }
    }
}
