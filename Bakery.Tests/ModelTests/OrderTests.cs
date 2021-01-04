using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
  {
  public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Order newOrder = new Order("", "",5, "");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void SetTitle_ReturnsTitle_String()
    {
      string title = "vendor order 1";
      Order newOrder = new Order(title, "", 0, ""); 

      string updatedTitle = "vendor order 2";
      newOrder.OrderTitle = updatedTitle;
      string result = newOrder.OrderTitle;

      Assert.AreEqual(updatedTitle, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> {}; 
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnListOfOrderObjectsInstatiated_OrderList()
    {
      string newTitle = "Order 1";
      string newTitle2 = "Order 2";
      string newDescription = "Ordered 5 loafs of bread";
      string newDescription2 = "Ordered 20 loafs of bread";
      int newPrice = 15; 
      int newPrice2 = 60;
      string newDate = "09191995";
      string newDate2 = "01122020";
      Order newOrder = new Order(newTitle, newDescription, newPrice, newDate);
      Order newOrder2 = new Order(newTitle2, newDescription2, newPrice2, newDate2);
      List<Order> orderList = new List<Order> { newOrder, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(orderList, result); 
    }
  }
}
