using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Contracts;
using Todo.Infrastructure.Database;

namespace Todo.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        public ToDoTaskDbContext Context { get; set; }

        public UnitOfWork(ToDoTaskDbContext context)
        {
            Context = context;
        }
        public int SaveChange()
        {
            return Context.SaveChanges();
        }
    }
}
