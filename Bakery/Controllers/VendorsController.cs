using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Bakery.Models;


namespace Bakery.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll(); 
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{vendorId}/orders")]
    public ActionResult Show(int vendorId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(vendorId);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorid}/orders")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, int orderPrice, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      selectedVendor.AddOrder(newOrder);
      List<Order> vendorsOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorsOrders);
      return View("Show", model);
    }
  }
}



