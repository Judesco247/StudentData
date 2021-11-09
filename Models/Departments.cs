using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData.Models
{
    public class Departments
    {
        [Key]
        public int Id { get; set; }
        public string dept_code { get; set; }
        public string dept_name { get; set; }
    }
}
