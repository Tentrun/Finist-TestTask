using Finist_TestTask.DAL.Interfaces.Repositories;
using Finist_TestTask.DAL.Repositories.Base;
using Finist_TestTask.Domain.Models.Client;

namespace Finist_TestTask.DAL.Repositories.Implementations;

public class ClientRepository : GenericRepository<Client>, IClientRepository
{
    public ClientRepository(ApplicationDbContext context) : base(context)
    {
    }
}