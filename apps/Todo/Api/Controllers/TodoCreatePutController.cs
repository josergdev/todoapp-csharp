namespace josergdev.Apps.Todo.Api.Controllers
{
    using System.Threading.Tasks;
    using josergdev.Todo.Todos.Application;
    using josergdev.Todo.Todos.Domain;
    using Microsoft.AspNetCore.Mvc;

    [Route("todos/create")]
    [ApiController]
    public class TodoCreatePutController : Controller
    {
        private readonly TodoCreator Creator;

        public TodoCreatePutController(TodoCreator creator)
        {
            Creator = creator;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Index(string id, [FromBody] TodoCreateRequest request)
        {
            await Creator.Create(new TodoId(id), new TodoTitle(request.Title));

            return StatusCode(201);
        }
    }

    public class TodoCreateRequest
    {
        public string Title { get; set; }
    }
}
