using Microsoft.EntityFrameworkCore;

namespace TaskManager.App.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    {
    }
    
    // тут ми описуємо DbSet-и для наших моделей, наприклад:
    // public DbSet<TaskItem> Tasks { get; set; }
}