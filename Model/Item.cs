using System;
using System.Collections.Generic;

namespace Remake_Inventory.Model
{
  public class Item
  {
    public int Id { get; set; }

    public int SKU { get; set; }

    public string Name { get; set; }

    public string ShortDescription { get; set; }

    public int NumberInStock { get; set; }

    public int Price { get; set; }

    public DateTime DateOrdered { get; set; } = DateTime.Now;

    public int LocationId { get; set; }

    public Location Location { get; set; }
  }
}