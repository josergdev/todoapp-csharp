namespace josergdev.Apps.Todo.Api.Extension.DependencyInjection
{
    using josergdev.Todo.Shared.Infrastructure.Persistence.EntityFramework;
    using josergdev.Todo.Todos.Domain;
    using josergdev.Todo.Todos.Infrastructure.Persistence.EntityFramework;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class Infrastructure
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services,
    IConfiguration configuration)
        {
            services.AddScoped<ITodoRepository, MsSqlTodoRepository>();
            services.AddScoped<DbContext, TodoContext>();
            services.AddDbContext<TodoContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("MoocDatabase")), ServiceLifetime.Transient);

            return services;
        }
    }
}
