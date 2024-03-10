using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Infrastructure;
using Todo.Shared.models;

namespace Todo.Query
{
    public abstract class QueryBase
    {
        protected RepositoryProvider _repositoryProvider { get; }
      

        public QueryBase(RepositoryProvider repositoryProvider)
        {
            _repositoryProvider = repositoryProvider;
        }

        

        public abstract Task<Result> HandleAsync();
    }
}
