using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LLMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // this is a sample endpoint that requires 'AdminUser' role access,
        // as defined in the AAD app registration manifest and assigned via AAD
        // users and groups.
        [HttpGet()]
        [Route("coordinator")]
        [Authorize(Roles = "Coordinator")]
        public async Task<ActionResult<string>> CoordinatorRoleGet()
        {
            // simulate some activity then return a result.

            await Task.Delay(TimeSpan.FromMilliseconds(50)).ConfigureAwait(false);

            return Ok("Successfully called the Coordinator endpoint.");
        }

        // this is a sample endpoint that requires 'StandardUser' role access,
        // as defined in the AAD app registration manifest and assigned via AAD
        // users and groups.
        [HttpGet()]
        [Route("requestor")]
        [Authorize(Roles = "Requestor")]
        public async Task<ActionResult<string>> RequestorRoleGet()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(50)).ConfigureAwait(false);
            return Ok("Successfully called the Requestor endpoint.");
        }

        [HttpGet()]
        [Route("standard")]
        [Authorize(Roles = "Student")]
        public async Task<ActionResult<string>> StudentRoleGet()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(50)).ConfigureAwait(false);
            return Ok("Successfully called the Student endpoint.");
        }

        [HttpGet()]
        [Route("teacher")]
        [Authorize(Roles = "Teacher")]
        public async Task<ActionResult<string>> TeacherRoleGet()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(50)).ConfigureAwait(false);
            return Ok("Successfully called the Teacher endpoint.");
        }

        // this is a sample endpoint that requires no authentication at all.
        // it is wide open to the public internet.
        [HttpGet()]
        [Route("noauth")]
        public async Task<ActionResult<string>> NoAuthGet()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(50)).ConfigureAwait(false);
            return Ok("Successfully called the api/test/noauth endpoint.");
        }
    }
}
