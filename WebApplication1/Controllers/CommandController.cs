using APIpractice.DataRepo;
using APIpractice.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIpractice.Controllers
{
    [Route("api/command")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        private readonly MockCommandRepo _repository = new MockCommandRepo();
        
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
         {
            var commandItems = _repository.GetAllCommands();

            return Ok(commandItems);
         }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
         {
            var commandItem = _repository.GetCommandById(id);

            return Ok(commandItem);
         }
    }
}
