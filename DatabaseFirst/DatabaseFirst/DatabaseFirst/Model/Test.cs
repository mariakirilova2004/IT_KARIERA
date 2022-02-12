using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DatabaseFirst.Model
{
    public class Test
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; }
    }
}
