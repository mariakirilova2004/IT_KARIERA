using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolNew.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Discipline { get; set; }
        public List<StudentTeacher> StudentTeacher { get; set; }
    }
}
