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
    public class GetAllToDoTaskQuery : QueryBase
    {
        public GetAllToDoTaskQuery(RepositoryProvider repositoryProvider) : base(repositoryProvider)
        {
        }

        public async override Task<Result> HandleAsync()
        {
            var task = await _repositoryProvider.ToDoTask.GetQueryable().Where(x=> x.IsDeleted==false).Select(x => new ToDoTaskViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                status = x.Status
            }).ToListAsync();

            if (task == null)
            {
                return Result.Error("დავალება ვერ მოიძებნა");
            }

            return Result.Success(task);
        }
    }
}
