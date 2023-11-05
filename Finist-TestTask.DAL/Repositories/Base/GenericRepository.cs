using System.Linq.Expressions;
using Finist_TestTask.DAL.Interfaces.Base;
using Microsoft.EntityFrameworkCore;

namespace Finist_TestTask.DAL.Repositories.Base;

public class GenericRepository <T> : IGenericRepository<T> where T : class
{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<T> _dbSet;

    public GenericRepository(ApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _dbSet = _context.Set<T>();
    }

    public async Task<T?> GetAsync(Expression<Func<T, bool>>? predicate)
    {
        IQueryable<T> query = _dbSet;
        if (predicate != null) query = query.Where(predicate);

        return await query.FirstOrDefaultAsync();
    }
}