using MVCframework.DataComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCframework.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult Index()
        {
            var repo = new CarInfoRepo();

            var model = repo.GetAllCars();
            return View(model);
        }

        public ActionResult Edit(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                ViewBag.Message = "Car Id Is not Found Please visit Index Page";
                return View();
            }
            var selected = int.Parse(id);
            var repo = new CarInfoRepo();
            var model = repo.FindCar(selected);
            if(model == null)
            {
                ViewBag.Message = "Car Id Is not Found Please visit Index Page";
                return View();
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(CarInfo data)
        {
            var repo = new CarInfoRepo();
            repo.UpdateCar(data);
            return RedirectToAction("Index");
        }

        public ActionResult AddCar() => View(new CarInfo());

        [HttpPost]
        public ActionResult AddCar(CarInfo data)
        {
            var repo = new CarInfoRepo();
            repo.AddNewCar(data);
            return RedirectToAction("Index");
        }


        public ActionResult Delete(string id)
        { 
            int id1 = int.Parse(id);
            var repo = new CarInfoRepo();
            repo.DeleteCar(id1);
            return RedirectToAction("Index");
        }
    }
}