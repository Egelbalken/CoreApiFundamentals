using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreCodeCamp.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ValuesController : ControllerBase
  {

    public string[] Get()
    {
      return new[] { "Hello", "From","Pluralsight" };
    }
  }
}
