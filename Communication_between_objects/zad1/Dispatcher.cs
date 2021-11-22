using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);
    public class Dispatcher
    {
        public event NameChangeEventHandler NameChange;
        private string name;

        public string Name
        {
            get { return name; }
            set 
            {
                name = value;
                NameChangeEventArgs arg = new NameChangeEventArgs(value);
                OnNameChange(arg);
            }
        }

        public void OnNameChange(NameChangeEventArgs args)
        {
                if (this.NameChange != null)
                {
                    this.NameChange(this, args);
                }
        }
    }
}
