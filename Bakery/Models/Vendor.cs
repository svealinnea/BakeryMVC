using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendorsList = new List<Vendor> {};
    public string VendorName { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

  public Vendor(string vendorName, string description)
  {
    VendorName = vendorName;
    Description = description;
    _vendorsList.Add(this);
    Id = _vendorsList.Count;

  }
  public static List<Vendor> GetAll()
  {
    return _vendorsList;
  }  
  public static Vendor Find(int Id)
  {
    return _vendorsList[Id-1];
  }
  public static void ClearAll()
  {
    _vendorsList.Clear();
  }
  }
}