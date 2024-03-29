using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using MyApp.Models;

namespace MyApp.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        // GET api/greeting
        [HttpGet]
        public ActionResult<Greeting> Get([FromQuery] string name = "World")
        {
   
            return new Greeting { Content = $"Hello, {name}!" };
        }
    }
}
