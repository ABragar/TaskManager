namespace TaskManager.App.Abstractions;

public interface IConsoleService
{
    Task RunAsync(CancellationToken cancellationToken);
}