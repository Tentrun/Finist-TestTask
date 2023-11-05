using Finist_TestTask.Domain.DTO;
using Finist_TestTask.IdentityServer.Extensions;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Finist_TestTask.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientController : ControllerBase
{
    [Authorize]
    [HttpPost]
    public async Task<ClientDTO> GetClientInfo(CancellationToken cancellationToken)
    {
        var userId = ClaimValueParser.GetUserId(HttpContext.User.Claims);
        
        var channel = GrpcChannel.ForAddress("http://localhost:5007");
        var client = new client_service.client_serviceClient(channel);

        var request = new client_info_request
        {
            ClientId = userId.ToString()
        };

        var serverResponse = await client.GetClientInfoAsync(request, cancellationToken: cancellationToken);

        var result = new ClientDTO(serverResponse.Name, serverResponse.SecondName, serverResponse.Patronymic,
            serverResponse.PhoneNumber, serverResponse.CardAccountNumber, serverResponse.DemandAccountNumber,
            serverResponse.ExpressAccountNumber);
        
        return result;
    }
}