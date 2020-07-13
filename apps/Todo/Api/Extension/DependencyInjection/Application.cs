namespace josergdev.Apps.Todo.Api.Extension.DependencyInjection
{
    using josergdev.Todo.Todos.Application;
    using Microsoft.Extensions.DependencyInjection;
    
    public static class Application
    {
        public static IServiceCollection AddTodoApplication(this IServiceCollection services)
        {
            services.AddScoped<TodoCreator, TodoCreator>();
            services.AddScoped<TodoFinder, TodoFinder>();
            services.AddScoped<TodoTitleUpdater, TodoTitleUpdater>();
            services.AddScoped<TodoCompletedSwitcher, TodoCompletedSwitcher>();
            services.AddScoped<TodoRemover, TodoRemover>();

            return services;
        }
    }
}
