using Microsoft.AspNetCore.Mvc;
using System;

namespace ParadiseInternalAPI.Controllers {
    [Route("guid")]
    [ApiController]
    public class GuidController : ControllerBase {
        [HttpGet("new")]
        public IActionResult NewGuid() {
            return Ok(Guid.NewGuid().ToString().Trim('"'));
        }
    }
}
