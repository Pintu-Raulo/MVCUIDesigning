﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCUIDesigning.Models;
namespace MVCUIDesigning.Controllers
{
    public class EmpController : Controller
    {
        [HttpGet]
        public ViewResult AddEmp()
        {
            return View();
        }
        //[HttpPost]
        //public ViewResult AddEmp(int Id,string Name,string Job,double salary)
        //{
        //    ViewBag.Id = Id;
        //    ViewBag.Name = Name;
        //    ViewBag.Job = Job;
        //    ViewBag.Salary = salary;
        //    return View("DisplayEmp1");
        //}
        //[HttpPost]
        //public ViewResult AddEmp(FormCollection fc)
        //{
        //    ViewBag.Id=fc["Id"];
        //    ViewBag.Name = fc["Name"];
        //    ViewBag.Job = fc["Job"];
        //    ViewBag.Salary = fc["Salary"];
        //    return View("DisplayEmp1");
        //}
        [HttpPost]
        public ViewResult AddEmp(Employee Emp)
        {
            return View("DisplayEmp2",Emp);
        }
    }
}