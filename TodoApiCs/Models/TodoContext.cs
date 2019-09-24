using Microsoft.EntityFrameworkCore;

// The database context is the main class that coordinates Entity Framework functionality for a data model
// This class is created by deriving from the Microsoft.EntityFrameworkCore.DbContext class
namespace TodoApiCs.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
