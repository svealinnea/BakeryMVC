using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll(); 
      return View(allVendors);
    }
    [HttpGet("/orders/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}
    

