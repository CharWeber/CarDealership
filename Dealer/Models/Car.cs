using System;
using System.Collections.Generic;

namespace Dealer.Models
{
  public class Car
  {
    public string MakeModel {get; set;}
    public int Price {get; set;}
    public int Miles {get; set;}
    private static List <Car> _inventory = new List<Car> {};

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _inventory.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _inventory;
    }
    public static void ClearAll()
    {
      _inventory.Clear();
    }
    public bool WorthBuying (int maxPrice)
    {
      return (Price <= maxPrice);
    }
  }
}
