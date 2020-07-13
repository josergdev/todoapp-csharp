namespace josergdev.Apps.Todo.Api.Controllers
{
    using System;
    using System.Threading.Tasks;
    using josergdev.Todo.Todos.Domain;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;

    [Route("todos")]
    [ApiController]
    public class TodoPutController : Controller
    {
        private ITodoRepository Repository;

        public TodoPutController(ITodoRepository repository)
        {
            Repository = repository;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Index(string id, [FromBody] Request request)
        {
            Todo todo = Todo.createTodo(new TodoId(id), new TodoTitle(request.Title));

            await Repository.Save(todo);

            return StatusCode(201);
        }
    }

    public class Request
    {
        public string Title { get; set; }
    }
}
