using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Remake_Inventory.Model;
using remake_inventory;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Remake_Inventory.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class LocationsController
  {
    [HttpPost]
    public ActionResult<Location> CreateLocation([FromBody]Location entry)
    {
      var context = new DatabaseContext();
      context.Locations.Add(entry);
      context.SaveChanges();
      return entry;
    }

    [HttpGet("All Locations")]
    public ActionResult<IEnumerable<Location>> GetAll()
    {
      var context = new DatabaseContext();
      var LocationList = context.Locations.OrderByDescending(l => l.Id);
      return LocationList.ToList();
    }
  }
}