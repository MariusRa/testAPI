using LLMS.Models;
using LLMS.Services;
using LLMS.viewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LLMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetUsers")]
        public IEnumerable<User>  GetUsers()
        {
            return _service.GetAllUsers();
        }

        [HttpPost]
        [Route("AddUser")]
        public IActionResult AddUser(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _service.GetById(model.UserId);
                if (user == null)
                {
                    User newUser = new User()
                    {
                        UserId = model.UserId,
                        UserName = model.UserName,
                        UserEmail = model.UserEmail,
                        UserRole = model.UserRole
                    };
                    var result = _service.SaveUser(newUser);
                    return Ok(result);
                }
                return BadRequest("User exist");
            }
            return Ok();
        }
    }
}
