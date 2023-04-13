using Entities.Configurations;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities.Context
{
    public class ToDoListDbContext : DbContext
    {
        public ToDoListDbContext(DbContextOptions<ToDoListDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            new ToDoItemConfiguration().Configure(builder.Entity<ToDoItem>());
        }

        public virtual DbSet<ToDoItem> ToDoItems { get; set; } = null!;
    }
}                
