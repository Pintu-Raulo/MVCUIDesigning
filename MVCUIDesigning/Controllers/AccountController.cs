using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUIDesigning.Controllers
{
    public class AccountController : Controller
    {
        public ViewResult Login()
        {
            return View();
        }
        public ViewResult Validate()
        {
            string Name = Request["txtName"];
            string Pwd = Request["txtPwd"];
            if (Name == "Pintu" && Pwd == "12345")
            {
                Session["User"] = Name;
               return View("Success");
            }
            else
            {
                ViewData["User"] = Name;
                return View("Failure");
            }
        }
    }
}