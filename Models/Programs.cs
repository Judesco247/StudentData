using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData.Models
{
    public class Programs
    {
        [Key]
        public int Id { get; set; }
        public string prog_code { get; set; }
        public string prog_name { get; set; }
    }
}
