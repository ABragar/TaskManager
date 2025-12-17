using TaskManager.App.Abstractions;
using TaskManager.App.Infrastructure;

namespace TaskManager.App.Services;


public class TaskService(AppDbContext dbContext) : ITaskService
{
    // тут реалізація
    
    public Task CreateNew(string name)
    {
        Console.WriteLine($"Creating new task {name}");
        return Task.CompletedTask;
    }

    public string[] GetAllTasksAsync()
    {
        Console.WriteLine($"Retrieving all tasks from database");
        return Array.Empty<string>();
    }
}