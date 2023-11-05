using Finist_TestTask.Domain.DTO;

namespace Finist_TestTask.BLL.Interfaces.Base;

public interface IAccountsService
{
    Task<AccountsDTO> GetUserAccounts(Guid id);
}