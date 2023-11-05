using Finist_TestTask.DAL.Interfaces.Repositories;
using Finist_TestTask.DAL.Repositories.Base;
using Finist_TestTask.Domain.Models.Account.Implementation;

namespace Finist_TestTask.DAL.Repositories.Implementations;

public class DemandRepository: GenericRepository<DemandAccount>, IDemandRepository
{
    public DemandRepository(ApplicationDbContext context) : base(context)
    {
    }
}