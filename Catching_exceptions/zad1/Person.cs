using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Person
    {
        private int age;

        public int Age
        {
            get { return age; }
            set 
            {
                if (value < 0 || value > 120) throw new ArgumentNullException("The Age must be between 0-120!");
                else age = value; 
            }
        }

        private string firstname ;

        public string Firstname 
        {
            get { return firstname ; }
            set
            {
                if (value == "" || value == null) throw new ArgumentNullException("The First name can not be null or empty!");
                else lastname = value;
            }
        }

        private string lastname;

        public string Lastname
        {
            get { return lastname; }
            set 
            {
                if (value == "" || value == null) throw new ArgumentNullException("The Last name can not be null or empty!");
                else lastname = value; 
            }
        }

        public Person(int age, string fname, string lname)
        {
            Age = age;
            Firstname = fname;
            Lastname = lname;
        }

    }
}
