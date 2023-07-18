using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
    public class CarsController : Controller
    {
        [Route("/cars/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpGet("/cars")]
        public ActionResult Index()
        {
            List<Car> allCars = Car.GetAll();
            return View(allCars);
        }

        [HttpPost("/cars")]

        public ActionResult Create(string year, string make, string vehicleModel)
        {
            Car myCar = new Car(year, make, vehicleModel);
            return RedirectToAction("Index");
        }

    }
}