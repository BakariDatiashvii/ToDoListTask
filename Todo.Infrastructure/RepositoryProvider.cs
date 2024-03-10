using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Contracts;
using Todo.Domain.Contracts.Repositories;

namespace Todo.Infrastructure
{
    public class RepositoryProvider
    {
        public IUnitOfWork UnitOfWork { get; }
        public IToDoTaskRepository ToDoTask { get; }

        public RepositoryProvider(
            IUnitOfWork unitOfWork,
            IToDoTaskRepository toDoTask)
        {
            UnitOfWork = unitOfWork;
            ToDoTask = toDoTask;
        }
            
    }
}
