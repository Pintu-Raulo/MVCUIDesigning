using MVCUIDesigning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MVCUIDesigning.Controllers
{
    public class CustomerController : Controller
    {
        public ViewResult DisplayCustomers()
        {
            Customer c1 = new Customer
            {
                CustId = 1001,
                Name = "Peter",
                Account = "Savings",
                Balance = 50000.00,
                City = "Delhi",
                Status = true,
                Photo = "/Images/Image1.jpg"
            };
            Customer c2 = new Customer
            {
                CustId = 1002,
                Name = "Kevin",
                Account = "Current",
                Balance = 50000.00,
                City = "Kolkata",
                Status = true,
                Photo = "/Images/Image2.jpg"
            };
            Customer c3 = new Customer
            {
                CustId = 1003,
                Name = "Sandra",
                Account = "Dmart",
                Balance = 50000.00,
                City = "Mumabai",
                Status = true,
                Photo = "/Images/Image3.jpg"
            };
            Customer c4 = new Customer
            {
                CustId = 1004,
                Name = "Williams",
                Account = "Savings",
                Balance = 50000.00,
                City = "Chennai",
                Status = true,
                Photo = "/Images/Image4.jpg"
            };
            Customer c5 = new Customer
            {
                CustId = 1005,
                Name = "John",
                Account = "Demart",
                Balance = 50000.00,
                City = "Bengaluru",
                Status = true,
                Photo = "/Images/Image5.jpg"
            };
            Customer c6 = new Customer
            {
                CustId = 1006,
                Name = "Bill",
                Account = "Current",
                Balance = 50000.00,
                City = "Hyderabad",
                Status = true,
                Photo = "/Images/Image6.jpg"
            };
            List < Customer > Customer = new List<Customer> { c1, c2, c3, c4, c5, c6 };
            return View(Customer);
        }
        public ViewResult AddCustomer()
        {
            return View();
        }
    }
}