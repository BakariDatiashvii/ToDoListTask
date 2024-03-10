using Microsoft.AspNetCore.Mvc;
using Todo.Infrastructure;

namespace ToDoListTask.Controllers
{
    public class BaseController :ControllerBase
    {
        protected RepositoryProvider _repositoryProvider;
       

        public BaseController(RepositoryProvider repositoryProvider)
        {
            _repositoryProvider = repositoryProvider;
        }

    }
}
