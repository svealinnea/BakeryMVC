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
      Order newOrder = new Order("", "",5);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void SetTitle_ReturnsTitle_String()
    {
      string title = "vendor order 1";
      Order newOrder = new Order(title, "", 0); 

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
      string newDescription = "Ordered 5 loafs of bread";
      int price = 15; 
      // int date = 011120;

      // string newTitle2 = "Order 2";
      // string newDescription2 = "Ordered 10 loafs of bread";
      // int price2 = 30; 
      // int date2 = 011520;

      // Order newOrder2 = new Order(newTitle2, newDescription2, price2);
      Order newOrder = new Order(newTitle, newDescription, price);
      List<Order> orderList = new List<Order> {newOrder};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(orderList, result);
    }
  }
}
