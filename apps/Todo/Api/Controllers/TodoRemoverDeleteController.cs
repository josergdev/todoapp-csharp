namespace josergdev.Apps.Todo.Api.Controllers
{
    using System.Threading.Tasks;
    using josergdev.Todo.Todos.Application;
    using josergdev.Todo.Todos.Domain;
    using Microsoft.AspNetCore.Mvc;

    [Route("todos")]
    [ApiController]
    public class TodoRemoverDeleteController : Controller
    {
        private TodoRemover Remover;

        public TodoRemoverDeleteController(TodoRemover remover)
        {
            Remover = remover;
        }

        [HttpDelete("remove/{id}")]
        public async Task<IActionResult> Remove(string id)
        {
            await Remover.Remove(new TodoId(id));

            return Ok();
        }

        [HttpDelete("remove-all")]
        public async Task<IActionResult> RemoveAll()
        {
            await Remover.RemoveAll();

            return Ok();
        }
    }
}
