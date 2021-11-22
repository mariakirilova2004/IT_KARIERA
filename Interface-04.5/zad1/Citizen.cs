using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    public class Citizen:IPerson,IBirthable,IIdentifiable
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string birthdate;

        public string Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }
    }
}
