using System;
using System.Collections.Generic;

namespace DatabaseFirst.Model
{
    public partial class Currencies
    {
        public Currencies()
        {
            Countries = new HashSet<Countries>();
        }

        public string CurrencyCode { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Countries> Countries { get; set; }
    }
}
