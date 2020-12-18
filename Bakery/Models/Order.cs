using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int Date { get; set; }

  public Order(string title, string description, int price, int date)
  {
    Title = title;
    Description = description;
    Price = price; 
    Date = date;
  }
  }
}