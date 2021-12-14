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

    [Route("api/StudentReg")]
    [ApiController()]
    public class StudentRegController : ControllerBase
    {
        readonly StudentDataContext _studentDataContext;

        public StudentRegController(StudentDataContext studentDataContext)
        {
            _studentDataContext = studentDataContext;
        }

        // GET : /api/StudentReg/getAllStudents
        [Route("/getAllStudents")]
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(_studentDataContext.StudentReg.ToList());
        }

        // POST: api/StudentReg/addnewstudent
        [Route("addnewstudent")]
        [HttpPost]
        public IActionResult AddNewStudent([FromBody] StudentReg studentReg)
        {
            _studentDataContext.Add(studentReg);
            _studentDataContext.SaveChanges();
            return Ok();
        }

        // PUT: api/StudentReg/updateStudentinfo
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

        //api/StudentReg/Removestudent/id
        [Route("Removestudent/{id:int}")]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var StudenInDB = _studentDataContext.StudentReg.Find(id);
            _studentDataContext.StudentReg.Remove(StudenInDB);
            _studentDataContext.SaveChanges();
            return Ok();
        }

        // GET : /api/StudentReg/GetState/id
        [Route("GetState/{stateId}")]
        [HttpGet]
        public IActionResult GetStates(int stateId)
        {
            var StatesInDB = _studentDataContext.States.Find(stateId);
            return Ok(StatesInDB);
        }


        // GET : /api/StudentReg/Getstudent/id
        [Route("Getstudent/{id:int}")]
        [HttpGet]
        public IActionResult GetStudents(int id)
        {
            var StudentInDB = _studentDataContext.StudentReg.Find(id);
            return Ok(StudentInDB);
        }

        // GET : /api/StudentReg/getAllDepartment
        [Route("getAllDepartment")]
        [HttpGet]
        public IActionResult GetAllDepartment()
        {
            return Ok(_studentDataContext.Departments.ToList());
        }

        //GET : /api/StudentReg/getAllProgram
        [Route("getAllProgram")]
        [HttpGet]
        public IActionResult GetProgram()
        {
            return Ok(_studentDataContext.Programs.ToList());
        }

        //GET : /api/StudentReg/getAllCourse
        [Route("getAllCourse")]
        [HttpGet]
        public IActionResult GetCourses()
        {
            return Ok(_studentDataContext.Courses.ToList());
        }

        //POST : /api/StudentReg/addnewState
        [Route("addnewState")]
        [HttpPost]
        public IActionResult AddState([FromBody] States states)
        {
            States statesToCreate = new States()
            {
                Name = states.Name,
                Code = states.Code,
                geozoneid = states.geozoneid,
                CountryId = states.CountryId,
            };
            _studentDataContext.Add(statesToCreate);
            _studentDataContext.SaveChanges();
            return Ok();
        }

        //GET : /api/StudentReg/getAllState
        [Route("getAllState")]
        [HttpGet]
        public IActionResult GetStates()
        {
            return Ok(_studentDataContext.States.ToList());
        }

        // PUT: /api/StudentReg/updateStates
        [Route("updateStates")]
        [HttpPut]
        public IActionResult UpdateStates(States states)
        {
            var StatesInDB = _studentDataContext.States.Find(states.StateId);

            StatesInDB.StateId = states.StateId;
            StatesInDB.Name = states.Name;
            StatesInDB.Code = states.Code;
            StatesInDB.geozoneid = states.geozoneid;
            StatesInDB.CountryId = states.CountryId;

            _studentDataContext.States.Update(StatesInDB);
            _studentDataContext.SaveChanges();
            return Ok();
        }

        //GET : /api/StudentReg/getLGA
        [Route("getLGA")]
        [HttpGet]
        public IActionResult GetLGA()
        {
            return Ok(_studentDataContext.LocalGovt.ToList());
        }

        //GET : /api/StudentReg/eachgetLGA
        [Route("eachgetLGA/{StateId}")]
        [HttpGet]
        public IActionResult GetEachLGA(int StateId)
        {
            var LocalGovt = _studentDataContext.LocalGovt.Where(x => x.StateId == StateId).ToList();
            return Ok(LocalGovt);
        }

        //GET : /api/StudentReg/getReligion
        [Route("getReligion")]
        [HttpGet]
        public IActionResult GetReligion()
        {
            return Ok(_studentDataContext.Religions.ToList());
        }
    }
}
