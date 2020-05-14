using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DAL.Repositories.IRepository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Get(int id);

        Task<IQueryable<TEntity>> GetAllAsync();
        
        Task AddAsync(TEntity entity);
        
        void Remove(TEntity entity);

        //If needed in future uncomment and use below
        //IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        //Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

    }
}
