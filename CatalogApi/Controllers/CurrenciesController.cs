using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CatalogApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CurrenciesController : ControllerBase
  {
    // GET api/currencies
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
        => new string[] { "Real", "Dólar", "Euro" };
  }
}
