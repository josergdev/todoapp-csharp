namespace josergdev.Todo.Todos.Application
{
    using josergdev.Todo.Todos.Domain;
    using System.Threading.Tasks;
    
    public class TodoCreator
    {
        private readonly ITodoRepository Repository;

        public TodoCreator(ITodoRepository repository)
        {
            Repository = repository;
        }

        public async Task Create(TodoId id, TodoTitle title)
        {
            Todo todo = Todo.CreateTodo(id, title);

            await Repository.Add(todo);
        }
    }
}
