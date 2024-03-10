using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Domain.Contracts.Repositories.Base
{
    public interface IGenerycRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void CreateMany(List<TEntity> entities);
        IQueryable<TEntity> GetQueryable();
    }
}
