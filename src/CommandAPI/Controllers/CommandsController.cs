using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
{
    [Route("api/Commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            return new string[] { "ali", "veli", "49" };
        }
    }
}