using MVCframework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCframework.Controllers
{
    public class HomeController : Controller
    {
       public string GetString()
        {
            return "This is Sachin R";
        }
        public double GetNumber(string v1,string v2)
        {
            var f1 = double.Parse(v1);
            var f2 = double.Parse(v2);
            return f1 + f2;
        }

        public ViewResult DisplayEmp()
        {
            var employee = new Employee { EmpId = 111, EmpName = "Sachin", EmpEmail = "Sachinr1751999@gmail.com", EmpSalary = 28200 };
            return View(employee);
        }
    }
}