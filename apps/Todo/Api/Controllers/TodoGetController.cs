namespace josergdev.Apps.Todo.Api.Controllers
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using josergdev.Todo.Todos.Domain;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;

    [Route("todos")]
    [ApiController]
    public class TodoGetController : Controller
    {
        private ITodoRepository Repository;

        public TodoGetController(ITodoRepository repository)
        {
            Repository = repository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Index(string id)
        {
            Todo todo = await Repository.Search(new TodoId(id));

            var response = new Dictionary<string, string>
            {
                { nameof(todo.Id).ToLower(), todo.Id.ToString() },
                { nameof(todo.Title).ToLower(), todo.Title.ToString() },
                { nameof(todo.Completed).ToLower(), todo.Completed.ToString() }
            };

            return Ok(response);
        }
    }
}
