using Finist_TestTask.BLL.Interfaces.Base;
using Finist_TestTask.BLL.Services;
using Finist_TestTask.DAL.Interfaces.Base;
using Finist_TestTask.DAL.Repositories.Base;
using Microsoft.Extensions.DependencyInjection;

namespace Finist_TestTask.BLL.DI;

public static class ApplicationServicesDependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services) =>
        services
            .AddScoped<IAccountsService, AccountsService>()
            .AddScoped<IClientService, ClientService>();
}