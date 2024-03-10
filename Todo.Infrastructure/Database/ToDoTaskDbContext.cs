using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Entities.ToDoTasks;
using Todo.Infrastructure.Database.Mapping;

namespace Todo.Infrastructure.Database
{
    public class ToDoTaskDbContext : DbContext
    {
        public DbSet<ToDoTask> toDoTasks { get; set; }

        public ToDoTaskDbContext(DbContextOptions<ToDoTaskDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureToDoTask();


            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
