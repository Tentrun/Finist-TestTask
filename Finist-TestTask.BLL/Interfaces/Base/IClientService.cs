using Finist_TestTask.Domain.DTO;

namespace Finist_TestTask.BLL.Interfaces.Base;

public interface IClientService
{
    Task<ClientDTO> GetClientInfo(Guid id);
}