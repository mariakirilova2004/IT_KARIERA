using System;
using System.Collections.Generic;

namespace DatabaseFirst.Model
{
    public partial class Peaks
    {
        public int Id { get; set; }
        public string PeakName { get; set; }
        public int Elevation { get; set; }
        public int MountainId { get; set; }

        public virtual Mountains Mountain { get; set; }
    }
}
