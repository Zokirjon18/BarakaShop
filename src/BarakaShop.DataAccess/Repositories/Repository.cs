using System.Linq.Expressions;
using BarakaShop.DataAccess.Contexts;
using BarakaShop.Domain.Commons;
using Microsoft.EntityFrameworkCore;

namespace BarakaShop.DataAccess.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
    {
        private readonly AppDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();    
        }

        public async Task InsertAsync(TEntity entity)
        {
            entity.CreatedAt = DateTime.Now;
            await _dbSet.AddAsync(entity);
        }

        public void Update(TEntity entity)
        {
            entity.UpdatedAt = DateTime.Now;
            _dbSet.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            entity.IsDeleted = true;
            entity.UpdatedAt = DateTime.Now;
            _dbSet.Update(entity);
        }

        public async Task<TEntity> SelectAsync(Expression<Func<TEntity, bool>> predicate, string[] includes = null)
        {
            var query = _dbSet.Where(predicate).AsQueryable();

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return await query.FirstOrDefaultAsync(predicate);
        }

        public IQueryable<TEntity> SelectAllAsQueryable()
        {
            return _dbSet.AsQueryable();
        }
    }

}
