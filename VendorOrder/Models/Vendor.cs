using System.Collections.Generic;

namespace VendorOrder.Models
{

  public class Vendor
  {

    private static List<Vendor> _instances = new List<Vendor> {};
    public string VendorDescription { get; set; }
    public string VendorName { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName, string vendorDescription)
    {
      VendorName = vendorName;
      VendorDescription = vendorDescription;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{ };
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int Id)
    {
      return _instances[Id - 1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

  }
}