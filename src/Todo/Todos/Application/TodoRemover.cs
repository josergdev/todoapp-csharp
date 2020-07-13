namespace josergdev.Todo.Todos.Application
{
    using josergdev.Todo.Todos.Domain;
    using System.Threading.Tasks;
    
    public class TodoRemover
    {
        private readonly TodoFinder Finder;
        private readonly ITodoRepository Repository;

        public TodoRemover(TodoFinder finder, ITodoRepository repository)
        {
            Finder = finder;
            Repository = repository;
        }

        public async Task Remove(TodoId id)
        {
            Todo todo = await Finder.Find(id);

            todo.Remove(id);

            await Repository.Remove(todo);
        }

        public async Task RemoveAll()
        {
            var todos = await Finder.FindAll();

            foreach (Todo todo in todos)
            {
                todo.Remove(todo.Id);

                await Repository.Remove(todo);
            }
        }

    }
}
