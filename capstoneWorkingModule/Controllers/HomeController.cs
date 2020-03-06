using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using capstoneWorkingModule.Models;
using CapstoneProj.Models;

namespace capstoneWorkingModule.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }


        [HttpGet]
        public ViewResult signUp()
        {

            return View();

        }
        [HttpGet]
        public ViewResult SolarSheet()
        {

            return View();

        }
        [HttpGet]
        public ViewResult Login()
        {

            return View();

        }

        public ViewResult thanks()
        {
           return View();
        }
       
        public ViewResult Login(Login logresponse)
        {
            if (ModelState.IsValid)
            {
         
                return View("SolarSheet", logresponse);
            }
            else
            {
                // The validation error
                return View();
            }
        }

        //public ViewResult ListCourses()
        //{

        //    return View(CourseRepository.Responses);
        //}

        //public ViewResult ListStudents()
        //{
        //    return View(StudentRepository.Responses);
        //}

    }
}
