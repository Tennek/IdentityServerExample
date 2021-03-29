using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Api.Controllers
{
    public class IdentityController : ControllerBase
    {
        [HttpGet]
        [Route("identity/get")]
        [Authorize]
        public IActionResult Get()
        {
            var result = from c in User.Claims select new { c.Type, c.Value };
            return new JsonResult(result);
        }

        [HttpGet]
        [Route("identity/onlyadmin")]
        [Authorize(Roles = "admin")]
        public IActionResult OnlyAdmin()
        {
            return new JsonResult(new [] { "Hello from admin" });
        }
    }
}
