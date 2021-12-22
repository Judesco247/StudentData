using Microsoft.EntityFrameworkCore;
using StudentData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData.Data
{
    public class DBContext_Class
    {
        public class StudentDataContext : DbContext
        {

            public StudentDataContext(DbContextOptions<StudentDataContext> options) : base(options)
            {
            }

            public DbSet<StudentReg> StudentReg { get; set; }
            public DbSet<States> States { get; set; }
            public DbSet<LocalGovt> LocalGovt { get; set; }
        }
    }
}
