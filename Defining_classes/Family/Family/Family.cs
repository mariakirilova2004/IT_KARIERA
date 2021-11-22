using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    public class Family
    {
        public List<Person> family;
        public Family()
        {
            family = new List<Person>();
        }

        public List<Person> SortFam(List<Person> FAM)
        {
            FAM.OrderBy(o => o.name).Reverse();
            return FAM;
        }
    }
}
