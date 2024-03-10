using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Infrastructure;
using Todo.Query.ViewModels.ToDoTaskVM;
using Todo.Shared.models;

namespace Todo.Query.Queries.ToDoTaskQueries
{
    public class GetToDoTaskQuery : QueryBase
    {
        private readonly Guid _id;
        public GetToDoTaskQuery(RepositoryProvider repositoryProvider, Guid id) : base(repositoryProvider)
        {
            _id = id;
        }

        public async override Task<Result> HandleAsync()
        {
            var task = await _repositoryProvider.ToDoTask.GetQueryable().FirstOrDefaultAsync(x => x.Id == _id && !x.IsDeleted);

            if (task == null)
            {
                return Result.Error("დავალება ვერ მოიძებნა");
            }

            var responceTask = new ToDoTaskViewModel()
            {
                Id = task.Id,
                Name = task.Name,
                status = task.Status,
            };

            return Result.Success(responceTask);
        }
    }
}
