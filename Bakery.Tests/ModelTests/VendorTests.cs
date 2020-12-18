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
      Vendor newVendor = new Vendor("test string", "test string");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsNameAndDescription_String()
    {
      string name = "Suzies Bakery";
      string description = "local bakery in NW Portland";
      Vendor newVendor = new Vendor(name,description);
      string result = newVendor.VendorName;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void SetName_SetName_String()
    {
    string name = "Suzies Bakery";
    string description = "local bakery in NW Portland";
    Vendor newVendor = new Vendor(name, description);

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
        [TestMethod]
    public void GetSVendors_ReturnsAllVendorObjects_VendorList()
    {
      string vendor01 = "Suzies Balkery";
      string vendor02 = "Joes Bagel Factory";
      string description01 = "local bakery";
      string description02 = "local bakery";
      Vendor newVendor1 = new Vendor(vendor01, description01);
      Vendor newVendor2 = new Vendor(vendor02, description02);
      List<Vendor> newVendorsList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newVendorsList, result);
    }
  }
}