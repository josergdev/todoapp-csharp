namespace josergdev.Todo.Todos.Domain
{
    using josergdev.Todo.Shared.Domain.ValueObject;

    public class TodoTitle : StringValueObject
    {
        public TodoTitle(string value) : base(value)
        {
        }
    }
}