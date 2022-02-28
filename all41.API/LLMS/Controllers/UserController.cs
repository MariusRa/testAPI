using LLMS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LLMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //[HttpPost]
        //[Route("GetUser")]
        //public IActionResult GetUserDetails()
        //{
        //    var userEmail = User.FindFirst("preferred_username")?.Value;
        //    var userName = User.FindFirst("name")?.Value;

        //    if (_userService.FindByNameAsync(userName) == null)
        //    {
        //        User user = new User
        //        {
        //            FullName = userEmail
        //        };
        //        _userService.CreateAsync(user);
        //        _userService.AddToRoleAsync(user, "Coordinator");

        //    }
        //    return Ok("save");
        //}
    }
}
