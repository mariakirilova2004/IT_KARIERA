using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolNew.Models
{
    public class School
    {
        public int SchoolPK { get; set; }
        public string Name { get; set; }

        public List<Student> Students { get; set; }
    }
}
