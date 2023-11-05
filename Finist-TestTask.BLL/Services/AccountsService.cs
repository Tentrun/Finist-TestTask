using Finist_TestTask.BLL.Interfaces.Base;
using Finist_TestTask.DAL.Interfaces.Base;
using Finist_TestTask.DAL.Interfaces.Repositories;
using Finist_TestTask.Domain.DTO;

namespace Finist_TestTask.BLL.Services;

public class AccountsService : IAccountsService
{
    private readonly IUnitOfWork _unitOfWork;

    public AccountsService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<AccountsDTO> GetUserAccounts(Guid id)
    {
        var cardRepository = _unitOfWork.GetRepository<ICardRepository>();
        var demandRepository = _unitOfWork.GetRepository<IDemandRepository>();
        var expressRepository = _unitOfWork.GetRepository<IExpressRepository>();

        var userCard = await cardRepository.GetAsync(x => x.UserId == id);
        var demandCard = await demandRepository.GetAsync(x => x.UserId == id);
        var expressCard = await expressRepository.GetAsync(x => x.UserId == id);

        var result = new AccountsDTO(userCard?.AccountNumber, demandCard?.AccountNumber, expressCard?.AccountNumber);
        return result;
    }
}