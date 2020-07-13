namespace josergdev.Apps.Todo.Api.Controllers
{
    using System.Threading.Tasks;
    using josergdev.Todo.Todos.Application;
    using josergdev.Todo.Todos.Domain;
    using Microsoft.AspNetCore.Mvc;

    [Route("todos")]
    [ApiController]
    public class TodoCompletedSwitcherPutController : Controller
    {
        private readonly TodoCompletedSwitcher CompletedSwitcher;

        public TodoCompletedSwitcherPutController(TodoCompletedSwitcher completedSwitcher)
        {
            CompletedSwitcher = completedSwitcher;
        }

        [HttpPut("complete/{id}")]
        public async Task<IActionResult> Complete(string id)
        {
            await CompletedSwitcher.Complete(new TodoId(id));

            return Ok();
        }

        [HttpPut("uncomplete/{id}")]
        public async Task<IActionResult> Uncomplete(string id)
        {
            await CompletedSwitcher.Uncomplete(new TodoId(id));

            return Ok();
        }
    }
}
