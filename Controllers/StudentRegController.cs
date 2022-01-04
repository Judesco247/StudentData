using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using StudentData.Data;
using StudentData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData.Controllers
{
    public class StudentRegController : Controller
    {
        private readonly string connectionString;

        public StudentRegController(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public IActionResult StudentRegistration()
        {
            //var sr = new StudentReg();
            ////var constr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            //using (SqlConnection sqlcon = new SqlConnection(connectionString))
            //{
            //    using (SqlCommand cmd = new SqlCommand("", sqlcon))
            //    {
            //        cmd.CommandTimeout = 1200;
            //        cmd.CommandType = System.Data.CommandType.Text;
            //        sqlcon.Open();

            //        using (SqlDataReader sdr = cmd.ExecuteReader())
            //        {
            //            sr.States = sdr["Name"].ToString();
            //            sr.LocalGovt = sdr["lgaName"].ToString();
            //        }
            //    }
            //}

            return View();
        }

        public IActionResult StudentInfo()
        {
            return View();
        }

    }
}
