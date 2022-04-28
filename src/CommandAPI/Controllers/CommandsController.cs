using CommandAPI.Data;
using CommandAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
{
    [Route("api/Commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        ICommandRepo commandRepo;
        public CommandsController(ICommandRepo _commandRepo)
        {
            commandRepo = _commandRepo;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAll()
        {
            return Ok(commandRepo.GetAll());
        }
        [HttpGet("{id}")]
        public ActionResult<Command> GetById(int id)
        {
            var commandItem = commandRepo.GetById(id);
            if(commandItem == null)
            return NotFound();
            return Ok(commandItem);
        }
    }
}