namespace josergdev.Todo.Shared.Infrastructure.Persistence.EntityFramework
{
    using josergdev.Todo.Todos.Domain;
    using Microsoft.EntityFrameworkCore;

    public class TodoContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TodoConfiguration());
        }
    }
}
