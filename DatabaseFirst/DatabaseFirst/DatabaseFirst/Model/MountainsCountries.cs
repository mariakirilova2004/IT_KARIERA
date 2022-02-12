using System;
using System.Collections.Generic;

namespace DatabaseFirst.Model
{
    public partial class MountainsCountries
    {
        public int MountainId { get; set; }
        public string CountryCode { get; set; }

        public virtual Countries CountryCodeNavigation { get; set; }
        public virtual Mountains Mountain { get; set; }
    }
}
