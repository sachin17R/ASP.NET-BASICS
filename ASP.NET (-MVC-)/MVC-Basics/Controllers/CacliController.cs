using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCframework.Controllers
{
    public class CacliController : Controller
    {
        // GET: Cacli
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Index(string first,string second,string operand)
        //{
        //     string Message = string.Empty;
        //    if(string.IsNullOrEmpty(first) && string.IsNullOrEmpty(second))
        //    {
        //       return ViewBag.Message = "Please enter the Values";
        //    }
        //    else
        //    {
        //        double v1 = double.Parse(first);
        //        double v2 = double.Parse(second);
        //        switch (operand)
        //        {
        //            case "+":Message = (v1 + v2).ToString();break;
        //            case "-":Message = (v1 - v2).ToString();break;
        //            case "x":Message = (v1 * v2).ToString();break;
        //            case "/":Message = (v1 / v2).ToString();break;
        //            default:
        //                break;
        //        }
        //    }
        //    ViewBag.Message = $"The Result Is: {Message}";
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Index(FormCollection data)
        //{
        //    string Message = string.Empty;
        //    if (string.IsNullOrEmpty(data["first"]) && string.IsNullOrEmpty(data["second"]))
        //    {
        //        Message = "Please enter the Values";
        //    }
        //    else
        //    {
        //        double v1 = double.Parse(data["first"]);
        //        double v2 = double.Parse(data["second"]);
        //        switch (data["operand"])
        //        {
        //            case "+": Message = (v1 + v2).ToString(); break;
        //            case "-": Message = (v1 - v2).ToString(); break;
        //            case "x": Message = (v1 * v2).ToString(); break;
        //            case "/": Message = (v1 / v2).ToString(); break;
        //            default:
        //                break;
        //        }
        //    }
        //    ViewData["Message"] = $"The Result Is: {Message}";
        //    return View();
        //}

        [HttpPost]
        public ActionResult Index(FormCollection sachin)
        {
            string Message = string.Empty;
            if (string.IsNullOrEmpty(sachin["first"]) && string.IsNullOrEmpty(sachin["second"]))
            {
                Message = "Please enter the Values";
            }
            else
            {
                double v1 = double.Parse(sachin["first"]);
                double v2 = double.Parse(sachin["second"]);
                switch (sachin["operand"])
                {
                    case "+": Message = (v1 + v2).ToString(); break;
                    case "-": Message = (v1 - v2).ToString(); break;
                    case "x": Message = (v1 * v2).ToString(); break;
                    case "/": Message = (v1 / v2).ToString(); break;
                    default:
                        break;
                }
            }
            TempData["Message"] = $"The result is: {Message}";
            return RedirectToAction("Index");
        }
    }
}