using StudentData.Core.IRepository;
using StudentData.Core.IServices;
using StudentData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData.Core.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void AddStudent(StudentReg studentReg)
        {
           _studentRepository.AddNewStudent (studentReg);
        }
        public void StudentUpdate(StudentReg studentReg)
        {
            _studentRepository.UpdateStudentInfo(studentReg);
        }
        public void StudentEdit(int id)
        {
            _studentRepository.EditStudents(id);
        }
    }
}
