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
    public class UpdateToDoTaskCommand : CommandBase
    {
        private readonly UpdateToDoTaskCommandModel _model;

        public UpdateToDoTaskCommand(RepositoryProvider repositoryProvider,UpdateToDoTaskCommandModel model) : base(repositoryProvider)
        {
            _model = model;
        }

        public async override Task<Result> HandleAsync()
        {
            var updateTask = await _repositoryProvider.ToDoTask.GetQueryable().FirstOrDefaultAsync(x => x.Id == _model.Id);
            if (updateTask == null)
            {
                return Result.Error("გამოცდა ვერ მოიძებნა");
            }
            else
            {
                updateTask.Name = _model.Name;
                updateTask.Status = _model.Status;
            }

         

            _repositoryProvider.ToDoTask.Update(updateTask);
            _repositoryProvider.UnitOfWork.SaveChange();
            return Result.Success(updateTask);
        }
    }
}
