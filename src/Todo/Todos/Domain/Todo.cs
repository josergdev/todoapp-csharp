namespace josergdev.Todo.Todos.Domain
{
    using System;
    using System.Collections.Generic;
    public class Todo
    {
        public TodoId Id { get; private set; }
        public TodoTitle Title { get; private set; }
        public TodoCompleted Completed { get; private set; }

        private Todo(TodoId id, TodoTitle title, TodoCompleted completed)
        {
            Id = id;
            Title = title;
            Completed = completed;
        }

        private Todo()
        {
        }

        public static Todo createTodo(TodoId id, TodoTitle title)
        {
            Todo todo = new Todo(id, title, new TodoCompleted(false));

            return todo;
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;

            var item = obj as Todo;
            if (item == null) return false;

            return this.Id.Equals(item.Id) && this.Title.Equals(item.Title) && this.Completed.Equals(item.Completed);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Id, this.Title, this.Completed);
        }
    }
}