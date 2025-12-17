namespace TaskManager.App.Abstractions;

public interface ITaskService
{
    //тут ми описуємо методи для маніпулювіання задачами
    public Task CreateNew(string name);
    public string[] GetAllTasksAsync();
}