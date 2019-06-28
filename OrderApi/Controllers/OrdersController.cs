using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderApi.Models;

namespace OrderApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class OrdersController : ControllerBase
  {
    // GET api/orders
    [HttpGet]
    public IActionResult Get()
    {

      var orders = new List<Order>
      {
            Order.NewOrder(100),
            Order.NewOrder(200)
      };

      return Ok(orders);
    }
  }
}
