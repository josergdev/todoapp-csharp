
namespace josergdev.Todo.Todos.Domain
{
    using josergdev.Todo.Shared.Domain.ValueObject;

    public class TodoId : Uuid
    {
        public TodoId(string value) : base(value)
        {
        }
    }
}