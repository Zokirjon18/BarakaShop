using System.Linq.Expressions;
using BarakaShop.Domain.Commons;

namespace BarakaShop.DataAccess.Repositories
{
    public interface IRepository<TEntity> where TEntity : Auditable
    {
        Task InsertAsync(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        Task<TEntity> SelectAsync(Expression<Func<TEntity, bool>> predicate, string[] includes = null);
        IQueryable<TEntity> SelectAllAsQueryable();
    }
}
