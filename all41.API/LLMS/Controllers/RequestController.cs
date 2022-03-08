using LLMS.Models;
using LLMS.Services;
using LLMS.viewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;

namespace LLMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly IRequestService _service;

        public RequestController(IRequestService service)
        {
            _service = service;
        }


        [HttpPost]
        [Route("NewRequest")]
        public IActionResult NewRequest(RequestViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirst("http://schemas.microsoft.com/identity/claims/objectidentifier")?.Value;
                
                Request request = new Request()
                {
                    RequestorId = userId,
                    StudentName = model.StudentName,
                    StudentEmail = model.StudentEmail,
                    StudentId = model.StudentId,
                    Language = model.Language,
                    CostCenter = model.CostCenter,
                    Target = model.Target,
                    Semester = model.Semester,
                    Comments = model.Comments,
                    Approval = model.Approval
                };
                
                var result = _service.AddNewRequest(request);
                
                return Ok(result);
            }
          
            return Ok();
        }


        [HttpGet]
        [Route("Requests")]
        public IEnumerable<Request> GetRequests()
        {
            return _service.GetAllRequests();
        }

        [HttpGet]
        [Route("RequestsU")]
        public IEnumerable<Request> GetUserRequests()
        {
            var userId = User.FindFirst("http://schemas.microsoft.com/identity/claims/objectidentifier").Value;
            return _service.GetAllUserRequests(userId);
        }

        [HttpPut]
        [Route("NewRequest/{id}")]
        public IActionResult UpdateAprroval(int id, [FromBody] RequestViewModelApproval model)
        {
            return Ok(_service.SetApprovalStatus(id, model.Approval));
        }
    }
}
