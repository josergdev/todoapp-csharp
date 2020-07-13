namespace josergdev.Apps.Todo.Api.Controllers
{
    using System.Threading.Tasks;
    using josergdev.Todo.Todos.Application;
    using josergdev.Todo.Todos.Domain;
    using Microsoft.AspNetCore.Mvc;

    [Route("todos/update-title")]
    [ApiController]
    public class TodoUpdateTitlePutController : Controller
    {
        private TodoTitleUpdater TitleUpdater;

        public TodoUpdateTitlePutController(TodoTitleUpdater titleUpdater)
        {
            TitleUpdater = titleUpdater;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Index(string id, [FromBody] TodoUpdateTitleRequest request)
        {
            await TitleUpdater.Update(new TodoId(id), new TodoTitle(request.Title));

            return Ok();
        }
    }

    public class TodoUpdateTitleRequest
    {
        public string Title { get; set; }
    }
}
