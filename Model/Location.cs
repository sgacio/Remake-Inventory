using System;
using System.Collections.Generic;

namespace Remake_Inventory.Model
{
  public class Location
  {
    public int Id { get; set; }
    public string Address { get; set; }
    public string ManagerName { get; set; }
    public int PhoneNumber { get; set; }

    public List<Item> Items { get; set; } = new List<Item>();
  }
}