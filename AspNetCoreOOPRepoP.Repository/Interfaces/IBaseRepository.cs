using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AspNetCoreOOPRepoP.Repository.Interfaces
{
    public interface IBaseRepository<TEntity, TKey, TFilter>
    {
        TEntity GetById(TKey id);
        Task<TEntity> GetByIdAsync(TKey id);
        void Add(TEntity entity);
        void Delete(TEntity entity);
        IQueryable<TEntity> GetAll(TFilter filter);
        Task<IQueryable<TEntity>> GetAllAsync(TFilter filter);
        IQueryable<TEntity> GetAllMatching(Expression<Func<TEntity, bool>> predicate, string[] includes = null);
        Task<IEnumerable<TEntity>> GetAllMatchingAsync(Expression<Func<TEntity, bool>> predicate, string[] includes = null);
    }
}
