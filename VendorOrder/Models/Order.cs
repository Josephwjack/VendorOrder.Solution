using System.Collections.Generic;

namespace VendorOrder.Models
{
  
  public class Order
  {
    public string Description { get; set; }
    // id
    // double price
    private static List<Order> _instances = new List<Order> {};

    public Order (string description)
    {
      Description = description;

    }
    
    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }



  }

}