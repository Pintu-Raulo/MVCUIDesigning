using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCUIDesigning.Models;

namespace MVCUIDesigning.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public ViewResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddStudent(Student student)
        {
            return View("DisplayStudent",student);
        }
        [HttpGet]
        public ViewResult AddStudentSt()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddStudentSt(Student student)
        {
            return View("DisplayStudentSt", student);
        }
        public PartialViewResult Header()
        {
            return PartialView("_Header");
        }
    }
}