namespace josergdev.Todo.Todos.Domain
{
    using System;

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

        public static Todo CreateTodo(TodoId id, TodoTitle title)
        {
            Todo todo = new Todo(id, title, new TodoCompleted(false));

            return todo;
        }

        public void UpdateTitle(TodoTitle title)
        {
            Title = title;
        }

        public void Complete()
        {
            Completed = new TodoCompleted(true);
        }

        public void Uncomplete()
        {
            Completed = new TodoCompleted(false);
        }

        public void Remove(TodoId id)
        {
            // Todo: Send TodoRemoved domain event.
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