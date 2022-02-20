using Microsoft.AspNetCore.Mvc;
using StudentData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData.Core.IRepository
{
    public interface IStudentRepository
    {
        public void AddNewStudent(StudentReg studentReg);
        public void UpdateStudentInfo(StudentReg studentReg);
        public void EditStudents(int id);
    }
}
