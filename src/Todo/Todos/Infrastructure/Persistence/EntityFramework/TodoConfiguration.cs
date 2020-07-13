namespace josergdev.Todo.Shared.Infrastructure.Persistence.EntityFramework
{
    using josergdev.Todo.Todos.Domain;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class TodoConfiguration : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.ToTable("Todos");

            builder.HasKey(todo => todo.Id);

            builder.Property(todo => todo.Id)
                .HasConversion(id => id.Value, id => new TodoId(id))
                .HasColumnName("id");

            builder.OwnsOne(todo => todo.Title)
                .Property(title => title.Value)
                .HasColumnName("title");

            builder.OwnsOne(todo => todo.Completed)
                .Property(completed => completed.Value)
                .HasColumnName("completed");
        }
    }
}