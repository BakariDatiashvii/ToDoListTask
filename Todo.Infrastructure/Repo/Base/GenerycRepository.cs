using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Contracts.Repositories.Base;
using Todo.Infrastructure.Database;

namespace Todo.Infrastructure.Repo.Base
{
    public class GenerycRepository<TEntity> : IGenerycRepository<TEntity> where TEntity : class
    {
        public ToDoTaskDbContext Context { get; set; }

        public GenerycRepository(ToDoTaskDbContext context)
        {
            Context = context;
        }
        public void Create(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void CreateMany(List<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public void Delete(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public IQueryable<TEntity> GetQueryable()
        {
            return Context.Set<TEntity>().AsQueryable().AsNoTracking();
        }

        public void Update(TEntity entity)
        {
            Context.Set<TEntity>().Update(entity);
        }
    }
}
