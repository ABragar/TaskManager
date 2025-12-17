using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TaskManager.App.Abstractions;
using TaskManager.App.Infrastructure;
using TaskManager.App.Services;

namespace TaskManager.App;

public static class DependencyExtensions
{
    public static IServiceCollection ConfigureServices(this IServiceCollection services)
    {
        services.AddSingleton<IConsoleService, ConsoleService>();
        services.AddScoped<ITaskService, TaskService>();
        services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=taskmanager.db"));
        return services;
    }
}
