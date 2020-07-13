namespace josergdev.Todo.Todos.Domain
{
    using System;

    public class TodoNotExists : Exception
    {
        public TodoNotExists(string message) : base(message)
        {
        }
    }
}
