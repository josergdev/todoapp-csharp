
namespace josergdev.Todo.Todos.Domain
{

    using josergdev.Todo.Shared.Domain.ValueObject;
    public class TodoCompleted : BoolValueObject
    {
        public TodoCompleted(bool value) : base(value)
        {

        }
    }
}