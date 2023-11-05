using Finist_TestTask.BLL.Interfaces.Base;
using Finist_TestTask.DAL.Interfaces.Base;
using Finist_TestTask.DAL.Interfaces.Repositories;
using Finist_TestTask.Domain.DTO;

namespace Finist_TestTask.BLL.Services;

public class ClientService : IClientService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAccountsService _accountsService;

    public ClientService(IUnitOfWork unitOfWork, IAccountsService accountsService)
    {
        _unitOfWork = unitOfWork;
        _accountsService = accountsService;
    }

    public async Task<ClientDTO> GetClientInfo(Guid id)
    {
        var clientRepository = _unitOfWork.GetRepository<IClientRepository>();
        var client = await clientRepository.GetAsync(x => x.Id == id);
        if (client == null)
        {
            throw new InvalidOperationException("Клиент с таким ID не найден");
        }
        var accounts = await _accountsService.GetUserAccounts(client.Id);

        var result = new ClientDTO(client.Name, client.SecondName, client.Patronymic, client.PhoneNumber,
            accounts?.CardAccount,
            accounts?.DemandAccount, accounts?.ExpressAccount);

        return result;
    }
}