using Microsoft.AspNetCore.Mvc;
using Todo.Command.Commands.ToDoTaskCommand;
using Todo.Command.CommandsModels.ToDoTaskCommandModels;
using Todo.Infrastructure;
using Todo.Query.Queries.ToDoTaskQueries;

namespace ToDoListTask.Controllers
{
    [ApiController]
    [Route(nameof(ToDoTaskController))]
    public class ToDoTaskController : BaseController
    {
        public ToDoTaskController(RepositoryProvider repositoryProvider) : base(repositoryProvider)
        {
        }

        [HttpPost("create-task")]
        public async Task<IActionResult> CreateToDoTask([FromBody] CreateToDoTaskCommandModel model)
        {
            var command = new CreateToDoTaskCommand(_repositoryProvider, model);


            var result = await command.HandleAsync();
            return Ok(result.Response);
        }

        [HttpPost("updateTask")]
        public async Task<IActionResult> UpdateToDoTask([FromBody] UpdateToDoTaskCommandModel model)
        {
            var command = new UpdateToDoTaskCommand(_repositoryProvider, model);


            var result = await command.HandleAsync();
            return Ok(result.Response);
        }

        [HttpPost("DeleteTask")]
        public async Task<IActionResult> DeleteToDoTask([FromBody] DeleteToDoTaskModel model)
        {
            var command = new DeleteToDoTaskCommand(_repositoryProvider, model);

            var result = await command.HandleAsync();
            return Ok(result.Response);
        }

        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> GetFaculty(Guid id)
        {
            var query = new GetToDoTaskQuery(_repositoryProvider, id);

            var result = await query.HandleAsync();
            return Ok(result.Response);
        }



        [HttpGet("getalltask")]
        public async Task<IActionResult> GetFaculties()
        {
            var query = new GetAllToDoTaskQuery(_repositoryProvider);
            var result = await query.HandleAsync();
            return Ok(result.Response);
        }
    }
}
