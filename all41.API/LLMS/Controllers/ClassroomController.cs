using LLMS.Models;
using LLMS.Services;
using LLMS.viewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassroomController : ControllerBase
    {
        private readonly IClassroomService _service;

        public ClassroomController(IClassroomService service)
        {
            _service = service;
        }


        [HttpGet]
        public IEnumerable<Classroom> GetClassrooms()
        {
            return _service.GetAllClassrooms();
        }

        [HttpGet("{id}")]
        public IActionResult GetClassroomById(int id)
        {   
            return Ok(_service.GetClassById(id));
        }

        [HttpPost("NewClassroom")]
        public IActionResult AddClassroom(ClassroomViewModel model)
        {
            if (ModelState.IsValid)
            {

            }
            return Ok();
        }
    }
}
