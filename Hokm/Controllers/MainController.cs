using Microsoft.AspNetCore.Mvc;

namespace Hokm.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {
        public IActionResult Home()
        {
            return Ok("Hey");
        }
    }
}
