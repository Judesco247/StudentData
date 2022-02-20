using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using StudentData.Core.IRepository;
using StudentData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static StudentData.Data.DBContext_Class;

namespace StudentData.Core.Repository
{
    public class StudentRepository : IStudentRepository
    {
        readonly StudentDataContext _studentDataContext;

        public StudentRepository(StudentDataContext studentDataContext)
        {
            _studentDataContext = studentDataContext;
        }

        public void AddNewStudent(StudentReg studentReg)
        {
            var stateid = int.Parse(studentReg.State);
            var state = _studentDataContext.States.Where(x => x.StateId == stateid).FirstOrDefault();
            studentReg.State = state.Name;
            _studentDataContext.Add(studentReg);
            _studentDataContext.SaveChanges();
        }

        public void UpdateStudentInfo(StudentReg studentReg)
        {
            var stateid = int.Parse(studentReg.State);
            var state = _studentDataContext.States.Where(x => x.StateId == stateid).FirstOrDefault();
            studentReg.State = state.Name;
            var StudentInDB = _studentDataContext.StudentReg.Find(studentReg.Id);

            StudentInDB.RegNumber = studentReg.RegNumber;
            StudentInDB.Surname = studentReg.Surname;
            StudentInDB.OtherNames = studentReg.OtherNames;
            StudentInDB.Address = studentReg.Address;
            StudentInDB.State = studentReg.State;
            StudentInDB.LocalGovtArea = studentReg.LocalGovtArea;
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
        }

        public void EditStudents(int id)
        {
            var stu = _studentDataContext.StudentReg.FirstOrDefault(x => x.Id == id);
            StudentReg sr = new StudentReg();
            sr.RegNumber = stu.RegNumber;
            sr.Surname = stu.Surname;
            sr.OtherNames = stu.OtherNames;
            sr.Address = stu.Address;
            sr.State = stu.State;
            sr.LocalGovtArea = stu.LocalGovtArea;
            sr.DateOfBirth = (DateTime)stu.DateOfBirth;
            sr.PhoneNumber = stu.PhoneNumber;
            sr.Alt_PhoneNumber = stu.Alt_PhoneNumber;
            sr.DateOfAdmission = (DateTime)stu.DateOfAdmission;
            sr.Course = stu.Course;
            sr.Department = stu.Department;
            sr.Program = stu.Program;
            sr.Religion = stu.Religion;
        }
    }
}
