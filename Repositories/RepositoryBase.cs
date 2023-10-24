using Entities.ApplicationDbCon;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
	public class RepositoryBase<T> where T : class
	{
		private readonly ApplicationDbContext _context;
		private readonly DbSet<T> _dbSet;

        public RepositoryBase()
        {
            _context = new ApplicationDbContext();
			_dbSet = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
		{
			_dbSet.Add(entity);
			await _context.SaveChangesAsync();
		}

		public IQueryable<T> GetAllAsync()
		{
			return _dbSet.AsQueryable();
		}
		public async Task UpdateAsync(T entity)
		{
			var tracker = _context.Attach(entity);
			tracker.State = EntityState.Modified;
			await _context.SaveChangesAsync();
		}
		public async Task DeleteAsync(T entity)
		{
			_context.Remove(entity);
			await _context.SaveChangesAsync();
		}
		public async Task<T?> GetByIdAsync(T entity)
        {
            return await _dbSet.FindAsync(entity);
        }

    }
}
