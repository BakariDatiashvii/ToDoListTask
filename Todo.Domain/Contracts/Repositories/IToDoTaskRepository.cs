using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Contracts.Repositories.Base;
using Todo.Domain.Entities.ToDoTasks;

namespace Todo.Domain.Contracts.Repositories
{
    public interface IToDoTaskRepository : IGenerycRepository<ToDoTask>
    {
    }
}
