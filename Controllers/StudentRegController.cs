using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData.Controllers
{
    public class StudentRegController : Controller
    {
        public IActionResult StudentRegistration()
        {
            return View();
        }
    }
}
