using Finist_TestTask.DAL.Interfaces.Repositories;
using Finist_TestTask.DAL.Repositories.Base;
using Finist_TestTask.Domain.Models.Account.Implementation;

namespace Finist_TestTask.DAL.Repositories.Implementations;

public class CardRepository : GenericRepository<CardAccount>, ICardRepository
{
    public CardRepository(ApplicationDbContext context) : base(context)
    {
    }
}