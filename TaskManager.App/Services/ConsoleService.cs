using TaskManager.App.Abstractions;

namespace TaskManager.App.Services;

//
public sealed class ConsoleService(ITaskService taskService) : IConsoleService
{
    public async Task RunAsync(CancellationToken cancellationToken) 
    {
        //Тут в тебе основний ццикл програми
        while (cancellationToken.IsCancellationRequested == false)
        {
            await Task.Delay(1000, cancellationToken);
            
            var userChoice = Console.ReadLine();
            
            
        }
    }
}


