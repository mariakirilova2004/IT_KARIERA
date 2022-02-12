using System;
using System.Collections.Generic;

namespace DatabaseFirst.Model
{
    public partial class CountriesRivers
    {
        public int RiverId { get; set; }
        public string CountryCode { get; set; }

        public virtual Countries CountryCodeNavigation { get; set; }
        public virtual Rivers River { get; set; }
    }
}
