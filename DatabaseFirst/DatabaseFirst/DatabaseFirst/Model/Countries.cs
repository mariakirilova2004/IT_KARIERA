using System;
using System.Collections.Generic;

namespace DatabaseFirst.Model
{
    public partial class Countries
    {
        public Countries()
        {
            CountriesRivers = new HashSet<CountriesRivers>();
            MountainsCountries = new HashSet<MountainsCountries>();
        }

        public string CountryCode { get; set; }
        public string IsoCode { get; set; }
        public string CountryName { get; set; }
        public string CurrencyCode { get; set; }
        public string ContinentCode { get; set; }
        public int Population { get; set; }
        public int AreInSqKm { get; set; }
        public string Capital { get; set; }

        public virtual Continents ContinentCodeNavigation { get; set; }
        public virtual Currencies CurrencyCodeNavigation { get; set; }
        public virtual ICollection<CountriesRivers> CountriesRivers { get; set; }
        public virtual ICollection<MountainsCountries> MountainsCountries { get; set; }
    }
}
