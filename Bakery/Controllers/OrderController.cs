using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Controllers
{
  public class OrderController : Controller
  {
    // [HttpGet("/orders")]
    // public ActionResult Index()
    // {
    //   List<Vendor> allVendors = Vendor.GetAll(); 
    //   return View(allVendors);
    // }
    [HttpGet("/order/new")]
    public ActionResult New()
    {
      return View();
    }
    // [HttpGet("/vendors/{vendorId}/order/{orderId}")]
    // public ActionResult Show(int vendorId, int orderId)
    // {
    //   Vendor vendor = Vendor.Find(vendorId); 
    //   Order order = Order.Find(orderId);
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   model.Add("order", order);
    //   model.Add("vendor", vendor);
    // }
  }
}
    

