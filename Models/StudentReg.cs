using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData.Models
{
    public class StudentReg
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(20)]
        public string Surname { get; set; }
        [StringLength(20)]
        public string LastName { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(20)]
        public string StateOfOrigin { get; set; }
        [StringLength(20)]
        public string LGA { get; set;  }
        [StringLength(15)]
        public string Religion { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public int PhoneNumber { get; set; }

        public int Alt_PhoneNumber { get; set; }
        public string Program { get; set; }

        public string Department { get; set; }

        public string Course { get; set; }
        public DateTime? DateOfAdmission { get; set; }
    }
}
