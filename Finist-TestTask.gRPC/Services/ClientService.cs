using Finist_TestTask.BLL.Interfaces.Base;
using Grpc.Core;
using Finist_TestTask.gRPC;

namespace Finist_TestTask.gRPC.Services;

public class ClientService : client_service.client_serviceBase
{
    private readonly ILogger<ClientService> _logger;
    private readonly IClientService _clientService;
    
    public ClientService(ILogger<ClientService> logger, IClientService clientService)
    {
        _logger = logger;
        _clientService = clientService;
    }

    public override async Task<client_info_reply> GetClientInfo(client_info_request request, ServerCallContext context)
    {
        var result = await _clientService.GetClientInfo(Guid.Parse(request.ClientId));

        return new client_info_reply
        {
            Name = result.Name,
            SecondName = result.SecondName,
            Patronymic = result.Patronymic,
            PhoneNumber = result.PhoneNumber,
            CardAccountNumber = result.CardAccount,
            DemandAccountNumber = result.DemandAccount,
            ExpressAccountNumber = result.ExpressAccount
        };
    }
}