using Finist_TestTask.DAL.Interfaces.Repositories;
using Finist_TestTask.DAL.Repositories.Base;
using Finist_TestTask.Domain.Models.Account.Implementation;

namespace Finist_TestTask.DAL.Repositories.Implementations;

public class ExpressRepository : GenericRepository<ExpressAccount>, IExpressRepository
{
    public ExpressRepository(ApplicationDbContext context) : base(context)
    {
    }
}