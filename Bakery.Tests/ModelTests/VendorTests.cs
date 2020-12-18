using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
//using System.Collections.Generic;


namespace Bakery.Tests
{
  [TestClass]
  public class VendorTests 
  {
    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Suzies Bakery";
      Vendor newVendor = new Vendor(name);
      string result = newVendor.VendorName;
      Assert.AreEqual(name, result);
    }
  }
}