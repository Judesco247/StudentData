using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StudentData.Data;
using StudentData.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static StudentData.Data.DBContext_Class;

namespace StudentData.Controllers
{
    public class StudentRegController : Controller
    {
        readonly StudentDataContext _studentDataContext;
        private readonly IHostingEnvironment _hostingEnvironment1;

        public StudentRegController(StudentDataContext studentDataContext, IHostingEnvironment hostingEnvironment)
        {
            _studentDataContext = studentDataContext;
            _hostingEnvironment1 = hostingEnvironment;
        }

        public IActionResult StudentRegistration()
        {
            return View();
        }

        public IActionResult EditStudents(int id)
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

            return View(sr);
        }

        //[HttpGet]
        //public IActionResult EditStudents2(int id)
        //{
        //    var per = _studentDataContext.StudentReg.Where(x => x.Id == id);
        //    return View(per);


        //}
        public IActionResult StudentInfo()
        {
            IEnumerable<StudentReg> studentRegs = _studentDataContext.StudentReg.ToList();

            return View(studentRegs);
        }


        public IActionResult PassportImage()
        {
            return View();
        }


        [HttpPost]
        public IActionResult PassportImage(IFormFile file)
        {
            string path = Path.Combine(_hostingEnvironment1.WebRootPath, "Passport", file.FileName);
            Image image = Image.FromStream(file.OpenReadStream(), true, true);
            int width = image.Width;
            int height = image.Height;
            if (width == 400 && height == 400)
            {
                var newImage = new Bitmap(image.Width, image.Height);

                using (var a = Graphics.FromImage(newImage))
                {
                    a.DrawImage(image, 0, 0, width, height);
                    newImage.Save(path);
                }

                ViewBag.Message = "The selected image file has been saved successfully";
            }
            else
            {
                ViewBag.Message = "Please upload image with size 400x400 only";
            }
            return View();
        }

    }
}
