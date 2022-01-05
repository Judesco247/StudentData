using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using StudentData.Data;
using StudentData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static StudentData.Data.DBContext_Class;

namespace StudentData.Controllers
{
    public class StudentRegController : Controller
    {
        readonly StudentDataContext _studentDataContext;

        public StudentRegController(StudentDataContext studentDataContext)
        {
            _studentDataContext = studentDataContext;
        }

        public IActionResult StudentRegistration()
        {
            return View();
        }

        public IActionResult StudentInfo()
        {
            IEnumerable<StudentReg> studentRegs = _studentDataContext.StudentReg.ToList();

            return View(studentRegs);
        }

    }
}
