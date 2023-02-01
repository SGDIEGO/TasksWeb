using Microsoft.EntityFrameworkCore;
using System.Data;
using TasksWeb.Models;

namespace TasksWeb.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options){}
        public DbSet<TaskModel> Tasks { get; set; }
    }
}
