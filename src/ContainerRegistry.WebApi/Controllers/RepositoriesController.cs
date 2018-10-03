using ContainerRegistry.WebApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace ContainerRegistry.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepositoriesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<RepositoryList> Get()
        {
            return new RepositoryList();
        }
    }
}