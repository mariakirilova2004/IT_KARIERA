using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistic
{
    public class Person
    {
        private string myVar1;

        public string name
        {
            get { return myVar1; }
            set 
            { 
                if(age != 0) myVar1 = value; 
            }
        }


        private int myVar;

        public int age
        {
            get { return myVar; }
            set 
            { 
                if(value > 30) myVar = value;
            }
        }

        public Person(int Age, string Name)
        {
            age = Age;
            name = Name;
        }
    }
}
