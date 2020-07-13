namespace josergdev.Todo.Todos.Application
{
    using josergdev.Todo.Todos.Domain;
    using System.Threading.Tasks;
    
    public class TodoCompletedSwitcher
    {
        private readonly TodoFinder Finder;
        private readonly ITodoRepository Repository;

        public TodoCompletedSwitcher(TodoFinder finder, ITodoRepository repository)
        {
            Finder = finder;
            Repository = repository;
        }

        public async Task Complete(TodoId id)
        {
            Todo todo = await Finder.Find(id);

            todo.Complete();

            await Repository.Update(todo);
        }

        public async Task Uncomplete(TodoId id)
        {
            Todo todo = await Finder.Find(id);

            todo.Uncomplete();

            await Repository.Update(todo);
        }

    }
}
