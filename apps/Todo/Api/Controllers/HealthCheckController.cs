namespace josergdev.Apps.Todo.Api.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;

    [Route("health-check")]
    [ApiController]
    public class HealthCheckGetController : ControllerBase
    {

        [HttpGet]
        public IActionResult handle()
        {
            return Ok(new Dictionary<string, string>()
            {
                {"status", "ok"}
            });
        }

    }
}