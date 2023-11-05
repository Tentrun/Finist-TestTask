namespace Finist_TestTask.DAL.Interfaces.Base;

public interface IUnitOfWork : IDisposable
{
    T GetRepository<T>() where T: class;
}