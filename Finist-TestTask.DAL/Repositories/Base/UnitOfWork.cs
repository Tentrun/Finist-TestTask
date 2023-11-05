using System.Collections;
using Finist_TestTask.DAL.Interfaces.Base;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Finist_TestTask.DAL.Repositories.Base;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _dbContext;
    private readonly Hashtable _repositories;

    private bool _disposed;

    public UnitOfWork(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        _repositories = new Hashtable();
    }

    public T GetRepository<T>() where T : class
    {
        var type = typeof(T).Name;
        if (_repositories.ContainsKey(type))
            return (T)_repositories[type];

        var repo = _dbContext.GetService<T>();
        _repositories.Add(type, repo);

        return repo;
    }
    
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                //dispose managed resources
                _dbContext.Dispose();
            }
        }
        //dispose unmanaged resources
        _disposed = true;
    }
}