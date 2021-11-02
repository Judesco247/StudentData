using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static StudentData.Data.DBContext_Class;

namespace StudentData.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentRegController : ControllerBase
    {
        readonly StudentDataContext _studentDataContext;

        public StudentRegController(StudentDataContext studentDataContext)
        {
            _studentDataContext = studentDataContext;
        }

        public IActionResult Get()
        {
            return Ok(_studentDataContext.StudentReg.ToList());
        }

        public IActionResult Post(StudentReg studentReg)
        {
            _studentDataContext.Add(studentReg);
            _studentDataContext.SaveChanges();
            return Ok();
        }

        public IActionResult Put(StudentReg studentReg)
        {
            var StudentInDB = _studentDataContext.StudentReg.Find(studentReg.Id);
            StudentInDB.FirstName = studentReg.FirstName;
            StudentInDB.Surname = studentReg.Surname;
            StudentInDB.LastName = studentReg.LastName;
            StudentInDB.Address = studentReg.Address;
            StudentInDB.StateOfOrigin = studentReg.StateOfOrigin;
            StudentInDB.LGA = studentReg.LGA;
            StudentInDB.Religion = studentReg.Religion;
            StudentInDB.DateOfAdmission = studentReg.DateOfAdmission;
            StudentInDB.PhoneNumber = studentReg.PhoneNumber;
            StudentInDB.Alt_PhoneNumber = studentReg.Alt_PhoneNumber;
            StudentInDB.Program = studentReg.Program;
            StudentInDB.Department = studentReg.Department;
            StudentInDB.Course = studentReg.Course;
            StudentInDB.DateOfAdmission = studentReg.DateOfAdmission;

            _studentDataContext.StudentReg.Update(StudentInDB);
            _studentDataContext.SaveChanges();
            return Ok();
        }

        public IActionResult Delete(int id)
        {
            var StudenInDB = _studentDataContext.StudentReg.Find(id);
            _studentDataContext.StudentReg.Remove(StudenInDB);
            _studentDataContext.SaveChanges();
            return Ok();
        }

        public IActionResult Get(int id)
        {
            var StudentInDB = _studentDataContext.StudentReg.Find(id);
            return Ok(StudentInDB);
        }
    }
}
