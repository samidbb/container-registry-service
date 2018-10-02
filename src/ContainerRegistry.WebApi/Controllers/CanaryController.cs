using Microsoft.AspNetCore.Mvc;

namespace ContainerRegistry.WebApi.Controllers
{
    [Route("system/[controller]")]
    [ApiController]
    public class CanaryController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }
    }
}