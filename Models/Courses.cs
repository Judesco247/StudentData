using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData.Models
{
    public class Courses
    {
        [Key]
        public int Id { get; set; }
        public string course_code { get; set; }
        public string course_name { get; set; }
    }
}
