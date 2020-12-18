using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;


namespace Bakery.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test string");
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
    [TestMethod]
    public void SetName_SetName_String()
    {
    string name = "Suzies Bakery";
    Vendor newVendor = new Vendor(name);

    string updatedName = "Joes Bagel Factory";
    newVendor.VendorName = updatedName; 
    string result = newVendor.VendorName;

    Assert.AreEqual(updatedName, result);
    }
    [TestMethod]
    public void GettAll_ReturnsAnEmptyList_VendorList()
    {
      List<Vendor> newList = new List<Vendor> {}; 
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}