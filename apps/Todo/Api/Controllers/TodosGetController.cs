namespace josergdev.Apps.Todo.Api.Controllers
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using josergdev.Todo.Todos.Domain;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;

    [Route("todos")]
    [ApiController]
    public class TodosGetController : Controller
    {
        private ITodoRepository Repository;

        public TodosGetController(ITodoRepository repository)
        {
            Repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string id)
        {
            IEnumerable todos = await Repository.SearchAll();

            var response = new List<Dictionary<string, string>>();

            foreach (Todo todo in todos)
            {
                response.Add(new Dictionary<string, string>
                {
                    { nameof(todo.Id).ToLower(), todo.Id.ToString() },
                    { nameof(todo.Title).ToLower(), todo.Title.ToString() },
                    { nameof(todo.Completed).ToLower(), todo.Completed.ToString() }
                });
            }

            return Ok(response);
        }
    }
}
