using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentData.Core.IServices;
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
        private readonly IStudentService _studentService;

        public StudentRegController(StudentDataContext studentDataContext, IStudentService studentService)
        {
            _studentDataContext = studentDataContext;
            _studentService = studentService;
        }

        // GET : /api/StudentReg/getAllStudents
        [Route("getAllStudents")]
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
            _studentService.AddStudent(studentReg);
            return Ok();
        }

        // PUT: api/StudentReg/updateStudentinfo
        [Route("updateStudentinfo")]
        [HttpPut]
        public IActionResult UpdateStudentInfo(StudentReg studentReg)
        {
            
            _studentService.StudentUpdate(studentReg);
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

        //GET : /api/StudentReg/geteachLGA
        //[Route("geteachLGA/{stateId}")]
        [HttpGet]
        public IActionResult GetEachLGA(int StateId)
        {
            var LocalGovt = _studentDataContext.LocalGovt
                .Where(x => x.StateId == StateId).ToList();
            return Ok(LocalGovt);
        }
    }
}
