using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAppStandards.Models;

namespace WebAppStandards.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;

            _logger.LogInformation("I'm in the weather constructor");
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("I'm executing the get");

            //throw new Exception("My Exception happened");

            return BadRequest("I got an error when executing something");
        }

        [HttpPost]
        public ActionResult Post([FromBody] DynamicTemplate template)
        {


            return Ok();
        }
    }
}
