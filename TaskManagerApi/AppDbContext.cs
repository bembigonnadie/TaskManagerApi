using Microsoft.EntityFrameworkCore;

namespace TaskManagerApi;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
    public DbSet<TaskItem> Tasks => Set<TaskItem>();
}