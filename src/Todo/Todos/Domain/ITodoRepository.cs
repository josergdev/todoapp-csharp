namespace josergdev.Todo.Todos.Domain
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    
    public interface ITodoRepository
    {
        Task Add(Todo todo);

        Task Update(Todo todo);

        Task Remove(Todo todo);

        Task<Todo> Search(TodoId id);

        Task<IEnumerable<Todo>> SearchAll();
    }
}
