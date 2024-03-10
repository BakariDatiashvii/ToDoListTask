using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Contracts.Repositories;
using Todo.Domain.Contracts.Repositories.Base;
using Todo.Domain.Entities.ToDoTasks;
using Todo.Infrastructure.Database;
using Todo.Infrastructure.Repo.Base;

namespace Todo.Infrastructure.Repo
{
    public class ToDoTaskRepository : GenerycRepository<ToDoTask>, IToDoTaskRepository
    {
        public ToDoTaskRepository(ToDoTaskDbContext context) : base(context)
        {
        }
    }
}
