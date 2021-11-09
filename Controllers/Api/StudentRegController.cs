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
    [ApiController()]
    public class StudentRegController : ControllerBase
    {
        readonly StudentDataContext _studentDataContext;

        public StudentRegController(StudentDataContext studentDataContext)
        {
            _studentDataContext = studentDataContext;
        }

        // GET : /api/controller/getAllStudents
        [Route("getAllStudents")]
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(_studentDataContext.StudentReg.ToList());
        }

        // POST: api/controller/addnewstudent
        [Route("addnewstudent")]
        [HttpPost]
        public IActionResult AddNewStudent([FromBody] StudentReg studentReg)
        {
            _studentDataContext.Add(studentReg);
            _studentDataContext.SaveChanges();
            return Ok();
        }

        // PUT: api/controller/updateStudentinfo
        [Route("updateStudentinfo")]
        [HttpPut]
        public IActionResult UpdateStudentInfo(StudentReg studentReg)
        {
            var StudentInDB = _studentDataContext.StudentReg.Find(studentReg.Id);

            StudentInDB.RegNumber = studentReg.RegNumber;
            StudentInDB.FirstName = studentReg.FirstName;
            StudentInDB.Surname = studentReg.Surname;
            StudentInDB.LastName = studentReg.LastName;
            StudentInDB.Address = studentReg.Address;
            StudentInDB.StateOfOrigin = studentReg.StateOfOrigin;
            StudentInDB.LGA = studentReg.LGA;
            StudentInDB.Religion = studentReg.Religion;
            StudentInDB.DateOfBirth = studentReg.DateOfBirth;
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

        //api/controller/Removestudent/id
        [Route("Removestudent/{id:int}")]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var StudenInDB = _studentDataContext.StudentReg.Find(id);
            _studentDataContext.StudentReg.Remove(StudenInDB);
            _studentDataContext.SaveChanges();
            return Ok();
        }
        //api/controller/Getstudent/id
        [Route("Getstudent/{id:int}")]
        public IActionResult GetStudents(int id)
        {
            var StudentInDB = _studentDataContext.StudentReg.Find(id);
            return Ok(StudentInDB);
        }
    }
}
