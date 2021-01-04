using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public string OrderTitle { get; set; }
    public string OrderDescription { get; set; }
    public int OrderPrice { get; set; }
    // public int OrderDate { get; set; }
    public int OrderId { get; }
    private static List<Order> _orderList = new List<Order> { };

    public Order(string orderTitle, string orderDescription, int orderPrice)
    {
      OrderTitle = orderTitle;
      OrderDescription = orderDescription;
      OrderPrice = orderPrice; 
      _orderList.Add(this);
      OrderId = _orderList.Count;
    }
    public static List<Order> GetAll()
    {
      return _orderList;
    }
    public static Order Find(int searchId)
    {
      return _orderList[searchId-1];
    }
    public static void ClearAll()
    {
      _orderList.Clear();
    }
  }
}