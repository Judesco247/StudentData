using StudentData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData.Core.IServices
{
    public interface IStudentService
    {
        public void AddStudent(StudentReg studentReg);
        public void StudentUpdate(StudentReg studentReg);
        public void StudentEdit(int id);
    }
}
