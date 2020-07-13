namespace josergdev.Todo.Todos.Application
{
    using josergdev.Todo.Todos.Domain;
    using System.Threading.Tasks;
    
    public class TodoTitleUpdater
    {
        private readonly TodoFinder Finder;
        private readonly ITodoRepository Repository;

        public TodoTitleUpdater(TodoFinder finder, ITodoRepository repository)
        {
            Finder = finder;
            Repository = repository;
        }

        public async Task Update(TodoId id, TodoTitle title)
        {
            Todo todo = await Finder.Find(id);

            todo.UpdateTitle(title);

            await Repository.Update(todo);
        }
    }
}
