namespace josergdev.Todo.Todos.Application
{
    using josergdev.Todo.Todos.Domain;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    
    public class TodoFinder
    {
        private readonly ITodoRepository Repository;

        public TodoFinder(ITodoRepository repository)
        {
            Repository = repository;
        }

        public async Task<Todo> Find(TodoId id)
        {
            Todo todo = await Repository.Search(id);

            EnsureTodoExists(id, todo);

            return todo;
        }

        public async Task<IEnumerable<Todo>> FindAll()
        {
            return await Repository.SearchAll();
        }

        private void EnsureTodoExists(TodoId id, Todo todo)
        {
            if (todo is null)
            {
                throw new TodoNotExists($"Todo with id {id} does not exists");
            }
        }
    }
}
