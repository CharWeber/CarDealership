using Dealer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Dealer.Controllers
{
  public class CarController : Controller
  {

    [HttpPost("/Car/Index")]
    public ActionResult Index(int maxPrice)
    {
      List<Car> totalCars = Car.GetAll();
      List<Car> CarsMatchingSearch = new List<Car>();

      foreach (Car car in totalCars)
      {
        if (car.WorthBuying(maxPrice))
        {
          CarsMatchingSearch.Add(car);
        }
      }

      return View(CarsMatchingSearch);
    }
  }
}