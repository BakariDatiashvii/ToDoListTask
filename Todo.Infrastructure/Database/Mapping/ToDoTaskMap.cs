using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Entities.ToDoTasks;

namespace Todo.Infrastructure.Database.Mapping
{
    public static class ToDoTaskMap
    {
        public static void ConfigureToDoTask(this ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<ToDoTask>();

            entity.ToTable(nameof(ToDoTask), "core");

            entity.HasKey(x => x.Id);
            entity.Property(X => X.Id).ValueGeneratedNever();
          
            entity.Property(x => x.Name).HasMaxLength(50).IsRequired();
            entity.Property(x => x.Status).IsRequired();







        }
    }
}
