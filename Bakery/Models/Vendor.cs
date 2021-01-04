using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendorsList = new List<Vendor> { };
    public string VendorName { get; set; }
    public string VendorDescription { get; set; }
    public int VendorId { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName, string description)
    {
      VendorName = vendorName;
      VendorDescription = description;
      _vendorsList.Add(this);
      VendorId = _vendorsList.Count;
      Orders = new List<Order>{ };

    }
    public static List<Vendor> GetAll()
    {
      return _vendorsList;
    }  
    public static Vendor Find(int vendorId)
    {
      return _vendorsList[vendorId-1];
    }
    // public static Vendor Find(int Id)
    // {
    //   return _vendorsList[Id-1];
    // }
    public static void ClearAll()
    {
      _vendorsList.Clear();
    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}