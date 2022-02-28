using LLMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace LLMS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

 
        [HttpGet]
        [Authorize(Roles = "Coordinator, Teacher")]
        public IEnumerable<WeatherForecast> Get()
        {
            //var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            //var userEmail = User.FindFirst("preferred_username")?.Value;
            //var userName = User.FindFirst("name")?.Value;

            //if (true)
            //{
            //    User user = new User
            //    {
            //        UserName = userName,
            //        Email = userEmail
            //    };
            //}
            

            

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });  
        }
    }
}
