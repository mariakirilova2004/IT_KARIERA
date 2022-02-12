using System;
using System.Collections.Generic;

namespace DatabaseFirst.Model
{
    public partial class Mountains
    {
        public Mountains()
        {
            MountainsCountries = new HashSet<MountainsCountries>();
            Peaks = new HashSet<Peaks>();
        }

        public int Id { get; set; }
        public string MountainRange { get; set; }

        public virtual ICollection<MountainsCountries> MountainsCountries { get; set; }
        public virtual ICollection<Peaks> Peaks { get; set; }
    }
}
