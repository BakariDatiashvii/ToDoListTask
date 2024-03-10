using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Command.CommandsModels.ToDoTaskCommandModels;
using Todo.Infrastructure;
using Todo.Shared.models;

namespace Todo.Command.Commands.ToDoTaskCommand
{
    public class DeleteToDoTaskCommand : CommandBase
    {
        private readonly DeleteToDoTaskModel _model;
        public DeleteToDoTaskCommand(RepositoryProvider repositoryProvider,DeleteToDoTaskModel model) : base(repositoryProvider)
        {
            _model = model;
        }

        public override async Task<Result> HandleAsync()
        {
           var DeleteTask = await _repositoryProvider.ToDoTask.GetQueryable()
                .FirstOrDefaultAsync(x=> x.Id == _model.Id);    
            if (DeleteTask == null)
            {
                return Result.Error("დავალება ვერ მოიძებნა");

            }

            DeleteTask.Delete();

            _repositoryProvider.ToDoTask.Update(DeleteTask);
            _repositoryProvider.UnitOfWork.SaveChange();
            return Result.Success("წარმატებით წაიშალა");
        }
    }
}
