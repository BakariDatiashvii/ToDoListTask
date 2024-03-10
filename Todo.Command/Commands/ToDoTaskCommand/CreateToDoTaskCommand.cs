using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Command.CommandsModels.ToDoTaskCommandModels;
using Todo.Domain.Entities.ToDoTasks;
using Todo.Infrastructure;
using Todo.Shared.models;

namespace Todo.Command.Commands.ToDoTaskCommand
{
    public class CreateToDoTaskCommand : CommandBase
    {
        private readonly CreateToDoTaskCommandModel  _model;
        public CreateToDoTaskCommand(RepositoryProvider repositoryProvider, CreateToDoTaskCommandModel model) : base(repositoryProvider)
        {
            _model = model;
        }

        public override async Task<Result> HandleAsync()
        {
            var todotask = await _repositoryProvider.ToDoTask.GetQueryable().FirstOrDefaultAsync(x=> x.Name==_model.Name);
            if (todotask != null)
            {
                return Result.Error("მსგავსი ტაკსი არსებობს");
            }

            var task = new ToDoTask()
            {
                Name = _model.Name,
                Status = _model.Status,
            };
            _repositoryProvider.ToDoTask.Create(task);
            _repositoryProvider.UnitOfWork.SaveChange();
            return Result.Success(task);
        }
    }
}
