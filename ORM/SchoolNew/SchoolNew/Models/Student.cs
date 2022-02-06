using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolNew.Models
{
    public class Student
    {
        [Key]
        public int TestPK { get; set; }
        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public School School { get; set; }
        [ForeignKey("city_id")]
        public City City { get; set; }

        public List<StudentTeacher> StudentTeacher { get; set; }
    }
}
