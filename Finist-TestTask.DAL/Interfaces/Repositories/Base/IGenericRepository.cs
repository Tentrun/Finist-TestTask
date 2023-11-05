using System.Linq.Expressions;

namespace Finist_TestTask.DAL.Interfaces.Base;

public interface IGenericRepository <T>
{
    Task<T?> GetAsync(Expression<Func<T, bool>>? predicate);
}