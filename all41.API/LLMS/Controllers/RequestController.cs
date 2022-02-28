using LLMS.Models;
using LLMS.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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


        [HttpGet]
        [Route("Language")]
        public IEnumerable<LearningLanguage> GetLanguage()
        {
            return _service.GetLearningLanguages();
        }
                
        [HttpGet]
        [Route("Target")]
        public IEnumerable<LearningTarget> GetTarger()
        {
            return _service.GetLearningTargets();
        }

        [HttpGet]
        [Route("Semester")]
        public IEnumerable<LearningSemester> GetSemester()
        {
            return _service.GetLearningSemesters();
        }
    }
}
