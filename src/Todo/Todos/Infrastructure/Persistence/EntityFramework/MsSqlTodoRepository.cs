namespace josergdev.Todo.Todos.Infrastructure.Persistence.EntityFramework
{
    using josergdev.Todo.Shared.Infrastructure.Persistence.EntityFramework;
    using josergdev.Todo.Todos.Domain;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class MsSqlTodoRepository : ITodoRepository
    {
        private TodoContext Context;

        public MsSqlTodoRepository(TodoContext todoContext)
        {
            Context = todoContext;
        }

        public async Task Add(Todo todo)
        {
            await Context.Todos.AddAsync(todo);
            await Context.SaveChangesAsync();
        }

        public async Task Update(Todo todo)
        {
            Context.Todos.Update(todo);
            await Context.SaveChangesAsync();
        }

        public async Task Remove(Todo todo)
        {
            Context.Remove(todo);
            await Context.SaveChangesAsync();
        }

        public async Task<Todo> Search(TodoId id)
        {
            return await Context.Todos.FirstOrDefaultAsync(todo => todo.Id.Equals(id));
        }

        public async Task<IEnumerable<Todo>> SearchAll()
        {
            return await Context.Todos.ToListAsync();
        }
    }
}
