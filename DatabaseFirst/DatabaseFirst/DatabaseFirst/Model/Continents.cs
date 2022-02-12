using System;
using System.Collections.Generic;

namespace DatabaseFirst.Model
{
    public partial class Continents
    {
        public Continents()
        {
            Countries = new HashSet<Countries>();
        }

        public string ContinentCode { get; set; }
        public string ContinentName { get; set; }

        public virtual ICollection<Countries> Countries { get; set; }
    }
}
